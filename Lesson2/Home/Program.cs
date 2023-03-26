// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter two numbers");
 String number1 = Console.ReadLine();
 bool success1 = float.TryParse(number1, out float num1);

 String number2 = Console.ReadLine();
  bool success2 = float.TryParse(number2, out float num2);
  if(success2 && success1){

Console.WriteLine("What do you want to do with numbers: + , - , * , / ?");
String operation = Console.ReadLine();

if (operation == "+") {
    float answer= num1 + num2;
    Console.WriteLine(" Answer = " +answer);
}else {
    if (operation == "-") {
float answer= num1 - num2;
Console.WriteLine(" Answer = " +answer);
    } else {
        if ( operation == "*"){
           float answer= num1 * num2;
Console.WriteLine(" Answer = " +answer); 
        } else {
            float answer= num1 / num2;
Console.WriteLine(" Answer = " +answer);
        }
    }

}
} else {
    Console.WriteLine(" Not number");
}
