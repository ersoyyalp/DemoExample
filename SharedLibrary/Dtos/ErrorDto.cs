﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Dtos
{
    public class ErrorDto
    {
        public List<String> Errors { get; private set; }  = new List<String>();

        public bool IsShow { get; private set; }
        
     

        public ErrorDto(String error, bool isShow) {
        
            Errors.Add(error);
            IsShow = isShow;
        }

        public ErrorDto(List<string> errors, bool ısShow)
        {
            Errors = errors;
            IsShow = ısShow;
        }
    }
}
