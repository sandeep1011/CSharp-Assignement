using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace assignment
{
    [Binding]
    public class ValidationTheWorkingOfAPIOnReqre_InSteps
    {
        ApiBaseClass apObj;
        [When(@"I register with  (.*) and (.*)")]
        public void WhenIRegisterWithAnd(string p0, string p1)
        {
            apObj = new ApiBaseClass();
            apObj.url();
            apObj.Registration(p0,p1);
            
        }
        
        
        
        [When(@"user send a GET request")]
        public void WhenUserSendAGETRequest()
        {
            apObj = new ApiBaseClass();
            apObj.url();
            apObj.getUserList();
        }
        
        [Then(@"Registeration should be successfull")]
        public void ThenRegisterationShouldBeSuccessfull()
        {
            Assert.IsTrue(apObj.verify_registeration());
        }
        
        [Then(@"Token shoud be returned")]
        public void ThenTokenShoudBeReturned()
        {
            Assert.IsTrue(apObj.token_generation());
        }
        
        [Then(@"The registeration should not be successfull")]
        public void ThenTheRegisterationShouldNotBeSuccessfull()
        {
            Assert.IsFalse(apObj.verify_registeration());
        }
        
        [Then(@"should be getting a list of users")]
        public void ThenShouldBeGettingAListOfUsers()
        {
            Assert.IsTrue(apObj.verify_responseNusers());
        }
    }
}
