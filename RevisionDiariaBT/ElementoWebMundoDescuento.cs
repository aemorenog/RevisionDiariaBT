using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionDiariaBT
{
    class ElementoWebMundoDescuento
    {
        public ElementoWebMundoDescuento()
        {
            PageFactory.InitElements(PropiedadColeccionDriver.driver, this);
        }

        /// <summary>
        /// Imagenes del Carrusel
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/div/ul/li[2]/a/img")]
        public IWebElement ImagenCarruselDescuento1 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/div/ul/li[3]/a/img")]
        public IWebElement ImagenCarruselDescuento2 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/div/ul/li[4]/a/img")]
        public IWebElement ImagenCarruselDescuento3 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/div/ul/li[5]/a/img")]
        public IWebElement ImagenCarruselDescuento4 { get; set; }

        /// <summary>
        /// Botónes Carrusel
        /// </summary>
        /// 

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/ol/li[1]/a")]
        public IWebElement BtnCarruselDescuentos1 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/ol/li[2]/a")]
        public IWebElement BtnCarruselDescuento2 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/ol/li[3]/a")]
        public IWebElement BtnCarruselDescuento3 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/ol/li[4]/a")]
        public IWebElement BtnCarruselDescuento4 { get; set; }




    }
}
