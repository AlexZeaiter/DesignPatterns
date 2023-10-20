using DesignPatterns.CreationalDesignPatternsClasses.FactoryClasses.VehicleFactoryClasses.ConcreteProduct;

namespace DesignPatterns.CreationalDesignPatternsClasses.FactoryClasses.VehicleFactoryClasses.ConcreteCreator
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(string Vehicle)
        {
            switch (Vehicle)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                case "Car":
                    return new Car();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Vehicle));
            }
        }
    }
}
