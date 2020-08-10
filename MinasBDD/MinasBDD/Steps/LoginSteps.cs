using System;
using TechTalk.SpecFlow;

namespace MinasBDD.Steps
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"the first number is juga")]
        public void DadoTheFirstNumberIsJuga()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Inicie el juego")]
        public void CuandoInicieElJuego()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"permite el ingreso del nickname pachuka")]
        public void EntoncesPermiteElIngresoDelNicknamePachuka()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
