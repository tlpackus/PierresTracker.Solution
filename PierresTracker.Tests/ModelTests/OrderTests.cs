using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresTracker.Models;
using System.Collections.Generic;
using System;

namespace PierresTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetOrderDetails_ReturnsOrderDetails_String()
    {
      //Arrange
      string orderDetails = "5 Loaves of bread";

      //Act
      Order newOrder = new Order(orderDetails);
      string result = newOrder.OrderDetails;

      //Assert
      Assert.AreEqual(orderDetails, result);
    }
  }
} 