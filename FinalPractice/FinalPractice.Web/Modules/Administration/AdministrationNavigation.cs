﻿using Serenity.Navigation;
using Administration = FinalPractice.Administration.Pages;

[assembly: NavigationMenu(2000, "Administration", icon: "fa-desktop")]
[assembly: NavigationLink(2000, "Administration/Exceptions Log", url: "~/errorlog.axd", permission: FinalPractice.Administration.PermissionKeys.Security, icon: "fa-ban", Target = "_blank")]
[assembly: NavigationLink(2000, "Administration/Languages", typeof(Administration.LanguageController), icon: "fa-comments")]
[assembly: NavigationLink(2000, "Administration/Translations", typeof(Administration.TranslationController), icon: "fa-comment-o")]
[assembly: NavigationLink(2000, "Administration/Roles", typeof(Administration.RoleController), icon: "fa-lock")]
[assembly: NavigationLink(2000, "Administration/User Management", typeof(Administration.UserController), icon: "fa-users")]