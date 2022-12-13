Console.Clear();

Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] a = new double [n];
double max = 0, min = 999;
for(int i = 0; i < n; i++)
{
    Console.WriteLine("Введите вещественные числа в массиве: ");
    a[i] = Convert.ToDouble(Console.ReadLine());
    if(a[i] > max)
    {
        max = a[i];
    }
    if(a[i] < min)
    {
        min = a[i];
    }
}
Console.WriteLine($"Max = {max}, Min = {min}");
double diff = 0;
diff = max - min;
Console.WriteLine($"Разность = {diff}");
