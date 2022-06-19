using System.Collections;
using System.Data;
using System.Net;

namespace HomeWork_9_1;

internal class Program
{
    static void Main(string[] args)
    {
        UserException userException = new UserException("Исключение пользовательского типа.");
        DataException dataException = new DataException("Представляет исключение, которое выдается при создании ошибок с помощью компонента ADO.NET.");
        ArgumentException argumentException = new ArgumentException("Это исключение выбрасывается, если один из передаваемых методу аргументов является недопустимым.");
        WebException webException = new WebException("Исключение, которое выдается, если при обращении к сети через подключаемый протокол возникает ошибка.");
        StackOverflowException stackOverflowException = new StackOverflowException("Исключение, которое возникает, когда стек выполнения превышает размер стека.");

        dataException.HelpLink = "https://docs.microsoft.com/ru-ru/dotnet/api/system.data.dataexception?view=net-5.0";
        argumentException.HelpLink = "https://docs.microsoft.com/ru-ru/dotnet/api/system.argumentexception?view=net-6.0";
        webException.HelpLink = "https://docs.microsoft.com/ru-ru/dotnet/api/system.net.webexception?view=net-6.0";
        stackOverflowException.HelpLink = "https://docs.microsoft.com/ru-ru/dotnet/api/system.stackoverflowexception?view=net-5.0";

        Exception[] exceptions = new Exception[5] { userException, dataException, argumentException, webException, stackOverflowException };
        foreach (Exception itemException in exceptions)
        {
            try
            {
                throw itemException;
            }
            catch (Exception e) 
            {
                e.Data.Add("Time", DateTime.Now); 
                Console.WriteLine(e.GetType());
                Console.WriteLine($"Вызвано исключение. {e.Message} Ошибка произошла в {e.Data["Time"]}, подробности: {e.HelpLink}");
                Console.WriteLine($"{Environment.NewLine}< ------------------------------------------------------ >{Environment.NewLine}");
            }
        }
        Console.ReadKey();
    }
}