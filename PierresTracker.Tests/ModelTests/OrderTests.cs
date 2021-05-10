using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresTracker.Models;
using System.Collections.Generic;
using System;

namespace PierresTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
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
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string description1 = "10 loaves of bread";
      string description2 = "50 pastries";
      Order newOrder1 = new Order(description1);
      Order newOrder2 = new Order(description2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
} 