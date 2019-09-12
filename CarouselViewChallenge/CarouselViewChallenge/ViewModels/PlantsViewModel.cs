using System.Collections;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CarouselViewChallenge.Services;

namespace CarouselViewChallenge.ViewModels
{
    public class PlantsViewModel
    {
        private readonly IPlantService m_plantService;

        public PlantsViewModel(IPlantService plantService)
        {
            m_plantService = plantService;
        }

        public ObservableCollection<PlantViewModel> Plants { get; } = new ObservableCollection<PlantViewModel>();

        public async Task Initialize()
        {
            var plants = await m_plantService.GetPlants();
            foreach (var plant in plants)
            {
                Plants.Add(new PlantViewModel(plant.Name, plant.WateringFrequency, plant.LastWateringDate, plant.ImageUrl));
            }
        }
    }
}