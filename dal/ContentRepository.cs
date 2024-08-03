using Dapper;
using Dapper.Contrib.Extensions;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCMS
{
    public class ContentRepository : BaseRepository<Content>
    {
        private CategoryRepository categoryRepository = RepositoryFactory.getCategoryRepository();
        private ContentCategoryRepository contentCategoryRepository = RepositoryFactory.getContentCategoryRepository();
        public List<Content> Search(ContentType type, ContentStatus status)
        {
            using (IDbConnection connection = DbUtils.getConnection())
            {
                return connection.Query<Content>("SELECT * FROM Content WHERE ContentType = @ContentType AND Status = @Status order by CreatedDate desc",
                    new { ContentType = type, Status = status }).ToList();
            }
        }
        public Content Insert(Content entity, List<string> selectedCategories)
        {
            UpdatePublishDate(entity);
            Content result = base.Insert(entity);
            InsertCategories(entity, selectedCategories);
            return result;
        }

        private void UpdatePublishDate(Content entity)
        {
            if (entity.Status == ContentStatus.Published && entity.PublishDate == null)
            {
                entity.PublishDate = DateTime.Now;
            }
            if (entity.Status != ContentStatus.Published)
            {
                entity.PublishDate = null;
            }
        }

        private void InsertCategories(Content entity, List<string> selectedCategories)
        {
            using (IDbConnection connection = DbUtils.getConnection())
            {
                connection.Execute("DELETE FROM ContentCategory WHERE ContentId = @ContentId", new { ContentId = entity.Id });
                foreach (string category in selectedCategories)
                {
                    Category cat = categoryRepository.FindByName(category);
                    if (cat != null)
                    {
                        ContentCategory cc = new ContentCategory();
                        cc.ContentId = entity.Id;
                        cc.CategoryId = cat.Id;
                        contentCategoryRepository.Insert(cc);
                    }
                }
            }
        }

        public void Update(Content entity, List<string> selectedCategories)
        {
            UpdatePublishDate(entity);
            base.Update(entity);
            InsertCategories(entity, selectedCategories);
        }
    }
}
