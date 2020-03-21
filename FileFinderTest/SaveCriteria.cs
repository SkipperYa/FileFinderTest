using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileFinderTest
{
    [Serializable]
    class Criteria
    {
        public string Directory { get; set; }

        public string Pattern { get; set; }

        public string Symbols { get; set; }

        public Criteria()
        {
            Directory = "";
            Pattern = "";
            Symbols = "";
        }

        public Criteria(string directory, string pattern, string symbols)
        {
            Directory = directory;
            Pattern = pattern;
            Symbols = symbols;
        }

        public static void Save(Criteria c)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (FileStream stream = new FileStream("criteria.dat", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(stream, c);
            }
        }

        public static Criteria Load()
        {
            Criteria c;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            try
            {
                using (FileStream stream = new FileStream("criteria.dat", FileMode.Open))
                {
                    c = (Criteria)binaryFormatter.Deserialize(stream);
                }
                return c;
            }
            catch (SerializationException sexc) { return new Criteria(); }
            catch (FileNotFoundException fnfexc) { return new Criteria(); }
        }
    }
}
