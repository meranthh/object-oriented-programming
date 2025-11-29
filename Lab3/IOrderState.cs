namespace Lab3;
public interface IOrderState
{
    void Advance(Order order);

    string Status();
}