namespace Authentication;

public class Users : CustomAttributes
{
    public DateTime JoinDate { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}
