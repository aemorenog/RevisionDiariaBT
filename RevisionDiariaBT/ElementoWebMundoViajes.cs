using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionDiariaBT
{
    class ElementoWebMundoViajes
    {
        public ElementoWebMundoViajes()
        {
            PageFactory.InitElements(PropiedadColeccionDriver.driver, this);
        }


        ///<summary>
        ///Botóne Next and Prev
        /// </summary>

        [FindsBy(How = How.ClassName, Using = "flex-next")]
        public IWebElement btnNetxMundoViajes { get; set; }

        [FindsBy(How = How.ClassName, Using = "flex-prev")]
        public IWebElement btnPrevMundoViajes { get; set; }

        ///<summary>
        ///Botones debajo de cada imagen carrusel Mundo Viajes
        /// </summary>

        [FindsBy(How = How.ClassName, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/ol/li[1]/a")]
        public IWebElement btnUnoCarrusel { get; set; }

        [FindsBy(How = How.ClassName, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/ol/li[2]/a")]
        public IWebElement btnDosCarrusel { get; set; }

        [FindsBy(How = How.ClassName, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/ol/li[3]/a")]
        public IWebElement btnTresCarrusel { get; set; }


        ///<summary>
        /// Carrusel Viajes
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[4]/div/div[2]/h3/a")]
        public IWebElement PrimeraImagenViajeCarrusel { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[4]/div/div[2]/h3/a")]
        public IWebElement SegundaImagenCarrusel { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[4]/div/div[2]/h3/a")]
        public IWebElement TerceraImagenViajeCarrusel { get; set; }

        ///<summary>
        /// Descubre Las Ofertas destacadas de esta semana
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/div/div/article[1]/div[2]/h5")]
        public IWebElement ViajeDestacadoSemana1 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/div/div/article[2]/div[2]/h5")]
        public IWebElement ViajeDestacadoSemana2 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/div/div/article[3]/div[2]/h5")]
        public IWebElement ViajeDestacadoSemana3 { get; set; }


        ///<summary>
        /// Viajes Destacados 
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[4]/div/div[2]/h3/a")]
        public IWebElement ViajeDestacadoDelMes1 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[5]/div/div[2]/h3/a")]
        public IWebElement ViajeDestacadoDelMes2 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[6]/div/div[2]/h3/a")]
        public IWebElement ViajeDestacadoDelMes3 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[7]/div/div[2]/h3/a")]
        public IWebElement ViajeDestacadoDelMes4 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[8]/div/div[2]/h3/as")]
        public IWebElement ViajeDestacadoDelMes5 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[9]/div/div[2]/h3/a")]
        public IWebElement ViajeDestacadoDelMes6 { get; set; }

        ///<summary>
        ///Especial Viajes El Corte Inglés
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/section[1]/article[1]/div[2]/a/h4")]
        public IWebElement CategoriaCorteInglesVerano { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/section[1]/article[2]/div[2]/a/h4")]
        public IWebElement CategoriaCorteInglesEuropa { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/section[1]/article[1]/div[2]/a/h4")]
        public IWebElement CategoriaCorteInglesVuelo { get; set; }
    }
}
