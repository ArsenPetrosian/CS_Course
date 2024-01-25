namespace GenericsOperationsUtility
{
    public interface ICalculationUtility<T>
    {
        T Add(T l, T r);
        T Sub(T l, T r);
        T Mul(T l, T r);
        T Div(T l, T r);
        void QuotientRemainder(T l, T r, out T quotient, out T remainder);
    }
}
