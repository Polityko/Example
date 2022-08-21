int N;   
                      
Console.WriteLine("введите число: ");
N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++) 
{
    
    if (i%2==0)
    {
        if(i!=1)
            Console.Write(",");
        Console.Write(i);
    }
}   