using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.AspNetCore.Mvc.DataAnnotations.Internal;
using Microsoft.Extensions.DependencyInjection;
using Pet.Core.Localization;
using System;

namespace Pet.Application.Extensions
{
    [Obsolete("使用报错，不知道咋解决")]
    public static class CustomDataAnnotationsLocalizationExtendsion
    {
        public static IMvcBuilder AddCustomDataAnnotationsLocalization(this IMvcBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            Action<MvcDataAnnotationsLocalizationOptions> action = new Action<MvcDataAnnotationsLocalizationOptions>(options =>
            {
                options.DataAnnotationLocalizerProvider =
                (type, factory) =>
                factory.Create(typeof(PetLocalization));
            });
            DataAnnotationsLocalizationServices
                .AddDataAnnotationsLocalizationServices(
                     builder.Services, action);
            return builder;
        }
    }
}
