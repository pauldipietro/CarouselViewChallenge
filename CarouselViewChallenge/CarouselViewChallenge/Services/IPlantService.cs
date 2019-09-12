using System.Collections.Generic;
using System.Threading.Tasks;
using CarouselViewChallenge.Models;

namespace CarouselViewChallenge.Services {
    public interface IPlantService
    {
        Task<IList<Plant>> GetPlants();
    }
}