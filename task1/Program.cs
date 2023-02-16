// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine($"чисел > 0 : {count (InitArray())}");

int [] InitArray()
{
    Console.WriteLine("Введите числа через запятую");
    return Console.ReadLine().Split(',').Select(int.Parse).ToArray();
}

int count (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        {
           count++;
        }
    }
    return count;
}
