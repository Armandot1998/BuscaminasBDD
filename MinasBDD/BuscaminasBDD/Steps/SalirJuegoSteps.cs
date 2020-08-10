using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BuscaminasBDD.Steps
{
    [Binding]
    public class SalirJuegoSteps
    {
        IWebDriver webDriver = new ChromeDriver(@"C:\Users\arman\source\repos\BuscaminasBDD\MinasBDD\SofwareTerceros");

        [Given(@"que al click en salir")]
        public void DadoQueAlClickEnSalir()
        {
            webDriver.Url = "http://localhost/MinasTDD/?c=Jugador&a=Jugar";
            webDriver.Navigate();
            var boton = webDriver.FindElement(By.Id("Salir"));
            boton.Click();
        }
        
        [When(@"el juego volvera a su pagina de inicio")]
        public void CuandoElJuegoVolveraASuPaginaDeInicio()
        {
            webDriver.Url = "http://localhost/MinasTDD/";
            webDriver.Navigate();
        }
        
        [Then(@"encontraremos otra vez la opcion ""(.*)""")]
        public void EntoncesEncontraremosOtraVezLaOpcion(string test)
        {
            webDriver.Url = "http://localhost/MinasTDD/";
            webDriver.Navigate();
            var element = webDriver.FindElement(By.Name("Jugar"));
            string str = element.GetAttribute("Name");

            Assert.AreEqual(test, str);
        }
    }
}
