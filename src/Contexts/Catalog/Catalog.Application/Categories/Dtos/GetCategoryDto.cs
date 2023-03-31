namespace Catalog.Application.Categories.Dtos
{
    public class GetCategoryDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int ParentCategoryId { get; set; }
        public bool Published { get; set; }
    }
}
