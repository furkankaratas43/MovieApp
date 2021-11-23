using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public static class CategoryRepository
    {
        private static List<Category> _categories = new List<Category>();
        static CategoryRepository()
        {
            _categories = new List<Category>(){
                new Category() {
                    Id = 1,
                    CategoryName = "Aksiyon"
                    },
                new Category() {
                    Id = 2,
                     CategoryName = "Dram"
                },
                new Category() {
                    Id = 3,
                    CategoryName = "Korku"
                },
                new Category() {
                    Id = 4,
                    CategoryName = "Bilim Kurgu"
                },
                new Category() {
                    Id = 5,
                    CategoryName = "Konulu"
                }
            };
        }


        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }

        public static void AddCategory(Category entity)
        {
            _categories.Add(entity);
        }

        public static Category GetById(int id)
        {
            return _categories.FirstOrDefault(i => i.Id == id);
        }

    }
}