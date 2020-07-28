using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CustomerManagementApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        //firmaları getir
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "FirmaA", "FirmaB", "FirmaC", "FirmaD", "FirmaE", };
        }
    }
}
