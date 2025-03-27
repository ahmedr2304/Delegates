



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













