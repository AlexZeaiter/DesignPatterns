namespace DesignPatterns.CreationalDesignPatternsClasses.BuilderClasses.VehicleBuilderClasses
{
    public class VehicleParts
    {
        public string frame;
        public string engine;
        public string doors;
        public VehicleParts( string frame, string engine, string doors)
        {
            this.frame = frame;
            this.engine = engine;
            this.doors = doors;
        }
    }
}
