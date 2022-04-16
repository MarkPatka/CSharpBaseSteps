using System;
using System.Collections.Generic;
using System.Text;

//switch (dozen)
//{
//    case 1:
//        switch (unit)
//        {
//            case 0:
//                Console.WriteLine("Десять");
//                break;
//            case 1:
//                Console.WriteLine(units[1] + ending);
//                break;
//            case 2:
//                Console.WriteLine("Две" + ending);
//                break;
//            case 3:
//                Console.WriteLine(units[3] + ending);
//                break;
//            case 4:
//                Console.WriteLine(units[4].Remove(4) + ending);
//                break;
//            case 5:
//                Console.WriteLine(units[5].Remove(3) + ending);
//                break;
//            case 6:
//                Console.WriteLine(units[6].Remove(3) + ending);
//                break;
//            case 7:
//                Console.WriteLine(units[7].Remove(3) + ending);
//                break;
//            case 8:
//                Console.WriteLine(units[8].Remove(5) + ending);
//                break;
//            case 9:
//                Console.WriteLine(units[9].Remove(5) + ending);
//                break;
//        }


//        break;

namespace task_05_L3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int dozen = number / 10;
            int unit = number % 10;
            string ending = "надцать";
            string ending1 = "десят";

            Dictionary<int, string> units = new Dictionary<int, string>(10);
            units.Add(0, " ");
            units.Add(1, "Один");
            units.Add(2, "Два");
            units.Add(3, "Три");
            units.Add(4, "Четыре");
            units.Add(5, "Пять");
            units.Add(6, "Шесть");
            units.Add(7, "Семь");
            units.Add(8, "Восемь");
            units.Add(9, "Девять");


            if (dozen == 1 && unit == 0)
            {
                Console.WriteLine("Десять");
            }
            else if (dozen == 1 && unit == 2)
            {
                Console.WriteLine(units[2].Substring(0, units[2].Length - 1) + "e" + ending);
            }
            else if (dozen == 1 && unit == 3)
            {
                Console.WriteLine(units[3] + ending);
            }
            else if (dozen == 1 && (unit == 1) ^ (unit >= 4))
            {
                Console.WriteLine(units[unit].Substring(0, units[unit].Length - 1) + ending);
            }
            else if (dozen == 2 ^ dozen == 3)
            {
                Console.WriteLine(units[dozen] + ending.Substring(2) + " " + units[unit]);
            }
            else if (dozen == 4)
            {
                Console.WriteLine("Сорок " + units[unit]);
            }
            else if (dozen == 5 ^ dozen == 6 ^ dozen == 7 ^ dozen == 8)
            {
                Console.WriteLine(units[dozen] + ending1 + " " + units[unit]);
            }
            else if (dozen == 9)
            {
                Console.WriteLine("Девяносто " + units[unit]);
            }




        }
    }
}


        
            
             


