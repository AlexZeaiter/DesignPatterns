using DesignPatterns.CreationalDesignPatternsClasses.AbstractFactoryClasses.AnimalWorldClasses.AbstractAnimalType;

namespace DesignPatterns.CreationalDesignPatternsClasses.AbstractFactoryClasses.AnimalWorldClasses.ConcreteAnimal.CarnivoreAnimals
{
    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    public class Wolf : Carnivore
    {
        public override string Eat(Herbivore h)
        {
            // Eat Bison
            return (GetType().Name + " eats " + h.GetType().Name);
        }
    }
}
