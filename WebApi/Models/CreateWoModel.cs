using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class CreateWoModel
    {
        public string Caller { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Priority { get; set; }
    }
}
