using System;
using System.Collections.Generic;

namespace CollectionsTasks
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding =
                System.Text.Encoding.UTF8;

            //ЗАДАНИЕ 1
            Console.WriteLine(
                "Задание 1. Удаление элемента");

            int count1 = InputHelper1.ReadInt(
                "Кол-во элементов: ", false);

            List<string> list = new List<string>();
            for (int i = 0; i < count1; i++)
            {
                list.Add(InputHelper1.ReadString(
                    $"Элемент #{i + 1}: "));
            }

            string element = InputHelper1.ReadString(
                "Элемент E для удаления: ");

            CollectionsTasks.Task1ListRemove(
                list, element);


            //ЗАДАНИЕ 2
            Console.WriteLine(
                "\nЗадание 2. LinkedList");

            int count2 = InputHelper1.ReadInt(
                "Кол-во элементов: ", false);

            LinkedList<string> linked =
                new LinkedList<string>();
            for (int i = 0; i < count2; i++)
            {
                linked.AddLast(InputHelper1.ReadString(
                    $"Элемент #{i + 1}: "));
            }

            CollectionsTasks.Task2LinkedListReverse(
                linked);


            //ЗАДАНИЕ 3
            Console.WriteLine(
                "\nЗадание 3. Школы и компьютеры");
            CollectionsTasks.Task3HashSetSchools();


            //ЗАДАНИЕ 4
            Console.WriteLine(
                "\nЗадание 4. Текст");
            Console.WriteLine(
                "Введите текст " +
                "(пустая строка — конец):");
            string text = "";
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                text += line + "\n";
            }
            CollectionsTasks.FillTextFile(
                "text.txt", text);
            CollectionsTasks.Task4HashSetLetters(
                "text.txt");


            //ЗАДАНИЕ 5
            Console.WriteLine(
                "\nЗадание 5. Ученики");
            int n = InputHelper1.ReadInt(
                "Кол-во учеников: ", false);
            string[] students = new string[n];
            for (int i = 0; i < n; i++)
            {
                students[i] =
                    InputHelper1.ReadString(
                        $"Фамилия Имя #{i + 1}: ");
            }
            CollectionsTasks.FillStudentsFile(
                "students.txt", students);
            CollectionsTasks.Task5DictionaryLogins(
                "students.txt");

            Console.WriteLine(
                "\n[Нажмите любую клавишу...]");
            Console.ReadKey();
        }
    }
}
