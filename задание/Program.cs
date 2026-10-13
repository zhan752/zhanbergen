
Console.Write("Введите имя: ");
string name = Console.ReadLine();
Console.Write("Введите возраст: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите город: ");
string city = Console.ReadLine();
Console.Write("Введите специальность: ");
string speciality = Console.ReadLine();

Console.WriteLine("Меня зовут " + name + ". Мне " + age + " лет. Я живу в городе " + city + ". Моя специальность — " + speciality + ".");


Console.Write("Товар: ");
string product = Console.ReadLine();
Console.Write("Цена: ");
int price = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество: ");
int count = Convert.ToInt32(Console.ReadLine());

int total = price * count;
Console.WriteLine("Итого: " + total + " тг.");


Console.Write("Введите возраст в годах: ");
int years = Convert.ToInt32(Console.ReadLine());

int months = years * 12;
int days = years * 365;

Console.WriteLine("Месяцев: " + months);
Console.WriteLine("Дней: " + days);


Console.Write("Количество отработанных часов: ");
int hours = Convert.ToInt32(Console.ReadLine());
Console.Write("Оплата за один час: ");
int payPerHour = Convert.ToInt32(Console.ReadLine());

int salary = hours * payPerHour;
Console.WriteLine("Итоговая зарплата: " + salary + " тг.");


Console.Write("Расстояние (км): ");
double distance = Convert.ToDouble(Console.ReadLine());
Console.Write("Расход на 100 км (л): ");
double consumption = Convert.ToDouble(Console.ReadLine());
Console.Write("Стоимость 1 литра бензина: ");
double fuelPrice = Convert.ToDouble(Console.ReadLine());

double liters = distance / 100 * consumption;
double cost = liters * fuelPrice;

Console.WriteLine("Потребуется литров: " + liters);
Console.WriteLine("Стоимость поездки: " + cost + " тг.");


Console.Write("Оценка по 1 предмету: ");
int g1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Оценка по 2 предмету: ");
int g2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Оценка по 3 предмету: ");
int g3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Оценка по 4 предмету: ");
int g4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Оценка по 5 предмету: ");
int g5 = Convert.ToInt32(Console.ReadLine());

double average = (g1 + g2 + g3 + g4 + g5) / 5.0;
Console.WriteLine("Средний балл: " + average);


Console.Write("Введите возраст: ");
int age = int.Parse(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("Доступ разрешен");
}
else
{
    Console.WriteLine("Доступ запрещен");
}


Console.Write("Введите число: ");
double number = double.Parse(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine("Число положительное");
}
else if (number < 0)
{
    Console.WriteLine("Число отрицательное");
}
else
{
    Console.WriteLine("Это ноль");
}


Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}


Console.Write("Введите первое число: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = double.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Большее число: " + a);
}
else if (b > a)
{
    Console.WriteLine("Большее число: " + b);
}
else
{
    Console.WriteLine("Числа одинаковые");
}


Console.Write("Введите количество баллов (0-100): ");
int score = int.Parse(Console.ReadLine());

if (score < 0 || score > 100)
{
    Console.WriteLine("Ошибка: баллы должны быть от 0 до 100");
}
else if (score <= 49)
{
    Console.WriteLine("Неудовлетворительно");
}
else if (score <= 69)
{
    Console.WriteLine("Удовлетворительно");
}
else if (score <= 89)
{
    Console.WriteLine("Хорошо");
}
else
{
    Console.WriteLine("Отлично");
}



Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.Write(i + " ");
}
Console.WriteLine();


Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine();


Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= n; i++)
{
    sum = sum + i;
}

Console.WriteLine("Сумма: " + sum);


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(number + " × " + i + " = " + (number * i));
}


Console.Write("Количество чисел: ");
int count = int.Parse(Console.ReadLine());
double sum = 0;

for (int i = 0; i < count; i++)
{
    Console.Write("Введите число: ");
    double number = double.Parse(Console.ReadLine());
    sum = sum + number;
}

Console.WriteLine("Сумма: " + sum);
Console.WriteLine("Среднее арифметическое: " + sum / count);


int secret = 37;
int attempts = 0;
int guess = 0;

while (guess != secret)
{
    Console.Write("Введите число: ");
    guess = int.Parse(Console.ReadLine());
    attempts++;

    if (guess > secret)
    {
        Console.WriteLine("Слишком большое число.");
    }
    else if (guess < secret)
    {
        Console.WriteLine("Слишком маленькое число.");
    }
}

Console.WriteLine("Вы угадали!");
Console.WriteLine("Количество попыток: " + attempts); 17:49