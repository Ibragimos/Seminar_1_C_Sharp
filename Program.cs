System.Console.Write("Enter a number 1: ");
 int num1 = Int32.Parse(Console.ReadLine());
 System.Console.Write("Enter a number 2: ");
 int num2 = Int32.Parse(Console.ReadLine());
 
 if(num1 > num2) System.Console.Write($"{num1} > {num2}");
 else if(num1 < num2) System.Console.Write($"{num2} > {num1}");
 else System.Console.Write($"{num1} = {num2}");