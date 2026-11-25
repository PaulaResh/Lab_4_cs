<img width="387" height="256" alt="image" src="https://github.com/user-attachments/assets/a553693e-be3c-4c91-ac9a-8c1e68f8d82b" />### Решетникова Полина ЛА-1 Лабораторная №4
# ЗАДАНИЕ 1.

## ТЕКСТ ЗАДАЧИ:
Составить программу, которая удаляет из списка L все
элементы E, если такие есть.

## АЛГОРИТМ РЕШЕНИЯ:
Метод Task1ListRemove<T> обобщённый, работает с List
любого типа. В Program заполняется List<string>: тип
string принимает любой ввод — числа, дробные, текст.
Элементы добавляются методом Add.
В цикле while проверка Contains и удаление Remove.
Remove удаляет только первое вхождение, поэтому цикл
нужен для удаления всех повторов.
Цикл while вместо for: при удалении в for элементы
сдвигаются влево, счётчик растёт, элемент пропускается.
Вывод циклом for через индексатор.

## ТЕСТИРОВАНИЕ
![](https://sun9-63.vkuserphoto.ru/s/v1/ig2/lDgdmmyz0L0q44psTPH_PChazGB0CcB3H12QZUTy8dqnh6AP7MItZ2YCrsX3MHOasdIxydX2YAc6mbJZnr-iBWXm.jpg?quality=95&as=32x29,48x43,72x65,108x98,160x145,240x217,333x301&from=bu&cs=333x0)

# ЗАДАНИЕ 2.

## ТЕКСТ ЗАДАЧИ:
Напечатать в обратном порядке элементы непустого списка L.
 
## АЛГОРИТМ РЕШЕНИЯ:
Метод Task2LinkedListReverse<T> обобщённый.
В Program заполняется LinkedList<string> методом AddLast.
Получается последний узел через свойство Last.
В цикле while выводится node.Value и выполняется переход
node = node.Previous, пока узел не станет null.
Индексация не используется: двусвязный список не
поддерживает доступ по индексу, обход идёт по ссылкам.
Сложность O(n), дополнительная память O(1).


## ТЕСТИРОВАНИЕ
![](https://sun9-4.vkuserphoto.ru/s/v1/ig2/HhSXII6uojg7-D8PEHYEWONl3tB930AjIMuY9qy_U9m93SeHvuDgRKRDCFetAOFlQseB0G9g9bWpDwoupaWlCXtM.jpg?quality=95&as=32x21,48x32,72x48,108x71,160x106,240x159,360x238,387x256&from=bu&cs=387x0)

# ЗАДАНИЕ 3.

## ТЕКСТ ЗАДАЧИ:
В городе n учебных заведений, закупающих технику в
компьютерных фирмах. Ответить на вопросы:
1) в каких фирмах закупка производилась каждым заведением;
2) в каких фирмах закупка производилась хотя бы одним;
3) в каких фирмах ни одно заведение не закупало технику.

## АЛГОРИТМ РЕШЕНИЯ:
Перечень всех фирм считывается в HashSet<string> allFirms.
Для каждого заведения создаётся отдельный HashSet внутри
цикла и сохраняется в List<HashSet<string>>. Создание
внутри цикла обязательно: HashSet — ссылочный тип, иначе
все заведения ссылались бы на один объект.
При вводе фирмы проверяется allFirms.Contains, при
отсутствии — ошибка и повторный ввод.
Вопрос 1: копия первого множества, затем IntersectWith
со всеми остальными (пересечение).
Вопрос 2: пустое множество, затем UnionWith со всеми
(объединение).
Вопрос 3: копия allFirms, затем ExceptWith с объединением
(разность).
Все три метода мутируют множество и возвращают void,
поэтому исходные данные копируются

## ТЕСТИРОВАНИЕ
![](https://sun9-53.vkuserphoto.ru/s/v1/ig2/O3U55FGUQoXiKQZKeHG4GG_4C0NZowS2IuArKmQmyN6h-be0Nlj_htBDUys2CRcgi7VnABhX5V0S0oCUjuFlw1Xi.jpg?quality=95&as=32x27,48x40,72x60,108x91,160x134,240x201,278x233&from=bu&u=RKcWeXz_eZElDYTnLrIA6zbC9IIRqVHvwP-KntLz4AQ&cs=278x0)
![](https://sun9-49.vkuserphoto.ru/s/v1/ig2/6uyV5Ko-likYyoqCiWkrNUKCKHhuca0Q1ds9dPtTrNzQqxRXmvLY8Iq27sbFf6tnPe21dYIkQA7yJ8S_lZ4mD3-t.jpg?quality=95&as=32x47,48x71,72x106,108x160,160x236,240x355,245x362&from=bu&cs=245x0)
![](https://sun9-68.vkuserphoto.ru/s/v1/ig2/jRzk1ZOUPY8zZkaRdDfs9SBEy0B8-HyccCvnfTc33NjR_uK1edXoQB_zgnEdp-771KBbLNIn_982t1iQWVPZqqdV.jpg?quality=95&as=32x21,48x31,72x47,108x71,160x105,209x137&from=bu&cs=209x0)

# ЗАДАНИЕ 4.

## ТЕКСТ ЗАДАЧИ:
Файл содержит текст на русском языке. Напечатать в
алфавитном порядке все звонкие согласные буквы, которые
входят хотя бы в одно слово.

## АЛГОРИТМ РЕШЕНИЯ:
Текст вводится с клавиатуры построчно до пустой строки.
Отдельный метод FillTextFile сохраняет его в файл через
StreamWriter — требование условия о хранении данных
в файле.
Текст читается File.ReadAllText и приводится к нижнему
регистру методом ToLower.
Создаётся HashSet<char> со звонкими согласными:
б, в, г, д, ж, з.
Циклом for по символам проверяется voiced.Contains,
найденные буквы добавляются в HashSet found — дубликаты
исключаются автоматически.
HashSet не хранит порядок, поэтому содержимое копируется
в List<char> и сортируется методом Sort.

## ТЕСТИРОВАНИЕ
![](https://sun9-45.vkuserphoto.ru/s/v1/ig2/SIJaAXNXwn46Vb1McOPBabz71fv0extfw-gpkYZE3IJDlla6Cml84qXcaPIFfjq0jS-Y6xUvkZywwuEpabdtJ5mM.jpg?quality=95&as=32x7,48x10,72x16,108x24,160x35,240x52,360x79,480x105,540x118,541x118&from=bu&u=F2d84-aL7TGtpjanZmA7Iglik2jprrdAw1frnG5B1aw&cs=541x0)

# ЗАДАНИЕ 5.

## ТЕКСТ ЗАДАЧИ:
На вход подаются фамилии и имена учеников (не более 100).
Сформировать уникальный логин: если фамилия встречается
первый раз, логин равен фамилии; второй раз — фамилия с
числом 2, третий — с числом 3 и т.д.

## АЛГОРИТМ РЕШЕНИЯ:
Данные вводятся с клавиатуры, отдельный метод
FillStudentsFile записывает их в текстовый файл.
Строки читаются File.ReadAllLines.
Создаётся Dictionary<string, int>: ключ — фамилия,
значение — счётчик появлений.
Одним циклом for по строкам:
- фамилия выделяется через IndexOf(' ') и Substring
  (дешевле Split, не создаёт лишних массивов);
- если ContainsKey — счётчик увеличивается через
  индексатор, логин = фамилия + счётчик;
- иначе counters[surname] = 1, логин = фамилия.

## ТЕСТИРОВАНИЕ
![](https://sun9-16.vkuserphoto.ru/s/v1/ig2/Eo7mZb0H12x2-iM_v_l9ZZU2al4jE44JsBH0WEM7tBjkriJDcs6PgDCFkCuEzsj8s_oJ2LzTFF_xnc_l4ybcfSyl.jpg?quality=95&as=32x28,48x41,72x62,108x93,160x138,240x207,304x262&from=bu&u=8ewwEkH9fnLR3-D3x1p89s9ndkVaqZG2FFXjEeCp-JY&cs=304x0)
![](https://sun9-87.vkuserphoto.ru/s/v1/ig2/N0UrFx_oRmm0SvivJ7qtVeIKs0k5d2eKGkwgifgr5LIt5tUSLWoBNxU_PyRewml6uC4kqRBBb41uIWcZ_MHFiPFR.jpg?quality=95&as=32x18,48x26,72x40,108x59,160x88,240x132,280x154&from=bu&cs=280x0)
![](https://sun9-62.vkuserphoto.ru/s/v1/ig2/J0z2om5G_cbXFJz06gr66o8X000PCaFio__eNNYqZzXUg7BFSM79rtntR5Tk_szggsTdEc7LvTb5TU7TUabBqhk5.jpg?quality=95&as=32x32,48x48,72x72,108x108,160x160,220x220&from=bu&cs=220x0)

# ЗАДАНИЕ 6.

## ТЕКСТ ЗАДАЧИ:
Реализовать класс Time с полями byte hours, byte minutes.
Метод: добавление произвольного количества минут (uint)
к объекту типа Time. Результат должен быть типа Time.

## АЛГОРИТМ РЕШЕНИЯ:
Приватные поля _hours и _minutes типа byte.
Свойства Hours и Minutes через явный get, без автосвойств.
Конструктор по умолчанию задаёт 00:00.
Конструктор с параметрами проверяет диапазоны 0-23 и 0-59,
при нарушении выбрасывает исключение — объект не может
существовать в некорректном состоянии.
Метод AddMinutes(uint mins):
- время переводится в минуты: hours * 60 + minutes;
- прибавляется mins;
- часы = (total / 60) % 24, переход через полночь;
- минуты = total % 60;
- возвращается новый объект, исходный не изменяется.
ToString переопределён: формат ЧЧ:ММ через PadLeft(2, '0').
Тип uint выбран потому, что количество добавляемых минут
не может быть отрицательным — проверка на уровне типа.

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


