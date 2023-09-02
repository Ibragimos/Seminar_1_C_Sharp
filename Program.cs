int n, i = 1;
n = Int32.Parse(Console.ReadLine());

while (i < n + 1)
{
    if(i % 2 == 0)  Console.WriteLine(i);
    i++;
}