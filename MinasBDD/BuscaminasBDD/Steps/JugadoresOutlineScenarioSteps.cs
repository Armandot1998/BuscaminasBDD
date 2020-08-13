using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace BuscaminasBDD.Steps
{
    [Binding]
    public class JugadoresOutlineScenarioSteps
    {
        IWebDriver webDriver = new ChromeDriver(@"C:\Users\arman\source\repos\BuscaminasBDD\MinasBDD\SofwareTerceros");

        [Given(@"the player is in game")]
        public void GivenThePlayerIsInGame()
        {
            webDriver.Url = "http://localhost/MinasTDD/";
            webDriver.Navigate();
            var boton = webDriver.FindElement(By.Name("Jugar"));
            boton.Click();
        }
        
        [Given(@"the player click on play and write""(.*)""")]
        public void GivenThePlayerClickOnPlayAndWrite(string nickname)
        {
            webDriver.Url = "http://localhost/MinasTDD/?c=Jugador&a=Crud";
            webDriver.Navigate();
            var element = webDriver.FindElement(By.Name("username"));
            element.SendKeys(nickname);
            var boton = webDriver.FindElement(By.Name("comenzar"));
            boton.Click();
        }
        
        [Given(@"the player click new game for (.*)")]
        public void GivenThePlayerClickNewGameFor(int npartida)
        {
            for (int i = 1; i < npartida; i++)
            {
                webDriver.Url = "http://localhost/MinasTDD/?c=Jugador&a=Jugar";
                webDriver.Navigate();
                var boton = webDriver.FindElement(By.Id("NuevaP"));
                boton.Click();
            }
        }
        
        [When(@"the game plays with the players")]
        public void WhenTheGamePlaysWithThePlayers()
        {
            webDriver.Url = "http://localhost/MinasTDD/?c=Jugador&a=Jugar";
            webDriver.Navigate();
        }
        
        [Then(@"the result of all ngames should be a ""(.*)""")]
        public void ThenTheResultOfAllNgamesShouldBeA(string npartidas)
        {
            webDriver.Url = "http://localhost/MinasTDD/?c=Jugador&a=Jugar";
            webDriver.Navigate();
            var element = webDriver.FindElement(By.Name("partida"));
            string str = element.GetAttribute("value");

            Assert.AreEqual(npartidas, str);
        }
    }
}
