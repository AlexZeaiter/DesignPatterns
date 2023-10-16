using DesignPatterns.SingletonClass;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DesignPatterns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingletonController : ControllerBase
    {
        [HttpGet]
        public async Task<string> Get()
        {
            SingletonNoThreadSafeImp s1 = SingletonNoThreadSafeImp.Instance;
            SingletonNoThreadSafeImp s2 = SingletonNoThreadSafeImp.Instance;
            // Test for same instance
            if (s1 == s2)
            {
                return "Objects are the same instance";
            }
            return "";
        }
    }
}
