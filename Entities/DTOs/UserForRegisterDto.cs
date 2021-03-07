using Core.Entities;

public class UserForRegisterDto : IDto
{
    public string Email { get; set; }
    public string Password { get; set; } //veritabanında yok ama bana Password lazim. Bu yüzden DTO kullandık.
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
