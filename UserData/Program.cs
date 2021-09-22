using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanust;
            //programm kuvab kasutaja vanust konsoolis;

            Console.WriteLine("Palun, sisesta oma sünniaasta");
            int yearofbirth = Convert.ToInt32(Console.ReadLine());

            int userage = 2021 - yearofbirth;

            //Console.WriteLine("Oled " + userage + " aastat vana");

            //string interpolation

            Console.WriteLine($"Oled {userage} aastat vana");

        }

    }
}
