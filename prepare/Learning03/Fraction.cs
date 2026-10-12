using System.Runtime.InteropServices.Swift;

class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction() {
        this._numerator = 1;
        this._denominator = 1;
    }

    public Fraction(int numerator)
    {
        this._numerator = numerator;
        this._denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        this._numerator = numerator;
        this._denominator = denominator;
    }

    public int GetNumerator() {
        return this._numerator;
    }

    public int GetDenominator() {
        return this._denominator;
    }

    public void SetNumerator(int value) {
        this._numerator = value;
    }

    public void SetDenominator(int value) {
        this._denominator = value;
    }

    public string GetFractionAsString()
    {
        return $"{this._numerator}/{this._denominator}";
    }

    public double GetFractionAsDecimal()
    {
        return (double) this._numerator / (double) this._denominator;
    }
}