// See https://aka.ms/new-console-template for more information
using homeWork8;
#region Задание 1. Работа с листом.
Console.WriteLine("Задание 1. Работа с листом.");
Task1 task1 = new Task1(100);
task1.Print("Начальный набор данных: ");
task1.RemoveElementBetween(25, 50);
task1.Print($"Набор элементов после удаления чисел между 25 и 50: ");
Console.ReadLine();
#endregion
#region Задание 2. Телефонная книга
Console.WriteLine("Задание 2. Телефонная книга");
Task2 task2 = new Task2();
task2.FillDictionary();
Console.WriteLine("Введите номер телефона для поиска:");
task2.FindElement(Console.ReadLine());
Console.ReadLine();
#endregion
#region Задание 3. Проверка повторов
Console.WriteLine("Задание 3. Проверка повторов");
Task3 task3 = new Task3();
task3.AddValues();
Console.ReadLine();
#endregion
#region Задание 3. Проверка повторов
Console.WriteLine("Задание 3. Проверка повторов");
Task4 task4 = new Task4();
task4.SerializePerson("_PersonXml.xml");

Console.ReadLine();
#endregion