namespace HuongQueViet.Models
{
    public enum DiscountType { Percentage, FixedAmount }

    public class Coupon
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public DiscountType DiscountType { get; set; }
        public decimal DiscountValue { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal MinOrderValue { get; set; }
        public bool IsActive { get; set; } = true;
    }

    public class Review
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public string UserId { get; set; } = string.Empty;
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }

    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Unit { get; set; } = string.Empty;
        public decimal StockQuantity { get; set; }
        public decimal LowStockThreshold { get; set; } = 5;
    }

    public class ProductIngredient
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int IngredientId { get; set; }
        public Ingredient? Ingredient { get; set; }
        public decimal QuantityNeeded { get; set; }
    }

    public class InventoryLog
    {
        public int Id { get; set; }
        public int IngredientId { get; set; }
        public decimal Change { get; set; }
        public string Reason { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }

    public class UserListViewModel
    {
        public string Id { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public List<string> Roles { get; set; } = new();
        public bool IsLockedOut { get; set; }
    }

    public class StatisticsViewModel
    {
        public decimal TotalRevenue { get; set; }
        public int TotalOrders { get; set; }
        public List<StatusCount> OrdersByStatus { get; set; } = new();
        public List<DailyRevenue> RevenueByDay { get; set; } = new();
        public List<ProductSales> TopProducts { get; set; } = new();
    }
    public class StatusCount { public string Status { get; set; } = string.Empty; public int Count { get; set; } }
    public class DailyRevenue { public DateTime Date { get; set; } public decimal Revenue { get; set; } }
    public class ProductSales { public string ProductName { get; set; } = string.Empty; public int QuantitySold { get; set; } }
}
