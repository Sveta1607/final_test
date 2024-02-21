Условия задачи: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Основные этапы решения задачи :
Функция вывода на печать элементов массива
Функция создания массива из вводимых пользователем с клавиатуры значений
Функция создания нового массива, с элементами по заданному в условии критерию

1. Функция вывода на печать элементов массива "PrintArray"
Создаём функцию типа void, принимающую на вход одномерный массив типа string. В теле функции цикл for со счётчиком.
Цикл выполняется пока значение счётчика меньше длинны массива (array.Length). В теле цикла - вывод в консоль элементов массива, по индексу счётчика, который при инициации цикла равен 0.
Для разделения элементов, используется дополнительная функция консольного вывода символов ", "

2. Функция создания массива из вводимых пользователем с клавиатуры значений "Vvod"
Функция типа string, возвращает массив значений, вводимых пользователем с клавиатуры. В теле функции :
Вывод в консоль информационного сообщения пользователю "Введите значения череp запятую в одну строку : ". После чего пользователь вводит значения. По окончании ввода, нажимает клавишу Enter.
Создание переменной типа string, которой присвается ввод от пользователя функцией Console.ReadLine()
Строкове значение, полученное из ввода, преобразуем в массив, строковой функцией Split(). Разделитель значений для функции - ","
Возвращаем массив из введённых пользователем значений.

3. Функция создания нового массива, с элементами по заданному в условии критерию "Len3_array"
Условия по которому значения помещаются в новый массив - количество символов, меньше или равное 3. Создаём функцию, возвращающую массив типа string. В теле функции :
Получаем из функции "Vvod" массив значений и присваеваем его одномерному массиву типа string
Создаём переменную типа string без значения, для конкатенации к ней элементов по заданному условию
Создаём цикл for. Цикл инициируется с счётчиком типа int, начальное значение которого - 0.
Условие цикла - значения счётчика меньше длинны массива. В конце цикла счётчик увеличивается на 1.
В теле цикла проверяется длина значения. Если она меньше или равна 3, значение конкатенируется к переменной и добавляется символ ",", для последующего разбиения на массив функцией Split().
После выхода из цикла от полученной строки значений, удаляется последний символ ","
Создаётся массив значений из строковой переменной с помощью функции Split(). Разделитель - символ ","
Массив возвращается из функции и передаётся в функцию "PrintArray" для вывода значений в консоль.