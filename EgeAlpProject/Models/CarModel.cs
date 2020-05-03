﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgeAlpProject.Models
{
    public class CarModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int CarBrandId { get; set; }
        //[ForeignKey("CategoryId")]
        public CarBrand CarBrand { get; set; }

    }
}
