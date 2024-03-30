﻿
using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsCMS
{
    public class Content
    {
        [Key]
        public long Id { get; set; }
        public ContentStatus Status { get; set; }
        public ContentType ContentType { get; set; }
        public string Title { get; set; }
        public string Permalink { get; set; }
        public string Body { get; set; }
        public string Rendered { get; set; }
        public string Template { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}