using Serenity.Navigation;
using MyPages = FinalPractice.SportDB.Pages;

// order navigation in de SiteBar
[assembly: NavigationMenu(8000, "Sport Shop", icon: "fa-soccer-ball-o")]
[assembly: NavigationLink(8000, "Sport Shop/Product", typeof(MyPages.ProductController), icon: "fa-shopping-cart")]
[assembly: NavigationLink(8000, "Sport Shop/Customer", typeof(MyPages.CustomerController), icon: "fa-user")]
[assembly: NavigationLink(8000, "Sport Shop/Orders", typeof(MyPages.OrderController), icon: "fa-ticket")]
