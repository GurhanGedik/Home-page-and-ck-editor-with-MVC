﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLoginPageAndCKEditor.Models.Entities
{
    public class Blogs
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
    }
}