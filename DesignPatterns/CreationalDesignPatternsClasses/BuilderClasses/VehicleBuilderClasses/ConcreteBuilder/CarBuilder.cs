using DesignPatterns.CreationalDesignPatternsClasses.BuilderClasses.VehicleBuilderClasses.ConcreteProduct;

namespace DesignPatterns.CreationalDesignPatternsClasses.BuilderClasses.VehicleBuilderClasses.ConcreteBuilder
{
    /// <summary>
    /// The 'ConcreteBuilder' class
    /// </summary>
    public class CarBuilder : VehicleBuilder
    {
        private VehicleParts vehicleParts;
        public CarBuilder(VehicleParts vehicleParts)
        {
            vehicle = new Vehicle("Car");
            this.vehicleParts = vehicleParts;
        }
        public override void BuildFrame()
        {
            vehicle["frame"] = vehicleParts.frame;
        }
        public override void BuildEngine()
        {
            vehicle["engine"] = vehicleParts.engine;
        }
        public override void BuildWheels()
        {
            vehicle["wheels"] = "4";
        }
        public override void BuildDoors()
        {
            vehicle["doors"] = vehicleParts.doors;
        }
    }
}
