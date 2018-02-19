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

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div[3]/div/div[2]/div[2]/a[2]")]
        public IWebElement btnSiguienteCarrusel { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div[3]/div/div[2]/div[2]/a[1]")]
        public IWebElement btnAnteriorCarrusel { get; set; }

        /// <summary>
        /// Imagenes Carrusel Home Beneficios
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div[3]/div/div[1]/ul/li[2]/a/img")]
        public IWebElement PrimerImagenCarrusel { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[3]/div/div[1]/ul/li[3]/a/img")]
        public IWebElement SegundaImagenCarrusel { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[3]/div/div[1]/ul/li[4]/a/img")]
        public IWebElement TerceraImagenCarrusel { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[3]/div/div[1]/ul/li[5]/a/img")]
        public IWebElement CuartaImagenCarrusel { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[3]/div/div[1]/ul/li[6]/a/img")]
        public IWebElement QuintaImagenCarrusel { get; set; }

        ///<summary>
        ///Botones circulares Carrusel Home
        /// </summary>
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[2]/div/div[2]/div[1]/div[1]/a")]
        public IWebElement btnCircularCarruselUno { get; set; }

        [FindsBy(How = How.ClassName, Using = "bx-pager-link")]
        public IWebElement btnCircularCarruselDos { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[2]/div/div[2]/div[1]/div[3]/a")]
        public IWebElement btnCircularCarruselTres { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[2]/div/div[2]/div[1]/div[4]/a")]
        public IWebElement btnCircularCarruselCuatro { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[2]/div/div[2]/div[1]/div[5]/a")]
        public IWebElement btnCircularCarruselQuinto { get; set; }

        ///<summary>
        /// Link Destacados
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[2]/a/img")]
        public IWebElement CalugaCorreosChile { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[5]/a/img")]
        public IWebElement CalugaLinio { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[6]/a/img")]
        public IWebElement CalugaFrigosorno { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[6]/a/img")]
        public IWebElement CalugaSamsung { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[8]/a/img")]
        public IWebElement CalugaSalcobrand { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[9]/a/img")]
        public IWebElement CalugaCorteIngles { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[10]/a/img")]
        public IWebElement CalugaLibreriaNacional { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[11]/a/img")]
        public IWebElement CalugaDespegar { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[12]/a/img")]
        public IWebElement CalugaMovistar { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[12]/a/img")]
        public IWebElement CalugaReifstore { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[14]/a/img")]
        public IWebElement CalugaA3D { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[15]/a/img")]
        public IWebElement CalugaViajesNovajet { get; set; }

        ///<summary>
        /// Botones Calugas Home
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/button[2]")]
        public IWebElement btnCalugasNext { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/button[1]")]
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
        /// Sección Ingresa (Login)
        /// </summary>

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement txtEmail { get; set; }

        [FindsBy(How = How.Id, Using = "pass")]
        public IWebElement txtpassword { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[1]/div/nav/ul/li[1]/div/div/div/form/input[5]")]
        public IWebElement btnIngresa { get; set; }

        /// <summary>
        /// Header BT
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[1]/div/nav/ul/li[1]")]
        public IWebElement menuIngresaCuenta { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[1]/div/nav/ul/li[2]/a/span")]
        public IWebElement menuInformacionAyuda { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=" + "modal - carro" + "]/span")]
        public IWebElement menuCarrodeCompra { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[1]/div/nav/ul/li[4]/a/span")]
        public IWebElement menuSeguimientoLinea { get; set; }

        /// <summary>
        /// Botón Favoritos Viajes
        /// </summary>
        /// 

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[4]/section/div[1]/div[2]/div[3]/ul/ul/li/a")]
        public IWebElement btnFavoritosViajes { get; set; }

        /// <summary>
        /// Botón Favoritos Tienda
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[4]/section/div[2]/div[2]/div[3]/ul/ul/li[1]/a")]
        public IWebElement btnFavoritosTienda { get; set; }

        /// <summary>
        /// Botón Favoritos Descuentos
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[4]/section/div[3]/div[2]/div[3]/ul/ul/li/a")]
        public IWebElement btnFavoritosDescuentos { get; set; }

        /// <summary>
        /// Imagen BT
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div/section/div/div[5]/h1/a")]
        public IWebElement ImagenBT { get; set; }

        /// <summary>
        /// Viaje X
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div[4]/section/div[1]/div[3]/div[2]/h3/a")]
        public IWebElement ViajeX { get; set; }


        ///<summary>
        /// Boton Cotizar
        /// </summary>
        /// 
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/div/div/div[4]/div[2]/div[2]/div[1]/div/div/div[3]/div[2]/article/div[2]/div[1]/div[2]/div/form/input[9]")]
        public IWebElement btnCotizarViaje { get; set; }


        ///<summary>
        /// Botón Carro de Compra
        /// </summary>
        /// 
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div[4]/section/div[2]/div[2]/div[3]/ul/ul/li[2]/a")]
        public IWebElement btnAgregarCarritoCompra { get; set; }

        ///<summary>
        /// Botones Next y Prev Carrusel Home BT
        /// </summary>

        public void BtnNextPrevCarruselHomeBT()
        {
            System.Threading.Thread.Sleep(2000);

            btnSiguienteCarrusel.Click();

            System.Threading.Thread.Sleep(2000);

            btnAnteriorCarrusel.Click();

            System.Threading.Thread.Sleep(2000);

        }
       
        ///<summary>
        /// Validar botones o Carrusel Home BT
        /// </summary>
        public void BtnSliderOCarruselHomeBT()
        {
            System.Threading.Thread.Sleep(1000);

            btnCircularCarruselDos.Click();

            System.Threading.Thread.Sleep(1500);

            btnCircularCarruselDos.Click();

            System.Threading.Thread.Sleep(1000);

            btnCircularCarruselDos.Click();

            System.Threading.Thread.Sleep(1000);

            btnCircularCarruselDos.Click();

            System.Threading.Thread.Sleep(1000);

            btnCircularCarruselDos.Click();

            System.Threading.Thread.Sleep(3000);
        }

        /// <summary>
        /// Ingreso de Link de Sliders
        /// </summary>
        /// 

        public void GetPrimeraImagenCarrusel()
        {
            PrimerImagenCarrusel.Click();
        }

        public void GetSegundaImagenCarrusel()
        {
            SegundaImagenCarrusel.Click();
        }

        public void GetTerceraImagenCarrusel()
        {
            TerceraImagenCarrusel.Click();
        }

        public void GetCuartaImagenCarrusel()
        {
            CuartaImagenCarrusel.Click();
        }

        /// <summary>
        /// Método Pulsar Botones Carrusel
        /// </summary>
        
        public void getBtnNextCarrusel()
        {
            btnSiguienteCarrusel.Click();
        }

        public void getBtnPrevCarrusel()
        {
            btnSiguienteCarrusel.Click();
        }
        
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

        ///<summary>
        /// Metódo Login BT
        /// </summary>

        public void logearse(string username, string password)
        {
            System.Threading.Thread.Sleep(2000);

            menuIngresaCuenta.Click();

            System.Threading.Thread.Sleep(2000);

            txtEmail.SendKeys(username);

            txtpassword.SendKeys(password);

            System.Threading.Thread.Sleep(2000);

            btnIngresa.Click();

        }

        ///<summary>
        /// Validar Carrusel BT
        /// </summary>

        public void BtnNextCarrusel()
        {
            System.Threading.Thread.Sleep(300);

            btnSiguienteCarrusel.Click();

            System.Threading.Thread.Sleep(300);

            btnSiguienteCarrusel.Click();

            System.Threading.Thread.Sleep(300);

            btnSiguienteCarrusel.Click();

            System.Threading.Thread.Sleep(300);
        
            btnSiguienteCarrusel.Click();

            System.Threading.Thread.Sleep(300);

        }

        ///<summary>
        /// Método Agregar Favoritos
        /// </summary>
        public void IngresarFavoritos(string correo, string pass)
        {
            System.Threading.Thread.Sleep(2000);

            menuIngresaCuenta.Click();

            System.Threading.Thread.Sleep(2000);

            txtEmail.SendKeys(correo);

            txtpassword.SendKeys(pass);

            System.Threading.Thread.Sleep(2000);

            btnIngresa.Click();

            System.Threading.Thread.Sleep(2000);

            ImagenBT.Click();

            System.Threading.Thread.Sleep(2000);

        }

        ///<summary>
        /// Utilizar el botón Agregar Carro
        /// </summary>

       public void IngresarBotónAgregarCarroProducto()
        {
            btnAgregarCarritoCompra.Click();
        }
       


        ///<summary>
        /// Utilizar botón Ingresar Viaje X
        /// </summary>

        public void IngresarViajeX()
        {
            System.Threading.Thread.Sleep(2000);

            ViajeX.Click();
        }

        /// <summary>
        /// Utilizar botón Cotizar
        /// </summary>
        /// 
        public void IngresoBotonCotizar()
        {
            System.Threading.Thread.Sleep(2000);

            btnCotizarViaje.Click();
        }

        /// <summary>
        /// Botones Favoritos
        /// </summary>

        public void FavoritosViajes()
        {
            btnFavoritosViajes.Click();
        }

        public void FavoritosTienda()
        {
            btnFavoritosTienda.Click();
        }

        public void FavoritosDescuentos()
        {
            btnFavoritosDescuentos.Click();
        }

        public void IngresaImagenBT()
        {
            ImagenBT.Click();
        }

        ///<sumary>
        /// Metodo Ir a Viajes
        /// </sumary>
        /// 

        public void IraViajes()
        {
            System.Threading.Thread.Sleep(2000);

            menuViajes.Click();

            System.Threading.Thread.Sleep(2000);

            opcionMenuIrViajes.Click();

            System.Threading.Thread.Sleep(2000);
        }

        /// <summary>
        /// Método Ir a Tienda
        /// </summary>
        public void IraTienda()
        {
            System.Threading.Thread.Sleep(2000);

            menuTienda.Click();

            System.Threading.Thread.Sleep(2000);

            opcionMenuIrTienda.Click();

            System.Threading.Thread.Sleep(2000);
        }

        /// <summary>
        /// Método Ir a Descuento
        /// </summary>
        /// 

        public void IraDescuento()
        {
            System.Threading.Thread.Sleep(6000);

            menuDescuento.Click();

            System.Threading.Thread.Sleep(6000);

            opcionMenuIrDescuento.Click();

            System.Threading.Thread.Sleep(6000);
        }
    }

}