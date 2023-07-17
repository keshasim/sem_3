// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


// Console.Write("Введите пятизначное число: ");
// int number,a,b,sum=0;
// number = Convert.ToInt32(Console.ReadLine());
// if(number>9999 && number<100000)
// {
// for(b=number;number!=0;number=number/10)
// {
// a=number % 10;
// sum=sum*10+a;
// }
// if(b==sum)
// Console.Write($"{b} является палиндромом.");
// else
// Console.Write($"{b} не является палиндромом.");
// } else
// Console.Write("Введите пятизначное число! ");

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// AB = √(x2 - x1)2 + (y2 - y1)2 + (z2-z1)2
// Console.Write("Введите координату по оси оХ для второй точки: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату по оси оY для второй точки: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату по оси оZ для второй точки: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату по оси оХ для первой точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату по оси оY для первой точки: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату по оси оZ для первой точки: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// double d = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) +  Math.Pow(z2 - z1, 2) ), 2);
// Console.WriteLine($"Расстояние: {d}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
// int end = Convert.ToInt32(Console.ReadLine()); 

// for (int i = 1; i <= end; i++) 
// {
//     Console.Write(Math.Pow(i, 3) + " ");
// }