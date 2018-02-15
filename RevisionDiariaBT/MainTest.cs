using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
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


        ///<summary>
        /// Validar Carrusel Automatico
        /// </summary>
        /// 
        [Test]
        public void WebHome_001_Validar_Funcionalidad_Slider_HomeBT_Automatico()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            System.Threading.Thread.Sleep(5000);
        }

        ///<summary>
        /// Validar botones <> Carrusel Home BT
        /// </summary>
        [Test]
        public void WebHome_002_Validar_Funcionalidad_Botones_NextyPrev_Carrusel_HomeBT()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            paginaBT.BtnNextPrevCarruselHomeBT();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Quit();

        }

        [Test]
        public void WebHome_003_Validar_Funcionalidad_Botones_O_Carrusel_HomeBT()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            paginaBT.BtnSliderOCarruselHomeBT();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Quit();

        }

        [Test]
        public void WebHome_004_Validar_Funcionalidad_Link_Slider_Carrusel_HomeBT()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            System.Threading.Thread.Sleep(1000);

            paginaBT.GetPrimeraImagenCarrusel();

            System.Threading.Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,500);");

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,500);");

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,700);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            System.Threading.Thread.Sleep(5000);

            /// Segundo Slider

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

            /// Tercer Slider

            paginaBT.GetTerceraImagenCarrusel();

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles.Last());

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


        /// <summary>
        /// Validacion Enlaces Mundo BT
        /// </summary>

        [Test]
        public void WebHome_Validar_Funcionalidad_Enlances_Mundos()
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
        public void WebHome_Validar_Funcionalidad_Boton_Favoritos_Mundos()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            string correo = "pruebaingesmart@gmail.com";
            string pass = "c123456";

            System.Threading.Thread.Sleep(3000);

            paginaBT.IngresarFavoritos(correo, pass);

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,350);");

            System.Threading.Thread.Sleep(3000);

            paginaBT.FavoritosViajes();

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,350);");

            paginaBT.FavoritosTienda();

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,350);");

            paginaBT.FavoritosDescuentos();

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Quit();

        }

        [Test]
        public void WebHome_Validar_Funcionalidad_Boton_CotizarViajes()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,400);");

            System.Threading.Thread.Sleep(3000);

            paginaBT.IngresarViajeX();

            System.Threading.Thread.Sleep(3000);

            paginaBT.IngresoBotonCotizar();

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Quit();
        }

        [Test]
        public void Web_Home_Validar_Icono_Carro_Compra()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            paginaBT.IngresarBotónAgregarCarroProducto();

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Quit();
        }

        [Test]
        public void WebHomeViajes_Validar_Funcionalidad_Slider_Automatico()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            System.Threading.Thread.Sleep(4000);

            paginaBT.IraViajes();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Quit();

        }

        [Test]
        public void WebHomeViajes_Validar_Funcionalidad_NextyPrev_Slider()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            ElementoWebMundoViajes paginaVJ = new ElementoWebMundoViajes();

            System.Threading.Thread.Sleep(4000);

            paginaBT.IraViajes();

            System.Threading.Thread.Sleep(4000);

            paginaVJ.BtnNextPrevCarruselHomeViajesBT();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Quit();
        }

        [Test]
        public void WebHomeViajes_Validar_Funcionalidad_Btn_Carrusel()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            ElementoWebMundoViajes paginaVJ = new ElementoWebMundoViajes();

            System.Threading.Thread.Sleep(4000);

            paginaBT.IraViajes();

            System.Threading.Thread.Sleep(4000);

            paginaVJ.BtnSliderOCarruselMundoViajes();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Quit();
        }

        [Test]
        public void WebHomeViajes_Validar_Funcionalidad_Link_Sliders_Carrusel()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            ElementoWebMundoViajes paginaVJ = new ElementoWebMundoViajes();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            System.Threading.Thread.Sleep(2000);

            paginaBT.IraViajes();

            //System.Threading.Thread.Sleep(1000);

            paginaVJ.IngresarPrimeraImagenCarruselViajes();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Segunda Imagen

            System.Threading.Thread.Sleep(400);

            paginaVJ.IngresarSegundoCirculo();

            paginaVJ.IngresarSegundaImagenCarruselViajes();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Tercera Imagen

            System.Threading.Thread.Sleep(400);

            paginaVJ.IngresarTercerCirculo();

            System.Threading.Thread.Sleep(1000);

            paginaVJ.IngresarTerceraImagenCarruselViajes();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            PropiedadColeccionDriver.driver.Quit();
        }



        [Test]
        public void WebHomeViajes_Validar_Funcionalidad_Ingreso_Viajes_Destacados()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            ElementoWebMundoViajes paginaVJ = new ElementoWebMundoViajes();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            System.Threading.Thread.Sleep(2000);

            paginaBT.IraViajes();

            System.Threading.Thread.Sleep(1000);

            paginaVJ.IngresarViajeDestacado1();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            ///
            System.Threading.Thread.Sleep(400);

            paginaVJ.IngresarViajeDestacado2();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            ///

            System.Threading.Thread.Sleep(400);

            paginaVJ.IngresarViajeDestacado3();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            PropiedadColeccionDriver.driver.Quit();

        }

        [Test]
        public void WebHomeViajes_Validar_Funcionalidad_Links_CorteIngles()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            ElementoWebMundoViajes paginaVJ = new ElementoWebMundoViajes();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            System.Threading.Thread.Sleep(2000);

            paginaBT.IraViajes();

            js.ExecuteScript("window.scrollBy(0,850);");

            System.Threading.Thread.Sleep(4000);

            paginaVJ.IngresaCorteInglesVerano();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles.Last());

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles[1]).Close();

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles.Last());

            System.Threading.Thread.Sleep(2000);

            ///
            paginaVJ.IngresaCorteInglesEuropa();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles.Last());

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles[1]).Close();

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles.Last());

            ///
            paginaVJ.IngresaCorteInglesVuelo();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles.Last());

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles[1]).Close();

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles.Last());

            System.Threading.Thread.Sleep(2000);

            PropiedadColeccionDriver.driver.Quit();
        }

        [Test]
        public void WebHomeViajes_Validar_Funcionalidad_Links_ProgramasCorteIngles()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            ElementoWebMundoViajes paginaVJ = new ElementoWebMundoViajes();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            System.Threading.Thread.Sleep(2000);

            paginaBT.IraViajes();

            js.ExecuteScript("window.scrollBy(0,850);");

            System.Threading.Thread.Sleep(4000);

            paginaVJ.IngresarProgramaVuelos();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles.Last());

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles[1]).Close();

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles.Last());

            System.Threading.Thread.Sleep(2000);

            ///
            paginaVJ.IngresarProgramaHoteles();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles.Last());

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles[1]).Close();

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles.Last());

            ///
            paginaVJ.IngresarProgramas();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles.Last());

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles[1]).Close();

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles.Last());

            System.Threading.Thread.Sleep(2000);

            PropiedadColeccionDriver.driver.Quit();
        }

        [Test]
        public void WebHomeViajes_Validar_Funcionalidad_Viajes_Destacados()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            ElementoWebMundoViajes paginaVJ = new ElementoWebMundoViajes();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            System.Threading.Thread.Sleep(2000);

            paginaBT.IraViajes();

            System.Threading.Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,2500);");

            System.Threading.Thread.Sleep(6000);

            PropiedadColeccionDriver.driver.Quit();
        }
    }

}
