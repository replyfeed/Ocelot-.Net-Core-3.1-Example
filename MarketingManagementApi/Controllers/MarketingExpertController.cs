using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MarketingManagementApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarketingExpertController : Controller
    {
        //pazarlama uzmlanlarını getir
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Uzman1", "Uzman2", "Uzman3", "Uzman4", "Uzman5", };
        }
    }
}
