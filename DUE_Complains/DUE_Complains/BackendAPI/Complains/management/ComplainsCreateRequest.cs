﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.BackendAPI.Complains
{
    public class ComplainsCreateRequest
    {
        public string IdStudent { get; set; }
        public int IdDepartment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public IFormFile ThumbnailImage { get; set; }


    }
}