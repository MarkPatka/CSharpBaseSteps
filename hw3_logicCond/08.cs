using System;

namespace task_08_L3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите любое вещ. число: ");
            double R = Double.Parse(Console.ReadLine());
            Console.Write("\nУкажите координату Х: ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("\nУкажите координату Y: ");
            double y = Double.Parse(Console.ReadLine());

            double X1 = 0;
            double X2 = -2 * R;
            double X3 = 0;
            double Y1 = -2 * R;
            double Y2 = 0;
            double Y3 = 0;

            double V1 = ((X1 - x) * (Y2 - Y1)) - ((X2 - X1) * (Y1 - y));
            double V2 = ((X2 - x) * (Y3 - Y2)) - ((X3 - X2) * (Y2 - y));
            double V3 = ((X3 - x) * (Y1 - Y3)) - ((X1 - X3) * (Y3 - y));

            if (((V1 == 0 ^ V2 == 0 ^ V3 == 0))
                && ((y <= 0 && y >= (-2 * R)) && (x <= 0 && x >= (-2 * R))))
            {
                Console.Write("Точка лежит на стороне треугольника!");
                //Знаю, что костыль, но иначе включить в одно условие проверку этого не смог

            }
            else if (((X1 == x && Y1 == x) ^ (X2 == x && Y2 == y)
                ^ (X3 == x && Y3 == y)))
            {
                Console.WriteLine("Точка - угол треугольника!");
                //Аналогично :(
            }
            else if ((V1 > 0 && V2 > 0 && V3 > 0)
                ^ (V1 < 0 && V2 < 0 && V3 < 0))
            {
                Console.Write("Точка внутри треугольника!");
            }
            else
            {
                Console.Write("Точка вне треугольника!");
                double D = Math.Pow(x, 2) + Math.Pow(y, 2);

                if ((x >= 0 && y >= 0) && (D <= 4 * Math.Pow(R, 2)) && (D >= (1 / 4) * D))
                {
                    Console.Write("Точка лежит на дуге!");
                }
                else
                {
                    Console.Write("Точка Снаружи Дуги!");
                }
            }
        }

    }    
}
