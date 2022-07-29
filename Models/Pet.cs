using System.ComponentModel.DataAnnotations;

namespace midterm_project.Models;

public class Pet {
    public int PetId { get; set; }

    [Required]
    [Display(Name = "Pet Name")]
    public string PetName { get; set; }

    [Required]
    [Display(Name = "Cute Image")]
    public string PetURL { get; set; }

    [Required]
    [Display(Name = "Description")]
    public string PetDescription { get; set; }

    [Required]
    [Display(Name = "Pet Coat Color")]
    public string PetColor { get; set; }

    [Required, Range(0, 1000)]
    [Display(Name = "Pet Age")]
    public int PetAge { get; set; }

    [Required]
    [Display(Name = "Pet Breed")]
    public string PetBreed { get; set; }

    [Required]
    [Display(Name = "Pet Size")]
    public string PetSize { get; set; }

}