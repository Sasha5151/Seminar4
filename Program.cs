// Задача 32: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, 
//и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int size = 4;
// int[] array = new int[size];
// FullArray(array);
// PrintArray(array);
// ReverseSign(array);
// PrintArray(array);

// void FullArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100,100);
//     }
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//        System.Console.Write(array[i] + " "); 
//     }
//     System.Console.WriteLine();
// }

// void ReverseSign(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//        array[i] *= -1; // array[i] = array[i] * -1;
//     }
// }

//End


// Задача 33: Задайте массив. Напишите программу, 
//которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// int size = 5;
// int[] array = new int[size];
// FullArray(array);
// PrintArray(array);
// int Q = 7 ;

// if (CheckNumberInArray(array , Q) ==true )
//     System.Console.WriteLine("Da");

// else
//     System.Console.WriteLine("Net");

// void FullArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1,10);
//     }
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//        System.Console.Write(array[i] + " "); 
//     }
//     System.Console.WriteLine();
// }

// bool CheckNumberInArray(int[]array , int Q)
// {  
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == Q)
//         {
//             return true;
//         }
//     }
//     return false;
//  }   

 //End

 // Задача 35. Массив из 123 случ чисел
 // найдите колличество чисел в интервале от 10 до 99

// int size = 123;
// int[] array = new int[size];
// FullArray(array);
// PrintArray(array);

// void FullArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,1000);
//     }
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//        System.Console.Write(array[i] + " "); 
//     }
//     System.Console.WriteLine();
// }

// int FindeNum(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if ((array[i] > 10 ) && (array[i] <99 ))
//         count++;
//     }
//     return count;
// } 
// FindeNum(array);
// System.Console.WriteLine();
// System.Console.WriteLine(FindeNum(array));

//End

// Задача 37. одномерный массив попарно умножить 


int size = 8;
int[] array = new int[size];
FullArray(array);
PrintArray(array);
System.Console.WriteLine();
Mult(array);
void FullArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,10);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       System.Console.Write(array[i] + " "); 
    }
}
void Mult(int[] array)
{
    int[] array1 = new int [array.Length/2];
    for (int i = 0 , j = array.Length-1 ; i < array.Length/2; i++ , j--)
    {
        array1[i] = array[i]*array[j];
        System.Console.WriteLine(array1[i]);
    }    
}
