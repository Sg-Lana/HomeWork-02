/* напшите программу которая принимает на вход число и выдает сумму
цифр в числе.
452 - 11
82 - 10*/

int Prompt(string massage)
{
    System.Console.WriteLine(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumNumberNumb (int number)
{
    int summa = 0;
    while (number > 0)
    {
    summa = summa + number % 10;
    number = number / 10;
    }
    return summa;
}

int n = Prompt("введите число - > ");
int sumnumber = SumNumberNumb(n);
Console.WriteLine($"сумма цифр числа {n} = {sumnumber}");