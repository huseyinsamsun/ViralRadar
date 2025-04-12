namespace ViralRadar.Application.Users.Commands.CreateUser;

public class CreatedUserResponse
{
    
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime CreatedDate { get; set; }
}