﻿using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Hangfire.Mongo.Dto
{
#pragma warning disable 1591
    [BsonDiscriminator(nameof(ExpiringJobDto))]
    public abstract class ExpiringJobDto : BaseJobDto
    {
        [BsonElement(nameof(ExpireAt))]
        public DateTime? ExpireAt { get; set; }
    }
    
#pragma warning restore 1591
}