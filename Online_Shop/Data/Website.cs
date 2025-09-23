using Online_Shop.Models;
using System.Xml.Linq;

namespace Online_Shop.Data
{
    public class Website
    {
        public static List<Category> categories { get; set; }
        public static List<Product> products { get; set; }
        public static List<Item> items { get; set; }

        public static List<User> users { get; set; }
        public static User currentUser { get; set; }

        public static Cart cart { get; set; }

        static Website()
        {
            categories = new List<Category>();
            products = new List<Product>();
            items = new List<Item>();

            {
                AddNewCategory(1, "گوشی موبایل", "این دسته بندی شامل انواع گوشی‌های هوشمند و موبایل می‌باشد");
                AddNewCategory(2, "لپ‌تاپ", "این دسته بندی شامل انواع لپ‌تاپ‌ برای کاربری شخصی و حرفه‌ای می‌باشد");
                AddNewCategory(3, "تبلت", "این دسته بندی شامل انواع تبلت‌های اندروید و آیپد می‌باشد");
                AddNewCategory(4, "تلویزیون", "این دسته بندی شامل انواع تلویزیون‌های LED ،OLED و QLED می‌باشد");
                AddNewCategory(5, "سیستم صوتی", "این دسته بندی شامل اسپیکر، ساندبار و سینما خانگی می‌باشد");
                AddNewCategory(6, "دوربین دیجیتال", "این دسته بندی شامل دوربین‌های عکاسی و فیلمبرداری می‌باشد");
                AddNewCategory(7, "لوازم جانبی موبایل", "این دسته بندی شامل قاب، شارژر، پاوربانک و هندزفری می‌باشد");
                AddNewCategory(8, "کنسول بازی", "این دسته بندی شامل پلی‌استیشن، ایکس‌باکس و نینتندو می‌باشد");
                AddNewCategory(9, "لوازم هوشمند خانگی", "این دسته بندی شامل خانه هوشمند، لامپ و دستیار صوتی می‌باشد");
                AddNewCategory(10, "قطعات کامپیوتر", "این دسته بندی شامل کارت گرافیک، پردازنده و مادربرد می‌باشد");

                AddNewItem(1, "گوشی سامسونگ Galaxy S23", "گوشی هوشمند پرچمدار سامسونگ با نمایشگر AMOLED", 1, 5, 35000);
                AddNewItem(2, "گوشی آیفون 14", "جدیدترین گوشی اپل با پردازنده قدرتمند A16 Bionic", 1, 3, 55000);
                AddNewItem(3, "گوشی شیائومی Redmi Note 12", "گوشی میان‌رده با باتری قوی و دوربین سه‌گانه", 1, 8, 15000);

                AddNewItem(4, "لپ‌تاپ Dell XPS 15", "لپ‌تاپ حرفه‌ای مناسب کارهای سنگین و طراحی", 2, 2, 70000);
                AddNewItem(5, "لپ‌تاپ MacBook Air M2", "مک‌بوک جدید اپل با پردازنده M2", 2, 4, 65000);
                AddNewItem(6, "لپ‌تاپ Asus TUF Gaming", "لپ‌تاپ گیمینگ اقتصادی با کارت گرافیک NVIDIA", 2, 6, 48000);

                AddNewItem(7, "تبلت iPad Pro 11", "تبلت قدرتمند اپل برای کارهای حرفه‌ای", 3, 5, 40000);
                AddNewItem(8, "تبلت Samsung Galaxy Tab S8", "تبلت اندرویدی با نمایشگر بزرگ و قلم S-Pen", 3, 3, 32000);

                AddNewItem(9, "تلویزیون LG OLED 55 اینچ", "تلویزیون OLED با کیفیت تصویر فوق‌العاده", 4, 2, 60000);
                AddNewItem(10, "تلویزیون Samsung QLED 65 اینچ", "تلویزیون هوشمند QLED با رزولوشن 4K", 4, 3, 75000);

                AddNewItem(11, "اسپیکر JBL Charge 5", "اسپیکر قابل حمل با صدای قوی و باتری طولانی", 5, 10, 6000);
                AddNewItem(12, "ساندبار Sony HT-S350", "ساندبار خانگی با صدای فراگیر", 5, 4, 12000);

                AddNewItem(13, "دوربین Canon EOS 90D", "دوربین حرفه‌ای DSLR با سنسور 32 مگاپیکسل", 6, 2, 45000);
                AddNewItem(14, "دوربین Sony Alpha A7 IV", "دوربین بدون آینه فول‌فریم برای عکاسی حرفه‌ای", 6, 1, 85000);

                AddNewItem(15, "پاوربانک Anker 20000mAh", "پاوربانک سریع و پرقدرت برای شارژ موبایل", 7, 15, 2500);
                AddNewItem(16, "هندزفری بی‌سیم AirPods Pro", "ایرپادز پرو اپل با نویز کنسلینگ", 7, 6, 9500);
                AddNewItem(17, "شارژر سریع سامسونگ 25W", "شارژر اصلی سامسونگ با فناوری فست شارژ", 7, 12, 1800);

                AddNewItem(18, "کنسول PlayStation 5", "کنسول نسل نهمی سونی با کنترلر DualSense", 8, 3, 62000);
                AddNewItem(19, "کنسول Xbox Series X", "کنسول مایکروسافت با پشتیبانی از بازی‌های 4K", 8, 2, 60000);
                AddNewItem(20, "نینتندو Switch OLED", "کنسول دستی و خانگی با نمایشگر OLED", 8, 4, 25000);

                AddNewItem(21, "دستیار صوتی Google Nest Mini", "اسپیکر هوشمند با پشتیبانی از دستیار گوگل", 9, 7, 3000);
                AddNewItem(22, "لامپ هوشمند Philips Hue", "لامپ هوشمند قابل کنترل با موبایل", 9, 10, 1200);
                AddNewItem(23, "جارو رباتیک Xiaomi", "جاروبرقی هوشمند با قابلیت نقشه‌برداری", 9, 3, 8000);

                AddNewItem(24, "کارت گرافیک NVIDIA RTX 4070", "کارت گرافیک قدرتمند برای بازی و رندرینگ", 10, 2, 75000);
                AddNewItem(25, "پردازنده Intel Core i9-13900K", "پردازنده نسل ۱۳ اینتل برای کامپیوترهای حرفه‌ای", 10, 3, 68000);
            }

            users = new List<User>();
            currentUser = null;

            cart = new Cart()
            {
                id = 1
            };
        }

        private static Category GetCategoryById(int id)
        {
            var category = categories.Find(c => c.id == id);
            return category ?? categories[0];
        }

        private static Product GetProductById(int id)
        {
            var product = products.Find(p => p.id == id);
            return product ?? products[0];
        }

        private static Item GetItemById(int id)
        {
            var item = items.Find(p => p.product.id == id);
            return item ?? items[0];
        }

        public static void AddNewCategory(int id, string name, string description)
        {
            categories.Add(new Category() { id = id, name = name, description = description });
        }

        public static void AddNewItem(int id, string name, string description, int categoryId, int count, int price)
        {
            products.Add(new Product() { id = id, name = name, description = description, category = GetCategoryById(categoryId) });
            items.Add(new Item() { product = GetProductById(id), count = count, price = price });
        }
    }
}
