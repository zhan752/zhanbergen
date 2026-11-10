using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Task1();
        Console.WriteLine("\nНажмите Enter, чтобы перейти к заданию 2...");
        Console.ReadLine();
        Console.Clear();

        Task2();
        Console.WriteLine("\nНажмите Enter, чтобы перейти к заданию 3...");
        Console.ReadLine();
        Console.Clear();

        Task3();
        Console.WriteLine("\nНажмите Enter, чтобы перейти к заданию 4...");
        Console.ReadLine();
        Console.Clear();

        Task4();
        Console.WriteLine("\nНажмите Enter, чтобы перейти к заданию 5...");
        Console.ReadLine();
        Console.Clear();

        Task5();
        Console.WriteLine("\nВсе задания выполнены! Нажмите Enter для выхода...");
        Console.ReadLine();
    }

    // ===== Задание 1. Список покупок (List<string>) =====
    static void Task1()
    {
        List<string> shopping = new List<string>();
        bool work = true;

        while (work)
        {
            Console.WriteLine("\n===== СПИСОК ПОКУПОК =====");
            Console.WriteLine("1. Добавить товар");
            Console.WriteLine("2. Показать товары");
            Console.WriteLine("3. Удалить товар");
            Console.WriteLine("4. Выход");
            Console.Write("Выберите пункт: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Введите товар: ");
                string item = Console.ReadLine();
                if (item == "")
                {
                    Console.WriteLine("Название не может быть пустым.");
                }
                else
                {
                    shopping.Add(item);
                    Console.WriteLine("Товар добавлен.");
                }
            }
            else if (choice == "2")
            {
                if (shopping.Count == 0)
                {
                    Console.WriteLine("Список пуст.");
                }
                else
                {
                    Console.WriteLine("Список:");
                    int number = 1;
                    foreach (string item in shopping)
                    {
                        Console.WriteLine(number + ". " + item);
                        number++;
                    }
                }
            }
            else if (choice == "3")
            {
                if (shopping.Count == 0)
                {
                    Console.WriteLine("Список пуст, удалять нечего.");
                }
                else
                {
                    Console.Write("Введите название товара для удаления: ");
                    string item = Console.ReadLine();
                    bool removed = shopping.Remove(item);
                    if (removed)
                        Console.WriteLine("Товар удалён.");
                    else
                        Console.WriteLine("Такого товара нет в списке.");
                }
            }
            else if (choice == "4")
            {
                work = false;
            }
            else
            {
                Console.WriteLine("Неверный пункт меню.");
            }
        }
    }

    // ===== Задание 2. Телефонная книга (Dictionary<string, string>) =====
    static void Task2()
    {
        Dictionary<string, string> book = new Dictionary<string, string>();
        bool work = true;

        while (work)
        {
            Console.WriteLine("\n===== ТЕЛЕФОННАЯ КНИГА =====");
            Console.WriteLine("1. Добавить контакт");
            Console.WriteLine("2. Найти номер по имени");
            Console.WriteLine("3. Удалить контакт");
            Console.WriteLine("4. Показать все контакты");
            Console.WriteLine("5. Выход");
            Console.Write("Выберите пункт: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Имя: ");
                string name = Console.ReadLine();
                Console.Write("Телефон: ");
                string phone = Console.ReadLine();

                if (name == "" || phone == "")
                {
                    Console.WriteLine("Имя и телефон не могут быть пустыми.");
                }
                else if (book.ContainsKey(name))
                {
                    Console.WriteLine("Контакт с таким именем уже существует.");
                }
                else
                {
                    book.Add(name, phone);
                    Console.WriteLine("Контакт добавлен.");
                }
            }
            else if (choice == "2")
            {
                Console.Write("Найти контакт: ");
                string name = Console.ReadLine();
                string phone;
                if (book.TryGetValue(name, out phone))
                    Console.WriteLine("Телефон: " + phone);
                else
                    Console.WriteLine("Контакт не найден.");
            }
            else if (choice == "3")
            {
                Console.Write("Введите имя для удаления: ");
                string name = Console.ReadLine();
                if (book.Remove(name))
                    Console.WriteLine("Контакт удалён.");
                else
                    Console.WriteLine("Контакт не найден.");
            }
            else if (choice == "4")
            {
                if (book.Count == 0)
                {
                    Console.WriteLine("Телефонная книга пуста.");
                }
                else
                {
                    Console.WriteLine("Все контакты:");
                    foreach (KeyValuePair<string, string> contact in book)
                    {
                        Console.WriteLine(contact.Key + " - " + contact.Value);
                    }
                }
            }
            else if (choice == "5")
            {
                work = false;
            }
            else
            {
                Console.WriteLine("Неверный пункт меню.");
            }
        }
    }

    // ===== Задание 3. Уникальные участники (HashSet<string>) =====
    static void Task3()
    {
        HashSet<string> members = new HashSet<string>();
        bool work = true;

        Console.WriteLine("===== РЕГИСТРАЦИЯ УЧАСТНИКОВ =====");
        Console.WriteLine("Для завершения введите: стоп");

        while (work)
        {
            Console.Write("\nВведите имя: ");
            string name = Console.ReadLine();

            // убираем пробелы и приводим к нижнему регистру,
            // чтобы "Анна" и "анна" считались одним участником
            name = name.Trim().ToLower();

            if (name == "")
            {
                Console.WriteLine("Имя не может быть пустым.");
            }
            else if (name == "стоп")
            {
                work = false;
            }
            else if (members.Contains(name))
            {
                Console.WriteLine("Такой участник уже зарегистрирован.");
            }
            else
            {
                members.Add(name);
                Console.WriteLine("Участник добавлен.");
            }
        }

        Console.WriteLine("\nВсего уникальных участников: " + members.Count);
    }

    // ===== Задание 4. Очередь в поликлинике (Queue<string>) =====
    static void Task4()
    {
        Queue<string> queue = new Queue<string>();
        bool work = true;

        while (work)
        {
            Console.WriteLine("\n===== ПОЛИКЛИНИКА =====");
            Console.WriteLine("1. Добавить пациента");
            Console.WriteLine("2. Вызвать следующего");
            Console.WriteLine("3. Посмотреть следующего");
            Console.WriteLine("4. Показать очередь");
            Console.WriteLine("5. Выход");
            Console.Write("Выберите пункт: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Имя пациента: ");
                string name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine("Имя не может быть пустым.");
                }
                else
                {
                    queue.Enqueue(name);
                    Console.WriteLine("Пациент добавлен в очередь.");
                }
            }
            else if (choice == "2")
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine("Очередь пуста, вызывать некого.");
                }
                else
                {
                    string patient = queue.Dequeue();
                    Console.WriteLine("Пациент " + patient + " вызван.");
                    ShowQueue(queue);
                }
            }
            else if (choice == "3")
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine("Очередь пуста.");
                }
                else
                {
                    Console.WriteLine("Следующий пациент: " + queue.Peek());
                }
            }
            else if (choice == "4")
            {
                ShowQueue(queue);
            }
            else if (choice == "5")
            {
                work = false;
            }
            else
            {
                Console.WriteLine("Неверный пункт меню.");
            }
        }
    }

    // вспомогательный метод для показа очереди
    static void ShowQueue(Queue<string> queue)
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("Очередь пуста.");
            return;
        }

        Console.WriteLine("Очередь:");
        int number = 1;
        foreach (string patient in queue)
        {
            Console.WriteLine(number + ". " + patient);
            number++;
        }
    }

    // ===== Задание 5. История действий (Stack<string>) =====
    static void Task5()
    {
        Stack<string> history = new Stack<string>();
        bool work = true;

        while (work)
        {
            Console.WriteLine("\n===== ИСТОРИЯ ДЕЙСТВИЙ =====");
            Console.WriteLine("1. Выполнить действие");
            Console.WriteLine("2. Отменить последнее действие");
            Console.WriteLine("3. Посмотреть последнее действие");
            Console.WriteLine("4. Показать историю");
            Console.WriteLine("5. Выход");
            Console.Write("Выберите пункт: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Действие: ");
                string action = Console.ReadLine();
                if (action == "")
                {
                    Console.WriteLine("Действие не может быть пустым.");
                }
                else
                {
                    history.Push(action);
                    Console.WriteLine("Действие сохранено.");
                }
            }
            else if (choice == "2")
            {
                if (history.Count == 0)
                {
                    Console.WriteLine("История пуста, отменять нечего.");
                }
                else
                {
                    string action = history.Pop();
                    Console.WriteLine("Отмена действия:");
                    Console.WriteLine(action);
                    ShowHistory(history);
                }
            }
            else if (choice == "3")
            {
                if (history.Count == 0)
                {
                    Console.WriteLine("История пуста.");
                }
                else
                {
                    Console.WriteLine("Последнее действие: " + history.Peek());
                }
            }
            else if (choice == "4")
            {
                ShowHistory(history);
            }
            else if (choice == "5")
            {
                work = false;
            }
            else
            {
                Console.WriteLine("Неверный пункт меню.");
            }
        }
    }

    // вспомогательный метод для показа истории
    static void ShowHistory(Stack<string> history)
    {
        if (history.Count == 0)
        {
            Console.WriteLine("История пуста.");
            return;
        }

        Console.WriteLine("История (сверху - последнее действие):");
        int number = 1;
        foreach (string action in history)
        {
            Console.WriteLine(number + ". " + action);
            number++;
        }
    }
}
