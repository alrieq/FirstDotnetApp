﻿using System.Text.Json;
using System.Text.Json.Serialization;

namespace WebApplication1.Models
{
    public class Product
    {
        public string? Id { get; set; }
        [JsonPropertyName("img")]
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Discreption { get; set; }
        public string? Price { get; set; }

        public override string? ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
