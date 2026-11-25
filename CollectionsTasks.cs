using System;
using System.Collections.Generic;
using System.IO;

namespace CollectionsTasks
{
    public static class CollectionsTasks
    {
        // ЗАДАНИЕ 1: Обобщенный метод для любого типа T
        public static void Task1ListRemove<T>(
            List<T> list, T element)
        {
            Console.Write("Исходный: ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                if (i < list.Count - 1) 
                    Console.Write(", ");
            }
            Console.WriteLine("");

            while (list.Contains(element))
            {
                list.Remove(element);
            }

            Console.Write("После удаления: ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                if (i < list.Count - 1) 
                    Console.Write(", ");
            }
            Console.WriteLine("\n");
        }

        // ЗАДАНИЕ 2: Обобщенный метод для любого типа T
        public static void Task2LinkedListReverse<T>(
            LinkedList<T> list)
        {           
            Console.Write("Исходный: ");
            LinkedListNode<T> nodeF = list.First;
            bool first = true;
            while (nodeF != null)
            {
                if (!first) Console.Write(", ");
                Console.Write(nodeF.Value);
                first = false;
                nodeF = nodeF.Next;
            }
            Console.WriteLine();

            Console.Write("Обратный порядок: ");
            LinkedListNode<T> node = list.Last;
            first = true;
            while (node != null)
            {
                if (!first) Console.Write(", ");
                Console.Write(node.Value);
                first = false;
                node = node.Previous;
            }
            Console.WriteLine("\n");
        }

        // ЗАДАНИЕ 3: HashSet (учебные заведения)
        public static void Task3HashSetSchools()
        {
            int n = InputHelper1.ReadInt(
                "Кол-во заведений: ", false);
            int m = InputHelper1.ReadInt(
                "Кол-во фирм: ", false);

            HashSet<string> allFirms = 
                new HashSet<string>();
            Console.WriteLine("Введите фирмы:");
            for (int i = 0; i < m; i++)
            {
                allFirms.Add(InputHelper1.ReadString(
                    $"Фирма #{i + 1}: "));
            }

            List<HashSet<string>> schools = 
                new List<HashSet<string>>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nЗаведение #{i+1}:");
                int k = InputHelper1.ReadInt(
                    "Кол-во фирм: ", false);
                HashSet<string> schoolFirms = 
                    new HashSet<string>();
                
                for (int j = 0; j < k; j++)
                {
                    string firm;
                    while (true)
                    {
                        firm = InputHelper1.ReadString(
                            $"Фирма #{j + 1}: ");
                        if (allFirms.Contains(firm)) 
                            break;
                        
                        Console.WriteLine(
                            "Ошибка: такой фирмы нет!");
                    }
                    schoolFirms.Add(firm);
                }
                schools.Add(schoolFirms);
            }

            HashSet<string> inter = 
                new HashSet<string>(schools[0]);
            for (int i = 1; i < n; i++)
            {
                inter.IntersectWith(schools[i]);
            }

            HashSet<string> union = 
                new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                union.UnionWith(schools[i]);
            }

            HashSet<string> none = 
                new HashSet<string>(allFirms);
            none.ExceptWith(union);

            Console.WriteLine("\n1) Каждое:");
            PrintSet(inter);
            Console.WriteLine("2) Хотя бы одно:");
            PrintSet(union);
            Console.WriteLine("3) Ни одно:");
            PrintSet(none);
        }

        private static void PrintSet(HashSet<string> set)
        {
            if (set.Count == 0)
            {
                Console.WriteLine("(пусто)");
                return;
            }
            foreach (string s in set)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }

        // ЗАДАНИЕ 4: HashSet (звонкие согласные из файла)
        public static void Task4HashSetLetters(
            string fileName)
        {     
            if (!File.Exists(fileName))
            {
                Console.WriteLine("Файл не найден!");
                return;
            }

            string text = File.ReadAllText(
                fileName).ToLower();
            HashSet<char> voiced = new HashSet<char> {
                'б', 'в', 'г', 'д', 'ж', 'з'
            };
            HashSet<char> found = new HashSet<char>();

            for (int i = 0; i < text.Length; i++)
            {
                if (voiced.Contains(text[i]))
                {
                    found.Add(text[i]);
                }
            }

            List<char> sorted = new List<char>(found);
            sorted.Sort();

            Console.Write("Результат: ");
            for (int i = 0; i < sorted.Count; i++)
            {
                Console.Write(sorted[i] + " ");
            }
            Console.WriteLine();
        }

        // ЗАДАНИЕ 5: Dictionary (уникальные логины)
        public static void Task5DictionaryLogins(
            string fileName)
        {      
            if (!File.Exists(fileName))
            {
                Console.WriteLine("Файл не найден!");
                return;
            }

            string[] lines = File.ReadAllLines(fileName);
            Dictionary<string, int> counters = 
                new Dictionary<string, int>();
            string[] logins = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Trim();
                if (string.IsNullOrEmpty(line)) 
                    continue;

                int spaceIdx = line.IndexOf(' ');
                string surname = spaceIdx > 0 ? 
                    line.Substring(0, spaceIdx) : line;

                if (counters.ContainsKey(surname))
                {
                    counters[surname]++;
                    logins[i] = surname + counters[surname];
                }
                else
                {
                    counters[surname] = 1;
                    logins[i] = surname;
                }
            }

            Console.WriteLine("Сформированные логины:");
            for (int i = 0; i < logins.Length; i++)
            {
                if (logins[i] != null)
                {
                    Console.WriteLine(logins[i]);
                }
            }
        }

        // Вспомогательный метод для Задания 4
        public static void FillTextFile(
            string fileName, string content)
        {
            using (StreamWriter writer = 
                new StreamWriter(fileName))
            {
                writer.WriteLine(content);
            }
        }

        // Вспомогательный метод для Задания 5
        public static void FillStudentsFile(
            string fileName, string[] lines)
        {
            using (StreamWriter writer = 
                new StreamWriter(fileName))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    writer.WriteLine(lines[i]);
                }
            }
        }
    }
}
