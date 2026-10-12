// Set the Pin
Console.WriteLine("Set your Pin (4 numbers)");
int pin = int.Parse(Console.ReadLine());
Console.Clear();

string answer = PinValidation(pin);
Console.WriteLine(answer);

// Description method
string PinValidation(int setPin)
{
    int attempt = 0;
    while (attempt < 3)
    {
        Console.Write("Enter correct pin ");
        int attemptPin = int.Parse(Console.ReadLine());
        if (setPin == attemptPin)
        {
            string message = "Your code is correct. Attemption is successfull";
            return message;
        }
        else
        {
            attempt++;
            if (attempt == 3)
            {
                continue;
            }
            Console.WriteLine($"Your code is wrong. You have {3 - attempt} attempts");
        }
    }
    string messageAttemptWrong = ("You have not more atteption, your credit card is blocked");
    return messageAttemptWrong; 
}