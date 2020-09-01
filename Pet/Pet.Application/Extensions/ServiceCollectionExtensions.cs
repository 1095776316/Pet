using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Pet.Core.Dto.AppSettings;
using Pet.Core.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pet.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCustomLocalization(this IServiceCollection services,
            LocalizationModel localization
            )
        {
            if (localization == null)
            {
                throw new ArgumentNullException(nameof(localization));
            }
            if (localization?.Languages?.Count == 0)
            {
                throw new ArgumentNullException(nameof(localization.Languages));
            }
            services.AddSingleton<IStringLocalizer>((sp) =>
            {
                var sharedLocalizer = sp.GetRequiredService<IStringLocalizer<PetLocalization>>();
                return sharedLocalizer;
            });
            var langs = localization.Languages.Select(p => p.Code).ToArray();
            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.SetDefaultCulture(localization.Languages[0].Code)
                .AddSupportedCultures(langs)
                .AddSupportedUICultures(langs);
            });

            return services;
        }
    }
}
