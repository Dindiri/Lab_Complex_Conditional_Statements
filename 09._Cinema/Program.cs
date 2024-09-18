//input
string ticketType = Console.ReadLine();
int countOfRows = int.Parse(Console.ReadLine());
int countOfSeats = int.Parse(Console.ReadLine());

//calculations

double totalPrice = countOfRows * countOfSeats;

if (ticketType == "Premiere") 
{
    totalPrice *= 12.00;
    Console.WriteLine(totalPrice);
}
else if (ticketType == "Normal")
{
    totalPrice *= 7.50;
    Console.WriteLine(totalPrice);
}
else if (ticketType == "Discount")
{
    totalPrice *= 5.00;
    Console.WriteLine(totalPrice);
}