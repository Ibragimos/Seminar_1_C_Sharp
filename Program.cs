int num1, num2, num3, max;
System.Console.WriteLine("Enter three numbers, via Inter: ");
num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());
num3 = Convert.ToInt32(Console.ReadLine());

max = num1;

if(num2 > max) max = num2;
else if(num3 > max) max = num3;
else  max = max;

System.Console.WriteLine($"Max = {max}");