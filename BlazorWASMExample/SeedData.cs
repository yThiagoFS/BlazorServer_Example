using BlazorWASMExample.Models;

namespace BlazorWASMExample
{
    public static class SeedData
    {
        public static List<Category> SeedCategories()
        => Enumerable.Range(0, 10)
            .Select(indice => new Category((long)indice, $"Category {indice}", $"Description {indice}"))
            .ToList();         
            
    }
}
