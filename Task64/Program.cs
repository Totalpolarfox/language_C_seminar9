// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


int ReadInt(string msg)
{
    Console.Write(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintEventNumbers(int numberM, int numberN)
{
    if (numberM >= numberN)
    {
        return;
    }
    if (numberM % 2 == 1)
    {
        numberM++;
    }
    Console.Write($"{numberM}, ");
    PrintEventNumbers(numberM + 2, numberN);
}

int firstNumber = ReadInt("Введите первое натуральное число: ");
int secondNumber = ReadInt("Введите второе натуральное число: ");
if (firstNumber > 0 && secondNumber > 0)
{
    Console.WriteLine($"Чётные натуральные числа в промежутке от {firstNumber} до {secondNumber} -");
    PrintEventNumbers(firstNumber, secondNumber);
}
else
{
    Console.WriteLine("Введенные данные не являются натуральным числом!");
}