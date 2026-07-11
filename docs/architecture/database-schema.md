# Thiết kế cơ sở dữ liệu — Hương Quê Việt

## Sơ đồ quan hệ (ERD dạng văn bản)

```
ApplicationUser 1───N Order
ApplicationUser 1───N Address
ApplicationUser 1───N Review
Address         1───N Order
Category        1───N Product
Product         1───N OrderItem
Product         1───N Review
Product         1───N ProductIngredient
Order           1───N OrderItem
Ingredient      1───N ProductIngredient
Ingredient      1───N InventoryLog
DeliveryZone    (tra cứu theo Province+District, không FK trực tiếp)
Coupon          (tham chiếu qua mã Code dạng chuỗi tại Order.CouponCode)
```

## Chi tiết các bảng

### ApplicationUser (kế thừa IdentityUser)
| Cột | Kiểu | Ghi chú |
|---|---|---|
| Id | string (GUID) | Khóa chính |
| UserName / Email | string | Từ IdentityUser |
| PasswordHash | string | Mật khẩu đã băm |
| PhoneNumber | string | Từ IdentityUser, bắt buộc nhập khi đăng ký |
| FullName | string | Mở rộng riêng cho hệ thống |

### Category
| Cột | Kiểu | Ghi chú |
|---|---|---|
| Id | int | Khóa chính |
| Name | string | Tên danh mục |

### Product
| Cột | Kiểu | Ghi chú |
|---|---|---|
| Id | int | Khóa chính |
| Name, Description | string | |
| Price | decimal | |
| StockQuantity | int | Dùng khi không quản lý theo nguyên liệu |
| CategoryId | int (FK) | → Category |
| ImageUrl | string? | Đường dẫn ảnh sau khi upload |
| IsActive | bool | Còn kinh doanh / đã ẩn (xóa mềm) |
| IsSpicy, IsFeatured | bool | Cờ hiển thị |
| CreatedAt | datetime | Phục vụ sắp xếp "món mới nhất" |

### Order
| Cột | Kiểu | Ghi chú |
|---|---|---|
| Id | int | Khóa chính |
| UserId | string (FK) | → ApplicationUser |
| AddressId | int (FK) | → Address |
| OrderDate | datetime | |
| TotalAmount | decimal | Đã gồm ship, trừ giảm giá |
| Status | enum | Pending/Confirmed/Preparing/Delivering/Completed/Cancelled |
| ShippingFee | decimal | |
| ETA | datetime? | |
| PaymentMethod | string | COD / VNPay |
| IsPaid | bool | |
| TransactionId | string? | Mã giao dịch VNPay |
| CouponCode | string? | |
| DiscountAmount | decimal | |

### OrderItem
| Cột | Kiểu | Ghi chú |
|---|---|---|
| Id | int | Khóa chính |
| OrderId | int (FK) | |
| ProductId | int (FK) | |
| Quantity | int | |
| UnitPrice | decimal | Lưu giá tại thời điểm đặt, không tham chiếu Price hiện tại |

### Address
| Cột | Kiểu | Ghi chú |
|---|---|---|
| Id | int | Khóa chính |
| UserId | string (FK) | |
| Province, District, Ward, Street | string | |
| Lat, Lng | double | Dùng tính khoảng cách (Haversine) |
| IsDefault | bool | |

### DeliveryZone
| Cột | Kiểu | Ghi chú |
|---|---|---|
| Id | int | Khóa chính |
| Province, District | string | Khóa tra cứu (không phải FK) |
| BaseFee | decimal | |
| FeePerKm | decimal | |

### Coupon
| Cột | Kiểu | Ghi chú |
|---|---|---|
| Id | int | Khóa chính |
| Code | string | |
| DiscountType | enum | Percentage / FixedAmount |
| DiscountValue | decimal | |
| ExpiryDate | datetime | |
| MinOrderValue | decimal | |
| IsActive | bool | |

### Review
| Cột | Kiểu | Ghi chú |
|---|---|---|
| Id | int | Khóa chính |
| ProductId, UserId | FK | |
| Rating | int | 1-5 |
| Comment | string | |
| CreatedAt | datetime | |

### Ingredient
| Cột | Kiểu | Ghi chú |
|---|---|---|
| Id | int | Khóa chính |
| Name, Unit | string | |
| StockQuantity | decimal | |
| LowStockThreshold | decimal | Ngưỡng cảnh báo |

### ProductIngredient (bảng trung gian — công thức chế biến)
| Cột | Kiểu | Ghi chú |
|---|---|---|
| Id | int | Khóa chính |
| ProductId, IngredientId | FK | |
| QuantityNeeded | decimal | Lượng nguyên liệu cần cho 1 phần |

### InventoryLog
| Cột | Kiểu | Ghi chú |
|---|---|---|
| Id | int | Khóa chính |
| IngredientId | FK | |
| Change | decimal | Âm = tiêu hao, dương = nhập kho |
| Reason | string | |
| CreatedAt | datetime | |
