using Serenity.Navigation;
using MyPages = FinalPractice.SportDB.Pages;

[assembly: NavigationLink(int.MaxValue, "SportDB/Product", typeof(MyPages.ProductController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "SportDB/Customer", typeof(MyPages.CustomerController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "SportDB/Order", typeof(MyPages.OrderController), icon: null)]