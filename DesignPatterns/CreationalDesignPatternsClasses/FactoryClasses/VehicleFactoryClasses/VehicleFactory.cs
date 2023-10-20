namespace DesignPatterns.CreationalDesignPatternsClasses.FactoryClasses.VehicleFactoryClasses
{
    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string Vehicle);
    }
}
