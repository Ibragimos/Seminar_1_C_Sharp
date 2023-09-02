int num1, num2, num3, max;
System.Console.WriteLine("Enter three numbers, via Inter: ");
num1 = Int32.Parse(Console.ReadLine());
num2 = Int32.Parse(Console.ReadLine());
num3 = Int32.Parse(Console.ReadLine());

max = num1;

if(num2 > max) max = num2;
else if(num3 > max) max = num3;
else  max = max;

System.Console.WriteLine($"Max = {max}");