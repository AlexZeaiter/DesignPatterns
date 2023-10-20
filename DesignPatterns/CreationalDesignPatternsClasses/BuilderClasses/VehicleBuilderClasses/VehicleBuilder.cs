using DesignPatterns.CreationalDesignPatternsClasses.BuilderClasses.VehicleBuilderClasses.ConcreteProduct;

namespace DesignPatterns.CreationalDesignPatternsClasses.BuilderClasses.VehicleBuilderClasses
{
    /// <summary>
    /// The 'Builder' abstract class
    /// </summary>
    abstract public class VehicleBuilder
    {
        protected Vehicle vehicle;
        public Vehicle Vehicle { 
            get 
            { 
                return vehicle; 
            } 
        }

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
