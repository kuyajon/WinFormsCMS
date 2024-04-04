using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsCMS
{
    [Dapper.Contrib.Extensions.Table("ContentCategory")]
    public class ContentCategory
    {
        [Key]
        public long Id { get; set; }
        public long ContentId { get; set; }
        public long CategoryId { get; set; }
    }
}
