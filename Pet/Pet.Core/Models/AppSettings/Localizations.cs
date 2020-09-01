using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Core.Dto.AppSettings
{
    public class LocalizationModel
    {
        public string Localizations = "Localizations";
        public List<LanguageModel> Languages { get; set; }
    }

    public class LanguageModel
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
