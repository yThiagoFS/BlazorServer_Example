namespace BlazorWASMExample.Models
{
    public class Category
    {
        public Category()
        {

        }

        public Category(long id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public long Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}
