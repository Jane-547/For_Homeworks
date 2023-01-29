// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите число 1");    // Ввести сообщение пользователю (1 число)
string strNumber1_1 = Console.ReadLine();    // Считать строку
int Number1_1 = Convert.ToInt32(strNumber1_1);    // Конвертировать текст в число

System.Console.WriteLine("Введите число 2");    // Ввести сообщение пользователю (2 число)
string strNumber1_2 = Console.ReadLine();    // Считать строку
int Number1_2 = Convert.ToInt32(strNumber1_2);    // Конвертировать текст в число

if (Number1_1 > Number1_2)    // Сравнить 2 числа. Если 1 число больше, чем 2, то max будет число 1, 
{
    System.Console.WriteLine("max = " + Number1_1 + ", min = " + Number1_2);    // Вывести на экран результат
}
else    // иначе max будет число 2
{
    System.Console.WriteLine("max = " + Number1_2 + ", min = " + Number1_1);
}