public class ExampleClass
{
    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void IncrementValue()
    {
        // Solution: Check for potential overflow
        if (_value == int.MaxValue)
        {
            throw new OverflowException("Integer overflow occurred.");
            //Alternative: _value = int.MinValue; //Handle wrap-around
        }
        _value++;
    }
}