Console.WriteLine("Введите четное число: ");
int n = Convert.ToInt32(Console.ReadLine());
bool[] a = new bool [n];
for(int i = 2; i < n; i++)
{
    a[i] = true;
}
for(int i = 2; i*i < n; i++)
{
    if(a[i])
    {
        for(int j = i + i; j < n; j += i)
        {
            a[j] = false;
            i = 2;

        }
    }
    while(!(a[i] && a[n-i]))
    {
        i++;
    }
    Console.WriteLine($"{i}, {n - i}");
}