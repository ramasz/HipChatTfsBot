﻿using System.Web.Http;

namespace HipChat.TfsBot.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "HipChatTfsBot",
                routeTemplate: "",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
