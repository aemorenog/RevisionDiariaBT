using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionDiariaBT
{
    class ElementoWebHomeBT
    {
        public ElementoWebHomeBT()
        {
            PageFactory.InitElements(PropiedadColeccionDriver.driver, this);
        }


        /// <summary>
        /// Botones Anterior y Siguiente Carrusel Home Beneficios
        /// </summary>

        [FindsBy(How = How.ClassName, Using = "bx-next")]
        public IWebElement btnSiguienteCarrusel { get; set; }

        [FindsBy(How = How.ClassName, Using = "bx-prev")]
        public IWebElement btnAnteriorCarrusel { get; set; }

        /// <summary>
        /// Imagenes Carrusel Home Beneficios
        /// </summary>

        [FindsBy(How = How.ClassName, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[3]/div/div[1]/ul/li[2]/a/img")]
        public IWebElement PrimerImagenCarrusel { get; set; }

        [FindsBy(How = How.ClassName, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[3]/div/div[1]/ul/li[3]/a/img")]
        public IWebElement SegundaImagenCarrusel { get; set; }

        [FindsBy(How = How.ClassName, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[3]/div/div[1]/ul/li[4]/a/img")]
        public IWebElement TerceraImagenCarrusel { get; set; }

        [FindsBy(How = How.ClassName, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[3]/div/div[1]/ul/li[5]/a/img")]
        public IWebElement CuartaImagenCarrusel { get; set; }

        [FindsBy(How = How.ClassName, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[3]/div/div[1]/ul/li[6]/a/img")]
        public IWebElement QuintaImagenCarrusel { get; set; }

        ///<summary>
        ///Botones circulares Carrusel Home
        /// </summary>

        [FindsBy(How = How.ClassName, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[2]/div/div[2]/div[1]/div[1]/a")]
        public IWebElement btnCircularCarruselUno { get; set; }

        [FindsBy(How = How.ClassName, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[2]/div/div[2]/div[1]/div[2]/a")]
        public IWebElement btnCircularCarruselDos { get; set; }

        [FindsBy(How = How.ClassName, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[2]/div/div[2]/div[1]/div[3]/a")]
        public IWebElement btnCircularCarruselTres { get; set; }

        [FindsBy(How = How.ClassName, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[2]/div/div[2]/div[1]/div[4]/a")]
        public IWebElement btnCircularCarruselCuatro { get; set; }

        [FindsBy(How = How.ClassName, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[2]/div/div[2]/div[1]/div[5]/a")]
        public IWebElement btnCircularCarruselQuinto { get; set; }

        ///<summary>
        /// Botones Calugas Home
        /// </summary>

        [FindsBy(How = How.ClassName, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/button[2]")]
        public IWebElement btnCalugasNext { get; set; }

        [FindsBy(How = How.ClassName, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/button[1]")]
        public IWebElement btnCalugaPrev { get; set; }

        ///<summary>
        /// Menú Ingreso de Mundo Viajes
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/section/div/div[5]/nav/ul/li[1]")]
        public IWebElement menuViajes { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/section/div/div[1]/div/h2/a")]
        public IWebElement opcionMenuIrViajes { get; set; }

        ///<summary>
        /// Menú Ingreso de Mundo Tienda
        /// </summary>
        /// 

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/section/div/div[5]/nav/ul/li[2]")]
        public IWebElement menuTienda { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/section/div/div[2]/div/h2/a")]
        public IWebElement opcionMenuIrTienda { get; set; }

        /// <summary>
        /// Menú Ingreso de Mundo Tienda
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/section/div/div[5]/nav/ul/li[3]")]
        public IWebElement menuDescuento { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/section/div/div[3]/div/h2/a")]
        public IWebElement opcionMenuIrDescuento { get; set; }

        /// <summary>
        /// Links Categoría Mundos
        /// </summary>
        /// 

        [FindsBy(How = How.LinkText, Using = "Ver todos los viajes")]
        public IWebElement LinkMundoViajes { get; set; }

        [FindsBy(How = How.LinkText, Using = "Ver toda la tienda")]
        public IWebElement LinkMundoTienda { get; set; }

        [FindsBy(How = How.LinkText, Using = "Ver todos los descuentos")]
        public IWebElement LinkMundoDescuentos { get; set; }

        ///<summary>
        ///Explorar Viajes
        ///</summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[2]/article[1]/div[2]/a/h4")]
        public IWebElement CategoriaChile { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[2]/article[2]/div[2]/a/h4")]
        public IWebElement CategoriaSudamérica { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[2]/article[3]/div[2]/a/h4")]
        public IWebElement CategoriaMexicoyCaribe { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[2]/article[4]/div[2]/a/h4")]
        public IWebElement CategoriaNorteamérica { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[2]/article[5]/div[2]/a/h4")]
        public IWebElement CategoriaEuropayLejanos { get; set; }

        /// <summary>
        /// Ingreso de Enlace de Mundos BT
        /// </summary>

        public void IngresarEnlaceMundoViajes()
        {
            System.Threading.Thread.Sleep(2000);

            LinkMundoViajes.Click();

            System.Threading.Thread.Sleep(2000);

        }

        public void IngresarEnlaceMundoTienda()
        {
            System.Threading.Thread.Sleep(2000);

            LinkMundoTienda.Click();

            System.Threading.Thread.Sleep(2000);

        }

        public void IngresarEnlaceMundoDescuentos()
        {
            System.Threading.Thread.Sleep(2000);

            LinkMundoDescuentos.Click();

            System.Threading.Thread.Sleep(2000);

        }
    }

 }