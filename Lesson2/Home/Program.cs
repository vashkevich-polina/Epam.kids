// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter two numbers");
string number1 = Console.ReadLine();
bool success1 = float.TryParse(number1, out float num1);

string number2 = Console.ReadLine();
bool success2 = float.TryParse(number2, out float num2);

if (success2 && success1)
{
    Console.WriteLine("What do you want to do with numbers: + , - , * , / ?");
    string operation = Console.ReadLine();
    float answer = 0;
    if (operation == "+")
    {
        answer = num1 + num2;
    }
    else if (operation == "-")
    {
        answer = num1 - num2;
    }
    else if (operation == "*")
    {
        answer = num1 * num2;
    }
    else
    {
        answer = num1 / num2; 
    }

    Console.WriteLine(" Answer = " + answer);

}
else
{
    Console.WriteLine(" Not number");
}
