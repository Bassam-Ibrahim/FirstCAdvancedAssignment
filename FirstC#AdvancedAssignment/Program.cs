class Program
{

    public static void Main(string[] args)
    {

        #region 

        /*
        1) 
         Geneeric class is a class declared with one or more type parameters the Type is specified when we use it in any instant
         we use it becuase it is typr safe , Avoid Casting , and reuse the code
         3) Multiparameter can declare more than one type parameter 
        4)  generic method declares its own type parameters not nessceary for class to be generic
        A generic interface is an interface that uses a type parameter <T>, allowing it to work with different data types while keeping the same structure.

        struct constraint req the Generic type to be value type
        class constraint req the Generic type to be ref type
        new() constraint It requires that T has a parameterless constructor.
        It forces generic type to implement a specific interface.
        It forces generic type to inherit from a specific base class. 
        You can combine more than one constraint
         */


        #endregion


    }

}
public class Val<T> where T : struct
{
    public T Value { get; set; }
}
public class Ref<T> where T : class
{
    public T Value { get; set; }
}
public class parameterless<T> where T : new()
{
    public T Create()
    {
        return new T();
    }
}

public class Compare<T> where T : IComparable<T>
{
    public T Max(T a, T b)
    {
        return a.CompareTo(b) > 0 ? a : b;
    }
}
public class Animal
{
    public string Name { get; set; }
}

public class Animalshelter<T> where T : Animal
{
    public void PrintName(T animal)
    {
        Console.WriteLine(animal.Name);
    }
}
public class Multi<T> where T : class, IComparable<T>, new()
{
    public T CreateAndCompare(T a)
    {
        T mul = new T();
        return a.CompareTo(mul) > 0 ? a : mul;
    }
}