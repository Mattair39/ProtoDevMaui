﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoDevMaui.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image {  get; set; }
        public short? ParentId { get; set; }
        public bool IsMainCategory => ParentId == 0;
    }

}
