﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Dto.Dtos.SubHeaderDtos
{
    public class ResultSubHeaderDto
    {
        public ObjectId Id { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Linkedln { get; set; }
        public string Instagram { get; set; }
    }
}
