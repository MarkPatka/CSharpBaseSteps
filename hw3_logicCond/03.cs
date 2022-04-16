using System;

namespace task_03_L3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Поочередно введите числа A, B и С: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Исходный порядок: | {A} | {B} | {C} |\n");

            int A1, B1, C1;

            if ((A == B) ^ (A == C) ^ (B == C))

            {
                if (A == B && A > C)
                {
                    A1 = A; B1 = B; C1 = C;
                    Console.Write($"В порядке возрастания: | {C1} | {B1} | {A1} |" +
                        $"\nВ порядке убывания: | {A1} | {B1} | {C1} |");

                }
                else if (A == B && A < C)
                {
                    A1 = C; B1 = B; C1 = A;
                    Console.Write($"В порядке возрастания: | {C1} | {B1} | {A1} |" +
                        $"\nВ порядке убывания: | {A1} | {B1} | {C1} |");
                }

                if (A == C && A > B)
                {
                    A1 = A; B1 = C; C1 = B;
                    Console.Write($"В порядке возрастания: | {C1} | {B1} | {A1} |" +
                        $"\nВ порядке убывания: | {A1} | {B1} | {C1} |");
                }
                else if (A == C && A < B)
                {
                    A1 = B; B1 = A; C1 = C;
                    Console.Write($"В порядке возрастания: | {C1} | {B1} | {A1} |" +
                        $"\nВ порядке убывания: | {A1} | {B1} | {C1} |");
                }
                if (B == C && B > A)
                {
                    A1 = B; B1 = C; C1 = A;
                    Console.Write($"В порядке возрастания: | {C1} | {B1} | {A1} |" +
                        $"\nВ порядке убывания: | {A1} | {B1} | {C1} |");
                }
                else if (B == C && B < A)
                {
                    A1 = A; B1 = B; C1 = C;
                    Console.Write($"В порядке возрастания: | {C1} | {B1} | {A1} |" +
                        $"\nВ порядке убывания: | {A1} | {B1} | {C1} |");
                }

            }
            else
            {
                A1 = A > B && A > C ? A : (B > A && B > C ? B : C);
                B1 = (B > A && A > C) ^ (B < A && A < C) ? A :
                    ((A > B && B > C) ^ (A < B && B < C) ? B : C);
                C1 = A < B && A < C ? A : (B < A && B < C ? B : C);
                Console.Write($"В порядке возрастания: | {C1} | {B1} | {A1} |" +
                    $"\nВ порядке убывания: | {A1} | {B1} | {C1} |");
            }


        }
    }
}
