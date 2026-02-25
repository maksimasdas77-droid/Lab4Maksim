using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Maksim
{
    internal class Ex4
    {
        internal class FileDetailsReader
        {

            public static void Startmas(string[] args)
            {
                string fileName = @"D:\учеба\БГУИР\ОПЯС#\Lab4Maksim\Hello.txt";
                File.WriteAllLines(fileName, args);
                Console.WriteLine("Аргументы сохранены в файл input.txt");
                Console.ReadLine();
            }
            public static void RestreamFile()
            {
                string fileName = @"D:\учеба\БГУИР\ОПЯС#\Lab4Maksim\Hello.txt";

                Console.Write("Введите новый текст для перезаписи файла: ");
                string newContent = Console.ReadLine();

                // Перезаписываем файл полностью
                File.WriteAllText(fileName, newContent, Encoding.UTF8);

                Console.WriteLine("Файл успешно перезаписан!");
            }


            public static void ReadFile(string fileName)
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fs, Encoding.UTF8);

                string text = reader.ReadToEnd();
                char[] contents = text.ToCharArray();

                reader.Close();
                fs.Close();

                foreach (char c in contents)
                    Console.Write(c);

                Console.WriteLine("\n\n----Cумирование----");
                Summarize(contents);
            }

            private static void Summarize(char[] contents)
            {
                int vowels = 0;
                int consonants = 0;
                int newLines = 0;

                string vowelSet = "аеёиоуыэюяAEIOUYaeiouy";

                foreach (char c in contents)
                {
                    if (c == '\n')
                        newLines++;
                    else if (vowelSet.Contains(c))
                        vowels++;
                    else if (char.IsLetter(c))
                        consonants++;
                }

                Console.WriteLine($"a) Общее количество символов: {contents.Length}");
                Console.WriteLine($"b) Общее количество гласных: {vowels}");
                Console.WriteLine($"c) Общее количество согласных: {consonants}");
                Console.WriteLine($"d) Общее количество строк: {newLines + 1}");
            }
        }
    }
}

