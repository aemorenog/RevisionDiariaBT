using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionDiariaBT
{
    class MainTest
    {
        static void Main(string[] args)
        {
        }

        [OneTimeSetUp]
        public void initialize()
        {
            //Usameos nuestra variable global webdriver y le asignamos que sea de tipo Chrome ()
            PropiedadColeccionDriver.driver = new ChromeDriver();



            //Maximizamos la pantalla que se abrira del navegador
            PropiedadColeccionDriver.driver.Manage().Window.Maximize();


            string urlPrueba = "https://desarrollobeneficiosbe.ingesmart.cl/";

            //Indicamos a nuestro driver a que página ir (página inicial o primera carga)
            PropiedadColeccionDriver.driver.Navigate().GoToUrl(urlPrueba);
        }





        /// <summary>
        /// Validacion Enlaces Mundo BT
        /// </summary>

        [Test]
        public void ValidarIngresoEnlacesMundos()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            paginaBT.IngresarEnlaceMundoViajes();

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            paginaBT.IngresarEnlaceMundoTienda();

             System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            paginaBT.IngresarEnlaceMundoDescuentos();

            PropiedadColeccionDriver.driver.Quit();

        }
    }



}
