using System.ComponentModel.DataAnnotations;

namespace midterm_project.Models;

public class Pet {
    public int PetId { get; set; }

    [Required]
    public string PetName { get; set; }

    [Required]
    public string PetURL { get; set; }

    [Required]
    public string PetDescription { get; set; }

    [Required]
    public string PetColor { get; set; }

    [Required, Range(0, 1000)]
    public int PetAge { get; set; }

    [Required]
    public string PetBreed { get; set; }

    [Required]
    public string PetSize { get; set; }

}