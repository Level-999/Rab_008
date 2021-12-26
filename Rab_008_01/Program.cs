using System;
using System.Linq;

using System.IO;


namespace Rab_008_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Выберите любую папку на своем компьютере, имеющую вложенные директории.
            //Выведите на консоль ее содержимое и содержимое всех подкаталогов.

            string path = @"C:\test"; //Создаём строковую переменную в которой хранится путь. Абсолютный путь. @"C:/Windows";
            Print(path,0);
            Console.ReadKey();
        }

        //Метод static, void выводит на экран содержимое
        static void Print(string path, int level)//Выодит на экран содержимое по этому пути path, level указывает уровни в папках
        {
            string[] dirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);


            if (dirs.Count() > 0 || files.Count() > 0)//Если у нас есть каталоги dirs.Count или файлы files.Count, знак или || для Count добавить вверху using System.Linq;

            {
                string offset = new string('\t', level);
                foreach (string s in dirs)
                {
                                      
                    Console.WriteLine(offset+s);
                    Print(s, level+1); //Вызов вложенных папок- level+1 Рекурсия
                }

                foreach (string s in files)

                {
                    Console.WriteLine(offset+s);
                   
                }
            }
            Console.ReadKey();
        }
        
    }
                

}


