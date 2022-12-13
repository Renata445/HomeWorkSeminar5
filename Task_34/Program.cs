Console.Clear();
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine()), k = 0;
int[] a = new int [n];
for(int i = 0; i < n; i++)
{
    a[i] = new Random().Next(100, 1000);
    Console.WriteLine($"{string.Join(", ", a[i])}");
    if(a[i] % 2 == 0)
    {
        k++;
    }
}
Console.WriteLine(k);