using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CMS.WebApp.Models;

public class Customer
{
   
    public int Id { get; set; }

    [DisplayName("Customer Name")]
    public string Name { get; set; } = default!;
    [DisplayName("Customer Email")]
    public string Email { get; set; } = default!;
    [DisplayName("Customer Phone")]
    public string Phone { get; set; } = default!;
    [DisplayName("Customer Address")]
    public string Address { get; set; }=default!;
}
