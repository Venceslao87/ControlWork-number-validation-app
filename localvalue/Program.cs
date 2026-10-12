Console.WriteLine("Hello, World");
Console.WriteLine("Check access to local and global variable");
int number;
int i = 0;
string stop; 
/*During the work on this program, this case was defined: whether the input number is greater or less  
 * than 50,and including the validation of the correct iitial input*/
//Validation the input number
while (true)
{
    if (i == 0)
    {
        Validation();
        Answer(number);
        i++;
    } else
    {
        Console.WriteLine("Do you want to stop it (y/n)?");
        stop = Console.ReadLine();
        if (stop == "y")
        {
            break;
        } else
        {
            Validation();
            Answer(number);
        }
    }
}





void Validation()
{
    while (true)
    {
        Console.WriteLine("Enter the number, between 0 and 100");
        number = int.Parse(Console.ReadLine());
        if (number > 0 && number < 100)
        {
            break;
        }
        else
        {
            Console.WriteLine("Enter correct number");
        }
    }
}


void Answer (int number)
{
    string answer = number switch
    {
> 50 => "The number is great then 50",
< 50 => "The number is less then 50",
_ => "The number is equal then 50",
    };
    Console.WriteLine (answer);
}
