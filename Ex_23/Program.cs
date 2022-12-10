/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
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

int GetCube (int x)
{
    int result=0;
    for (int i=1; i<=x; i++)
    {
        result = Convert.ToInt32(Math.Pow(i, 3));
        Console.Write($"{result}, ");
    }
    
    return result;
}

int x = GetNumber("Введите число, которое больше 0: ");
int number = GetCube (x);