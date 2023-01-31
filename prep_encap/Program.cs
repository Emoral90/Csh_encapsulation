// namespace Fraction;

public class Program{
    // If done well, there will be no need for global variables

    // Entry point for program
    static void Main(){
        // Constructors
        Fraction fraction = new Fraction();

        // assign new values to numerator and denominator from Fraction.cs
        fraction.set_numerator(4);
        fraction.set_denominator(5);

        // print newly assigned values of numerator and denominator from Fraction.cs
        Console.WriteLine();
        Console.WriteLine($"Private variable NUMERATOR: {fraction.get_numerator()}");
        Console.WriteLine($"Private variable DENOMINATOR: {fraction.get_denominator()}");
        Console.WriteLine();
    }
}