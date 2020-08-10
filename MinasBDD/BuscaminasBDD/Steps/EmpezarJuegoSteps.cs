using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BuscaminasBDD.Steps
{
    [Binding]
    public class EmpezarJuegoSteps
    {

        IWebDriver webDriver = new ChromeDriver(@"C:\Users\arman\source\repos\BuscaminasBDD\MinasBDD\SofwareTerceros");


        [Given(@"que al click en jugar")]
        public void DadoQueAlClickEnJugar()
        {
            webDriver.Url = "http://localhost/MinasTDD/";
            webDriver.Navigate();
            var boton = webDriver.FindElement(By.Name("Jugar"));
            boton.Click();
        }
        
        [When(@"el juego solicita ingresar su nickname ""(.*)""")]
        public void CuandoElJuegoSolicitaIngresarSuNickname(string nickname)
        {
            webDriver.Url = "http://localhost/MinasTDD/?c=Jugador&a=Crud";
            webDriver.Navigate();
            var element = webDriver.FindElement(By.Name("username"));
            element.SendKeys(nickname);
            var boton = webDriver.FindElement(By.Name("comenzar"));
            boton.Click();
        }
        
        [Then(@"nuestro nickname de juego sera ""(.*)""")]
        public void EntoncesNuestroNicknameDeJuegoSera(string username)
        {
            webDriver.Url = "http://localhost/MinasTDD/?c=Jugador&a=Jugar";
            webDriver.Navigate();
            var element = webDriver.FindElement(By.Name("nickname"));
            string str = element.GetAttribute("value");

            Assert.AreEqual(username, str);

        }
    }
}
