// Задача 64: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

string Sequence(int start, int end){
    if (start == end){
        return end.ToString();
    }else if (start > end){
        return "";
    }
    
    return start + ", " + Sequence(start + 1, end);

}

Console.Write("Введите начальное значение последовательности: ");
int start = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конечное значение последовательности: ");
int end = Convert.ToInt32(Console.ReadLine());

string result = Sequence(start, end);
Console.WriteLine(result);