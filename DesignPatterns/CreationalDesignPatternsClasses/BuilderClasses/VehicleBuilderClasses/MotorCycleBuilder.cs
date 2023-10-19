namespace DesignPatterns.CreationalDesignPatternsClasses.BuilderClasses.VehicleBuilderClasses
{
    public class MotorCycleBuilder : VehicleBuilder
    {
        private VehicleParts vehicleParts;
        public MotorCycleBuilder(VehicleParts vehicleParts)
        {
            vehicle = new Vehicle("MotorCycle");
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
            vehicle["wheels"] = "2";
        }
        public override void BuildDoors()
        {
            vehicle["doors"] = vehicleParts.doors;
        }
    }
}
