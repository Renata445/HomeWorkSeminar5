Console.Clear();

Console.WriteLine("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int [n];
for(int i = 0; i < n; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
}

int k_1 = 0, k_2 = 0;
for(int i = 0; i < n; i++)
{
    if(a[i] % 2 == 0)
    {
        Console.WriteLine($"Вася получил четверки: {a[i]}");
        k_1++;
       
    }
}
for(int i = 0; i < n; i++)
{
    if(a[i] % 2 != 0)
    {
        Console.WriteLine($"Вася получил тройки: {a[i]}");
        k_2++;
    }
}

if(k_1 > k_2)
{
    Console.Write("YES");
}
else
{
    Console.WriteLine("NO");
}