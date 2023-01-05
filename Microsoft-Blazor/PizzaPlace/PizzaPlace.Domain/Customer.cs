using System.ComponentModel.DataAnnotations;

namespace PizzaPlace.Domain;

public class Customer
{
    [Required(ErrorMessage = "Please provide a city")]
    public string City { get; set; } = default!;

    public int Id { get; set; }

    [Required(ErrorMessage = "Please provide a name")]
    public string Name { get; set; } = default!;

    [Required(ErrorMessage = "Please provide a street with house number.")]
    public string Street { get; set; } = default!;
}