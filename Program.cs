//Made by mohammad hossein hatami

Console.WriteLine("Welcome to the survey!");
Console.WriteLine();

// zero question
Console.Write("Are you married? (y/n): ");
char answer0 = Console.ReadKey().KeyChar;
Console.WriteLine();

switch (answer0)
{
    case 'y':
    case 'Y':
        Console.WriteLine("Alright! you have entered Yes!");
        Console.WriteLine();

        Console.Write("Do you have any children? (y/n): ");
        answer0 = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (answer0)
        {
            case 'y':
            case 'Y':
                Console.WriteLine("Alright! you have entered Yes");
                Console.WriteLine();
                break;
            case 'n':
            case 'N':
                Console.WriteLine("Alright! you have entered No");
                Console.WriteLine();
                break;
            default:
                Console.WriteLine("Sorry, I didn't understand your answer.");
                Console.WriteLine();
                break;
        }
        break;
    case 'n':
    case 'N':
        Console.WriteLine("Alright! you have entered No!");
        Console.WriteLine();
        break;
    default:
        Console.WriteLine("Sorry, I didn't understand your answer.");
        Console.WriteLine();
        break;
}

Console.WriteLine();


// First question
Console.Write("Do you like ice cream? (y/n): ");
char answer1 = Console.ReadKey().KeyChar;
Console.WriteLine();

switch (answer1)
{
    case 'y':
    case 'Y':
        Console.WriteLine("Alright! you have entered Yes!");
        Console.WriteLine();

        Console.Write("Vanilla or chocolate? (v/c): ");
        answer1 = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (answer1)
        {
            case 'v':
            case 'V':
                Console.WriteLine("Alright! you have entered Vanilla");
                Console.WriteLine();
                break;
            case 'c':
            case 'C':
                Console.WriteLine("Alright! you have entered chocolate");
                Console.WriteLine();
                break;
            default:
                Console.WriteLine("Sorry, I didn't understand your answer.");
                Console.WriteLine();
                break;
        }
        break;
    case 'n':
    case 'N':
        Console.WriteLine("Alright! you have entered No!");
        Console.WriteLine();
        break;
    default:
        Console.WriteLine("Sorry, I didn't understand your answer.");
        Console.WriteLine();
        break;
}

Console.WriteLine();

// Second question
Console.Write("Do you enjoy hiking? (y/n): ");
answer0 = Console.ReadKey().KeyChar;
Console.WriteLine();

switch (answer0)
{
    case 'y':
    case 'Y':
        Console.WriteLine("Alright! you have entered yes");
        Console.WriteLine();

        Console.Write("you usually hiking in the morning or at night? (m/n)");
        answer0 = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (answer0)
        {
            case 'm':
            case 'M':
                Console.WriteLine("Alright! you have entered morning");
                Console.WriteLine();
                break;
            case 'n':
            case 'N':
                Console.WriteLine("Alright! you have entered night");
                Console.WriteLine();
                break;
            default:
                Console.WriteLine("Sorry, I didn't understand your answer.");
                Console.WriteLine();
                break;
        }

        break;
    case 'n':
    case 'N':
        Console.WriteLine("Alright! you have entered No!");
        Console.WriteLine();
        break;
    default:
        Console.WriteLine("Sorry, I didn't understand your answer.");
        Console.WriteLine();
        break;
}

// Third question
Console.Write("Do you prefer cats or dogs? (c/d): ");
answer0 = Console.ReadKey().KeyChar;
Console.WriteLine();

switch (answer0)
{
    case 'c':
    case 'C':
        Console.WriteLine("Alright! you have entered cat");
        Console.WriteLine();
        break;
    case 'd':
    case 'D':
        Console.WriteLine("Alright! you have entered dog");
        Console.WriteLine();
        break;
    default:
        Console.WriteLine("Sorry, I didn't understand your answer.");
        Console.WriteLine();
        break;
}

Console.WriteLine();
Console.WriteLine("Thank you for taking the survey!");