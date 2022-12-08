
namespace CSharpSyntax;

public class Customer
{
    // bunch of customer stuff here

    

    private void saveToDatabase(bool makeBackup)
    {
        // code here to do that stuff.
    }

    public void SaveToDatabaseWithNoBackup()
    {
        saveToDatabase(false);
    }

    public void SaveToDatabaseWithBackup()
    {
        saveToDatabase(true);
    }
}
