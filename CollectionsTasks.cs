using System;
using System.Collections.Generic;
using System.IO;

namespace CollectionsTasks
{
    public static class CollectionsTasks
    {
        // ЗАДАНИЕ 1: Удаление элемента из List
        public static void Task1ListRemove()
        {
            Console.WriteLine(
                "Задание 1. Удаление элемента");
            List<int> list = new List<int>();

            int count = InputHelper.ReadInt(
                "Количество элементов: ", false);
            for (int i = 0; i < count; i++)
            {
                int val = InputHelper.ReadInt(
                    $"Элемент #{i + 1}: ");
                list.Add(val);
            }

            int element = InputHelper.ReadInt(
                "Элемент E для удаления: ");

            while (list.Contains(element))
            {
                list.Remove(element);
            }

            Console.WriteLine(
                "Список после удаления:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }

        // ЗАДАНИЕ 2: LinkedList в обратном порядке
        public static void Task2LinkedListReverse()
        {
            Console.WriteLine(
                "\nЗадание 2. В обратном порядке");
            LinkedList<int> list =
                new LinkedList<int>();

            int count = InputHelper.ReadInt(
                "Количество элементов: ", false);
            for (int i = 0; i < count; i++)
            {
                int val = InputHelper.ReadInt(
                    $"Элемент #{i + 1}: ");
                list.AddLast(val);
            }

            Console.WriteLine(
                "В обратном порядке:");
            LinkedListNode<int> node =
                list.Last;
            while (node != null)
            {
                Console.Write(node.Value + " ");
                node = node.Previous;
            }
            Console.WriteLine();
        }

        // ЗАДАНИЕ 3: HashSet про учебные заведения и фирмы
        public static void Task3HashSetSchools()
        {
            Console.WriteLine(
                "\nЗадание 3. Про учебные заведения и фирмы");
            int n = InputHelper.ReadInt(
                "Кол-во учебных заведений: ",
                false);
            int m = InputHelper.ReadInt(
                "Кол-во компьютерных фирм: ",
                false);

            // Все фирмы
            HashSet<string> allFirms =
                new HashSet<string>();
            Console.WriteLine(
                "Введите названия фирм:");
            for (int i = 0; i < m; i++)
            {
                string firm =
                    InputHelper.ReadString(
                        $"Фирма #{i + 1}: ");
                allFirms.Add(firm);
            }

            // Для каждого заведения - свои фирмы
            List<HashSet<string>> schools =
                new List<HashSet<string>>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    $"\nЗаведение #{i + 1}:" +
                    " введите кол-во фирм:");
                int k = InputHelper.ReadInt(
                    "Кол-во фирм: ", false);
                HashSet<string> schoolFirms =
                    new HashSet<string>();
                for (int j = 0; j < k; j++)
                {
                    string firm;
                    while (true)
                    {
                        firm = InputHelper.ReadString(
                            $"Фирма #{j + 1}: ");

                        if (allFirms.Contains(firm))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(
                                "Ошибка: фирма \"" +
                                firm +
                                "\" не существует!" +
                                " Введите из списка:");
                            PrintSet(allFirms);
                        }
                    }
                    schoolFirms.Add(firm);
                }
                schools.Add(schoolFirms);
            }

            // 1. Пересечение всех (каждое закупало)
            HashSet<string> intersection =
                new HashSet<string>(schools[0]);
            for (int i = 1; i < n; i++)
            {
                intersection.IntersectWith(
                    schools[i]);
            }

            // 2. Объединение всех (хотя бы одно)
            HashSet<string> union =
                new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                union.UnionWith(schools[i]);
            }

            // 3. Ни одно не закупало
            HashSet<string> none =
                new HashSet<string>(allFirms);
            none.ExceptWith(union);

            Console.WriteLine(
                "\n1) Закупало каждое:");
            PrintSet(intersection);

            Console.WriteLine(
                "2) Закупало хотя бы одно:");
            PrintSet(union);

            Console.WriteLine(
                "3) Не закупало ни одно:");
            PrintSet(none);
        }

        private static void PrintSet(
            HashSet<string> set)
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

        // ЗАДАНИЕ 4: Звонкие согласные из файла
        public static void Task4HashSetLetters(
            string fileName)
        {
            Console.WriteLine(
                "\nЗадание 4. " +
                "Звонкие согласные");

            if (!File.Exists(fileName))
            {
                Console.WriteLine(
                    "Файл не найден!");
                return;
            }

            string text = File.ReadAllText(
                fileName).ToLower();

            // Звонкие согласные русского языка
            HashSet<char> voiced =
                new HashSet<char> {
                    'б', 'в', 'г', 'д', 'ж', 'з'
                };

            HashSet<char> found =
                new HashSet<char>();
            for (int i = 0; i < text.Length; i++)
            {
                if (voiced.Contains(text[i]))
                {
                    found.Add(text[i]);
                }
            }

            // Сортируем в алфавитном порядке
            List<char> sorted =
                new List<char>(found);
            sorted.Sort();

            Console.WriteLine(
                "Звонкие согласные " +
                "в алфавитном порядке:");
            for (int i = 0; i < sorted.Count; i++)
            {
                Console.Write(sorted[i] + " ");
            }
            Console.WriteLine();

        }
        // Заполнение файла текстом
        public static void FillRussianTextFile(
            string fileName)
        {
            string[] lines = {
        "В городе стоял большой дом.",
        "Дети играли во дворе каждый день.",
        "Жираф гулял по зоопарку важно.",
        "Зимой выпал белый пушистый снег.",
        "Гроза гремела над далёким лесом."
    };
            using (StreamWriter writer =
                new StreamWriter(fileName))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    writer.WriteLine(lines[i]);
                }
            }
            Console.WriteLine(
                "Файл " + fileName + " заполнен.");
        }

        // ЗАДАНИЕ 5: Уникальные логины
        public static void Task5DictionaryLogins(
            string fileName)
        {
            Console.WriteLine(
                "\n=== Задание 5. Логины ===");

            if (!File.Exists(fileName))
            {
                Console.WriteLine(
                    "Файл не найден!");
                return;
            }

            string[] lines =
                File.ReadAllLines(fileName);
            int n = lines.Length;

            Dictionary<string, int> counters = //повтор
                new Dictionary<string, int>();

            string[] logins = new string[n];

            for (int i = 0; i < n; i++)
            {
                string line = lines[i].Trim();
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }

                int spaceIdx = line.IndexOf(' ');
                string surname;
                if (spaceIdx > 0)
                {
                    surname = line.Substring(
                        0, spaceIdx);
                }
                else
                {
                    surname = line;
                }

                if (counters.ContainsKey(surname))
                {
                    counters[surname]++;
                    logins[i] = surname +
                        counters[surname];
                }
                else
                {
                    counters[surname] = 1;
                    logins[i] = surname;
                }
            }

            Console.WriteLine(
                "\nСформированные логины:");
            for (int i = 0; i < n; i++)
            {
                if (logins[i] != null)
                {
                    Console.WriteLine(logins[i]);
                }
            }
        }

        // Заполнение файла
        public static void FillStudentsFile( 
            string fileName)
        {
            int n = InputHelper.ReadInt(
                "Кол-во учеников: ", false);
            using (StreamWriter writer =
                new StreamWriter(fileName))
            {
                for (int i = 0; i < n; i++)
                {
                    string surname =
                        InputHelper.ReadString(
                            $"Фамилия #{i + 1}: ");
                    string name =
                        InputHelper.ReadString(
                            $"Имя #{i + 1}: ");
                    writer.WriteLine(
                        surname + " " + name);
                }
            }
            Console.WriteLine(
                "Файл " + fileName +
                " заполнен.");
        }
    }
}