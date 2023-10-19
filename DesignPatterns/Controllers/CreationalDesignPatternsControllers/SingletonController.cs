using DesignPatterns.CreationalDesignPatternsClasses.SingletonClasses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DesignPatterns.Controllers.CreationalDesignPatternsControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingletonController : ControllerBase
    {
        [HttpGet]
        [Route("notthreadsafe")]
        public IActionResult GetNoThreadSafeResult()
        {
            StringBuilder result = new StringBuilder();
            var numbers = Enumerable.Range(0, 10);
            SingletonNoThreadSafeImp s1 = SingletonNoThreadSafeImp.Instance;
            SingletonNoThreadSafeImp s2 = SingletonNoThreadSafeImp.Instance;
            // Test for same instance
            if (s1 == s2)
            {
                result.Append("Objects are the same instance").Append(Environment.NewLine);
            }

            Parallel.ForEach(numbers, i =>
            {
                var s = SingletonNoThreadSafeImp.Instance;
                s.callSingleton();
                var resultText = string.Format("This is call number: {0}", s.TotalNumberOfCalls);
                result.Append(resultText).Append(Environment.NewLine);
            });
            result.Append(string.Format("The total calls number: {0}", s1.TotalNumberOfCalls)).Append(Environment.NewLine);
            return new JsonResult(result.ToString());
        }

        [HttpGet]
        [Route("threadsafe")]
        public IActionResult GetThreadSafetyResult()
        {
            StringBuilder result = new StringBuilder();
            var numbers = Enumerable.Range(0, 10);
            ThreadSafetySingletonImp s1 = ThreadSafetySingletonImp.Instance;
            ThreadSafetySingletonImp s2 = ThreadSafetySingletonImp.Instance;
            // Test for same instance
            if (s1 == s2)
            {
                result.Append("Objects are the same instance").Append(Environment.NewLine);
            }

            Parallel.ForEach(numbers, i =>
            {
                var s = ThreadSafetySingletonImp.Instance;
                s.callSingleton();
                var resultText = string.Format("This is call number: {0}", s.TotalNumberOfCalls);
                result.Append(resultText).Append(Environment.NewLine);
            });
            result.Append(string.Format("The total calls number: {0}", s1.TotalNumberOfCalls)).Append(Environment.NewLine);
            return new JsonResult(result.ToString());
        }

        [HttpGet]
        [Route("doublelock")]
        public IActionResult GetNoDoubleLockSafeResult()
        {
            StringBuilder result = new StringBuilder();
            var numbers = Enumerable.Range(0, 10);
            DoubleCheckLockThreadSafetySingletonImp s1 = DoubleCheckLockThreadSafetySingletonImp.Instance;
            DoubleCheckLockThreadSafetySingletonImp s2 = DoubleCheckLockThreadSafetySingletonImp.Instance;
            // Test for same instance
            if (s1 == s2)
            {
                result.Append("Objects are the same instance").Append(Environment.NewLine);
            }

            Parallel.ForEach(numbers, i =>
            {
                var s = DoubleCheckLockThreadSafetySingletonImp.Instance;
                s.callSingleton();
                var resultText = string.Format("This is call number: {0}", s.TotalNumberOfCalls);
                result.Append(resultText).Append(Environment.NewLine);
            });
            result.Append(string.Format("The total calls number: {0}", s1.TotalNumberOfCalls)).Append(Environment.NewLine);
            return new JsonResult(result.ToString());
        }

        [HttpGet]
        [Route("lazyloading")]
        public IActionResult GetLazySingletonResult()
        {
            StringBuilder result = new StringBuilder();
            var numbers = Enumerable.Range(0, 10);
            DotNetLazyTypeSingletonImp s1 = DotNetLazyTypeSingletonImp.Instance;
            DotNetLazyTypeSingletonImp s2 = DotNetLazyTypeSingletonImp.Instance;
            // Test for same instance
            if (s1 == s2)
            {
                result.Append("Objects are the same instance").Append(Environment.NewLine);
            }

            Parallel.ForEach(numbers, i =>
            {
                var s = DotNetLazyTypeSingletonImp.Instance;
                s.callSingleton();
                var resultText = string.Format("This is call number: {0}", s.TotalNumberOfCalls);
                result.Append(resultText).Append(Environment.NewLine);
            });
            result.Append(string.Format("The total calls number: {0}", s1.TotalNumberOfCalls)).Append(Environment.NewLine);
            return new JsonResult(result.ToString());
        }
    }
}
