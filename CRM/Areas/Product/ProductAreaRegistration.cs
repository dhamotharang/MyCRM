﻿using System.Web.Mvc;

namespace CRM.Areas.Product
{
    public class ProductAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Product";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            //context.MapRoute(
            //    "Product_default",
            //    "Product/{controller}/{action}/{id}",
            //    new { action = "Index", id = UrlParameter.Optional }
            //);

            context.MapRoute(
              "Product_default",
              "Product/{controller}/{action}/{id}/{temp}/{cid}",
              new { action = "Index", id = UrlParameter.Optional, temp = UrlParameter.Optional, cid = UrlParameter.Optional }
          );
           
        }
    }
}