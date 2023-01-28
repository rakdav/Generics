using Generics;

Person tom = new Person(56, "Tom");
Person bob = new Person("abc", "Bob");
int tomId = (int)tom.Id;
string bobId= (string)bob.Id;
Console.WriteLine(tom.Id);
Console.WriteLine(bob.Id);

PersonGeneric<int,string> sam = new PersonGeneric<int,string>(45, "Sam","qwerty");
PersonGeneric<string,int> kate = new PersonGeneric<string,int>("a5","Kate",123);
int samId = sam.Id;
string kateId=kate.Id;
Console.WriteLine(samId);
Console.WriteLine(kateId);

Company<PersonGeneric<int,string>> samsung = 
            new Company<PersonGeneric<int,string>>(sam);
Console.WriteLine(samsung.CEO.Id);
Console.WriteLine(samsung.CEO.Name);
Console.WriteLine(samsung.CEO.Password);
int a = 7, b = 4;
Swap<int>(ref a,ref b);
Console.WriteLine(a+" "+b);

double c = 7.9, d = 3.14;
Swap<double>(ref c,ref d);
Console.WriteLine(c+" "+d);

void Swap<T> (ref T x,ref T y)
{
    T temp = x;
    x = y;
    y=temp;
}

Message message = new Message("Message text");
Messanger<Message> messanger = new Messanger<Message>();
messanger.SendMessage(message);