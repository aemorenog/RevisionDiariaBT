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
        public void WebHome_Validar_Funcionalidad_Slider_HomeBT_Automatico()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            System.Threading.Thread.Sleep(5000);
        }

        ///<summary>
        /// Validar botones <> Carrusel Home BT
        /// </summary>
        [Test]
        public void WebHome_Validar_Funcionalidad_Botones_NextyPrev_Carrusel_HomeBT()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            paginaBT.BtnNextPrevCarruselHomeBT();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Quit();

        }

        [Test]
        public void WebHome_Validar_Funcionalidad_Botones_O_Carrusel_HomeBT()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            paginaBT.BtnSliderOCarruselHomeBT();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Quit();

        }

        [Test]
        public void WebHome_Validar_Funcionalidad_Link_Slider_Carrusel_HomeBT()
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

            js.ExecuteScript("window.scrollBy(0,1900);");

            System.Threading.Thread.Sleep(6000);

            /// Viaje 1

            paginaVJ.IngresoViajeDestacado1();

            System.Threading.Thread.Sleep(2500);

            PropiedadColeccionDriver.driver.Navigate().Back();

            System.Threading.Thread.Sleep(2500);

            /// Viaje 2

            paginaVJ.IngresoViajeDestacado2();

            System.Threading.Thread.Sleep(2500);

            PropiedadColeccionDriver.driver.Navigate().Back();

            System.Threading.Thread.Sleep(2500);

            /// Viaje 3
            /// 

            paginaVJ.IngresoViajeDestacado3();

            System.Threading.Thread.Sleep(2500);

            PropiedadColeccionDriver.driver.Navigate().Back();

            System.Threading.Thread.Sleep(2500);

            /// Viaje 4
            /// 
            paginaVJ.IngresoViajeDestacado4();

            System.Threading.Thread.Sleep(2500);

            PropiedadColeccionDriver.driver.Navigate().Back();

            System.Threading.Thread.Sleep(2500);

            /// Viaje 5
            /// 

            paginaVJ.IngresoViajeDestacado5();

            System.Threading.Thread.Sleep(2500);

            PropiedadColeccionDriver.driver.Navigate().Back();

            System.Threading.Thread.Sleep(2500);

            /// Viaje 6
            /// 
            paginaVJ.IngresoViajeDestacado6();

            System.Threading.Thread.Sleep(2500);

            PropiedadColeccionDriver.driver.Navigate().Back();

            System.Threading.Thread.Sleep(2500);

            PropiedadColeccionDriver.driver.Quit();
        }

        [Test]
        public void WebHomeViajes_Validar_Funcionalidad_Categorias_Viajes()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            ElementoWebMundoViajes paginaVJ = new ElementoWebMundoViajes();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            System.Threading.Thread.Sleep(2000);

            paginaBT.IraViajes();

            System.Threading.Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,1900);");

            System.Threading.Thread.Sleep(5000);

            ///Categoria Chile
            ///
            paginaVJ.IngresarCategoriaChile();

            System.Threading.Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,365);");

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            ///Categoria Sudamerica
            ///

            paginaVJ.IngresarCategoriaSudamerica();

            System.Threading.Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,365);");

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            ///Categoria Mexico
            ///

            paginaVJ.IngresarCategoriaMexicoCaribe();

            System.Threading.Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,365);");

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            ///Categoria Norteamerica
            ///

            paginaVJ.IngresarCategoriaEuropaLejanos();

            System.Threading.Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,365);");

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Quit();
        }

        /// <summary>
        /// 
        /// </summary>

        [Test]
        public void WebHomeTienda_Validar_Funcionalidad_Slider_Automatico()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            System.Threading.Thread.Sleep(4000);

            paginaBT.IraTienda();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Quit();

        }

        [Test]
        public void WebHomeTienda_Validar_Funcionalidad_Link_Sliders_Carrusel()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            ElementoWebMundoTienda paginaTienda = new ElementoWebMundoTienda();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            System.Threading.Thread.Sleep(2000);

            paginaBT.IraTienda();

            //System.Threading.Thread.Sleep(1000);

            paginaTienda.IngresarPrimeraImagenCarruselTienda();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Segunda Imagen

            System.Threading.Thread.Sleep(400);

            paginaTienda.IngresarSegundoBtnCircular();

            paginaTienda.IngresarSegundaImagenCarruselTienda();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Tercera Imagen

            System.Threading.Thread.Sleep(400);

            paginaTienda.IngresarTerceroBtnCircular();

            System.Threading.Thread.Sleep(1000);

            paginaTienda.IngresarTerceraImagenCarruselTienda();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Quit();
        }

        [Test]
        public void WebHomeTienda_Validar_Funcionalidad_Ingreso_Tienda_Destacados()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            ElementoWebMundoTienda paginaTienda = new ElementoWebMundoTienda();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            System.Threading.Thread.Sleep(2000);

            paginaBT.IraTienda();

            System.Threading.Thread.Sleep(1000);

            /// Producto 1

            paginaTienda.IngresarProductoDestacadoTienda1();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Producto 2
            System.Threading.Thread.Sleep(400);

            paginaTienda.IngresarProductoDestacadoTienda2();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Producto 3

            System.Threading.Thread.Sleep(400);

            paginaTienda.IngresarProductoDestacadoTienda3();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Producto 4
            /// 

            System.Threading.Thread.Sleep(400);

            paginaTienda.IngresarProductoDestacadoTienda4();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Producto 5
            /// 

            System.Threading.Thread.Sleep(400);

            paginaTienda.IngresarProductoDestacadoTienda5();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Producto 6
            /// 

            System.Threading.Thread.Sleep(400);

            paginaTienda.IngresarProductoDestacadoTienda6();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Producto 7
            /// 

            System.Threading.Thread.Sleep(400);

            paginaTienda.IngresarProductoDestacadoTienda7();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Producto 8
            /// 

            System.Threading.Thread.Sleep(400);

            paginaTienda.IngresarProductoDestacadoTienda8();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Producto 9
            /// 

            System.Threading.Thread.Sleep(400);

            paginaTienda.IngresarProductoDestacadoTienda9();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Quit();

        }

        [Test]
        public void WebHomeTienda_Validar_Funcionalidad_Categorias_Tienda()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            ElementoWebMundoTienda paginaTienda = new ElementoWebMundoTienda();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            System.Threading.Thread.Sleep(2000);

            paginaBT.IraTienda();

            System.Threading.Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,1900);");

            System.Threading.Thread.Sleep(5000);

            ///Categoria Tecnología
            ///
            paginaTienda.IngresarCategoriaTecnologia();

            System.Threading.Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,365);");

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            ///Categoria Hogar
            ///

            paginaTienda.IngresarCategoriaHogar();

            System.Threading.Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,365);");

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            ///Categoria Belleza
            ///

            paginaTienda.IngresarCategoriaBelleza();

            System.Threading.Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,365);");

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            ///Categoria Deportes
            ///

            paginaTienda.IngresarCategoriaDeportes();

            System.Threading.Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,365);");

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Categoría Infantil
            /// 

            paginaTienda.IngresarCategoriaInfantil();

            System.Threading.Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,365);");

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            PropiedadColeccionDriver.driver.Quit();
        }

        [Test]
        public void WebHomeDescuentos_Validar_Funcionalidad_Slider_Automatico()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            System.Threading.Thread.Sleep(6000);

            paginaBT.IraDescuento();

            System.Threading.Thread.Sleep(6000);

            PropiedadColeccionDriver.driver.Quit();

        }

        [Test]
        public void WebHomeDescuentos_Validar_Funcionalidad_Link_Sliders_Carrusel()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            ElementoWebMundoDescuento paginaDescuentos = new ElementoWebMundoDescuento();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            System.Threading.Thread.Sleep(2000);

            paginaBT.IraDescuento();

            //System.Threading.Thread.Sleep(1000);

            paginaDescuentos.IngresarImagenDescuento1();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Segunda Imagen

            System.Threading.Thread.Sleep(400);

            paginaDescuentos.IngresarBtnCarrusel2();

            paginaDescuentos.IngresarImagenDescuento2();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Tercera Imagen

            System.Threading.Thread.Sleep(400);

            paginaDescuentos.IngresarBtnCarrusel3();

            System.Threading.Thread.Sleep(1000);

            paginaDescuentos.IngresarImagenDescuento3();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Cuarta Imagen

            System.Threading.Thread.Sleep(400);

            paginaDescuentos.IngresarBtnCarrusel4();

            System.Threading.Thread.Sleep(1000);

            paginaDescuentos.IngresarImagenDescuento4();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Quit();
        }

        [Test]
        public void WebHomeDescuentos_Validar_Funcionalidad_Categorias_Descuentos()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            ElementoWebMundoDescuento paginaDescuentos = new ElementoWebMundoDescuento();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            System.Threading.Thread.Sleep(2000);

            paginaBT.IraDescuento();

            System.Threading.Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,1900);");

            System.Threading.Thread.Sleep(5000);

            ///Categoria Restaurantes
            ///
            paginaDescuentos.IngresarCategoriaRestaurantes();

            System.Threading.Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,365);");

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            ///Categoria Bienestar
            ///

            paginaDescuentos.IngresarCategoriaBienestar();

            System.Threading.Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,365);");

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            ///Categoria Entretenimiento
            ///

            paginaDescuentos.IngresarCategoriaEntretencion();

            System.Threading.Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,365);");

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            ///Categoria Servicios
            ///

            paginaDescuentos.IngresarCategoriaServicios();

            System.Threading.Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,365);");

            System.Threading.Thread.Sleep(4000);

            ///Categoria Educación
            ///

            paginaDescuentos.IngresarCategoriaEducacion();

            System.Threading.Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,365);");

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            ///Categoria Compras
            ///

            paginaDescuentos.IngresarCategoriaCompras();

            System.Threading.Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,365);");

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Quit();
        }

        [Test]
        public void WebHomeDescuentos_Validar_Funcionalidad_Ingreso_Descuento_Destacados()
        {
            ElementoWebHomeBT paginaBT = new ElementoWebHomeBT();

            ElementoWebMundoDescuento paginaDescuentos = new ElementoWebMundoDescuento();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            System.Threading.Thread.Sleep(2000);

            paginaBT.IraDescuento();

            System.Threading.Thread.Sleep(1000);

            /// Producto 1

            paginaDescuentos.IngresarDescuentoDestacado1();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Producto 2
            System.Threading.Thread.Sleep(400);

            paginaDescuentos.IngresarDescuentoDestacado2();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Producto 3

            System.Threading.Thread.Sleep(400);

            paginaDescuentos.IngresarDescuentoDestacado3();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Producto 4
            /// 

            System.Threading.Thread.Sleep(400);

            paginaDescuentos.IngresarDescuentoDestacado4();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Producto 5
            /// 

            System.Threading.Thread.Sleep(400);

            paginaDescuentos.IngresarDescuentoDestacado5();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Producto 6
            /// 

            System.Threading.Thread.Sleep(400);

            paginaDescuentos.IngresarDescuentoDestacado6();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Producto 7
            /// 

            System.Threading.Thread.Sleep(400);

            paginaDescuentos.IngresarDescuentoDestacado7();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Producto 8
            /// 

            System.Threading.Thread.Sleep(400);

            paginaDescuentos.IngresarDescuentoDestacado8();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            /// Producto 9
            /// 

            System.Threading.Thread.Sleep(400);

            paginaDescuentos.IngresarDescuentoDestacado9();

            System.Threading.Thread.Sleep(2500);

            js.ExecuteScript("window.scrollBy(0,650);");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Quit();

        }

    }

}
