﻿using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WorldCitiesAPI.Data.Models;

[Table("Countries")]
[Index(nameof(Name))]
[Index(nameof(ISO2))]
[Index(nameof(ISO3))]

public class Country
{
    [Key]
    [Required]
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("iso2")]
    public string ISO2 { get; set; } = string.Empty;
    [JsonPropertyName("iso3")]
    public string ISO3 { get; set; } = string.Empty;
    public ICollection<City>? Cities { get; set; }
}
