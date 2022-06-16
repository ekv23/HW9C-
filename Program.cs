int[,] NewTriangle(int a)
{
    int[,] triangle = new int[a, a];
    for (int i = 0; i < a; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for (int i = 2; i < a; i++)
    {
        for (int j = 1; j < a; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
    return triangle;
}

void Print(int[,] array)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        string space = "     ";
        for (int j = 0; j < i + 1; j++)
        {
            space = space + Convert.ToString(array[i, j]) + "     ";
        }
        int startPrintPosition = (Console.WindowWidth - space.Length) / 2;
        Console.SetCursorPosition(startPrintPosition, i + 5);
        Console.WriteLine(space);   
        Console.WriteLine();     
    }
    Console.WriteLine();     
}

Console.WriteLine("Введите количество строк треугольника Паскаля:");
int height = Convert.ToInt32(Console.ReadLine());
int[,] array = NewTriangle(height);
Console.Clear();
Print(array);