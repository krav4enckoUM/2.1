using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1
{
    class Word
    {
        public string WordValue { get; set; } //Свойство, хранящее введенное слово

        public string wordEndToBegin() //Метод переворачивания слова
        {
            char[] letters = WordValue.ToCharArray(); //Преобразуем строку в массив символов
            Array.Reverse(letters); //Реверсируем массив
            return new string(letters); //переводим массив символов обратно в строку
        }

        public string InsertLetter(string letter, Int32 position) //Метод вставки символа в слово
        {
            if (position > WordValue.Length) //Проверка корректности введенных данных
            {
                return "Ошибка вставки!";
            }
            else
            {
                return WordValue.Insert(position - 1, letter); //Вставка символа в нужное место
            }
        }

        public Int32 WordMaxLength
        {
            get { return WordValue.Length; } //Находим длину слова
        }

        public Int32 NumberOfDifferentLetters
        {
            get
            {
                Int32 i = 0;
                var groups = WordValue.ToCharArray().GroupBy(c => c); //Лямбда-выражение для поиска разных букв
                foreach (var char_group in groups)
                    i++; //Подсчет кол-ва разных букв
                return i;
            }
        }
    }
}
