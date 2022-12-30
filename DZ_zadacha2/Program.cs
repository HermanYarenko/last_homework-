int m = InputInt("Введите первое число:");
int n = InputInt("Введите второе число:");
Console.WriteLine($"Сумма промежуточных чисел от {m} до {n} = {CountNaturalSum(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}