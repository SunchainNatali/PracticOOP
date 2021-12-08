using System;
using System.Collections.Generic;


namespace Methody
{
    class Program
    {

        static bool ResultNotNull { get; set; } = false;

        static double Resultat { get; set; }

        static double PeremX { get; set; }

        static double PeremY { get; set; }

        static int Choices { get; set; }

        static int BigChoiceOper { get; set; }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int choose;
            do
            {
                Console.WriteLine("Выбери операцию: \n 1. Калькулятор \n 2. Книга имен \n 3. Периметр, площадь, радиус окружности \n 4. Фигуры.");
                while (!int.TryParse(Console.ReadLine(), out choose))
                {
                    Console.WriteLine("Введите номер операции. Пример: Операция 1 = 1");
                }

                Choices = choose;

                switch (Choices)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Выберите математическую операцию: \n 1. Сложение \n 2. Вычетание \n 3. Умножение \n 4. Деление \n 5. Выход в главное меню");

                            BigChoiceOper = int.Parse(Console.ReadLine());

                            switch (BigChoiceOper)
                            {
                                case 1:
                                    while (true)
                                    {
                                        if (ResultNotNull)
                                        {
                                            PeremX = Resultat;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ты выбрал сложение \n Введи x:");

                                            PeremX = int.Parse(Console.ReadLine());
                                        }

                                        Console.WriteLine("Введите y: ");

                                        PeremY = int.Parse(Console.ReadLine());

                                        Resultat = Summa(PeremX, PeremY);
                                        ResultNotNull = true;

                                        Console.WriteLine("Вы хотите сохранить результат и продолжить с ним работу? (Y)es / (N)o / (C)ancel ");

                                        string res_value_sum = Console.ReadLine();


                                        if (res_value_sum == "N" || res_value_sum == "n")
                                        {
                                            Resultat = 0;
                                            ResultNotNull = false;
                                        }


                                        if (res_value_sum == "C" || res_value_sum == "c")
                                            break;
                                    }
                                    break;

                                case 2:
                                    while (true)
                                    {
                                        if (ResultNotNull)
                                        {
                                            PeremX = Resultat;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Введите x: ");

                                            PeremX = int.Parse(Console.ReadLine());
                                        }
                                        Console.WriteLine("Введите y: ");

                                        PeremY = int.Parse(Console.ReadLine());

                                        Resultat = Substraction(PeremX, PeremY);
                                        ResultNotNull = true;

                                        Console.WriteLine("Вы хотите сохранить результат и продолжить с ним работу? (Y)es / (N)o / (C)ancel ");

                                        string res_value_sub = Console.ReadLine();

                                        if (res_value_sub == "N" || res_value_sub == "n")
                                        {
                                            Resultat = 0;
                                            ResultNotNull = false;
                                        }

                                        if (res_value_sub == "C" || res_value_sub == "c")
                                        {
                                            break;
                                        }
                                    }

                                    break;
                                case 3:
                                    while (true)
                                    {
                                        if (ResultNotNull)
                                        {
                                            PeremX = Resultat;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Вы выбрали сумму \n Введите x:");

                                            PeremX = int.Parse(Console.ReadLine());
                                        }

                                        Console.WriteLine("Введите y: ");

                                        PeremY = int.Parse(Console.ReadLine());

                                        Resultat = Multiply(PeremX, PeremY);
                                        ResultNotNull = true;

                                        Console.WriteLine("Вы хотите сохранить результат и продолжить с ним работу? (Y)es / (N)o / (C)ancel ");

                                        string res_value_sum = Console.ReadLine();


                                        if (res_value_sum == "N" || res_value_sum == "n")
                                        {
                                            Resultat = 0;
                                            ResultNotNull = false;
                                        }


                                        if (res_value_sum == "C" || res_value_sum == "c")
                                            break;
                                    }


                                    break;
                                case 4:

                                    while (true)
                                    {
                                        if (ResultNotNull)
                                        {
                                            PeremX = Resultat;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Вы выбрали сумму \n Ведите x:");

                                            PeremX = int.Parse(Console.ReadLine());
                                        }



                                        PeremY = 0;
                                        while (PeremY == 0)
                                        {
                                            Console.WriteLine("Введите y: ");
                                            PeremY = int.Parse(Console.ReadLine());
                                        }


                                        Resultat = Division(PeremX, PeremY);
                                        ResultNotNull = true;

                                        Console.WriteLine("Вы хотите сохранить результат и продолжить с ним работу? (Y)es / (N)o / (C)ancel ");

                                        string res_value_sum = Console.ReadLine();


                                        if (res_value_sum == "N" || res_value_sum == "n")
                                        {
                                            Resultat = 0;
                                            ResultNotNull = false;
                                        }


                                        if (res_value_sum == "C" || res_value_sum == "c")
                                            break;
                                    }


                                    break;
                            }


                        } while (BigChoiceOper != 5);

                        break;
                    case 2:
                        int list_choose_Name;
                        List<string> names = new List<string>();
                        do
                        {
                            Console.WriteLine("Выберите, что вы хотиде сделать: \n 1. Добавить имя\n 2. Показать список имен \n 3. Удалить имя \n 5. Выход  ");

                            list_choose_Name = int.Parse(Console.ReadLine());
                            switch (list_choose_Name)
                            {

                                case 1:
                                    Console.WriteLine("Добавить имя");
                                    AddName(names);
                                    break;
                                case 2:
                                    Console.WriteLine("Содержит имена");
                                    ShowNames(names);

                                    break;
                                case 3:
                                    Console.WriteLine("Удалить имя");
                                    Console.WriteLine("Сделайте свой выбор");
                                    DellName(names, int.Parse(Console.ReadLine()));

                                    break;


                            }

                        } while (list_choose_Name != 5);
                        break;

                    case 3:

                        int user_enter;
                        do
                        {
                            Console.WriteLine("Выберите, что вы хотите найти. \n 1. Площадь\n 2. Периметр \n 3. Радиус окружности \n 6. Выход");
                            while (!int.TryParse(Console.ReadLine(), out user_enter))
                            {
                                Console.WriteLine("Введите номер операции:");
                            }
                            switch (user_enter)
                            {
                                case 1:
                                    Console.WriteLine("Окружность квадрата \n Введите R");
                                    double r;
                                    while (!double.TryParse(Console.ReadLine(), out r))
                                    {
                                        Console.WriteLine("Введите номер");
                                    }
                                    Square(r);

                                    break;

                                case 2:
                                    Console.WriteLine("Окружность квадрата \n Введите R");
                                    double rad;
                                    while (!double.TryParse(Console.ReadLine(), out rad))
                                    {
                                        Console.WriteLine("Введите номер");
                                    }
                                    Perimetr(rad);
                                    break;
                                case 3:
                                    Console.WriteLine("Диаметр круга");
                                    double diam;
                                    while (!double.TryParse(Console.ReadLine(), out diam))
                                    {
                                        Console.WriteLine("Введите номер");
                                    }
                                    Radius(diam);
                                    break;
                            }
                        } while (user_enter != 6);


                        break;
                    case 4:
                        Console.WriteLine("Выберите фигуру:\n 1 - Квадрат\n 2 - Треугольник прямоугольный\n 3 - Треугольник равносторонний\n 4 - Перевернутый треугольник\n 5 - Песочные часы");
                        int choice = int.Parse(Console.ReadLine());
                        do
                        {
                            switch (choice)
                            {
                                case 1:
                                    Square();
                                    return;
                                case 2:
                                    Triangle();
                                    return;
                                case 3:
                                    EquilateralTriangle();
                                    return;
                                case 4:
                                    Reverse_triangle();
                                    return;
                                case 5:
                                    Hourglass();
                                    return;

                            }
                        } while (true);


                        break;
                }
            } while (choose != 6);
        }

        static double Summa(double x, double y)
        {

            double result = x + y;
            Console.WriteLine($"Результат: {x} + {y} = {result}");

            return result;
        }

        static double Substraction(double x, double y)
        {
            double result = x - y;
            Console.WriteLine($"Результат: {x} - {y} = {result}");
            return result;
        }

        static double Multiply(double x, double y)
        {
            double result = x * y;
            Console.WriteLine($"Результат: {x} * {y} = {result}");
            return result;
        }

        static double Division(double x, double y)
        {
            if (y == 0)
            {
                return 0;
            }
            double result = x / y;
            Console.WriteLine($"Результат: {x} / {y} = {result}");
            return result;
        }

        static double Square(double r)
        {
            const double pi = 3.14;
            double s = 2 * pi * Math.Pow(r, 2);
            double s2 = 2 * Math.Pow(r, 2);
            Console.WriteLine($"Площадь: {s}\n or {s2}PI");
            return s;
        }

        static double Perimetr(double r)
        {
            const double pi = 3.14;
            double p = 2 * pi * r;
            double pi2 = 2 * r;
            Console.WriteLine($"Периметр: {p} \n or {pi2}PI ");
            return p;
        }

        static double Radius(double diametr)
        {
            double radius = diametr / 2;
            Console.WriteLine($"Радиус: {radius}");
            return radius;
        }

        static void AddName(List<string> names)
        {
            Console.WriteLine("Введите слово");
            names.Add(Console.ReadLine());
        }

        static void ShowNames(List<string> names)
        {
            int i = 0;
            foreach (string str in names)
            {
                Console.WriteLine(i + ". " + str);
                i++;
            }
        }

        static void DellName(List<string> names, int number)
        {
            Console.WriteLine("Введите индекс для удаления");
            names.RemoveAt(number);
        }

        static void Reverse_triangle()
        {
            string[,] str = new string[5, 5];
            for (int i = 4; i >= 0; i--)
            {
                for (int j = 4; j >= 0; j--)
                {
                    str[i, j] = "0";

                    if (i == j)
                    {
                        break;
                    }
                }

            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (str[i, j] != "0")
                    {
                        str[i, j] = " ";
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(str[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Triangle()
        {
            string[,] str = new string[5, 5];
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    str[i, j] = "0";

                    if (i == j)
                    {
                        break;
                    }
                }

            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (str[i, j] != "0")
                    {
                        str[i, j] = " ";
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(str[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Square()
        {
            string[,] str = new string[5, 5];
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    str[i, j] = "0";
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (str[i, j] != "0")
                    {
                        str[i, j] = " ";
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(str[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void EquilateralTriangle()
        {
            int p = 5;
            int n = p;
            for (int i = 0; i < n; i++, p--)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("0");
                for (int m = 0; m < i * 2; m++)
                {
                    Console.Write("0");
                }
                Console.WriteLine("0");
            }
            for (int i = 0; i <= n; i++)
            {
                Console.Write("0");
            }
            Console.ReadKey();
        }
        static void Hourglass()
        {
            string[,] str = new string[5, 5];
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    if (i == 0)
                    {
                        str[i, j] = "0";
                    }
                    if (i == j)
                    {
                        str[i, 5 - j - 1] = "0";
                        str[i, j] = "0";
                    }
                    if (i == 4)
                    {
                        str[i, j] = "0";
                    }

                }

            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (str[i, j] != "0")
                    {
                        str[i, j] = " ";
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(str[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}