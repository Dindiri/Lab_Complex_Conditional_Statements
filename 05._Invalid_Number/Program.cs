//input
int num = int.Parse(Console.ReadLine());

//calculations ->  A given number is valid if it is in the range [100...200] or it is equals to 0.  
if ((num == 0) || (num >= 100 && num <= 200))
{
    Console.WriteLine();
}
else
{
    Console.WriteLine("invalid");
}