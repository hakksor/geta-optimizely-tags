﻿using System.Web.Mvc;
using System.Web.Routing;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;

namespace Geta.Tags
{
    [InitializableModule]
    public class InitializeModule : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            RouteTable.Routes.MapRoute(
                "GetaTags", 
                "getatags",
                new { action = "Index", controller = "GetaTags" });
        }

        public void Uninitialize(InitializationEngine context)
        {
        }
        
        public void Preload(string[] parameters)
        {
        }
    }
}