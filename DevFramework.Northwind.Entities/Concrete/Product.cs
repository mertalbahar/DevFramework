﻿using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.Entities.Concrete
{
    public class Product : IEntity
    {
        public virtual int ProductId { get; set; }
        public virtual int? CategoryId { get; set; }
        public virtual int? SupplierId { get; set; }
        public virtual string ProductName { get; set; }
        public virtual string QuantityPerUnit { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual Int16 UnitsInStock { get; set; }
        public virtual Int16 UnitsOnOrder { get; set; }
        public virtual Int16 ReorderLevel { get; set; }
        public virtual bool Discontinued { get; set; }
    }
}
