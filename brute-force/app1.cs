using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brute_force {
    public class app1
    {
        public string Directory { get; set; }
        public string FileName { get; set; }

        public app1()
        {
            this.Directory = @"C:\Users\uysal\Desktop";
            this.FileName = "q1";
        }

        public app1(string Directory, string FileName)
        {
            this.Directory = Directory;
            this.FileName = FileName;
        }

        public void Run(string text)
        {
            List<char> characters = editText(text);
            List<string> datas = new List<string>();
            string data = String.Empty;

            foreach (char digit1 in characters)
            {
                foreach (char digit2 in characters)
                {
                    foreach (char digit3 in characters)
                    {
                        foreach (char digit4 in characters)
                        {
                            foreach (char digit5 in characters)
                            {
                                data = $"{digit1}{digit2}{digit3}{digit4}{digit5}";
                                datas.Add(data);
                                data = String.Empty;
                            }
                        }
                    }
                }
            }
            newTxt(Directory, FileName);
            write($@"{Directory}\{FileName}.txt", datas);
        }

        private List<char> editText(string text)
        {
            text = text.Replace(" ", "");
            text = text.Replace(",", "");
            List<char> characters = new List<char>();

            foreach (char character in text)
            {
                if (!characters.Contains(character))
                {
                    characters.Add(character);
                }
            }
            //characters.Sort();
            return characters;
        }

        private void newTxt(string directory, string fileName)
        {
            FileStream fileStream = File.Create($@"{directory}\{fileName}.txt");
            fileStream.Close();
        }

        private void write(string directory, List<string> datas)
        {
            File.WriteAllLines(directory, datas);
        }
    }
}


