using System.ComponentModel.DataAnnotations;

namespace SolarCoffee.Data.Models;

public class CustomerAddress
{
    public int Id { get; set; }

    [MaxLength(250)]
    public string AddressLine1 { get; set; }

    [MaxLength(250)]
    public string AddressLine2 { get; set; }
    
    [MaxLength(120)]
    public string City { get; set; }
    
    [MaxLength(120)]
    public string State { get; set; }
    
    [MaxLength(64)]
    public string Country { get; set; }
    
    [MaxLength(32)]
    public string PostalCode { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime ModifiedOn { get; set; }
}