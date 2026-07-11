using Microsoft.EntityFrameworkCore;
using HuongQueViet.Data;
using HuongQueViet.Models;
using HuongQueViet.Services;
using Xunit;

namespace HuongQueViet.Tests
{
    public class CouponServiceTests
    {
        private AppDbContext GetInMemoryContext()
            => new(new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options);

        [Fact]
        public async Task ValidateAndCalculate_ExpiredCoupon_ReturnsInvalid()
        {
            var context = GetInMemoryContext();
            context.Coupons.Add(new Coupon { Code = "OLD10", DiscountType = DiscountType.Percentage, DiscountValue = 10, ExpiryDate = DateTime.Now.AddDays(-1), IsActive = true });
            await context.SaveChangesAsync();

            var (isValid, _, discount) = await new CouponService(context).ValidateAndCalculate("OLD10", 200000);

            Assert.False(isValid);
            Assert.Equal(0, discount);
        }

        [Fact]
        public async Task ValidateAndCalculate_ValidPercentageCoupon_CalculatesCorrectly()
        {
            var context = GetInMemoryContext();
            context.Coupons.Add(new Coupon { Code = "SALE10", DiscountType = DiscountType.Percentage, DiscountValue = 10, ExpiryDate = DateTime.Now.AddDays(30), IsActive = true });
            await context.SaveChangesAsync();

            var (isValid, _, discount) = await new CouponService(context).ValidateAndCalculate("SALE10", 200000);

            Assert.True(isValid);
            Assert.Equal(20000, discount);
        }

        [Fact]
        public async Task ValidateAndCalculate_BelowMinOrderValue_ReturnsInvalid()
        {
            var context = GetInMemoryContext();
            context.Coupons.Add(new Coupon { Code = "BIG50", DiscountType = DiscountType.FixedAmount, DiscountValue = 50000, ExpiryDate = DateTime.Now.AddDays(30), MinOrderValue = 300000, IsActive = true });
            await context.SaveChangesAsync();

            var (isValid, message, _) = await new CouponService(context).ValidateAndCalculate("BIG50", 100000);

            Assert.False(isValid);
            Assert.Contains("tối thiểu", message);
        }
    }
}
