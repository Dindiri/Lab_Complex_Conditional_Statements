//input
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

//check and output

if (firstNumber < secondNumber && secondNumber < thirdNumber)
{
    Console.WriteLine("Ascending");
}
else if (firstNumber > secondNumber && secondNumber > thirdNumber)
{
    Console.WriteLine("Descending");
}
else
{
    Console.WriteLine("Not sorted");
}