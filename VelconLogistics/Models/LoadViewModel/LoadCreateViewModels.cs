using Microsoft.AspNetCore.Mvc.Rendering;
using System;using System.Collections.Generic;
using System.Linq;
using VelconLogistics.Models;

namespace VelconLogistics.Models.LoadViewModel
{
    public class LoadCreateViewModels
    {

        public Load Load { get; set; }
        public List<Driver> AvailableDriver { get; set; }

        // NOTE: Here we use an expression bodied, read-only property
        //       AND the ?. operator
        //       ...good times....
        public List<SelectListItem> AvailableOption
        {
            get
            {
                if (AvailableDriver == null)
                {
                    return null;
                }

                var apt = AvailableDriver?.Select(d => new SelectListItem(d.FullName, d.Id.ToString())).ToList();
                apt.Insert(0, new SelectListItem("Select Driver", "Add Driver"));

                return apt;
            }
        }
    }
}
