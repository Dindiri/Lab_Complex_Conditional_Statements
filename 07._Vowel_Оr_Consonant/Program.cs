//input
using System.Reflection.Metadata;

char letter = char.Parse(Console.ReadLine());

//calculations -> Vowels letters are: A, a, E, e, I, i, O, o, U, u
switch (letter)
{
    case 'A':
    case 'a':
    case 'E':
    case 'e':
    case 'I':
    case 'i':
    case 'O':
    case 'o':
    case 'U':
    case 'u':
        Console.WriteLine("Vowel");
        break;
    default:
        Console.WriteLine("Consonant");
        break;
}