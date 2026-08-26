namespace C__Advanced_01
{
    internal class Program
    {
        static void Main()
        {
            #region Q1
            //   What is a generic class? Why use generics?
            // Answer => class defined with a type parameter placeholder (<T>) and the actual data type is specified at the time of instantiation .
            //  Type Safety , Performance , Code Reusability , Cleaner Code 
            #endregion
            #region Q2
            // Write a generic class Container<T> with Add and Get methods .
            //public class Container<T>
            //{
            //    private List<T> _items = new();

            //    public void Add(T item) => _items.Add(item);
            //    public T Get(int index) => _items[index];
            //}
            #endregion
            #region Q3
            // What are multiple type parameters? Write Pair<TKey, TValue >.
            // Answer => generic class takes two or more distinct type placeholders.
            //    public class Pair<TKey, TValue>
            //{
            //    public TKey Key { get; set; }
            //    public TValue Value { get; set; }

            //    public Pair(TKey key, TValue value)
            //    {
            //        Key = key;
            //        Value = value;
            //    }
            //}
            #endregion
            #region Q4
            // What is a generic method? Write Swap<T> method .
            // Answer => method declared with its own type parameters, allowing it to operate on arguments of various types independently .
            //    public static void Swap<T>(ref T a, ref T b)
            //{
            //    T temp = a;
            //    a = b;
            //    b = temp;
            //}
            #endregion
            #region Q5
            // Write a generic method FindMax<T> that finds maximum value .
            //    public static T FindMax<T>(T a, T b) where T : IComparable<T>
            //{
            //    return a.CompareTo(b) > 0 ? a : b;
            //}
            #endregion
            #region Q6
            // What is a generic interface? Write IRepository<T>. 
            // Answer => interface defined with type parameters that establishes a standardized, strongly-typed contract for any class implementing it .
            //    public interface IRepository<T>
            //{
            //    void Add(T entity);
            //    T GetById(int id);
            //}
            #endregion
            #region Q7
            // What is the 'struct' constraint? Write an example.
            // Restricts the type argument T to non-nullable value types .
            //    public class ValueContainer<T> where T : struct
            //{
            //    public T Data { get; set; }
            //}
            #endregion
            #region Q8
            // What is the 'class' constraint? Write an example.
            // Restricts the type argument T to reference types .
            //    public class ReferenceContainer<T> where T : class
            //{
            //    public T? Data { get; set; }
            //}
            #endregion
            #region Q9
            // What is the 'new()' constraint? Write an example.
            // Requires that the type argument T has a parameterless constructor .
            //    public class Factory<T> where T : new()
            //{
            //    public T CreateInstance() => new T();
            //}
            #endregion
            #region Q10
            // What is the interface constraint? Write an example.
            // Ensures that the type argument T implements a specified interface.
            //    public class Runner<T> where T : IRepository
            //{
            //    public void Execute(T resource) => resource.Add(5);
            //}
            #endregion
        }
    }
}

