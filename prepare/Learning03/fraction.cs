using System;

public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int top)
    {
        _topNumber = top;
        _bottomNumber = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    public void SetTopNumber(int number)
    {
        _topNumber = number;
    }

    public void SetBottomNumber(int number)
    {
        _bottomNumber = number;
    }

    public int GetTopNumber()
    {
        return _topNumber;
    }

    public int GetBottomNumber()
    {
        return _bottomNumber;
    }

    public string GetFractionString()
    {
        string fractionString = $"{_topNumber}/{_bottomNumber}";
        return fractionString;
    }

    public double GetDecimalValue()
    {
        return (double)_topNumber / (double)_bottomNumber;
    }


}