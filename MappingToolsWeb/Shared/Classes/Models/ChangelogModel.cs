﻿using System;
using System.Text.Json.Serialization;

namespace MappingToolsWeb.Shared.Classes.Models {

    public class ChangelogModel {

        [JsonPropertyName("tag_name")]
        public string TagName { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("published_at")]
        public DateTime PublishedAt { get; set; }

        [JsonPropertyName("body")]
        public string Body { get; set; }

        [JsonPropertyName("html_url")]
        public string Url { get; set; }
    }
}