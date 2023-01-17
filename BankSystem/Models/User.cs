namespace BankSystem.Models;

public class User
{
    public int Id { get; }
    public string Name { get; set; }

    public User(int id)
    {
        Id = id;
    }

    public User(int id, string name) : this(id)
    {
        Name = name;
    }

    public override bool Equals(Object? obj)
    {
        if (obj == null || obj is not User)
        {
            return false;
        }
        return true;
    }
}