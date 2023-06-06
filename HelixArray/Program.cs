using System;

public class Program
{
    public static void Main()
    {
        int sizeX = Convert.ToInt32(Console.ReadLine());        //считываем размер массива
        int sizeY = sizeX;                                      //принимаем, что массив - квадрат ( но можно и прямоугольный!)
        int CorrectY = 0;                                       //переменная -декремент 
        int CorrectX = 0;                                       //переменная -декремент
        int[,] mas = new int[sizeX, sizeY];                     //двумерный массив для исходных данных
        
       for (var i = 0; i < mas.GetLength(0); i++)      //заполняем массив исходными данными
       {
           for (var j = 0; j < mas.GetLength(1); j++)
           {
               mas[i, j] = int.Parse(Console.ReadLine());
           }
       }
       //наглядный вывод  исходного массива
       //for (var i = 0; i < mas.GetLength(0); i++)      
       //{
       //    for (var j = 0; j < mas.GetLength(1); j++)
       //    {
       //        Console.Write(mas[i, j] + " ");
       //    }
       //    Console.WriteLine();
       //}
       
        // алгоритм Helix ( "по улитке" или "по спирали")
        while (sizeY > 0)
        {
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < ((sizeX < sizeY) ? sizeY : sizeX); x++)
                {
                    if (y == 0 && x < sizeX - CorrectX)
                        Console.Write(mas[y + CorrectY, x + CorrectX] + " ");

                    if (y == 1 && x < sizeY - CorrectY && x != 0)
                        Console.Write(mas[x + CorrectY, sizeX - 1] + " ");

                    if (y == 2 && x < sizeX - CorrectX && x != 0)
                        Console.Write(mas[sizeY - 1, sizeX - (x + 1)] + " ");
                    
                    if (y == 3 && x < sizeY - (CorrectY + 1) && x != 0) 
                        Console.Write(mas[sizeY - (x + 1), CorrectY] + " ");
                }
            }

            sizeY--;
            sizeX--;
            CorrectY += 1;
            CorrectX += 1;
        }
    }
}