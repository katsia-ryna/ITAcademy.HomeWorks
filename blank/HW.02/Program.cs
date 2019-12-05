using System;
using System.IO;

namespace HW._02
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.считываем тект из файла image.txt
            //2.задаем строчный тип данных для считанных данных
            //3.задаем строчный тип массиву и присваиваем массиву считанные ранее данные
            //4.очистка объекта (освобождение неуправляемых ресурсов) 
            //5.задаем тип данных byte для массива
            //6.описываем цикл, считываются данные из массива
            //7.конвертируем данные из массива в эквивалентные 8-разрядные целые числа
            //8.записываем получившуюся картинку в папку
            //все работало)

            StreamReader textReader = new StreamReader(@"C:\Windows\Temp\image.txt", true);
            string textReaderResult = textReader.ReadToEnd();
            string[] arrayOFTextResult = textReaderResult.Split(' ');
            textReader.Dispose();
            byte[] imageBytes = new byte[arrayOFTextResult.Length - 1];

            for (int i = 0; i < arrayOFTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOFTextResult[i], 2);
                imageBytes[i] = binary;

            }
            File.WriteAllBytes(@"C:\Windows\Temp\image.png", imageBytes);

        }
    }
}
