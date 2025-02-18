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
        // Bug: Missing check for potential overflow
        _value++;
    }
}