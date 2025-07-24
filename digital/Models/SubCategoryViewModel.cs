using Microsoft.AspNetCore.Mvc.Rendering;

namespace digital.Models
{
    public class SubCategoryViewModel
    {
        public List<SelectListItem> Categories { get; set; }
        public List<SubCategory> SubCategoryList { get; set; }
        public SubCategory SubCategoryToEdit { get; set; }
    }


}