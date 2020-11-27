using EjemploViewComponent.Models.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploViewComponent.Views.Shared.Components.BootstrapModal
{
    public class BootstrapModalViewComponent : ViewComponent
    {
        public BootstrapModalViewComponent()
        {

        }

        public IViewComponentResult Invoke(BootstrapModalModel model)
        {
            return View(model);
        }

        // public async Task<IViewComponentResult> InvokeAsync(BootstrapModalModel model)
        // {
        //     var algo = await ...
        //     return View(model);
        // }
    }
}
