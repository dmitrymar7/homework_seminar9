// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int start, int end){
    if (start == end){
        return start;
    }else if (start > end){
        return 0;
    }

    return start + Sum(start + 1, end);
}

Console.Write("Введите начальное значение промежутка: ");
int start = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конечное значение промежутка: ");
int end = Convert.ToInt32(Console.ReadLine());

int result = Sum(start, end);
Console.WriteLine($"сумма натуральных элементов в промежутке от {start} до {end} = {result}");