using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPatternAPI.Models
{
    public class Requisition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RequestedBy { get; set; }
        public DateTime RequestedTime { get; set; }
        public bool IsActive { get; set; }
    }
}
