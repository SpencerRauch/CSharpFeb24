#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace PetParty.Models;

public class Pet
{
    [Required]
    // [DataType(DataType.Password)]
    // [DataType(DataType.Date)] // do this if you don't want your datetime to track time
    public string Name { get;set; }

    [Display(Name = "Type of Pet")]
    [Required]
    public string Species { get;set; }

    [Required(ErrorMessage = "Please supply age")]
    [Range(1,int.MaxValue)]
    public int? Age { get;set; }

    public bool IsCute { get;set; }

}