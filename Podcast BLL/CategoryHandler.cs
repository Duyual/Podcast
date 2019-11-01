using Podcast_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast_BLL
{
    public class CategoryHandler
    {

        Categories categories;

        public CategoryHandler()
        {
            categories = new Categories();
        }

        public Categories fetchCategories()
        {
            return categories.Deserialize();
        }

        public bool addCategory(string newCategory)
        {
            Categories oldCategories = categories.Deserialize();
            if (oldCategories != null)
            {
                foreach (string oldCategory in oldCategories)
                {
                    if (oldCategory.Equals(newCategory))
                        return false;
                }
                oldCategories.Add(newCategory);
                oldCategories.Serialize();
            } else
            {
                Categories newCategories = new Categories();
                newCategories.Add(newCategory);
                newCategories.Serialize();
            }
            return true;
        }

    }
}
