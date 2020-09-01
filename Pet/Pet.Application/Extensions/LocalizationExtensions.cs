using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using Pet.Core.Dto.AppSettings;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Pet.Application.Extensions
{
    public static class LocalizationExtensions
    {
        public static IApplicationBuilder UseCustomRequestLocalization(this IApplicationBuilder app,
            LocalizationModel localization)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            if (localization == null)
            {
                throw new ArgumentNullException(nameof(localization));
            }
            if (localization?.Languages?.Count == 0)
            {
                throw new ArgumentNullException(nameof(localization.Languages));
            }
            IList<CultureInfo> cultures = new List<CultureInfo>();
            foreach (var item in localization.Languages)
            {
                cultures.Add(new CultureInfo(item.Code));
            }

            RequestLocalizationOptions options = new RequestLocalizationOptions()
            {
                DefaultRequestCulture = new RequestCulture(cultures[0]),
                SupportedCultures = cultures,
                SupportedUICultures = cultures
            };
            options.RequestCultureProviders.Clear();
            options.RequestCultureProviders.Add(new QueryStringRequestCultureProvider());
            return app.UseMiddleware<RequestLocalizationMiddleware>(Options.Create(options));
        }
    }
}
