// namespace Fraction;

public class Program{
    // Global variables
    private static double NUMERATOR;
    private static double DENOMINATOR;
    
    // Entry point for program
    static void Main(){
        // Constructors
        Fraction fraction = new Fraction();

        Program.NUMERATOR = fraction.set_numerator(4);
        Program.DENOMINATOR = fraction.set_denominator(5);

        Console.WriteLine();
        Console.WriteLine($"Private variable NUMERATOR: {Program.NUMERATOR}");
        Console.WriteLine($"Private variable DENOMINATOR: {Program.DENOMINATOR}");
        Console.WriteLine();
    }
}