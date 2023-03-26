﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ManagedCode.OpenAI.API.Image
{
    internal class EditImageRequestDto: BaseImageRequestDto
    {
        [JsonPropertyName("prompt")]
        public string Description { get; set; }

        [JsonPropertyName("image")]
        public string ImageBase64 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("mask")]
        public string? MaskBase64 { get; set; }
    }
}
