using Microsoft.AspNetCore.Mvc;
using Online_Shop.Data;

namespace Online_Shop.Componentes
{
    public class CategoriesComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("/Views/Components/CategoriesComponent.cshtml", Website.categories);
        }
    }
}
