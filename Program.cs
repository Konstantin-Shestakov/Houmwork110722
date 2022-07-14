//  Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Елена, совсем запутался, как убрать ошибку, если пользователь 
// нажал пробел после последнего числа, а затем ввод. Ошибка кода.


Console.Write("Введите элементы через пробел, не ставьте пробел  конце!!!!: ");
int[] myArrey = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);//создаем массив, принимаем числа с консоли,
// используя пробел, как разделитель Split, конвертируем в число (Parse).
int count = 0;

for (int i = 0; i < myArrey.Length; i++) // перебираем массив, до его длины Length
{
    Console.Write($"{myArrey[i]} "); // вывод массива в консоль
    if (myArrey[i] > 0) //цикл проверки по условию задачи
    {
        count++;// просто счетчик
    }
}

Console.Write($" -> {count}");


/*// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)



internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("введите значение k1: ");
        double k1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("введите значение b1: ");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("введите значение k2: ");
        double k2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("введите значение b1: ");
        double b2 = Convert.ToDouble(Console.ReadLine());

        
        if (b1 == b2 && k1 == k2)
        {
            Console.WriteLine("Прямые совпадают");
        }
        else if (k1 == k2)

        {
            Console.WriteLine("Прямые не пересикаются");
        }
        else
        {
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;
            Console.WriteLine($" k1 ={k1}, b1= {b1}, k2 ={k2}, b2 ={b2} ->({x:f2};{y:f2})");
            
        }




    }
}
*/