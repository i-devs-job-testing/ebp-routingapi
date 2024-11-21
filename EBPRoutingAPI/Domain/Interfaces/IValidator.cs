namespace EBPRoutingAPI.Domain.Interfaces;

public interface IValidator<T> where T : class
{
    bool Validate(T value);
}
