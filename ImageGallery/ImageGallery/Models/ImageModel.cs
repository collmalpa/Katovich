﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImageGallery.Models
{
    public class ImageModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string ImageSmall { get; set; }
    }
}