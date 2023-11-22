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
            int imageCount;
            int quantityPerRow;
            int maxRow;
            int remainder;

            Console.Write("Сколько всего у вас картинок?: ");
            imageCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько картинок должно быть в одном ряду?: ");
            quantityPerRow = Convert.ToInt32(Console.ReadLine());

            maxRow = imageCount / quantityPerRow;
            remainder = imageCount % quantityPerRow;

            // Сори за магическое число, просто вставил форматирование текста для красоты
            Console.WriteLine(new string('-', 45));

            Console.WriteLine($"Полностью заполненых рядов: {maxRow}\n" +
                              $"Остаток картинок на непоный ряд: {remainder}.\n");
        }
    }
}
