namespace LabHelloMvc.Models;

public class Person
{
    //primary key
    public int personId { get; set; }

    public string FirstName { get; set; } = String.Empty;
    
    public string LastName { get; set; } = String.Empty;
}