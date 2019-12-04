using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// Gets the menu.
        /// </summary>
        public Menu Menu { get; } = new Menu();
        /// <summary>
        /// Holds all valid menu items.
        /// </summary>
        private IEnumerable<IMenuItem> validMenuItems;
        /// <summary>
        /// Contains valid combos.
        /// </summary>
        public List<IMenuItem> ValidCombos = new List<IMenuItem>();
        /// <summary>
        /// Contains valid entrees.
        /// </summary>
        public List<IMenuItem> ValidEntrees = new List<IMenuItem>();
        /// <summary>
        /// Contains valid sides.
        /// </summary>
        public List<IMenuItem> ValidSides = new List<IMenuItem>();
        /// <summary>
        /// Contains valid drinks.
        /// </summary>
        public List<IMenuItem> ValidDrinks = new List<IMenuItem>();


        [BindProperty]
        public string search { get; set; }
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();
        [BindProperty]
        public float? minimumPrice { get; set; }
        [BindProperty]
        public float? maximumPrice { get; set; }
        [BindProperty]
        public List<string> excludeIngredient { get; set; } = new List<string>();

        public void OnGet()
        {
            validMenuItems = Menu.AvailableMenuItems;

            foreach (IMenuItem menuItem in validMenuItems)
            {
                if (menuItem is Entree)
                {
                    ValidEntrees.Add(menuItem);
                }
                else if (menuItem is CretaceousCombo)
                {
                    ValidCombos.Add(menuItem);
                }
                else if (menuItem is Side)
                {
                    ValidSides.Add(menuItem);
                }
                else if (menuItem is Drink)
                {
                    ValidDrinks.Add(menuItem);
                }
            }
        }

        public void OnPost()
        {
            validMenuItems = Menu.AvailableMenuItems;

            /*
            validMenuItems = Search(validMenuItems, search);
            validMenuItems = MenuCategory(validMenuItems, menuCategory);
            validMenuItems = MinimumPrice(validMenuItems, minimumPrice);
            validMenuItems = MaximumPrice(validMenuItems, maximumPrice);
            validMenuItems = ExcludeIngredient(validMenuItems, excludeIngredient);
            */

            if(search != null)
            {
                validMenuItems = validMenuItems.Where(menuItem => menuItem.Description.Contains(search, StringComparison.InvariantCultureIgnoreCase));
            }
            if(menuCategory.Count != 0)
            {
                validMenuItems = validMenuItems.Where(menuItem => menuCategory.Contains(menuItem.GetType().Name) || menuCategory.Contains(menuItem.GetType().BaseType.Name));
            }
            if(minimumPrice != null)
            {
                validMenuItems = validMenuItems.Where(menuItem => menuItem.Price > minimumPrice);
            }
            if(maximumPrice != null)
            {
                validMenuItems = validMenuItems.Where(menuItem => menuItem.Price < maximumPrice);
            }
            if(excludeIngredient.Count != 0)
            {
                validMenuItems = validMenuItems.Where(menuItem =>
                {
                    foreach(string ingredient in menuItem.Ingredients)
                    {
                        if (excludeIngredient.Contains(ingredient))
                        {
                            return false;
                        }
                    }
                    return true;
                });
            }

            foreach (IMenuItem menuItem in validMenuItems)
            {
                if(menuItem is Entree)
                {
                    ValidEntrees.Add(menuItem);
                }
                else if (menuItem is CretaceousCombo)
                {
                    ValidCombos.Add(menuItem);
                }
                else if (menuItem is Side)
                {
                    ValidSides.Add(menuItem);
                }
                else if (menuItem is Drink)
                {
                    ValidDrinks.Add(menuItem);
                }
            }
            
        }

        /*
        /// <summary>
        /// Removes menu items from a list that don't contain a search string.
        /// </summary>
        /// <param name="results">The list that should be changed.</param>
        /// <param name="searchString">The string that should be searched for.</param>
        /// <returns></returns>
        private List<IMenuItem> Search(List<IMenuItem> results, string searchString)
        {
            if(searchString == null)
            {
                return results;
            }

            List<IMenuItem> duplicateList = new List<IMenuItem>(results);
            foreach (IMenuItem menuItem in duplicateList)
            {
                if (!menuItem.Description.Contains(searchString, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Remove(menuItem);
                }
            }
            return results;
        }

        /// <summary>
        /// Removes menu items from a list that aren't in a set of categories.
        /// </summary>
        /// <param name="results">The menu list that should be changed.</param>
        /// <param name="menuCategory">The set of categories.</param>
        /// <returns></returns>
        private List<IMenuItem> MenuCategory(List<IMenuItem> results, List<string> menuCategory)
        {
            if (menuCategory.Count == 0)
            {
                return results;
            }

            List<IMenuItem> duplicateList = new List<IMenuItem>(results);
            foreach (IMenuItem menuItem in duplicateList)
            {
                if (menuItem.GetType().Name == "CretaceousCombo")
                {
                    if (!menuCategory.Contains(menuItem.GetType().Name)){
                        results.Remove(menuItem);
                    }
                    
                }
                else if (!menuCategory.Contains(menuItem.GetType().BaseType.Name))
                {
                    results.Remove(menuItem);
                }
            }
            return results;
        }

        /// <summary>
        /// Removes menu items from a list that are below a certain minimum price.
        /// </summary>
        /// <param name="results">The menu list that should be changed.</param>
        /// <param name="minimumPrice">The minimum price.</param>
        /// <returns></returns>
        private List<IMenuItem> MinimumPrice(List<IMenuItem> results, float? minimumPrice)
        {
            if (minimumPrice == null)
            {
                return results;
            }

            List<IMenuItem> duplicateList = new List<IMenuItem>(results);
            foreach (IMenuItem menuItem in duplicateList)
            {
                if (menuItem.Price < minimumPrice)
                {
                    results.Remove(menuItem);
                }
            }
            return results;
        }

        /// <summary>
        /// Removes menu items from a list that are above a certain maximum price.
        /// </summary>
        /// <param name="results">The menu list that should be changed.</param>
        /// <param name="maximumPrice">The maximum price.</param>
        /// <returns></returns>
        private List<IMenuItem> MaximumPrice(List<IMenuItem> results, float? maximumPrice)
        {
            if (maximumPrice == null)
            {
                return results;
            }

            List<IMenuItem> duplicateList = new List<IMenuItem>(results);
            foreach (IMenuItem menuItem in duplicateList)
            {
                if (menuItem.Price > maximumPrice)
                {
                    results.Remove(menuItem);
                }
            }
            return results;
        }

        /// <summary>
        /// Removes menu items from a list that contain excluded ingredients.
        /// </summary>
        /// <param name="results">The menu list that should be changed.</param>
        /// <param name="excludeIngredient">A list of the excluded ingredients.</param>
        /// <returns></returns>
        private List<IMenuItem> ExcludeIngredient(List<IMenuItem> results, List<string> excludeIngredient)
        {
            if (excludeIngredient.Count == 0)
            {
                return results;
            }

            List<IMenuItem> duplicateList = new List<IMenuItem>(results);
            foreach (IMenuItem menuItem in duplicateList)
            {
                foreach(string ingredient in menuItem.Ingredients)
                {
                    if (excludeIngredient.Contains(ingredient))
                    {
                        results.Remove(menuItem);
                        break;
                    }
                }
            }
            return results;
        }
        */
    }
}