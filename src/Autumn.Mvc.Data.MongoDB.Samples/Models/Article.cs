﻿using System;
using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Autumn.Mvc.Data.MongoDB.Samples.Models
{
    [BsonIgnoreExtraElements]
    [Collection(Name="article")]
    [Resource( Version ="v1",Deletable = false,Updatable = false)]
    public class ArticleInfo : AbstractEntity
    {
        [Required]
        public string Title { get; set; }

        public string Content { get; set; }
        
        public bool? IsValidate { get; set; }
        
        public string[] Test { get; set; }
    }

    [BsonIgnoreExtraElements]
    [Collection(Name = "article")]
    [Resource(Name = "article", Version = "v2", Deletable = false, Updatable = false)]
    public class ArticleInfoV2 : ArticleInfo
    {
        public DateTime PublishDate { get; set; }

        [Range(0, 100)] public int Score { get; set; }
    }
}