using NUnit.Framework;
using OpenQA.Selenium.Chrome;
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

        [Test]
        public void ValidarBotonesCarruselBT()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            System.Threading.Thread.Sleep(3000);

            paginaBT.BtnNextCarrusel();

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Quit();

        }

        [Test]
        public void ValidarImagenesCarruselBT()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            System.Threading.Thread.Sleep(300);

            paginaBT.GetPrimeraImagenCarrusel();

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,500);");

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,500);");

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,700);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            System.Threading.Thread.Sleep(5000);

            /// Segunda Imagen de Carrusel

            paginaBT.GetSegundaImagenCarrusel();

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,500);");

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,500);");

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,700);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            System.Threading.Thread.Sleep(5000);

            /// Tercera Imagen de Carrusel

            paginaBT.GetTerceraImagenCarrusel();

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,500);");

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,500);");

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,700);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles[1]).Close();

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles.Last());

            System.Threading.Thread.Sleep(5000);

            /// Cuarta Imagen de Carrusel

            paginaBT.GetCuartaImagenCarrusel();

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,500);");

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,500);");

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,700);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Quit();
        }
    }

}
