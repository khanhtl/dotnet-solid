namespace OCP.Interface
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }
    //public abstract class ISpecification<T>
    //{
    //    public abstract bool IsSatisfied(T p);
    //    public static ISpecification<T> operator &(
    //    ISpecification<T> first, ISpecification<T> second)
    //    {
    //        return new AndSpecification<T>(first, second);
    //    }
    //}
}
