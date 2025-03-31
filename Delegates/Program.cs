using Delegates;

#region Using delegation method as predicate paramter

using Delegates;

List<Book> books = new List<Book>()
        {
            new Book("The programmer" , 32.05M),
            new Book("Clean Code" , 40.1M),
            new Book("Fundementals of Algorithms" , 20.0M),
            new Book("C# Modern" , 15.3M),
            new Book("Head first Design Patterns" , 32M)
        };

bool GreaterThan30(Book book) => book.Price > 30M;
bool LessThan20(Book book) => book.Price < 20M;

bool StartWithC(Book book) => book.Title.StartsWith('C');


//get the count of the books that are greater than 30
Console.WriteLine("The count of the books that are greater than 30 : " + BookManagment.CountBooks(books, GreaterThan30));
//get the count of the booksthat are less than 20
Console.WriteLine("The count of the books that are Less than 20 : " + BookManagment.CountBooks(books, LessThan20));
//get the count of the books that are starting with C
Console.WriteLine("The count of the books that are starting with C : " + BookManagment.CountBooks(books, StartWithC));

#endregion

#region Using SimpleDelegation


static void Welocme(string name) => Console.WriteLine("Welcome " + name);
static void Hello(string name) => Console.WriteLine("Hello " + name);

//MyDelegate d1 = new MyDelegate(Welocme);
MyDelegate d1 = Welocme;
d1("Ahmed");
//MyDelegate d2 = new MyDelegate(Hello);
MyDelegate d2 = Hello;
d2("Mohammed");


static void InvokeMyDelegate(MyDelegate myDelegate, string name) => myDelegate.Invoke(name);

InvokeMyDelegate(d1, "Ahmed");
InvokeMyDelegate(d2, "Mohamed");

// Delegate Declaration
public delegate void MyDelegate(string message);
#endregion

















