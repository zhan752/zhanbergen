using System;

class Program
{
    static void Main()
    {
        Task1();
        Next();

        Task2();
        Next();

        Task3();
        Next();

        Task4();
        Next();

        Task5();

        Console.WriteLine();
        Console.WriteLine("Все задания выполнены! Нажмите Enter для выхода...");
        Console.ReadLine();
    }

    // ---------- Вспомогательные методы ----------

    // Пауза между заданиями
    static void Next()
    {
        Console.WriteLine();
        Console.WriteLine("Нажмите Enter, чтобы перейти к следующему заданию...");
        Console.ReadLine();
        Console.Clear();
    }

    // Чтение целого числа (повторяет ввод, пока не введут число)
    static int ReadInt()
    {
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Ошибка! Введите целое число: ");
        }
        return number;
    }

    // Чтение целого числа в диапазоне от min до max
    static int ReadIntInRange(int min, int max)
    {
        int number = ReadInt();
        while (number < min || number > max)
        {
            Console.Write("Число должно быть от " + min + " до " + max + ". Повторите ввод: ");
            number = ReadInt();
        }
        return number;
    }

    // ---------- Задание 1. Список оценок ----------
    static void Task1()
    {
        Console.WriteLine("=== Задание 1. Список оценок ===");
        Console.WriteLine();

        int[] grades = new int[5];

        for (int i = 0; i < grades.Length; i++)
        {
            Console.Write("Введите оценку " + (i + 1) + ": ");
            grades[i] = ReadInt();
        }

        Console.WriteLine();
        Console.WriteLine("Оценки студента:");
        foreach (int grade in grades)
        {
            Console.Write(grade + " ");
        }
        Console.WriteLine();
    }

    // ---------- Задание 2. Сумма элементов ----------
    static void Task2()
    {
        Console.WriteLine("=== Задание 2. Сумма элементов ===");
        Console.WriteLine();

        int[] numbers = new int[6];

        Console.WriteLine("Введите 6 чисел:");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = ReadInt();
        }

        int sum = CalculateSum(numbers);

        Console.WriteLine();
        Console.WriteLine("Сумма элементов: " + sum);
    }

    static int CalculateSum(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum = sum + numbers[i];
        }
        return sum;
    }

    // ---------- Задание 3. Чётные и нечётные числа ----------
    static void Task3()
    {
        Console.WriteLine("=== Задание 3. Чётные и нечётные числа ===");
        Console.WriteLine();

        int[] array = new int[10];

        Console.WriteLine("Введите 10 чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = ReadInt();
        }

        int evenCount = 0;
        int oddCount = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (IsEven(array[i]))
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }

        Console.WriteLine();
        Console.Write("Массив: ");
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Чётных чисел: " + evenCount);
        Console.WriteLine("Нечётных чисел: " + oddCount);
    }

    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    // ---------- Задание 4. Поиск максимального значения ----------
    static void Task4()
    {
        Console.WriteLine("=== Задание 4. Поиск максимального значения ===");
        Console.WriteLine();

        int[] array = new int[7];

        Console.WriteLine("Введите 7 чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = ReadInt();
        }

        int max = array[0];
        int maxIndex = 0;

        // Знак ">" (а не ">=") гарантирует, что останется индекс ПЕРВОГО максимума
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }

        Console.WriteLine();
        Console.Write("Массив: ");
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Максимальное число: " + max);
        Console.WriteLine("Индекс: " + maxIndex);
    }

    // ---------- Задание 5. Анализ успеваемости ----------
    static void Task5()
    {
        Console.WriteLine("=== Задание 5. Анализ успеваемости ===");
        Console.WriteLine();

        Console.Write("Количество студентов: ");
        int count = ReadInt();
        while (count <= 0)
        {
            Console.Write("Количество должно быть положительным. Повторите ввод: ");
            count = ReadInt();
        }

        int[] grades = new int[count];

        Console.WriteLine();
        for (int i = 0; i < grades.Length; i++)
        {
            Console.Write("Оценка " + (i + 1) + ": ");
            grades[i] = ReadIntInRange(0, 100);
        }

        Console.WriteLine();
        Console.WriteLine("Средний балл: " + CalculateAverage(grades));
        Console.WriteLine("Максимальный балл: " + FindMax(grades));
        Console.WriteLine("Минимальный балл: " + FindMin(grades));
        Console.WriteLine("Студентов с оценкой 70 и выше: " + CountPassed(grades));
    }

    static double CalculateAverage(int[] grades)
    {
        int sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum = sum + grades[i];
        }
        return (double)sum / grades.Length;
    }

    static int FindMax(int[] grades)
    {
        int max = grades[0];
        for (int i = 1; i < grades.Length; i++)
        {
            if (grades[i] > max)
            {
                max = grades[i];
            }
        }
        return max;
    }

    static int FindMin(int[] grades)
    {
        int min = grades[0];
        for (int i = 1; i < grades.Length; i++)
        {
            if (grades[i] < min)
            {
                min = grades[i];
            }
        }
        return min;
    }

    static int CountPassed(int[] grades)
    {
        int count = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            if (grades[i] >= 70)
            {
                count++;
            }
        }
        return count;
    }
}
