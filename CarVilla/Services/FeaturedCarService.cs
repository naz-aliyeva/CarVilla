using CarVilla.Contexts;
using CarVilla.Models;

namespace CarVilla.Services;

public class FeaturedCarService
{
    private readonly AppDbContext _context;

    public FeaturedCarService()
    {
        _context = new AppDbContext();
    }
    #region Create
    public void CreateFeaturedCar(FeaturedCar  featuredCar)
    {
        _context.FeaturedCars.Add(featuredCar);
        _context.SaveChanges(); 
    }
    #endregion


    #region Read

    public FeaturedCar GetFeaturedCarById(int id)
    {
        FeaturedCar? featuredCar = _context.FeaturedCars.Find(id);
        if (featuredCar is null) 
        {
            throw new Exception($"Database daxilinde {id} id-e sahib data tapilmadi");
        }

        return featuredCar;
    }
    public List<FeaturedCar> GetAllFeatureCars()
    {
        List<FeaturedCar> featuredCars = _context.FeaturedCars.ToList(); 
        return featuredCars;
    }
    #endregion

    #region Update
    public void UpdateFeaturedCar(int id, FeaturedCar updatedFeaturedCar)
    {
        if (id != updatedFeaturedCar.Id)
        {
            throw new Exception("id-ler ust uste dusur ");
        }
        FeaturedCar? baseFeaturedCar = _context.FeaturedCars.Find(id);

        if (baseFeaturedCar is not null )
        {
            throw new Exception($" databasede {id} id-e sahib data tapilmadi ");
        }
        baseFeaturedCar.ImgUrl = updatedFeaturedCar.ImgUrl;
    #endregion

        #region Delete 
    public void DeleteFeaturedCar(int id)
    {
        FeaturedCar? featuredCar = _context.FeaturedCars.Find(id);
        if (featuredCar is null)
        {
            throw new Exception($"Database daxilinde {id} id-e sahib data tapilmadi");
        }
        _context.FeaturedCars.Remove(featuredCar);
        _context.SaveChanges();
    }
    #endregion
}
