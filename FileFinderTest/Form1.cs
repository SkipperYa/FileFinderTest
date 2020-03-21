using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileFinderTest
{
    public partial class Form1 : Form
    {
        //Количество обработанных файлов
        static int count = 0;
        private static CancellationTokenSource cts;
        private static CancellationToken token;
        DirectoryInfo Path;
        DateTime start;
        DateTime end;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopButton.Enabled = false;

            // Загрузка последних критериев поиска
            Criteria criteria = Criteria.Load();

            directoryPathTextBox.Text = criteria.Directory;
            fileNameTextBox.Text = criteria.Pattern;
            symbolsTextBox.Text = criteria.Symbols;
        }

        private async void findButton_Click(object sender, EventArgs e)
        {
            // Проверка на наличие пустых строк
            if (String.IsNullOrEmpty(directoryPathTextBox.Text)
                || String.IsNullOrEmpty(fileNameTextBox.Text)
                || String.IsNullOrEmpty(symbolsTextBox.Text))
            {
                MessageBox.Show("Заполните все критерии поиска!", "Внимание!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cts = new CancellationTokenSource();
            token = cts.Token;

            count = 0;
            // Очиста узлов дерева перед новым поиском
            treeView.Nodes[0].Nodes.Clear();
            treeView.Nodes[1].Nodes.Clear();
            treeView.Nodes[2].Nodes.Clear();

            try
            {
                Path = new DirectoryInfo(directoryPathTextBox.Text);
            }
            catch (ArgumentException aex)
            {
                MessageBox.Show("Путь содержит недопустимые знаки.", "Внимание!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            findButton.Enabled = false;
            stopButton.Enabled = true;

            // Начало поиcка
            start = DateTime.Now;

            timer.Start();

            await Task.Run(() => Search(Path, Path, fileNameTextBox.Text, symbolsTextBox.Text, token));

            timer.Stop();

            stopButton.Enabled = false;
            findButton.Enabled = true;
        }      

        // Метод производит поиск по 3 критериям
        private void Search(DirectoryInfo Path, DirectoryInfo startPath, string pattern, 
                            string symbols, CancellationToken token)
        {
            try
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }

                FileInfo[] getFiles = Path.GetFiles();

                // Отображние текущей директории
                Invoke((Action)(() => currentDirectoryLabel.Text = Path.FullName.ToString()));

                for (int i = 0; i < getFiles.Length; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }
                    // Отображение текущего файла
                    Invoke((Action)(() => currentFileLabel.Text = getFiles[i].Name));

                    // Поиск файлов, соотвествующих критерию "Стартовая директория"
                    if (startPath.ToString().Equals(getFiles[i].DirectoryName))
                    {
                        // Заполнение узла критерия "Стартовая директория"
                        Invoke((Action)(() => treeView.Nodes[0].Nodes.Add(getFiles[i].FullName)));
                    }

                    // Поиск файлов, соотвествующих критерию "Шаблон" 
                    // (символу или группе сиволов) в названии файла
                    if (getFiles[i].Name.Contains(pattern))
                        // Заполнение узла критерия "Шаблон"
                        Invoke((Action)(() => treeView.Nodes[1].Nodes.Add(getFiles[i].Name)));

                    // Поиск в файле содержимого, соотвествующего критерию "Символы в файле"
                    using (StreamReader reader = new StreamReader(getFiles[i].FullName))
                    {
                        if (token.IsCancellationRequested)
                        {
                            return;
                        }
                        string text = reader.ReadToEnd();
                        if (text.Contains(symbols))
                        {
                            // Заполнение узла критерия "Символы"
                            Invoke((Action)(() => treeView.Nodes[2].Nodes.Add(getFiles[i].Name)));
                        }
                    }

                    // Подсчет количества обработанных файлов
                    Invoke((Action)(() => numberFileLabel.Text = (++count).ToString()));
                }

                DirectoryInfo[] dirs = Path.GetDirectories();
                foreach (DirectoryInfo directoryInfo in dirs)
                {
                    Search(directoryInfo, startPath, pattern, symbols, token);
                }

            }
            catch (UnauthorizedAccessException ex) { }
            catch (DirectoryNotFoundException dfex)
            {
                MessageBox.Show("Неудалось найти заданную стартовую директорию!", "Внимание!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            cts.Cancel();
            stopButton.Enabled = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Сохранение последних критериев поиска
            Criteria criteria = new Criteria(directoryPathTextBox.Text, 
                                             fileNameTextBox.Text, symbolsTextBox.Text);

            Criteria.Save(criteria);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            end = DateTime.Now;
            TimeSpan interval = end - start;
            timeSearchLabel.Text = String.Format("{0:f1}", interval.TotalSeconds).ToString() + " сек.";
        }
    }
}
