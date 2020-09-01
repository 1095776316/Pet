using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using Pet.Core.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Pet.Application.Attriubtes
{
    public class LocalizedDescriptionAttribute : DescriptionAttribute
    {
        private  IStringLocalizer _l;
        public LocalizedDescriptionAttribute()
        : base()
        {
            Instance();
        }
        public LocalizedDescriptionAttribute(string desc)
        : base(desc)
        {
            Instance();
        }

        private void Instance()
        {
            var options = Options.Create(new LocalizationOptions());  
            var factory = new ResourceManagerStringLocalizerFactory(options, NullLoggerFactory.Instance);
            var l = new StringLocalizer<PetLocalization>(factory);
            _l = l;
        }
        public override string Description
        {
            get { return _l[base.DescriptionValue]; }
        }
    }
}
