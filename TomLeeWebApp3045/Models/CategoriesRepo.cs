namespace TomLeeWebApp3045.Models
{
    public class CategoriesRepo
    {
        //categories in this method are seeded as such:
        public static List<Category> _categories = new List<Category>()
        {
            new Category { CategoryId = 1, Name = "Science" , Description = "Science"},
            new Category { CategoryId = 2, Name = "History" , Description = "History"},
            new Category { CategoryId = 3, Name = "Technology" , Description = "Technology"},
            new Category { CategoryId = 4, Name = "Art" , Description = "Art"},
            new Category { CategoryId = 5, Name = "Literature" , Description = "Literature"}
        };

        public static void AddCategory(Category category)
        {
            var maxId = _categories.Max(m => m.CategoryId);
            category.CategoryId = maxId + 1;
            _categories.Add(category);
        }

        public static List<Category> GetAllCategories() => _categories;
        

        public static Category? GetCategoryById(int id)
        {
            var category = _categories.FirstOrDefault(c => c.CategoryId == id);
            if (category != null)
            {
                return new Category
                {
                    CategoryId = category.CategoryId,
                    Name = category.Name,
                    Description = category.Description
                };
            }
            return null;
        }

        public static void UpdateCategory(int categoryId, Category category)
        {
            if (categoryId != category.CategoryId)
            {
                return; // or throw an exception, check later.
            }
            var categoryToUpdate = _categories.FirstOrDefault(uc => uc.CategoryId == categoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }
        }

        public static void DeleteCategory(int categoryId)
        {
            var categoryToDelete = _categories.FirstOrDefault(d => d.CategoryId == categoryId);
            if (categoryToDelete != null)
            {
                _categories.Remove(categoryToDelete);
            }
        }

    }
}