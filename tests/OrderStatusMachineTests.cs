using HuongQueViet.Helpers;
using HuongQueViet.Models;
using Xunit;

namespace HuongQueViet.Tests
{
    public class OrderStatusMachineTests
    {
        [Theory]
        [InlineData(OrderStatus.Pending, OrderStatus.Confirmed, true)]
        [InlineData(OrderStatus.Delivering, OrderStatus.Cancelled, false)] // rule quan trọng: không hủy khi đang giao
        [InlineData(OrderStatus.Preparing, OrderStatus.Delivering, true)]
        [InlineData(OrderStatus.Completed, OrderStatus.Pending, false)]
        public void CanTransition_ReturnsExpectedResult(OrderStatus from, OrderStatus to, bool expected)
        {
            Assert.Equal(expected, OrderStatusMachine.CanTransition(from, to));
        }
    }
}
