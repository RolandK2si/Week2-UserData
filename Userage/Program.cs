using System;

namespace Userage
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaastat;
            //programm kuvab sünniaasta konsoolis;
            //"oled sündinud aastal {yearofbirth};

            Console.WriteLine("Palun, sisesta oma vanus");
            int age = Convert.ToInt32(Console.ReadLine());

            int yearofbirth = 2021 - age;

            Console.WriteLine($"Sa oled sündinud aastal {yearofbirth}");


        }
    }
}
