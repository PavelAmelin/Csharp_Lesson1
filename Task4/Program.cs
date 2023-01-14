int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    if (a > c)
    Console.WriteLine(a);
}
if (b > a)
{
    if (b > c)
    Console.WriteLine(b);
}
if (c > b)
{
    if (c > a)
    Console.WriteLine(c);
}