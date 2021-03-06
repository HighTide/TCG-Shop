﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;

namespace TCGshopTestEnvironment.Views.Manage
{
    public static class ManageNavPages
    {
        public static string ActivePageKey => "ActivePage";

        public static string Index => "Index";

        public static string ChangePassword => "ChangePassword";

        public static string Orders => "Orders";

        public static string Orderdetails => "Orderdetails";

        public static string UserManagement => "UserManagement";

        public static string NewProduct => "UserManagement";

        public static string NewAuction => "NewAuction";

        public static string ManageCategories => "ManageCategories";

        public static string IndexNavClass(ViewContext viewContext) => PageNavClass(viewContext, Index);

        public static string ChangePasswordNavClass(ViewContext viewContext) => PageNavClass(viewContext, ChangePassword);

        public static string OrdersNavClass(ViewContext viewContext) => PageNavClass(viewContext, Orders);

        public static string NewProductNavClass(ViewContext viewContext) => PageNavClass(viewContext, Orderdetails);

        public static string NewAuctionNavClass(ViewContext viewContext) => PageNavClass(viewContext, NewAuction);
        public static string UserManagementNavClass(ViewContext viewContext) => PageNavClass(viewContext, UserManagement);

        public static string ManageCategoriesNavClass(ViewContext viewContext) => PageNavClass(viewContext, ManageCategories);

        public static string PageNavClass(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string;
            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
        }

        public static void AddActivePage(this ViewDataDictionary viewData, string activePage) => viewData[ActivePageKey] = activePage;
    }
}