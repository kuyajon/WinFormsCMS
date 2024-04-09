using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCMS
{
    class RepositoryFactory
    {
        public static ContentRepository getContentRepository()
        {
            return new ContentRepository();
        }
        public static CategoryRepository getCategoryRepository()
        {
            return new CategoryRepository();
        }
        public static ContentCategoryRepository getContentCategoryRepository()
        {
            return new ContentCategoryRepository();
        }

        public static SectionRepository getSectionRepository()
        {
            return new SectionRepository();
        }
    }
}
