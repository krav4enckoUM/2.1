using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Word word = new Word(); //Создаем экземпляр класса
            Console.Write("Введите слово: ");
            word.WordValue = Console.ReadLine();

            Console.WriteLine("Слово наоборот: {0}", word.wordEndToBegin());
            Console.WriteLine("Длина слова: {0}", word.WordMaxLength.ToString());
            Console.WriteLine("Кол-во разных букв в слове: {0}", word.NumberOfDifferentLetters);

            Console.Write("\nВведите символ для вставки: ");
            string letter = Console.ReadLine();
            Console.Write("Введите позицию для вставки: ");
            Int32 position = Convert.ToInt32(Console.ReadLine());
            string newWord = word.InsertLetter(letter, position);
            Console.WriteLine("Слово после вставки: {0}", newWord);

            Console.ReadKey();
        }
    }
}
