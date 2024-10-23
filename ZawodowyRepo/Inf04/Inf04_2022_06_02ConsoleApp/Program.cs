

using Inf04_2022_06_02ConsoleApp;
Console.WriteLine($"Liczba zarejestrowanych osób to {Person.count}");

Person person = new Person();
//person.id = -1;

Console.WriteLine("Podaj id");
string strId = Console.ReadLine();
Console.WriteLine("Podaj imię");
string name = Console.ReadLine();

Person secondPerson = new Person(name: name, id: int.Parse(strId));

Person thirdPerson = new Person(secondPerson);

person.Show("Jan");
secondPerson.Show("Jan");
thirdPerson.Show("Jan");

Console.WriteLine($"Liczba zarejestrowanych osób to {Person.count}");
