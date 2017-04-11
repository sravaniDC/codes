using System;
using System.Reflection;

public class MyClass
{
    public virtual int AddNumb(int numb1, int numb2)
    {
        int result = numb1 + numb2;
        return result;
    }

}

class MyMainClass
{
    public static int Main()
    {
        Console.WriteLine("\nReflection.MethodInfo");
         MyClass myClassObj = new MyClass();
        Type myTypeObj = myClassObj.GetType();
        MethodInfo myMethodInfo = myTypeObj.GetMethod("AddNumb");
        object[] mParam = new object[] { 5, 10 };
        Console.Write("\nFirst method - " + myTypeObj.FullName + " returns " +
                             myMethodInfo.Invoke(myClassObj, mParam) + "\n");
        return 0;
    }
}
