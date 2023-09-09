﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcBuilderWebApi.Models
{
    public class Ram
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string? MemoryType { get; set; }
        public int? MemorySize { get; set; }
        public byte? Nmodule { get; set; }
        public string? MemoryHerz { get; set; }
       
        public string? Mass { get; set; }
        public decimal? Price { get; set; }
        public string ImageName { get; set; }
        public string? ImageNamePng { get; set; }
    }
}
