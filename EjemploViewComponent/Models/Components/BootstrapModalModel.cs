using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploViewComponent.Models.Components
{
    public class BootstrapModalModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string MethodName { get; set; }
    }
}
