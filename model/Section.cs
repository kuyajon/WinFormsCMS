
using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsCMS
{
    [Dapper.Contrib.Extensions.Table("Section")]
    public class Section
    {
        [Key]
        public long Id { get; set; }
        public string ContentKey { get; set; }
        public string ContentBody { get; set; }
    }
}
