using System;

class Program
{
    static void PrintGreeting(string userName)
    {
        Console.WriteLine("Привет, " + userName + "! Добро пожаловать!");
    }

    static void RunTask1()
    {
        Console.Write("Введите имя: ");
        string greetName = Console.ReadLine();

        PrintGreeting(greetName);
    }

    static double CalculateArea(double rectLength, double rectWidth)
    {
        return rectLength * rectWidth;
    }

    static void RunTask2()
    {
        Console.Write("Введите длину: ");
        double areaLength = double.Parse(Console.ReadLine());

        Console.Write("Введите ширину: ");
        double areaWidth = double.Parse(Console.ReadLine());

        double areaResult = CalculateArea(areaLength, areaWidth);

        Console.WriteLine("Площадь: " + areaResult);
    }

    static bool IsEven(int checkedNumber)
    {
        return checkedNumber % 2 == 0;
    }

    static void RunTask3()
    {
        Console.Write("Введите число: ");
        int evenNumber = int.Parse(Console.ReadLine());

        if (IsEven(evenNumber))
        {
            Console.WriteLine("Число чётное");
        }
        else
        {
            Console.WriteLine("Число нечётное");
        }
    }

    static void PrintMultiplicationTable(int tableBase)
    {
        for (int step = 1; step <= 10; step++)
        {
            Console.WriteLine(tableBase + " x " + step + " = " + (tableBase * step));
        }
    }

    static void RunTask4()
    {
        Console.Write("Введите число: ");
        int tableNumber = int.Parse(Console.ReadLine());

        Console.WriteLine();
        PrintMultiplicationTable(tableNumber);
    }

    static double Add(double addFirst, double addSecond)
    {
        return addFirst + addSecond;
    }

    static double Subtract(double subFirst, double subSecond)
    {
        return subFirst - subSecond;
    }

    static double Multiply(double mulFirst, double mulSecond)
    {
        return mulFirst * mulSecond;
    }

    static double Divide(double divFirst, double divSecond)
    {
        return divFirst / divSecond;
    }

    static void RunTask5()
    {
        string calcAgain = "да";

        while (calcAgain == "да")
        {
            Console.Write("Введите первое число: ");
            double calcFirst = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double calcSecond = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine();

            Console.Write("Выберите операцию: ");
            int calcChoice = int.Parse(Console.ReadLine());

            if (calcChoice == 1)
            {
                Console.WriteLine("Результат: " + Add(calcFirst, calcSecond));
            }
            else if (calcChoice == 2)
            {
                Console.WriteLine("Результат: " + Subtract(calcFirst, calcSecond));
            }
            else if (calcChoice == 3)
            {
                Console.WriteLine("Результат: " + Multiply(calcFirst, calcSecond));
            }
            else if (calcChoice == 4)
            {
                if (calcSecond == 0)
                {
                    Console.WriteLine("Ошибка: делить на ноль нельзя!");
                }
                else
                {
                    Console.WriteLine("Результат: " + Divide(calcFirst, calcSecond));
                }
            }
            else
            {
                Console.WriteLine("Такой операции нет. Выберите число от 1 до 4.");
            }

            Console.WriteLine();
            Console.Write("Продолжить? (да/нет): ");
            calcAgain = Console.ReadLine().ToLower();
            Console.WriteLine();
        }
    }

    static void WaitForEnter()
    {
        Console.WriteLine();
        Console.WriteLine("Нажмите Enter, чтобы перейти к следующему заданию...");
        Console.ReadLine();
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("===== Задание 1. Персональное приветствие =====");
        RunTask1();
        WaitForEnter();

        Console.WriteLine("===== Задание 2. Площадь прямоугольника =====");
        RunTask2();
        WaitForEnter();

        Console.WriteLine("===== Задание 3. Проверка числа =====");
        RunTask3();
        WaitForEnter();

        Console.WriteLine("===== Задание 4. Таблица умножения =====");
        RunTask4();
        WaitForEnter();

        Console.WriteLine("===== Задание 5. Калькулятор =====");
        RunTask5();

        Console.WriteLine("Все задания выполнены. Нажмите Enter для выхода.");
        Console.ReadLine();
    }
}
