using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionDiariaBT
{
    class ElementoWebMundoTienda
    {
        public ElementoWebMundoTienda()
        {
            PageFactory.InitElements(PropiedadColeccionDriver.driver, this);
        }


    }
}
