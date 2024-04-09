
using Dapper.Contrib.Extensions;

namespace WinFormsCMS
{
    [Dapper.Contrib.Extensions.Table("Content")]
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

        [Write(false)]
        public string LocalParentPath => GetParentPath();
        [Write(false)]
        public string LocalFullPath => GetFullPath();

        private string GetParentPath()
        {
            return $"{Config.LocalFolder}/{Config.RootContentPath}/{CreatedDate.Year}/{CreatedDate.Month}/{Permalink}";
        }
        private string GetFullPath()
        {
            return $"{LocalParentPath}/index.html";
        }
    }
}
