using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GisRoutes.Dto
{
    public class Address
    {
        public string street { get; set; }
        public string Zone { get; set; }
        public string township { get; set; }
        public string department { get; set; }
    }
}
