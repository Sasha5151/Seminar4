// Задача 32: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, 
//и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int size = 4;
int[] array = new int[size];
FullArray(array);
PrintArray(array);
ReverseSign(array);
PrintArray(array);

void FullArray(int[] array);
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100,100);
    }
}

void PrintArray(int[] array);
{
    for (int i = 0; i < array.Length; i++)
    {
       System.Console.Write(array[i] + " "); 
    }
    System.Console.WriteLine();
}

void ReverseSign(int[] array);
{
    for (int i = 0; i < array.Length; i++)
    {
       array[i] *= -1; // array[i] = array[i] * -1;
    }
}


// Задача 33: Задайте массив. Напишите программу, 
//которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да



// int [] array = new int[5] {6 ,7 ,19,345,3};
// int q = 5;
// bool w = false;
// for (int i = 0 ; i<5 ; i++)
// {   if (array[i] == q)
//     {
//         w = true;
//     }
// }
//     if (w == false)
//     {
//     System.Console.Write("no");     
//     }
//     else System.Console.Write("da");

