//
// Cычeв B.B.
//
// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int ReadInt(string msg)
{
    Console.Write(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int CalcSumm(int numberM, int numberN)
{
    if (numberM == numberN)
    {
        return numberM;
    }
    return numberM + CalcSumm(numberM + 1, numberN);
}

int firstNumber = ReadInt("Введите первое натуральное число: ");
int secondNumber = ReadInt("Введите второе натуральное число: ");
if (firstNumber > 0 && secondNumber > 0)
{
    Console.Write($"Сумма натуральных чисел в промежутке от {firstNumber} до {secondNumber} = ");
    Console.Write(CalcSumm(firstNumber, secondNumber));
}
else
{
    Console.WriteLine("Введенные данные не являются натуральным числом!");
}

