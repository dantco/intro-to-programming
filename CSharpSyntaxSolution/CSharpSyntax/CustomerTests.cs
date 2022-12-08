
namespace CSharpSyntax;

public class CustomerTests
{
    [Fact]
    public void ExpressingIntention()
    {
        var c = new Customer();


        c.SaveToDatabaseWithNoBackup();
        c.SaveToDatabaseWithBackup();

        //c.SaveToDatabase(false);
        
    }
}
