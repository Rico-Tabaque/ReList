using System;

public class User
{
    public int Id { get; set; }
    public string GivenName { get; set; }
    public string FamilyName { get; set; }
    public string Gender { get; set; }
    public DateTime Birthdate { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Password { get; set; }

    public ICollection<Todo>? Todos { get; }

}
