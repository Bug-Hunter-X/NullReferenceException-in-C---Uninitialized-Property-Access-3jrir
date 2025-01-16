public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize MyProperty
    public ExampleClass()
    {
        MyProperty = 0; // or another default value
    }

    public void MyMethod()
    {
        // Option 1: Initialize in constructor - safest approach
        int value = MyProperty * 2;

        // Option 2: Null check (only if MyProperty can be null)
        //if (MyProperty != null) 
        //{
        //    int value = MyProperty * 2; 
        //}
        //else
        //{
        //    // Handle the null case appropriately
        //}
    }
}