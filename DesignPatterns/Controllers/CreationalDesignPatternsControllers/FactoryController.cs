using DesignPatterns.CreationalDesignPatternsClasses.BuilderClasses.VehicleBuilderClasses;
using DesignPatterns.CreationalDesignPatternsClasses.FactoryClasses.DocumentFactory;
using DesignPatterns.CreationalDesignPatternsClasses.FactoryClasses.DocumentFactory.ConcreteCreator;
using DesignPatterns.CreationalDesignPatternsClasses.FactoryClasses.VehicleFactoryClasses;
using DesignPatterns.CreationalDesignPatternsClasses.FactoryClasses.VehicleFactoryClasses.ConcreteCreator;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DesignPatterns.Controllers.CreationalDesignPatternsControllers
{
    public class FactoryController : Controller
    {
        /// <summary>
        /// Factory Pattern Demo
        /// </summary>
        [HttpGet]
        [Route("Factory/Vehicle")]
        public IActionResult GetVehicleFactoryResult()
        {
            StringBuilder result = new StringBuilder();

            VehicleFactory factory = new ConcreteVehicleFactory();

            IFactory car = factory.GetVehicle("Car");
            
            IFactory bike = factory.GetVehicle("Bike");
            
            IFactory scooter = factory.GetVehicle("Scooter");
            
            result.AppendLine(car.Drive(500));
            result.AppendLine(bike.Drive(20));
            result.AppendLine(scooter.Drive(10));

            return new JsonResult(result.ToString());
        }

        [HttpGet]
        [Route("Factory/Document")]
        public IActionResult GetDocumentFactory()
        {
            StringBuilder result = new StringBuilder();
            // Note: constructors call Factory Method
            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();
            // Display document pages
            foreach (Document document in documents)
            {
                result.AppendLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    result.AppendLine(" " + page.GetType().Name);
                }
            }
            return new JsonResult(result.ToString());
        }
    }
}
