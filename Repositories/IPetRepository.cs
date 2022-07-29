using midterm_project.Models;

public interface IPetRepository {
    IEnumerable<Pet> GetAllPets();
    Pet GetPetById(int petId);
    Pet CreatePet(Pet pet);
    Pet UpdatePet(Pet pet);
    void DeletePetById(int petId);

}
