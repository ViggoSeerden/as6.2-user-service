namespace UserServiceBusiness.Models;

public class User
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }    
    
    public string Email { get; set; }    
    
    public int RoleId { get; set; }
    
    public Role Role { get; set; }
}