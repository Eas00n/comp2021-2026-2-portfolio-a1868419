public class Person
{
    // Auto-properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    // Constructor with validation
    public Person(string firstName, string lastName, int age)
    {
        // age should be a non-negative integer
        if (age < 0)
        {
            throw new ArgumentException("Age cannot be negative.");
        }

        // firstname cannot be empty or whitespace
        if (string.IsNullOrWhiteSpace(firstName))
        {
            throw new ArgumentException("First name cannot be empty.");
        }   

        // lastname cannot be empty or whitespace
        if (string.IsNullOrWhiteSpace(lastName))
        {
            throw new ArgumentException("Last name cannot be empty.");
        }

        // Assign values to properties
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
    // python return "LastName, FirstName"
    public string FullName()
    {
        return $"{LastName}, {FirstName}";
    }

    // return true if adult
    public bool IsAdult()
    {
        return Age >= 18;
    }
    // Person class with validation2
}