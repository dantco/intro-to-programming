
namespace CSharpSyntax;

public class MoreObjectStuff
{
}

public class FormatterUtils
{
    public string FormatName(string firstName, string lastName, string? mi)
    {
        var fullName = $"{lastName}, {firstName}";

        if (mi is not null)
        {
            fullName += $" {mi}.";
        }
        return fullName ;
    }
