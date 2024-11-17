﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.DTO
{
    public class Comment
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("userId")]
        public string UserIdComment { get; set; }

        [BsonElement("postId")]
        public string PostIdComment { get; set; }

        [BsonElement("content")]
        public string Content { get; set; }

        [BsonElement("likes")]
        public int Likes { get; set; }

        [BsonElement("likeUsers")]
        public List<string> LikeUsers { get; set; }
    }
}
