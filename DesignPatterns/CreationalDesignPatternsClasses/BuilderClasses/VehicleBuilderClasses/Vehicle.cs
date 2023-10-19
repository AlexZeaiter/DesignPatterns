using System.Text;

namespace DesignPatterns.CreationalDesignPatternsClasses.BuilderClasses.VehicleBuilderClasses
{
    public class Vehicle
    {
        private string vehicleType;
        private Dictionary<string, string> parts = new Dictionary<string, string>();

        public Vehicle(string vehicleType)
        {
            this.vehicleType = vehicleType;
        }

        public string this[string key]
        {
            get { return parts[key]; }
            set { parts[key] = value; }
        }

        public string returnVehicleData()
        {
            StringBuilder vehicleData = new StringBuilder();
            vehicleData.AppendLine(string.Format("Vehicle Type: {0}", vehicleType));
            vehicleData.AppendLine(string.Format(" Frame : {0}", parts["frame"]));
            vehicleData.AppendLine(string.Format(" Engine : {0}", parts["engine"]));
            vehicleData.AppendLine(string.Format(" #Wheels : {0}", parts["wheels"]));
            vehicleData.AppendLine(string.Format(" #Doors : {0}", parts["doors"]));
            return vehicleData.ToString();
        }
    }
}
