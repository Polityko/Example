int A = 0;
Console.WriteLine("Введите число: ");
A = Convert.ToInt32(Console.ReadLine()); 

int B = 0; 
Console.WriteLine("Введите число: ");
B = Convert.ToInt32(Console.ReadLine()); 

int max = A;
int min = B;

if (A > max) {max = A; min = B;}
if (B > max) {max = B; min = A;}

Console.WriteLine ("max = " + max);
Console.WriteLine ("min = " + min);