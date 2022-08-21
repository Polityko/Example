int a;
Console.WriteLine("введите число: ");
a = Convert.ToInt32(Console.ReadLine()); 

int b;
Console.WriteLine("введите число: ");
b = Convert.ToInt32(Console.ReadLine()); 

int c;
Console.WriteLine("введите число: ");
c = Convert.ToInt32(Console.ReadLine()); 

int max = a;

if (a > max) {max = a;}
if (b > max) {max = b;}
if (c > max) {max = c;}

Console.WriteLine ("max = " + max);