### Решетникова Полина ЛА-1 Лабораторная №4
# ЗАДАНИЕ 1.

## ТЕКСТ ЗАДАЧИ:
Составить программу, которая удаляет из списка L все
элементы E, если такие есть.

## АЛГОРИТМ РЕШЕНИЯ:
1. Считать количество элементов и заполнить List<int>
   методом Add.
2. Считать удаляемый элемент E.
3. В цикле while проверять наличие элемента методом
   Contains и удалять методом Remove. Remove удаляет
   только первое вхождение, поэтому цикл нужен для
   удаления всех повторов.
4. Вывести список циклом for.

## ТЕСТИРОВАНИЕ
![](https://sun9-62.vkuserphoto.ru/s/v1/ig2/5aeYShwwYCY3p2-44q8Mk53iDASa0QP-2-929S2xSNGbPkvN2fuSfxRx-pbKInuYA96gjOmnNiQlnMC-9kRs8Gsk.jpg?quality=95&as=32x42,48x63,72x95,108x143,160x211,240x317,269x355&from=bu&u=hT2Fm9DHMuiL2hGsc8cNBPx0sOfNLyOtd_94-go2-yQ&cs=269x0)

# ЗАДАНИЕ 2.

## ТЕКСТ ЗАДАЧИ:
Напечатать в обратном порядке элементы непустого списка L.
 
## АЛГОРИТМ РЕШЕНИЯ:

1. Заполнить LinkedList<int> методом AddLast.
2. Получить последний узел через свойство Last.
3. В цикле while выводить node.Value и переходить к
   node.Previous, пока узел не станет null.
4. Индексация не используется: двусвязный список не
   поддерживает доступ по индексу, обход идёт по ссылкам.


## ТЕСТИРОВАНИЕ
![](https://sun9-84.vkuserphoto.ru/s/v1/ig2/eNdqrOArfq0bwAhPvEszmUviufPNFnOvZPNb_y-2G4epxVFp0uZmS5RFnrS4uhFb5jxJIgbDW2LCt3sJfJtf4iHu.jpg?quality=95&as=32x32,48x48,72x72,108x108,160x160,240x240,274x274&from=bu&u=q1jcRAxsQiXP-bHsGrk_-GAcGor43aAcIsZxwQ7vT0k&cs=274x0)

# ЗАДАНИЕ 3.

## ТЕКСТ ЗАДАЧИ:
В городе n учебных заведений, закупающих технику в
компьютерных фирмах. Ответить на вопросы:
1) в каких фирмах закупка производилась каждым заведением;
2) в каких фирмах закупка производилась хотя бы одним;
3) в каких фирмах ни одно заведение не закупало технику.

## АЛГОРИТМ РЕШЕНИЯ:
1. Считать перечень всех фирм в HashSet allFirms.
2. Для каждого заведения считать его фирмы в отдельный
   HashSet, сохранить в List<HashSet<string>>.
3. При вводе фирмы проверять allFirms.Contains: если
   фирмы нет в перечне, вывести ошибку и запросить
   ввод повторно.
4. Вопрос 1: копия первого множества, затем
   IntersectWith со всеми остальными (пересечение).
5. Вопрос 2: пустое множество, затем UnionWith со
   всеми множествами (объединение).
6. Вопрос 3: копия allFirms, затем ExceptWith с
   объединением (разность).

## ТЕСТИРОВАНИЕ
![](https://sun9-38.vkuserphoto.ru/s/v1/ig2/ddZnKDblKmZRbbtPCVk-44VOzCrzYz7RVNY2l98c_YHC3yjgEYxSTQo35l1j5xnKz-OUg7mQRBv4PeJQO9WYP0xY.jpg?quality=95&as=32x21,48x31,72x47,108x70,160x104,240x155,360x233,374x242&from=bu&u=FDEnrb-j98ex9kz7YC-qbaV1WmK0Xb__NjGe_m_tm8k&cs=374x0)
![](https://sun9-55.vkuserphoto.ru/s/v1/ig2/3XuCqhm42-xvefikUqoWiJ6lKEwCY7CfHVShKaWyKeaZ4aStpLPQCAVbvedr9lXWpJ_goJFKw4YJ1Xrk2YrIIE1z.jpg?quality=95&as=32x27,48x40,72x60,108x91,160x134,240x201,360x302,480x402,540x453,550x461&from=bu&u=TpIMreK7FReAr4h5jFOv7_1eZzw_bK8JQaneTuESBqg&cs=550x0)
![](https://sun9-46.vkuserphoto.ru/s/v1/ig2/KErfcBNDMUQ0vvybNSmdUT4mCEBZoOviJy5R7eTmeYptifMFkgDZfIgxv4-gbMHsiYmrmm7zvoMmWwKe87OYqovy.jpg?quality=95&as=32x15,48x22,72x33,108x49,160x73,240x109,301x137&from=bu&u=Dpw3uLPOA6gcDnDbUV59f3W7lXAzzGcQljovWJRUWbc&cs=301x0)

# ЗАДАНИЕ 4.

## ТЕКСТ ЗАДАЧИ:
Файл содержит текст на русском языке. Напечатать в
алфавитном порядке все звонкие согласные буквы, которые
входят хотя бы в одно слово.

## АЛГОРИТМ РЕШЕНИЯ:
1. Отдельный метод FillRussianTextFile создаёт исходный
   файл с русским текстом через StreamWriter.
2. Прочитать текст методом File.ReadAllText, привести к
   нижнему регистру методом ToLower.
3. Создать HashSet<char> со звонкими согласными:
   б, в, г, д, ж, з.
4. Пройти по символам текста циклом for, проверять
   voiced.Contains и добавлять найденные в HashSet found.
   HashSet автоматически исключает дубликаты.
5. Скопировать found в List<char> и отсортировать
   методом Sort, так как HashSet не хранит порядок.
6. Вывести отсортированный список.

## ТЕСТИРОВАНИЕ
![](https://sun9-56.vkuserphoto.ru/s/v1/ig2/Jl6q-5NrxpXcKLFvcta8oue5VMoWXs2MyZlcUSV1-bwVBHgWOQkUOJSI-NLECsKCfiAiIX54qbjnans7uSYoCoMu.jpg?quality=95&as=32x6,48x10,72x15,108x22,160x32,240x48,360x73,372x75&from=bu&u=xw5szJ1DzF2tSBGoUdZ7ZyakzDQCZkyRykxMyefLh8g&cs=372x0)

# ЗАДАНИЕ 5.

## ТЕКСТ ЗАДАЧИ:
На вход подаются фамилии и имена учеников (не более 100).
Сформировать уникальный логин: если фамилия встречается
первый раз, логин равен фамилии; второй раз — фамилия с
числом 2, третий — с числом 3 и т.д.

## АЛГОРИТМ РЕШЕНИЯ:
1. Отдельный метод FillStudentsFile заполняет исходный
   текстовый файл парами "Фамилия Имя".
2. Прочитать строки методом File.ReadAllLines.
3. Создать Dictionary<string, int> counters: ключ —
   фамилия, значение — счётчик её появлений.
4. Одним циклом for по всем строкам:
   - выделить фамилию через IndexOf(' ') и Substring;
   - если counters.ContainsKey — увеличить счётчик и
     склеить фамилию с новым значением;
   - иначе добавить ключ со значением 1, логин равен
     фамилии.
5. Вывести массив логинов.

## ТЕСТИРОВАНИЕ
![](https://sun9-61.vkuserphoto.ru/s/v1/ig2/JJDL7VofE1iJgcEaadQDQlpOtT3Y92Bc5SBBUMQvDR3AD2u_8zTuu8fmwH0JBEft4BPILwK4tg7DEHu0cFe3Fv2g.jpg?quality=95&as=32x52,48x79,72x118,108x177,160x262,240x393,284x465&from=bu&u=s9QkA-8UP-1oqS32TS8uRQ5bLtXeMujpJNTBw_ZA5HI&cs=284x0)
![](https://sun9-68.vkuserphoto.ru/s/v1/ig2/gsgKLoL4tRtqQ43OHx1Mg0j90RmakD3X7nIKz-pctUOzA0fFFUVKe9OJJ4fGKAMMd9UcUJEd8LnhVISyddisQPq9.jpg?quality=95&as=32x30,48x44,72x67,108x100,160x148,240x222,303x280&from=bu&u=h7c_IVUSBuQWGOBW-nEc5ICW132HkR5LcOKHg1CxvT0&cs=303x0)
![](https://sun9-50.vkuserphoto.ru/s/v1/ig2/TaZ6V4109RHmkCpL_rRlHjQbKHBpAPaqFRH7haweeKfH98Nxqt8-lRNeZq22g-lKL5EF-LMbkwVUqTI9PmUUkkjq.jpg?quality=95&as=32x47,48x71,72x107,108x160,160x237,240x356,284x421&from=bu&u=2u1cSHIiT4q_TWP7L9PTGEKdT_IbNbJNmhVDDEE2wlk&cs=284x0)

# ЗАДАНИЕ 6.

## ТЕКСТ ЗАДАЧИ:
Реализовать класс Time с полями byte hours, byte minutes.
Метод: добавление произвольного количества минут (uint)
к объекту типа Time. Результат должен быть типа Time.

## АЛГОРИТМ РЕШЕНИЯ:
1. Приватные поля _hours и _minutes типа byte.
   Свойства Hours и Minutes раскрыты через явный get,
   автосвойства не используются.
2. Конструктор по умолчанию задаёт 00:00.
3. Конструктор с параметрами проверяет диапазоны:
   часы 0-23, минуты 0-59, иначе выбрасывает исключение.
4. Метод AddMinutes(uint mins):
   - перевести время в общее число минут:
     hours * 60 + minutes;
   - прибавить mins;
   - часы = (total / 60) % 24, переход через полночь;
   - минуты = total % 60;
   - вернуть новый объект Time, исходный не изменяется.
5. Переопределить ToString: вывод в формате ЧЧ:ММ
   через PadLeft(2, '0').
6. Тип uint для минут выбран потому, что количество
   добавляемых минут не может быть отрицательным:
   проверка выполняется на уровне типа данных.

## ТЕСТИРОВАНИЕ
![](https://sun9-16.vkuserphoto.ru/s/v1/ig2/5q9FZpkW3BNfqkjnoLb6nTZZwhJKrZO7pObc-mr0SyeIG7QjwNGBfBsnPZBSErsyHFXS1dMRpfAKG3WQo4kVoB0s.jpg?quality=95&as=32x15,48x22,72x33,108x50,160x74,240x111,306x141&from=bu&u=jaXyknnmBHeiX3-FnUqmYKOAbj6a6LeyjvRokkVbMsQ&cs=306x0)
![](https://sun9-80.vkuserphoto.ru/s/v1/ig2/hM5UvLcaEh9CdzsosToWF-vsfDpYtbtIAUiwOonA8ZZWq9f5_AG4icHNmN982I7Eh5TtyE5x8E4CwtkIwtEWblz2.jpg?quality=95&as=32x18,48x27,72x41,108x61,160x90,240x135,305x172&from=bu&u=x_LNI1Z-QDdjDsgY42empCQFW8HpmIFPuCLh6Y7DWmc&cs=305x0)

# ЗАДАНИЕ 7.

## ТЕКСТ ЗАДАЧИ:
Добавить к классу Time перегруженные операции.
Унарные: ++ добавление минуты, -- вычитание минуты.
Приведение типа: byte (явное) — количество часов;
bool (неявное) — true, если часы и минуты не равны нулю.
Бинарные: + и - с беззнаковым целым (минуты), лево- и
правосторонние. Результат типа Time.

## АЛГОРИТМ РЕШЕНИЯ:
1. operator ++ вызывает AddMinutes(1).
2. operator -- переводит время в минуты; если результат
   равен нулю, добавляет 1440 минут (сутки), затем
   вычитает 1 — корректный переход через полночь.
3. operator +(Time, uint) вызывает AddMinutes.
4. operator +(uint, Time) вызывает AddMinutes —
   правосторонняя версия, обеспечивает коммутативность.
5. operator -(Time, uint): если вычитаемое больше
   текущего числа минут, добавляется 1440, затем
   вычитание и приведение к формату ЧЧ:ММ.
6. operator -(uint, Time): аналогично с учётом порядка
   операндов, результат приводится по модулю 1440.
7. explicit operator byte возвращает _hours, минуты
   отбрасываются. Приведение явное, так как теряются
   данные.
8. implicit operator bool возвращает true, если
   _hours != 0 или _minutes != 0. Приведение неявное,
   так как потери данных нет.

## ТЕСТИРОВАНИЕ
![](https://sun9-49.vkuserphoto.ru/s/v1/ig2/A5-MX7mrkhGf3bXeYbVRPqGYEofjLOlmZNGnQv1gZ8GEhMVpa8WGArj4PZy2JqgzWJxKGUg5U0sLnwXZ_7UK-YTk.jpg?quality=95&as=32x30,48x45,72x68,108x102,160x151,240x226,322x303&from=bu&u=Vbl68bdqGkP8V8J8UKlxv3fSEAmftExtVcFlCPDF6S4&cs=322x0)


