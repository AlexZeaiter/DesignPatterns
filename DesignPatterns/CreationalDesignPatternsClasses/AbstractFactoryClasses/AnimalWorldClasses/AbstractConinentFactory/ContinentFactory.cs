using DesignPatterns.CreationalDesignPatternsClasses.AbstractFactoryClasses.AnimalWorldClasses.AbstractAnimalType;

namespace DesignPatterns.CreationalDesignPatternsClasses.AbstractFactoryClasses.AnimalWorldClasses.AbstractConinentFactory
{
    /// <summary>
    /// The 'AbstractFactory' abstract class
    /// </summary>
    abstract public class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
