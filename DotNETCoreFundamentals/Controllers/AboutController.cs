using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNETCoreFundamentals.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
        [Route("[action]")]
        public string Phone()
        {
            return "+84163-55-78900";
        }

        public string Address()
        {
            return "Vietnam";
        }
    }
}
