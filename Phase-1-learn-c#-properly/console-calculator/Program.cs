try
{
  Console.WriteLine("Welcome to the calculater");
  Console.Write("Num 1: ");
  string input1 = Console.ReadLine();
  double num1 = Convert.ToDouble(input1);
  Console.Write("Num 2:");
  string input2 = Console.ReadLine();
  double num2 = Convert.ToDouble(input2);
  string calcOperator;

  do
  {
    Console.WriteLine("\nWhat action would you like to take?");
    Console.WriteLine("- For adding enter '+'");
    Console.WriteLine("- For substracting enter '-'");
    Console.WriteLine("- For multiplying enter '*'");
    Console.WriteLine("- For dividing enter '/'");
    Console.Write("Operator: ");
    calcOperator = Console.ReadLine();
    if (calcOperator.Length == 1 && (
        calcOperator == "+" ||
        calcOperator == "-" ||
        calcOperator == "*" ||
        calcOperator == "/"))
      break;
    Console.WriteLine("\nInvalid operator");
  } while (true);

  switch (calcOperator)
  {
    case "+":
      Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
      break;
    case "-":
      Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
      break;
    case "*":
      Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
      break;
    case "/":
      Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
      break;
  }
}
catch (System.Exception e)
{
  Console.WriteLine($"Not good, something failed: {e.Message}");
}
