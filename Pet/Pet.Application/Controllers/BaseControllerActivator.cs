using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Application.Controllers
{
    public class BaseControllerActivator : IControllerActivator
    {
        public object Create(ControllerContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var controllerType = context.ActionDescriptor.ControllerTypeInfo.AsType();

            var controller = context.HttpContext.RequestServices.GetRequiredService(controllerType);

            if (controller is BaseController baseController)
            {
                baseController.L = context.HttpContext.RequestServices.GetRequiredService<IStringLocalizer>();
            }
            return controller;
        }

        public void Release(ControllerContext context, object controller)
        {

        }
    }
}
