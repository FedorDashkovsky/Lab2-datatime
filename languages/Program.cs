using System;
using System.Globalization;

namespace Task8
{
    public class Reader
    {
        public static CultureInfo ReadCulture()
        {
            
            
            Console.WriteLine("Выберите язык: ru-русский, en-английский, fr-французский и др.");
            CultureInfo culture;
            Console.WriteLine("Введите культуру:");
            while (true)
            {
                string inputCulture = Console.ReadLine();
                try
                {
                    culture = CultureInfo.CreateSpecificCulture(inputCulture);
                    return culture;
                }
                catch (CultureNotFoundException)
                {
                    Console.WriteLine("Неправильный вид, введите существующую культуру.");
                }
            }
        }
        static void Main(string[] args)
        {
            CultureInfo culture = ReadCulture();
            DateTime someDate = new DateTime();
            for (int index = 0; index < 12; index++)
            {
                Console.WriteLine(someDate.AddMonths(index).ToString("MMMM", culture));
            }
        }
    

    
    }


}




