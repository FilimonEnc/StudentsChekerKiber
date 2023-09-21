﻿using System;

namespace StudentsChekerKiber.Data.Entity
{
    public class BaseEntity
    {

        public int Id { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime DateUpdated { get; set; }

        public bool Status { get; set; }

    }
}
