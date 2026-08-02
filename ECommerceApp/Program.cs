using ECommerceApp.models;
using System.Linq;
namespace ECommerceApp
{
   public class Program
    {
        static Appcontext context = new Appcontext();
        static int loggedInUserId = 0;

        static void Main(string[] args)
        {
            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine("E-Commerce Console App ");
                Console.WriteLine("1. Register New User");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Add New Category");
                Console.WriteLine("4. Add New Product");
                Console.WriteLine("5. View All Products");
                Console.WriteLine("6. Place an Order");
                Console.WriteLine("7. View My Orders");
                Console.WriteLine("8. View Order Details");
                Console.WriteLine("9. Add a Review");
                Console.WriteLine("10. View Reviews");
                Console.WriteLine("11. Logout");
                Console.WriteLine("0. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        RegisterUser(); 
                        break;
                    case 2: 
                        Login(); 
                        break;
                    case 3:
                        AddCategory();
                        break;
                    case 4:
                        AddProduct();
                        break;
                    case 5:
                        ViewAllProducts();
                        break;
                    case 6:
                        PlaceOrder();
                        break;
                    case 7:
                        ViewMyOrders();
                        break;
                    case 8:
                        ViewOrderDetails();
                        break;
                    case 9:
                        AddReview();
                        break;
                    case 10: 
                        ViewReviewsForProduct(); 
                        break;
                    case 11:
                        Logout(); 
                        break;
                    case 0: 
                        exitApp = true; 
                        break;
                }
            }
        }

        static void RegisterUser() 
        {
            User user = new User();

            Console.Write("Enter Name: ");
            user.Name = Console.ReadLine();

            Console.Write("Enter Email: ");
            user.Email = Console.ReadLine();

            Console.Write("Enter Password: ");
            user.Password = Console.ReadLine();

            context.Users.Add(user);
            context.SaveChanges();

            Console.WriteLine("User registered successfully.");

        }
        static void Login()
        {
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            User user = context.Users
                .FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                loggedInUserId = user.UserId;
                Console.WriteLine("Login successful.");
            }
            else
            {
                Console.WriteLine("Invalid email or password.");
            }
        }
        static void AddCategory()
        {
            Category category = new Category();

            Console.Write("Enter Category Name: ");
            category.Name = Console.ReadLine();

            context.Categories.Add(category);
            context.SaveChanges();

            Console.WriteLine("Category added successfully.");
        }
        static void AddProduct() {
            Product product = new Product();

            Console.Write("Enter Product Name: ");
            product.Name = Console.ReadLine();

            Console.Write("Enter Product Price: ");
            product.Price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Available Categories:");

            foreach (var category in context.Categories)
            {
                Console.WriteLine($"{category.CategoryId} - {category.Name}");
            }

            Console.Write("Enter Category ID: ");
            product.CategoryId = int.Parse(Console.ReadLine());

            context.Products.Add(product);
            context.SaveChanges();

            Console.WriteLine("Product added successfully.");
        }
        
        static void ViewAllProducts() {

            var products = context.Products.ToList();

            if (products.Count == 0)
            {
                Console.WriteLine("No products found.");
                return;
            }

            foreach (var product in products)
            {
                var category = context.Categories
                    .FirstOrDefault(c => c.CategoryId == product.CategoryId);

                Console.WriteLine(
                    $"ID: {product.ProductId} | Name: {product.Name} | Price: {product.Price} | Category: {category?.Name}");
            }
        }
        static void PlaceOrder() {
            if (loggedInUserId == 0)
            {
                Console.WriteLine("Please login first.");
                return;
            }

            Order order = new Order();
            order.UserId = loggedInUserId;
            order.OrderDate = DateTime.Now;

            context.Orders.Add(order);
            context.SaveChanges();

            string choice;

            do
            {
                Console.WriteLine("\nAvailable Products:");

                foreach (var product in context.Products)
                {
                    Console.WriteLine($"{product.ProductId} - {product.Name} - {product.Price}");
                }

                Console.Write("Enter Product ID: ");
                int productId = int.Parse(Console.ReadLine());

                Console.Write("Enter Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderProduct orderProduct = new OrderProduct
                {
                    OrderId = order.OrderId,
                    ProductId = productId,
                    Quantity = quantity
                };

                context.OrderProducts.Add(orderProduct);
                context.SaveChanges();

                Console.Write("Add another product? (y/n): ");
                choice = Console.ReadLine().ToLower();

            } while (choice == "y");

            Console.WriteLine("Order placed successfully.");
        }
        static void ViewMyOrders() {
            if (loggedInUserId == 0)
            {
                Console.WriteLine("Please login first.");
                return;
            }

            var orders = context.Orders
                .Where(o => o.UserId == loggedInUserId)
                .ToList();

            if (orders.Count == 0)
            {
                Console.WriteLine("No orders found.");
                return;
            }

            foreach (var order in orders)
            {
                Console.WriteLine($"Order ID: {order.OrderId} Date: {order.OrderDate}");
            }

        }
        static void ViewOrderDetails() {
            Console.Write("Enter Order ID: ");
            int orderId = int.Parse(Console.ReadLine());

            var order = context.Orders.FirstOrDefault(o => o.OrderId == orderId);

            if (order == null)
            {
                Console.WriteLine("Order not found.");
                return;
            }

            var items = context.OrderProducts.Where(op => op.OrderId == orderId).ToList();

            decimal total = 0;

            foreach (var item in items)
            {
                var product = context.Products.FirstOrDefault(p => p.ProductId == item.ProductId);

                decimal subTotal = product.Price * item.Quantity;
                total += subTotal;

                Console.WriteLine($"{product.Name} - Qty: {item.Quantity} - Price: {product.Price}");
            }

            Console.WriteLine($"Total = {total}");

            var review = context.Reviews.FirstOrDefault(r => r.OrderId == orderId);

            if (review != null)
            {
                Console.WriteLine($"Rating: {review.Rating}");
                Console.WriteLine($"Comment: {review.Comment}");
            }
            else
            {
                Console.WriteLine("No review yet.");
            }
        }
        static void AddReview() {
            if (loggedInUserId == 0)
            {
                Console.WriteLine("Please login first.");
                return;
            }

            Console.Write("Enter Order ID: ");
            int orderId = int.Parse(Console.ReadLine());

            var order = context.Orders
                .FirstOrDefault(o => o.OrderId == orderId && o.UserId == loggedInUserId);

            if (order == null)
            {
                Console.WriteLine("Order not found.");
                return;
            }

            var existingReview = context.Reviews
                .FirstOrDefault(r => r.OrderId == orderId);

            if (existingReview != null)
            {
                Console.WriteLine("This order already has a review.");
                return;
            }

            Review review = new Review();

            review.OrderId = orderId;

            Console.Write("Enter Rating: ");
            review.Rating = int.Parse(Console.ReadLine());

            Console.Write("Enter Comment: ");
            review.Comment = Console.ReadLine();

            context.Reviews.Add(review);
            context.SaveChanges();

            Console.WriteLine("Review added successfully.");
        }
        static void ViewReviewsForProduct() {

            Console.Write("Enter Product ID: ");
            int productId = int.Parse(Console.ReadLine());

            var orderProducts = context.OrderProducts
                .Where(op => op.ProductId == productId)
                .ToList();

            if (orderProducts.Count == 0)
            {
                Console.WriteLine("No reviews found.");
                return;
            }

            foreach (var item in orderProducts)
            {
                var review = context.Reviews
                    .FirstOrDefault(r => r.OrderId == item.OrderId);

                if (review != null)
                {
                    Console.WriteLine($"Rating: {review.Rating}");
                    Console.WriteLine($"Comment: {review.Comment}");
 
                }
            }
        }
        static void Logout() {

            loggedInUserId = 0;
            Console.WriteLine("Logged out successfully.");
        }
    }
}