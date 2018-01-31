using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionDiariaBT
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }
    //<summary> Creamos un Auto-Implementada Propiedad para llamar a driver de un solo lugar y ahorramos un campo mas
    class PropiedadColeccionDriver
    {
        public static IWebDriver driver { get; set; }
    }
}
