using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using AkshaakWebAPI.ActionFilters;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using VMD.RESTApiResponseWrapper.Net;
using VMD.RESTApiResponseWrapper.Net.Filters;

namespace AkshaakWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }

                  

            );

            //for API responses


            config.Filters.Add(new LoggingFilterAttribute());
            config.Filters.Add(new GlobalExceptionAttribute());


            config.Filters.Add(new ApiExceptionFilter());
            config.MessageHandlers.Add(new WrappingHandler());

        }
    }
}
