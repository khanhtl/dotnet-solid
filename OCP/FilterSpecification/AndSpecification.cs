using OCP.Interface;

namespace OCP.FilterSpecification
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _first, _second;
        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this._first = first;
            this._second = second;
        }
        public bool IsSatisfied(T t)
        {
            return _first.IsSatisfied(t) && _second.IsSatisfied(t);
        }
    }
}
