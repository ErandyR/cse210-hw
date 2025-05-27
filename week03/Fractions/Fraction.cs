
using System.Security.Cryptography.X509Certificates;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTopNumber()
    {
        return _top;
    }

    public void SetTopNumber(int topNumber)
    {
        _top = topNumber;
    }

    public int GetBottomNumber()
    {
        return _bottom;
    }

    public void SetBottomNumber(int bottomNumber)
    {
        _bottom = bottomNumber;
    }

    public string GetFraction()
    {
        string fractionResult = $"{_top}/{_bottom}";
        return fractionResult;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}