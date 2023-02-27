using System;

interface IClub
{
    // Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Methods
    public string Fullname();
}

class ClubMember : IClub
{
    // Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    // Constructors
    public ClubMember()
    {
        Id = 0;
        FirstName = "";
        LastName = "";
        Email = "";
        Age = 0;
        Gender = "";
    }

    public ClubMember(int id, string firstName, string lastName, string email, int age, string gender)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Age = age;
        Gender = gender;
    }

    // Methods
    public string Fullname()
    {
        return FirstName + " " + LastName;
    }

    public void DisplayAll()
    {
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Name: " + Fullname());
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Gender: " + Gender);
    }

    public void DisplayNameAndEmail()
    {
        Console.WriteLine("Name: " + Fullname());
        Console.WriteLine("Email: " + Email);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ClubMember member = new ClubMember(1, "John", "Doe", "johndoe@example.com", 25, "Male");
        member.DisplayAll();

        Console.WriteLine();

        ClubMember member2 = new ClubMember();
        member2.Id = 2;
        member2.FirstName = "Jane";
        member2.LastName = "Doe";
        member2.Email = "janedoe@example.com";
        member2.Age = 27;
        member2.Gender = "Female";
        member2.DisplayNameAndEmail();
    }
}
