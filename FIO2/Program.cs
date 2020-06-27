using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIO2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName;
            string lName;
            string pogonyalo;
            float height;
            float weight;
            string mobile;
            float age;
            string city;
            string street;
            int house;
            int apartment;

            Console.Write("Ваше имя:"); fName = Console.ReadLine().Trim();
            Console.Write("Ваша фамилия:"); lName = Console.ReadLine().Trim();
            Console.Write("Ваше отчество:"); pogonyalo = Console.ReadLine().Trim();
            Console.Write("Ваш рост:"); height = float.Parse(Console.ReadLine().Replace(",", "."));
            Console.Write("Ваш вес:"); weight = float.Parse(Console.ReadLine().Replace(",", "."));
            Console.Write("Номер вашего мобильного телефона:"); mobile = Console.ReadLine().Trim();
            Console.Write("Ваш возраст:"); age = float.Parse(Console.ReadLine().Replace(",", "."));
            Console.Write("Ваш город:"); city = Console.ReadLine().Trim();
            Console.Write("Ваша улица:"); street = Console.ReadLine().Trim();
            Console.Write("Номер вашего дома:"); house = int.Parse(Console.ReadLine());
            Console.Write("Номер вашей квартиры:"); apartment = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------------");

            Console.WriteLine($"Ваше имя: {fName}");
            Console.WriteLine($"Ваша фамилия: {lName}");
            Console.WriteLine($"Ваше отчество: {pogonyalo}");
            Console.WriteLine($"Ваш рост: {height}");
            Console.WriteLine($"Ваш вес: {weight}");
            Console.WriteLine($"Номер вашего мобильного телефона: {mobile}");
            Console.WriteLine($"Ваш возраст: {age}");
            Console.WriteLine($"Ваш город: {city}");
            Console.WriteLine($"Ваша улица: {street}");
            Console.WriteLine($"Номер вашего дома: {house}");
            Console.WriteLine($"Номер вашей квартиры: {apartment}");

            Console.ReadLine();
        }
    }
}
