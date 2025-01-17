using Microsoft.Playwright;
using NUnit.Framework;
using Playwright_Practice.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Playwright_Practice.steps
{
    [Binding]
    public sealed class Flipkartdefinition:BasePage
    {

        FlipkartPage flipkartpage = new FlipkartPage();
        
       

        [Given(@"Iam on the Flipkart homepage")]
        public async Task GivenIamOnTheFlipkartHomepage()
        {
          await  base.NavigateToUrl("https://www.flipkart.com/");
        }


        [When(@"I search for ""(.*)"" product")]
        public async Task WhenISearchForProduct(string p0)
        {
            await base.ClickElement(FlipkartPage.FlipkartSearchBox);
            await base.FillInTextbox(FlipkartPage.FlipkartSearchBox, p0);
            await base.ClickEnter(FlipkartPage.FlipkartSearchBox, "Enter");
        }

        [When(@"Select first product")]
        public async Task WhenSelectFirstProduct()
        {
            await Page.ClickAsync(FlipkartPage.FirstProduct);    
        }
        [Then(@"verify product")]
        public void ThenVerifyProduct()
        {
            Assert.IsTrue(FlipkartPage.IphoneProduct.Contains("Apple iPhone 15 Pro Max"));
        }

























    }
}
