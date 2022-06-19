using System.Collections;

namespace HomeWork_9_1;

public class UserException : Exception
{
    public UserException(string message) : base(message) { }
    public override string? HelpLink { get => "http://www.yandex.ru"; set => base.HelpLink = value; }
}
