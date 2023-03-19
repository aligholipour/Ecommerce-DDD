namespace Catalog.Application.Categories.Dtos
{
    public class AddCategoryDto
    {
        public string Name { get; set; }
        public int ParentCategoryId { get; set; }
        public bool Published { get; set; }
    }
}
