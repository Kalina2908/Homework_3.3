/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/


int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result>9)
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


int GetSum (int number) // функция должна работать для любого числа в диапазоне от 10 до 2147483647
{
    string num=Convert.ToString(number);
    int lenght=num.Length;
    int sum=0;
    int x=0;
    int y=0;
    while (number>9)
    {
        x=number/Convert.ToInt32(Math.Pow(10, (lenght-1)));
        y=number%10;
        sum=sum+(x-y);
        number=(number-(x*Convert.ToInt32(Math.Pow(10, (lenght-1)))))/10;
        lenght=lenght-2;
    }
    return sum; 
}


int number=GetNumber("Введите число, которое больше 9: ");
int palidrome =GetSum(number);
 if (palidrome==0)
    {
       Console.WriteLine("Введеное число - палиндром"); 
    }
    else
    {
        Console.WriteLine("Введеное число - не палиндром");
    }


