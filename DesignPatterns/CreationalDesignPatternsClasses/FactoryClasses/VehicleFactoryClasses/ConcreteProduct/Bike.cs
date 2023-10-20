namespace DesignPatterns.CreationalDesignPatternsClasses.FactoryClasses.VehicleFactoryClasses.ConcreteProduct
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Bike : IFactory
    {
        public string Drive(int miles)
        {
            return "Drive the Bike : " + miles.ToString() + "Km";
        }
    }
}
