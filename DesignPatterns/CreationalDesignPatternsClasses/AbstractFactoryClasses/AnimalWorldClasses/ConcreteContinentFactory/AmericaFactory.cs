﻿using DesignPatterns.CreationalDesignPatternsClasses.AbstractFactoryClasses.AnimalWorldClasses.AbstractAnimalType;
using DesignPatterns.CreationalDesignPatternsClasses.AbstractFactoryClasses.AnimalWorldClasses.AbstractConinentFactory;
using DesignPatterns.CreationalDesignPatternsClasses.AbstractFactoryClasses.AnimalWorldClasses.ConcreteAnimal.CarnivoreAnimals;
using DesignPatterns.CreationalDesignPatternsClasses.AbstractFactoryClasses.AnimalWorldClasses.ConcreteAnimal.HerbivoreAnimals;

namespace DesignPatterns.CreationalDesignPatternsClasses.AbstractFactoryClasses.AnimalWorldClasses.ConcreteContinentFactory
{
    /// <summary>
    /// The 'ConcreteFactory' class
    /// </summary>
    public class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
}
