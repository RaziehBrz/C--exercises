using System.Runtime.Intrinsics.Arm;

public class Calculator
{
    public double FirstNumber { get; set; }
    public double SecondNumber { get; set; }
    public char _operator;
    public double _result;

    public char PrintMenu()
    {
        Console.WriteLine("Options:");
        Console.WriteLine("\t+ : Add");
        Console.WriteLine("\t- : Substract");
        Console.WriteLine("\t* : Multiply");
        Console.WriteLine("\t/ : Divide");
        Console.Write("Enter an option: ");
        return _operator = Convert.ToChar(Console.ReadLine());
    }
    public void CalculateResult()
    {
        switch (_operator)
        {
            case '+':
                _result = FirstNumber + SecondNumber;
                break;
            case '-':
                _result = FirstNumber - SecondNumber;
                break;
            case '*':
                _result = FirstNumber * SecondNumber;
                break;
            case '/':
                _result = FirstNumber / SecondNumber;
                break;
            default:
                throw new Exception("That was not a valid option");
        }
        Console.WriteLine($"Your result: {FirstNumber} {_operator} {SecondNumber} = {_result}");
    }
}