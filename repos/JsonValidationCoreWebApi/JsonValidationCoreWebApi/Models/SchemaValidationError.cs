﻿using Newtonsoft.Json.Schema;

namespace JsonValidationCoreWebApi.Models
{
    public class SchemaValidationError
    {
        public ErrorType ErrorType { get; set; }

        public string Message { get; set; }

        public object Value { get; set; }
    }
}
