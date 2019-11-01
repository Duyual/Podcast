using Podcast_Models;
using Podcast_Models.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public Categories FetchCategories()
        {
            return categories.Deserialize();
        }

        public bool AddCategory(string newCategory)
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

        public void UpdateCategory(string oldCategory, string newCategory)
        {
            Categories oldCategories = categories.Deserialize();
            if (!String.IsNullOrEmpty(newCategory))
            {
                for (int i = 0; i < oldCategories.Count; i++)
                {
                    if (oldCategories[i].Equals(oldCategory))
                    {
                        oldCategories[i] = newCategory;
                        oldCategories.Serialize();
                        return;
                    }
                }
            }

        }

        public void RemoveCategory(string category)
        {
            Categories oldCategories = categories.Deserialize();
            oldCategories.Remove(category);
            oldCategories.Serialize();
        }

    }
}
