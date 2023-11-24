using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_images
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int imagesCount;
            int maxImagesInRow;
            int countFilledRow;
            int countRemainderImages;

            Console.Write("Сколько всего у вас картинок?: ");
            imagesCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько картинок должно быть в одном ряду?: ");
            maxImagesInRow = Convert.ToInt32(Console.ReadLine());

            countFilledRow = imagesCount / maxImagesInRow;
            countRemainderImages = imagesCount % maxImagesInRow;

            Console.WriteLine($"\nПолностью заполненых рядов: {countFilledRow}\n" +
                              $"Остаток картинок на непоный ряд: {countRemainderImages}.\n");
        }
    }
}