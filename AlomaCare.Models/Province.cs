﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class Province
    {
        [Key]
        public int ProvinceId { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public List<City> Cities { get; set; } = [];

    }
}
