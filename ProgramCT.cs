using System;

namespace CollectionsTasks
{
    class ProgramCT
    {
        static void Main()
        {
            Console.OutputEncoding =
                System.Text.Encoding.UTF8;

            //CollectionsTasks.Task1ListRemove();
            //CollectionsTasks.Task2LinkedListReverse();
            //CollectionsTasks.Task3HashSetSchools();

            // Задание 4
            string textFile = "russian.txt";
            CollectionsTasks.FillRussianTextFile(
                textFile);
            CollectionsTasks.Task4HashSetLetters(
                textFile);

            // Задание 5
            Console.WriteLine("\nЗаполнение файла students.txt: ");
            string studentsFile = "students.txt";
            CollectionsTasks.FillStudentsFile(
                studentsFile);
            CollectionsTasks.Task5DictionaryLogins(
                studentsFile);

            Console.WriteLine(
                "\n[Нажмите любую клавишу...]");
            Console.ReadKey();
        }
    }
}