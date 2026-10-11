using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            string[] word_array = { "Пирог", "Вешалка", "Душ" };
            int attempt = 3;


            Random rnd = new Random();
            int random_value = rnd.Next(word_array.Length);                                          ///Рандомное число


    
            string word = word_array[random_value];                                 //word = рандомное слово в массиве

            List<char> silent_word = new List<char>();
            for (int i = 0; i < word.Length; i++)
            {
                silent_word.Add('_');
                
            }
            Console.WriteLine(string.Join("", silent_word));

            while (attempt > 0)
            {
                Console.WriteLine("Введите букву");
                char z = Convert.ToChar(Console.ReadLine());
                if (word.Contains(z))
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == z)
                        {
                            silent_word[i] = z;
                            Console.WriteLine(silent_word);
                        }
                    }
                }
                else
                {
                    Console.WriteLine(string.Join("", silent_word));
                    attempt--;
                }
            }

            
            









        }
    }
}
