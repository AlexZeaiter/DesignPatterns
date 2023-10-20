namespace DesignPatterns.CreationalDesignPatternsClasses.FactoryClasses.VehicleFactoryClasses.ConcreteProduct
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Scooter : IFactory
    {
        public string Drive(int miles)
        {
            return "Drive the Scooter : " + miles.ToString() + "Km";
        }
    }
}
