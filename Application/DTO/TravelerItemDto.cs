using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class TravelerItemDto
    {
        public string Name { get; set; }
        public uint Quantity { get; set; }
        public bool IsTaken { get; set; }
    }
}
