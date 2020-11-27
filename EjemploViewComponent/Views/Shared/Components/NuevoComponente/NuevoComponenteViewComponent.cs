using EjemploViewComponent.Models.Components;
using Microsoft.AspNetCore.Mvc;

namespace EjemploViewComponent.Views.Shared.Components.NuevoComponente
{
    // [ViewComponent(Name="micomponente")]
    public class NuevoComponenteViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(NuevoComponenteModel model)
        {
            return View(model);
        }
    }
}