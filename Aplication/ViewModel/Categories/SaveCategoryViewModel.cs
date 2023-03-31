using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Core.Application.ViewModel.Categories
{
    public class SaveCategoryViewModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "category name is required")]
        public string categoryName { get; set; }

        [Required(ErrorMessage = "category description is required")]
        public string categoryDescription { get; set; }
    }
}
