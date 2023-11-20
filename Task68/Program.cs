// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string msg)
{
    Console.Write(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int functionAkkerman(int numberM, int numberN)
{
    if (numberM == 0)                               //если первое число = 0
    {
        return numberN + 1;                         // вернуть второе число + 1
    }
    else if (numberN == 0)                          //если второе число = 0
    {
        return functionAkkerman(numberM - 1, 1);    //вычислить функцию, где первое уменьшается на 1, второе = 1
    }
    return functionAkkerman(numberM - 1, functionAkkerman(numberM, numberN - 1));
}

int firstNumber = ReadInt("Введите первое неотрицательное число: ");
int secondNumber = ReadInt("Введите второе неотрицательное число: ");


if (firstNumber < 0 && secondNumber < 0)
{
    Console.WriteLine("Введенные данные не являются неотрицательным числом!");
}
else
{
    Console.Write($"Функция Аккермана A({firstNumber},{secondNumber}) = ");
    Console.WriteLine(functionAkkerman(firstNumber, secondNumber));
}




