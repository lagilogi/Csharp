using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

string GetOperator() {
  string calcOperator;

  while (true) {
    Console.WriteLine("\nWhat action would you like to take?");
    Console.WriteLine("- For adding enter '+'");
    Console.WriteLine("- For substracting enter '-'");
    Console.WriteLine("- For multiplying enter '*'");
    Console.WriteLine("- For dividing enter '/'\n");

    Console.Write("Operator: ");
    calcOperator = Console.ReadLine() ?? "";
    if (calcOperator == "+" || calcOperator == "-" ||
        calcOperator == "*" || calcOperator == "/")
      return calcOperator;
    Console.WriteLine($"\nInvalid operator: {calcOperator}. Try again:\n");
  }
}

double  GetNumeralInput(int inputNum) {
  string input;

  while (true) {
    Console.Write($"Num {inputNum}: ");
    input = Console.ReadLine() ?? "";
    if (double.TryParse(input, out double num)) {
      return num;
    }
    Console.WriteLine($"Invalid input: {input}. Try again:\n");
  }
}

double  Add(double num1, double num2) {
  return num1 + num2;
}

double  Subtract(double num1, double num2) {
  return num1 - num2;
}

double  Multiply(double num1, double num2) {
  return num1 * num2;
}

double  Divide(double num1, double num2) {
  return num1 / num2;
}

int Main() {
  Console.WriteLine("Welcome to the Calculater!\nNote: Use . as the decimal separator for the numbers.\n");
  double num1 = GetNumeralInput(1);
  string calcOperator = GetOperator();
  double num2 = GetNumeralInput(2);

  switch (calcOperator)
  {
    case "+":
      Console.WriteLine($"{num1} + {num2} = {Add(num1, num2)}");
      break;
    case "-":
      Console.WriteLine($"{num1} - {num2} = {Subtract(num1, num2)}");
      break;
    case "*":
      Console.WriteLine($"{num1} * {num2} = {Multiply(num1, num2)}");
      break;
    case "/":
      if (num2 == 0)
        Console.WriteLine("Error: Cannot divide by 0");
      else
        Console.WriteLine($"{num1} / {num2} = {Divide(num1, num2)}");
      break;
  }
  return 0;
}
Main();


//////////////////////////////
///
/// This calculator has already taught you:
///
/// - Variables
/// - Primitive types
/// - Methods
/// - Loops
/// - Input validation
/// - Switch statements
/// - Basic program structure
/// - Simple user experience considerations
