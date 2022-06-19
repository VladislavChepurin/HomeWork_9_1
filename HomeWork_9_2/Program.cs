global using HomeWork_9_1; // Для портирования класса UserException из HomeWork_9_1

namespace HomeWork_9_2;

internal class Program
{
    static void Main(string[] args)
    {
        ReadConcole rc = new ReadConcole();
        rc.NotifiEvent += SortSurname;
        Start(rc);       
    }

    private static void Start(ReadConcole rc)
    {
        try
        {
            rc.Read();
        }
        catch (UserException e)
        {
            Console.WriteLine(e.Message);
            Start(rc); // Нужно нечеловеческое упорство для StackOverflow
        }
        finally
        {
            Console.ReadKey();
        }
    }

    private static void SortSurname(int nunber)
    {  
        // Список наиболее частотных фамилий http://imja.name/familii/pyatsot-chastykh-familij.shtml
        string[] surname = new string[] {"Иванов", "Смирнов", "Кузнецов", "Попов", "Васильев"};
        Console.WriteLine($"{Environment.NewLine}Результат сортировки:");

        switch (nunber)
        {
            case 1:
                var orderedNumbers1 = from i in surname //Пузырек не try
                                   orderby i
                                    select i;
                foreach (string i in orderedNumbers1)
                {
                    Console.WriteLine(i);
                }          
                break;
            case 2:
                var orderedNumbers2 = from j in surname
                                   orderby j descending
                                    select j;
                foreach (string j in orderedNumbers2)
                {
                    Console.WriteLine(j);
                }
                break;
            default:
                throw new UserException("Так быть недолжно.");
        }
    }
}