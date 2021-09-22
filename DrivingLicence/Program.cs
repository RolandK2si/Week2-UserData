using System;

namespace DrivingLicence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis
            //"Oled liiga noor, et juhilube saada"
            //kui kasutaja on vanem kui 18, siis programm kuvab konsoolis
            //"Oled piisavalt vana, et juhilube saada"
            //kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju õnne! Nüüd sa saad ka juhilube taotleda"

            Console.WriteLine("Palun, kirjuta oma sünniaasta");
            int yearofbirth = Convert.ToInt32(Console.ReadLine());

            int userage = 2021 - yearofbirth;

            if (userage > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada");
            }
            else if (userage < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada");
            }
            else
            {
                Console.WriteLine("Palju õnne! Nüüd oled piisavalt vana, et juhilube saada");
            }
        }
    }
}
