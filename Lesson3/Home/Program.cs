Console.WriteLine("Enter two numbers less than a billion");

string number1 = Console.ReadLine();
bool success1 = int.TryParse(number1, out int num1);

string number2 = Console.ReadLine();
bool success2 = int.TryParse(number2, out int num2);

if (success2 && success1 && num1 > 0 && num2 > 0)
{
    int[] first = new int[10];
    for (int i = first.Length - 1; i >= 0; i--)
    {
        first[i] = num1 % 10;
        num1 = num1 / 10;
    }
    int[] second = new int[10];
    for (int i = second.Length - 1; i >= 0; i--)
    {
        second[i] = num2 % 10;
        num2 = num2 / 10;
    }
    int[] number = new int[10];
    for (int i = number.Length - 1; i >= 0; i--)
    {
        number[i] = first[i] + second[i];
    }
    int answer = number[0];
    for (int i = 1; i < number.Length; i++)
    {
        answer = answer * 10 + number[i];
    }
    Console.WriteLine("Answer" + "=" + answer);
}
else
{
    Console.WriteLine(" Invalid input");
}