using midterm_project.Migrations;
using midterm_project.Models;

public class EFPetRepository : IPetRepository
{
    private readonly PetDbContext _context;

    public EFPetRepository(PetDbContext context){
        _context = context;
    }

    public Pet CreatePet(Pet newPet)
    {
        _context.Pet.Add(newPet);
        _context.SaveChanges();
        return newPet;
    }

    public void DeletePetById(int petId)
    {
        var pet = _context.Pet.Find(petId);
        if (pet != null)
        {
            _context.Pet.Remove(pet);
            _context.SaveChanges();
        }
    }

    public IEnumerable<Pet> GetAllPets()
    {
        return _context.Pet.ToList();
    }

    public Pet GetPetById(int petId)
    {
        return _context.Pet.Find(petId);
    }

    public Pet UpdatePet(Pet newPet)
    {
        var originalPet = _context.Pet.Find(newPet.PetId);
        
        if (originalPet != null)
        {
            originalPet.PetName = newPet.PetName;
            originalPet.PetURL = newPet.PetURL;
            originalPet.PetDescription = newPet.PetDescription;
            originalPet.PetColor = newPet.PetColor;
            originalPet.PetAge = newPet.PetAge;
            originalPet.PetBreed = newPet.PetBreed;
            originalPet.PetSize = newPet.PetSize;
        }

        _context.SaveChanges();
        return originalPet;
    }
}


