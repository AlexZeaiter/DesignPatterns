using DesignPatterns.CreationalDesignPatternsClasses.AbstractFactoryClasses.AnimalWorldClasses.AbstractAnimalType;
using DesignPatterns.CreationalDesignPatternsClasses.AbstractFactoryClasses.AnimalWorldClasses.AbstractConinentFactory;

namespace DesignPatterns.CreationalDesignPatternsClasses.AbstractFactoryClasses.AnimalWorldClasses
{
    public class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;
        // Constructor
        public AnimalWorld(ContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }
        public string RunFoodChain()
        {
            return _carnivore.Eat(_herbivore);
        }
    }
}
