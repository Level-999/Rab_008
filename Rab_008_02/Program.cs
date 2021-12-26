using System;
using System.Linq;
using System.IO;

namespace Rab_008_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Программно создайте текстовый файл и запишите в него 10 случайных чисел.
            //Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.


            StreamWriter Text = new StreamWriter("d:\\Text.txt");
            Random r = new Random();
            for (int i = 0; i < 10; i++) Text.WriteLine(r.Next(0, 100));
               
            Text.Close();


            float sum = 0;
            string[] arg;
            StreamReader sr = new StreamReader("d:\\Text.txt");
            
            {
                arg = sr.ReadLine().Split(' ');
                
                foreach (string s in arg)


                {
                    if (s != null)
                    {                        
                        sum += float.Parse(s);
                    }

                }

            }
            sr.Close();
            Console.WriteLine("Сумма чисел = {0}", sum);
           



            Console.ReadKey();
        }

    }
}