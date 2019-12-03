﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCRUDApp.Shared.Models
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
