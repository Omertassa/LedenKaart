using System;
using TechTalk.SpecFlow;
using Ledenkaart_Verzender;

namespace Ledenkaart_Tester
{

    

    [Binding]
    public class ImporterenVanEenBestandSteps
    {

        


       [Given(@"The file to be imported is already in use by another program")]
        public void GivenTheFileToBeImportedIsAlreadyInUseByAnotherProgram()
        {
        
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press the Import button")]
        public void WhenIPressTheImportButton()
        {
        }
        
        [When(@"When I select the file")]
        public void WhenWhenISelectTheFile()
        {
            ScenarioContext.Current.Pending();
        }


        [Then(@"A messagebox will appear with an error message")]
        public void ThenAMessageboxWillAppearWithAnErrorMessage()
        {
            ScenarioContext.Current.Pending();
        }


        [Then(@"The right panel will not be accesible")]
        public void ThenTheRightPanelWillNotBeAccesible()
        {
            ScenarioContext.Current.Pending();
        }


        [Then(@"The Status label will say ""(.*)""")]
        public void ThenTheStatusLabelWillSay(string p0)
        {
            ScenarioContext.Current.Pending();
        }


    }
}
