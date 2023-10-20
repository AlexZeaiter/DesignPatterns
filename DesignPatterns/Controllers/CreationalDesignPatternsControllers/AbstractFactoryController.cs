using DesignPatterns.CreationalDesignPatternsClasses.AbstractFactoryClasses.AnimalWorldClasses;
using DesignPatterns.CreationalDesignPatternsClasses.AbstractFactoryClasses.AnimalWorldClasses.AbstractConinentFactory;
using DesignPatterns.CreationalDesignPatternsClasses.AbstractFactoryClasses.AnimalWorldClasses.ConcreteContinentFactory;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DesignPatterns.Controllers.CreationalDesignPatternsControllers
{
    public class AbstractFactoryController : Controller
    {
        [HttpGet]
        [Route("Abstract-Factory/Animal-World")]
        public IActionResult Index()
        {
            StringBuilder result = new StringBuilder();

            // Create and run the African animal world
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            result.AppendLine(world.RunFoodChain());
            // Create and run the American animal world
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            result.AppendLine(world.RunFoodChain());

            return new JsonResult(result.ToString());
        }
    }
}
