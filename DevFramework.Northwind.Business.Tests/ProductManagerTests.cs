﻿using DevFramework.Northwind.Business.Concrete.Manager;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.Concrete;
using FluentValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace DevFramework.Northwind.Business.Tests
{
    [TestClass]
    public class ProductManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_validation_check()  // Test did not worked. Postsharp error occurs.
        {
            //Mock<IProductDal> mock = new Mock<IProductDal>();

            //ProductManager productManager = new ProductManager(mock.Object);
            //productManager.Add(new Product());
        }
    }
}
