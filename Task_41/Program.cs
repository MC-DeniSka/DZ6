// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int [] GetMassive() 
{
    System.Console.WriteLine("Введите длину массива ");
    int length = Convert.ToInt32(Console.ReadLine());
    if (length > 0)
    {
        System.Console.WriteLine("Введите значения элементов массива");
        int [] arr = new int [length];
        for (int i = 0; i < length; i++)
        {
            arr [i] = Convert.ToInt32(Console.ReadLine());
        }
        return arr;
    }
    else 
    {
        int [] arr = {-1};
        System.Console.WriteLine("Ошибка! Длина отрицательная!");
        return arr;
    }

}

void PrintArr(int [] arr)
{
    Console.WriteLine(@"[{0}]",String.Join(", ",arr));
}

void AboveZero(int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }   
    }
    System.Console.WriteLine("Количество чисел ,которые больше 0 = "+count);
}


int [] massive = GetMassive();
PrintArr(massive);
AboveZero(massive);