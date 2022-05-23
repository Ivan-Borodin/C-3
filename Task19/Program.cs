Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int n=a;
int m=0;
while (n>0)
{
    int i=n%10;
    n=n/10;
    m=m*10+i;
}
if (a==m) Console.WriteLine("да");
else Console.WriteLine("нет");
