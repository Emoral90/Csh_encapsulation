public class Fraction{
    // Attributes
    private double numerator;
    private double denominator;

    // Methods
    // Getter to return numerator value, if any
    public double get_numerator(){
        return numerator;
    }

    public double get_denominator(){
        return denominator;
    }

    public double set_numerator(double numerator_set){
        numerator = numerator_set;
        return numerator;
    }

    public double set_denominator(double denominator_set){
        denominator = denominator_set;
        return denominator;
    }
}