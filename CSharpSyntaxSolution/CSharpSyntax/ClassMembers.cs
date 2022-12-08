

namespace CSharpSyntax;

public class ClassMembers
{
    [Fact]
    public void CreatingStuff()
    {
        var book1 = new LibraryBook("9999");
        book1.Author = "Sue";

        var book2 = new LibraryBook("9999");
        book2.Author = "Sue";

        //var book2 = book1;

        var myPay = 50M;
        var yourPay = 50M;

        Assert.Equal(myPay, yourPay);

        Assert.Equal(book1, book2);

        if(book1 == book2)
        {

        }
        


    }

    [Fact]
    public void NullableValueTypes()
    {
        DateTime? birthday = null;

        if (birthday.HasValue)
        {
            birthday.Value.AddDays(3);
        }
    }
}

public class LibraryBook : IEquatable<LibraryBook>
{

    // "State"
    // - fields (class-level variables)
    // Properties should never throw exceptions.
    // Properties imply no computation.
    // - If a user class sets a property, it should never change until they
    //   change it.
    public string Isbn { get; private set; } = string.Empty;
    public string Author { get; set; } = string.Empty;

    public LibraryBook(string isbn)
    {
        Isbn = isbn;

    }

    public bool Equals(LibraryBook? other)
    {
        return (this.Isbn == other?.Isbn && this.Author == other.Author) ;
    }
    // "Behavior"
    //  - Methods

    //  - Constructors
    // - Properties
    //  - *Destructors
}