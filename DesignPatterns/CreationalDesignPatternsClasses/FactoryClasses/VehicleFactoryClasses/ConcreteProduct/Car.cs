namespace DesignPatterns.CreationalDesignPatternsClasses.FactoryClasses.VehicleFactoryClasses.ConcreteProduct
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Car : IFactory
    {
        public string Drive(int miles)
        {
            return "Drive the Car : " + miles.ToString() + "Km";
        }
    }
}
