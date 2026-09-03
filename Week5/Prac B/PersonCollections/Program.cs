List<Person> people = new();

people.Add(new Person("Yuchen", "Lu", 21));
people.Add(new Person("Jun", "Lee", 19));
people.Add(new Person("Anon", "Kim", 17));
people.Add(new Person("Shanice", "Wong", 25));
people.Add(new Person("Ecclesiasticalot", "Brown", 35));
people.Add(new Person("Mark", "Smith", 45));
people.Add(new Person("Annalie", "White", 22));
people.Add(new Person("Melissa", "Green", 29));
people.Add(new Person("Askey", "Jones", 18));
people.Add(new Person("Alex", "Taylor", 31));

public class Person
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    public double Age
    {
        get;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age can't be less than 0");
            }

            field = value;
        }
    }

    public string FullName => $"{FirstName} {LastName}";

    public Person(string firstName, string lastName, double age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public bool IsAdult()
    {
        return Age >= 18;
    }
}