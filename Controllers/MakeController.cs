using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using vega.Models;

namespace vega.Controllers
{
    public class MakeController
    {
        
        
        public MakeController()
        {
            
        }

        [HttpGet("/api/makes")]
        public IEnumerable<Make> Get(){
            
            return null;
        }
    }
}