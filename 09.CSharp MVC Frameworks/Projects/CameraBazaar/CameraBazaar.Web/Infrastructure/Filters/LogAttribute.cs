﻿namespace CameraBazaar.Web.Infrastructure.Filters
{
    using System;
    using Microsoft.AspNetCore.Mvc.Filters;
    using System.IO;
    using System.Threading.Tasks;

    public class LogAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            using (var writer = new StreamWriter("logs.txt", true))
            {
                var dateTime = DateTime.UtcNow;
                var ipAddress = context.HttpContext.Connection.RemoteIpAddress;
                var userName = context.HttpContext.User?.Identity?.Name ?? "Anonymous";
                var controller = context.Controller.GetType().Name;
                //var action = context.ActionDescriptor.DisplayName;
                var action = context.RouteData.Values["action"];

                var logMessage = $"{dateTime} - {ipAddress} - {userName} - {controller}.{action}";

                if (context.Exception != null)
                {
                    var exceptionType = context.Exception.GetType().Name;
                    var exceptionMessage = context.Exception.Message;

                    logMessage = $"[!] {logMessage} - {exceptionType} - {exceptionMessage}";
                }

                writer.WriteLine(logMessage);
            }


            // ASYNC Version !
            //Task.Run(async () =>
            //{
            //    using (var writer = new StreamWriter("logs.txt", true))
            //    {
            //        var dateTime = DateTime.UtcNow;
            //        var ipAddress = context.HttpContext.Connection.RemoteIpAddress;
            //        var userName = context.HttpContext.User?.Identity?.Name ?? "Anonymous";
            //        var controller = context.Controller.GetType().Name;
            //        //var action = context.ActionDescriptor.DisplayName;
            //        var action = context.RouteData.Values["action"];

            //        var logMessage = $"{dateTime} - {ipAddress} - {userName} - {controller}.{action}";

            //        if (context.Exception != null)
            //        {
            //            var exceptionType = context.Exception.GetType().Name;
            //            var exceptionMessage = context.Exception.Message;

            //            logMessage = $"[!] {logMessage} - {exceptionType} - {exceptionMessage}";
            //        }

            //        await writer.WriteLineAsync(logMessage);
            //    }
            //})
            //.GetAwaiter()
            //.GetResult();

        }
    }
}