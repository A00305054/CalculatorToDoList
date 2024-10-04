namespace CalculatorWebAPI.Interfaces
{
    public interface ICalculatorService<T>
    {
        T Add(T num1, T num2);
        T Subtract(T num1, T num2);
        T Multiply(T num1, T num2);
        T Divide(T num1, T num2);
    }
}
