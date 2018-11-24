using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hack.Models
{
    public class Option
    {
        [Key]
        public int Id { get; set; }
        public int SpotId { get; set; }
        public int SurfaceId { get; set; }
        public string Description { get; set; }
    }
}