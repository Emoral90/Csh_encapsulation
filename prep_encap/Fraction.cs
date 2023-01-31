public class Fraction{
    // Attributes
    private int numerator;
    private int denominator;

    // Methods
    // Getter to return numerator value, if any
    public int get_numerator(){
        return numerator;
    }

    public int get_denominator(){
        return denominator;
    }

    public int set_numerator(int numerator_set){
        numerator = numerator_set;
        return numerator;
    }

    public int set_denominator(int denominator_set){
        denominator = denominator_set;
        return denominator;
    }

    public void get_fraction_string(int first_num, int second_num){
        Console.WriteLine($"This is the fraction in a formatted string: {first_num} / {second_num}");
    }
}