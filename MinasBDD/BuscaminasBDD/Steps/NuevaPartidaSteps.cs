using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BuscaminasBDD.Steps
{
    [Binding]
    public class NuevaPartidaSteps
    {
        IWebDriver webDriver = new ChromeDriver(@"C:\Users\arman\source\repos\BuscaminasBDD\MinasBDD\SofwareTerceros");

        [Given(@"que al click en nueva partida")]
        public void DadoQueAlClickEnNuevaPartida()
        {
            webDriver.Url = "http://localhost/MinasTDD/?c=Jugador&a=Jugar";
            webDriver.Navigate();
            var boton = webDriver.FindElement(By.Id("NuevaP"));
            boton.Click();
        }
        
        [When(@"el juego reiniciara la partida de buscaminas")]
        public void CuandoElJuegoReiniciaraLaPartidaDeBuscaminas()
        {
            webDriver.Url = "http://localhost/MinasTDD/?c=Jugador&a=Jugar";
            webDriver.Navigate();
        }
        
        [Then(@"encontraremos el numero de partida incrementado en (.*)")]
        public void EntoncesEncontraremosElNumeroDePartidaIncrementadoEn(string npartidas)
        {
            webDriver.Url = "http://localhost/MinasTDD/?c=Jugador&a=Jugar";
            webDriver.Navigate();
            var element = webDriver.FindElement(By.Name("partida"));
            string str = element.GetAttribute("value");

            Assert.AreEqual(npartidas, str);
        }
    }
}
