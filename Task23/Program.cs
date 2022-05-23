Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i=1; i<=n; i++)
{
    int a = i*i*i;
    Console.WriteLine($"{i}   {a}");
}