Console.Clear();
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int [n];
int sum = 0;
for(int i = 0; i < n; i++)
{
    a[i] = new Random().Next(1, 100);
    Console.WriteLine($"{string.Join(", ", a[i])}");
    if(i % 2 != 0)
    {
        sum += a[i];
    }
}
Console.WriteLine($"Сумма = {sum}");