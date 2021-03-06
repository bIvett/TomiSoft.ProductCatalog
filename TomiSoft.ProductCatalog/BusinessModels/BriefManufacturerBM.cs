﻿using System;
using TomiSoft.ProductCatalog.BusinessModels.Concepts;

namespace TomiSoft.ProductCatalog.BusinessModels {
    public class BriefManufacturerBM {
        public BriefManufacturerBM(ManufacturerIdBM manufacturerId, string name, ManufacturerLocationBM location, Uri websiteUri) {
            ManufacturerId = manufacturerId;
            Name = name;
            Location = location;
            WebsiteUri = websiteUri;
        }

        public ManufacturerIdBM ManufacturerId { get; }
        public string Name { get; }
        public ManufacturerLocationBM Location { get; }
        public Uri WebsiteUri { get; }
    }
}
