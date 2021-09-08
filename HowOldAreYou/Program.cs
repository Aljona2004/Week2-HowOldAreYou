using System;

namespace HowOldAreYou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //programm küsib kasutaja vanust
            //programm arvutab kasutaja sünniaastat
            //programm kuvab kasutaja sünniaastat konsoolis

            //convert string from ReadLine() to int
            Console.WriteLine("Tere, kui vana sa oled?");
            int Age = Convert.ToInt32(Console.ReadLine());

            int YearOfBirth = 2021 - Age;

            Console.WriteLine("Oled sündinud aastal " + YearOfBirth);

        }
    }
}
