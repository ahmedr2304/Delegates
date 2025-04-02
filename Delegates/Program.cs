using Delegates;

#region Using delegation method as predicate paramter

Console.WriteLine("******* Using Using delegation method as predicate paramter");

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

Console.WriteLine("******* End Using delegation method as predicate paramter");
Console.WriteLine();

#endregion

#region UsingBuiltInDelegate
Console.WriteLine("******* Using Built in Delegate");
// Calling the Built in delegate "Action" that conatins from 1 param to 16 param and dosn't return value
Action<string> action = BuiltInDelegates.Print;
action("Ahmed Ramadan");

// Calling the Built in delegate "Func" that conatins from 1 param to 16 param and has output param as  a return value
Func<int,int,int> func = BuiltInDelegates.Add;
Console.WriteLine(func(1, 2));

// Calling the Built in delegate "Func" that conatins one  param  and  return bool
Predicate<int> predicate= BuiltInDelegates.IsEven;
Console.WriteLine(predicate(2));

Console.WriteLine("******* End Using Built in Delegate");
Console.WriteLine();

#endregion

#region Apply LamdaExpression and Anymous function 

Console.WriteLine("*******Apply LamdaExpression and Anymous function");
//get the count of the books that are greater than 30 Apply LamdaExpression
Console.WriteLine("The count of the books that are greater than 30 Apply LamdaExpression : " + BookManagment.CountBooks(books, book => book.Price > 30M));

//get the count of the books that are greater than 30 Apply Anynmous Method
Console.WriteLine("The count of the books that are greater than 30 Apply Anynmous Method : " + BookManagment.CountBooks(books, delegate (Book book) { return book.Price > 30M; }));

Console.WriteLine("*******End Apply LamdaExpression and Anymous function");
Console.WriteLine();
#endregion

#region Another Example for Applying LamdaExpression And Anynmous Method 
Console.WriteLine("*******Another Example for Applying LamdaExpression And Anynmous Method");
var emps = new Employee[]
{
    new Employee{Id = 1, Name="Ahmed",Geneder = "M",TotalSalary = 10000M },
    new Employee{Id = 2, Name="Moahmed",Geneder = "M",TotalSalary = 3000M },
    new Employee{Id = 3, Name="Moahmoud",Geneder = "M",TotalSalary = 7000M },
    new Employee{Id = 4, Name="Fawzy",Geneder = "M",TotalSalary = 8000M },
    new Employee{Id = 5, Name="Mona",Geneder = "F",TotalSalary = 2000M },
    new Employee{Id = 6, Name="Judy",Geneder = "F",TotalSalary = 9000M },
    new Employee{Id = 7, Name="Jowiraia",Geneder = "F",TotalSalary = 7500M },
};

Dashboard dashboard = new Dashboard();
dashboard.ProcessEmployees(emps, $"Employees that those total salary>5000", e => e.TotalSalary > 5000M);
dashboard.ProcessEmployees(emps, $"Employees that those Names start with M", e => e.Name.StartsWith('M'));

Console.WriteLine("*******End Another Example for Applying LamdaExpression And Anynmous Method");
Console.WriteLine();
#endregion

#region MultiCasting Delegate  
Console.WriteLine("*******MultiCasting Delegate******");

var rectangleHelper = new RectangleHelper();

RectangleHelper.RectangeDelegate  rectangeDelegate;
rectangeDelegate = rectangleHelper.GetArea;
rectangeDelegate += rectangleHelper.GetPerimeter;
rectangeDelegate(10, 10);

rectangeDelegate -= rectangleHelper.GetPerimeter;
Console.WriteLine("*** After un subscribing ");
rectangeDelegate(10, 10);

Console.WriteLine("*******End MultiCasting Delegate******");
Console.WriteLine();
#endregion

#region Using SimpleDelegation


Console.WriteLine("*******SimpleDelegation");
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

Console.WriteLine("*******End SimpleDelegation");
Console.WriteLine();

#endregion
#region Delegation Declartion
// Delegate Declaration
public delegate void MyDelegate(string message);

#endregion


















