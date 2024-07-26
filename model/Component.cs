
using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsCMS
{
    [Dapper.Contrib.Extensions.Table("Component")]
    public class Component
    {
        [Key]
        public long Id { get; set; }
        public string ComponentKey { get; set; }
        public string ComponentBody { get; set; }
    }
}
