using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pet.Application.Extensions
{
    public static class BaseControllerAsServiceExtensioncs
    {
        public static IMvcBuilder AddBaseControllerAsService(this IMvcBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            var feature = new ControllerFeature();
            builder.PartManager.PopulateFeature(feature);

            foreach (var controller in feature.Controllers.Select(c => c.AsType()))
            {
                builder.Services.TryAddTransient(controller,controller);
            }
            builder.Services.Replace(ServiceDescriptor.Transient<IControllerActivator, ServiceBasedControllerActivator>());
            return builder;
        }
    }
}
