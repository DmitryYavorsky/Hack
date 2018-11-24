using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hack.Models
{
    public class ViewModel
    {
        public SelectList spots { get; set; }
        public SelectList surfaces { get; set; }
        public int? SpotId { get; set; }
        public int? SurfaceId { get; set; }
    }
}