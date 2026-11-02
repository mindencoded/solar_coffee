namespace SolarCoffee.Data.Models;

public class Customer
{
    public int Id { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public DateTime CreatedOn { get; set; }
    
    public DateTime ModifiedOn { get; set; }
    
    public CustomerAddress CustomerAddress { get; set; }
}