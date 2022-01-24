using System;
using TechTalk.SpecFlow;

namespace SpecFlowGettingStarted.StepDefinitions
{
    [Binding]
    public class RetreiveLocationDataBasedOnCountryAndZipCodeStepDefinitions
    {
        [Given(@"the country code (us|ca) and zip code (\d+)")]
        public void GivenTheCountryCodeUsAndZipCode(string countryCode, int zipCode)
        {
        }

        [When(@"I request the locations? corresponding to these codes")]
        public void WhenIRequestTheLocationsCorrespondingToTheseCodes()
        {
        }

        [Then(@"the response contains the name (.+)")]
        public void ThenTheResponseContainsTheNameBeverlyHills(string placeName)
        {
        }

        [Then(@"the response contains exactly (\d+) locations")]
        public void ThenTheResponseContainsExactlyLocation(int p0)
        {
        }
    }
}
