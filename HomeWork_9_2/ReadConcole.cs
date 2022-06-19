
namespace HomeWork_9_2;

internal class ReadConcole
{
    public delegate void Notify(int num);
    public event Notify? NotifiEvent;
    UserException userException = new UserException("Введено некоректное заначение.");// Побережем память машины не будем создавать мусор в каждой ирретации.

    public void Read()
    {
        Console.WriteLine("Введите чило 1 или 2");
        if (int.TryParse(Console.ReadLine(), out int  result) && (result == 1 || result == 2))
        {
            NotifiEvent?.Invoke(result);
        }
        else
        {
            throw userException;
           // Read(); Так проще.
        }
    }
}
