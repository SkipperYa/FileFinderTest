namespace FileFinderTest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Стартовая директория");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Шаблон");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Символы");
            this.directoryPathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.currentFileLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberFileLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timeSearchLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.currentDirectoryLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.symbolsTextBox = new System.Windows.Forms.TextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // directoryPathTextBox
            // 
            this.directoryPathTextBox.Location = new System.Drawing.Point(33, 44);
            this.directoryPathTextBox.Name = "directoryPathTextBox";
            this.directoryPathTextBox.Size = new System.Drawing.Size(208, 20);
            this.directoryPathTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Стартовая директория:";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(376, 44);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 20);
            this.findButton.TabIndex = 4;
            this.findButton.Text = "Поиск";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(33, 124);
            this.treeView.Name = "treeView";
            treeNode7.Name = "StartDirectory";
            treeNode7.Text = "Стартовая директория";
            treeNode8.Name = "Pattern";
            treeNode8.Text = "Шаблон";
            treeNode9.Name = "Simbols";
            treeNode9.Text = "Символы";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            this.treeView.Size = new System.Drawing.Size(289, 286);
            this.treeView.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сейчас в обработке:";
            // 
            // currentFileLabel
            // 
            this.currentFileLabel.AutoSize = true;
            this.currentFileLabel.Location = new System.Drawing.Point(340, 162);
            this.currentFileLabel.Name = "currentFileLabel";
            this.currentFileLabel.Size = new System.Drawing.Size(0, 13);
            this.currentFileLabel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кол-во обработанных файлов:";
            // 
            // numberFileLabel
            // 
            this.numberFileLabel.AutoSize = true;
            this.numberFileLabel.Location = new System.Drawing.Point(494, 190);
            this.numberFileLabel.Name = "numberFileLabel";
            this.numberFileLabel.Size = new System.Drawing.Size(13, 13);
            this.numberFileLabel.TabIndex = 7;
            this.numberFileLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Затраченное время:";
            // 
            // timeSearchLabel
            // 
            this.timeSearchLabel.AutoSize = true;
            this.timeSearchLabel.Location = new System.Drawing.Point(445, 219);
            this.timeSearchLabel.Name = "timeSearchLabel";
            this.timeSearchLabel.Size = new System.Drawing.Size(37, 13);
            this.timeSearchLabel.TabIndex = 9;
            this.timeSearchLabel.Text = "0 сек.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Шаблон имени файла:";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(251, 44);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(116, 20);
            this.fileNameTextBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Текущая директория:";
            // 
            // currentDirectoryLabel
            // 
            this.currentDirectoryLabel.AutoSize = true;
            this.currentDirectoryLabel.Location = new System.Drawing.Point(328, 124);
            this.currentDirectoryLabel.Name = "currentDirectoryLabel";
            this.currentDirectoryLabel.Size = new System.Drawing.Size(0, 13);
            this.currentDirectoryLabel.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Символы в файле:";
            // 
            // symbolsTextBox
            // 
            this.symbolsTextBox.Location = new System.Drawing.Point(33, 86);
            this.symbolsTextBox.Name = "symbolsTextBox";
            this.symbolsTextBox.Size = new System.Drawing.Size(208, 20);
            this.symbolsTextBox.TabIndex = 3;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(457, 44);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 20);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Стоп";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.symbolsTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.currentDirectoryLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeSearchLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numberFileLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentFileLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.directoryPathTextBox);
            this.Name = "Form1";
            this.Text = "Поиск файлов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox directoryPathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label currentFileLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label numberFileLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label timeSearchLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label currentDirectoryLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox symbolsTextBox;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Timer timer;
    }
}

