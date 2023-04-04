using BuildingBlocks.Domain;

namespace Catalog.Domain.Entities.Categories
{
    public class Category : Entity<int>
    {
        public string Name { get; set; }
        public int ParentCategoryId { get; set; }
        public bool Published { get; set; }

        public void ChangePublishState(bool categoryState)
        {
            Published = categoryState;
        }

        public bool IsPublished() => Published;

        public bool HasParentCategory => ParentCategoryId != 0;
    }
}
