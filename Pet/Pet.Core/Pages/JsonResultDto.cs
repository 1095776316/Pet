using Pet.Core.Enums;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Pet.Core
{
    public class JsonResultDto
    {
        public ReponseStatus Code { get; set; }

        public string Message { get; set; }

        public IReadOnlyCollection<string> Errors { get; set; }

        public object Data { get; set; }
    }
}
