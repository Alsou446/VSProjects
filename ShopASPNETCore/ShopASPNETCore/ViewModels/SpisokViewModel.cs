﻿using ShopASPNETCore.Data.Models;
using System.Collections.Generic;

namespace ShopASPNETCore.ViewModels
{
    public class SpisokViewModel
    {
        public IEnumerable<Task> allTasks { get; set; }

        public string curList { get; set; }
    }
}
