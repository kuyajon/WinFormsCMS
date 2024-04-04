using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsCMS
{
    [Dapper.Contrib.Extensions.Table("Category")]
    public class Category
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public ContentType ContentType { get; set; }
    }
}
