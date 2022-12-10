/*
## Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввод не соотвествует условию!");
        }
    }
    return result;
}

double GetDistance (int ax, int ay, int az, int bx, int by, int bz)
{
    double result = 0;
    result = Math.Sqrt(Math.Pow(bx-ax, 2)+Math.Pow(by-ay, 2)+Math.Pow(bz-az, 2));

    return result;
}

int ax = GetNumber("Введите координату х первой точки: ");
int ay = GetNumber("Введите координату y первой точки: ");
int az = GetNumber("Введите координату z первой точки: ");

int bx = GetNumber("Введите координату х второй точки: ");
int by = GetNumber("Введите координату y второй точки: ");
int bz = GetNumber("Введите координату z второй точки: ");

double distance = GetDistance(ax, ay, az, bx, by, bz);
Console.WriteLine($"Расстояние равно {distance}");
