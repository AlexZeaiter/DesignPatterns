using DesignPatterns.CreationalDesignPatternsClasses.AbstractFactoryClasses.AnimalWorldClasses.AbstractAnimalType;

namespace DesignPatterns.CreationalDesignPatternsClasses.AbstractFactoryClasses.AnimalWorldClasses.ConcreteAnimal.CarnivoreAnimals
{
    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    public class Lion : Carnivore
    {
        public override string Eat(Herbivore h)
        {
            // Eat Wildebeest
            return (GetType().Name + " eats " + h.GetType().Name);
        }
    }
}
