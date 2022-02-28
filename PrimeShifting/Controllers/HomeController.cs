using Microsoft.AspNetCore.Mvc;
using Primes.Models;

namespace Primes.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Home()
    {
      return View();
    }
    [Route("/primes")]
    public ActionResult Primes(string userNumber)
    {

      Prime userPrime = new Prime();
      userPrime.UserNumber = int.Parse(userNumber);
      userPrime.GetPrimes();
      return View(userPrime);
    }
  }
}
