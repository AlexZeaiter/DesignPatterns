using DesignPatterns.CreationalDesignPatternsClasses.BuilderClasses.VehicleBuilderClasses;
using DesignPatterns.CreationalDesignPatternsClasses.BuilderClasses.VehicleBuilderClasses.ConcreteBuilder;
using DesignPatterns.CreationalDesignPatternsClasses.SingletonClasses;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DesignPatterns.Controllers.CreationalDesignPatternsControllers
{
    public class BuilderController : Controller
    {
        [HttpGet]
        [Route("Builder")]
        public IActionResult GetBuilderResult()
        {
            VehicleParts carParts = new VehicleParts("Car Frame", "2500 CC", "2");
            VehicleParts motorCycleParts = new VehicleParts("Motor Cycle Frame", "700 CC", "0");
            VehicleParts scooterParts = new VehicleParts("Scooter Frame", "500 CC", "0");

            VehicleBuilder builder;
            Shop shop = new Shop();

            builder = new CarBuilder(carParts);
            shop.Construct(builder);
            string carData = builder.Vehicle.returnVehicleData();

            builder = new MotorCycleBuilder(motorCycleParts);
            shop.Construct(builder);
            string motorCycleData = builder.Vehicle.returnVehicleData();

            builder = new ScooterBuilder(scooterParts);
            shop.Construct(builder);
            string scooterData = builder.Vehicle.returnVehicleData();

            StringBuilder result = new StringBuilder();
            result.AppendLine(carData);
            result.AppendLine(motorCycleData);
            result.AppendLine(scooterData);

            return new JsonResult(result.ToString());
        }
    }
}
