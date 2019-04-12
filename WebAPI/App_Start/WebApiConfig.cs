using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            //Enable CORS
            config.EnableCors(new EnableCorsAttribute("http://localhost:4200", headers:"*", methods:"*"));

            // Web API configuration and services
            //changing default xml format to json
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));

            //config.MapHttpAttributeRoutes();

            // Web API routes
            //changing api mapping 


            //config.MapHttpAttributeRoutes(); //Don't miss this

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = System.Web.Http.RouteParameter.Optional }
            //);
            
            //config.Routes.MapHttpRoute("DefaultApiWithId", "Api/{controller}/{id}", new { id = RouteParameter.Optional }, new { id = @"\d+" });
            //config.Routes.MapHttpRoute("DefaultApiWithAction", "Api/{controller}/{action}");

            config.Routes.MapHttpRoute(
                name: "ActionApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.MapHttpAttributeRoutes();
        }
    }
}
