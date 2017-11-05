﻿using Autumn.Data.Rest.Entities;
using Autumn.Data.Rest.Samples.Repositories;
using MongoDB.Bson.Serialization.Attributes;

namespace Autumn.Data.Rest.Samples.Entities
{
    [BsonIgnoreExtraElements]
    [Entity(Name = "site", Version = "v1")]
    public class Site : AbstractEntity
    {
        [BsonElement("website")]
        public string WebSite { get; set; }

        [BsonElement("count")]
        public double? Count { get; set; }

        [BsonElement("company")]
        public string Company { get; set; }
    }
}