﻿using EntityData.Common;

namespace EntityData.Models
{
    public class Location : EntityBase<Guid>
    {
        public double Lat { get; set; }

        public double Long { get; set; }

        public string Address { get; set; }

        public string AddressDetails { get; set; }

        public string Codepost { get; set; }

    }
}
