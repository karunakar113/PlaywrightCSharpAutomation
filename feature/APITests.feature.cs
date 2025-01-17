﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Playwright_Practice.Feature
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("API Tests")]
    public partial class APITestsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "APITests.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "feature", "API Tests", null, ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Retrieve information from the endpoint")]
        [NUnit.Framework.CategoryAttribute("APItests")]
        [NUnit.Framework.CategoryAttribute("1")]
        [NUnit.Framework.TestCaseAttribute("7637554", null)]
        public void RetrieveInformationFromTheEndpoint(string iD, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "APItests",
                    "1"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("ID", iD);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Retrieve information from the endpoint", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
  testRunner.Given(string.Format("The API endpoint has baseURI \"https://gorest.co.in\" and basePath \'/public/v2/user" +
                            "s/\' and ID \'{0}\'", iD), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
  testRunner.When("I send a GET request to the endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 7
  testRunner.Then("I should receive a response with status code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 8
  testRunner.Then(string.Format("the JSON path \"id\" should have value \"{0}\"", iD), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("POST new data to the endpoint with authentication")]
        [NUnit.Framework.CategoryAttribute("APItests")]
        [NUnit.Framework.CategoryAttribute("2")]
        [NUnit.Framework.TestCaseAttribute("Jane Smith", "jane_Smith@test.com", "male", "active", null)]
        public void POSTNewDataToTheEndpointWithAuthentication(string name, string email, string gender, string status, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "APItests",
                    "2"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Name", name);
            argumentsOfScenario.Add("Email", email);
            argumentsOfScenario.Add("Gender", gender);
            argumentsOfScenario.Add("Status", status);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("POST new data to the endpoint with authentication", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 15
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 16
  testRunner.Given("The API endpoint has baseURI \"https://gorest.co.in\" and basePath \"/public/v2/user" +
                        "s\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 17
  testRunner.When(string.Format("I send a POST request with access token in the header and \"{0}\" \"{1}\" \"{2}\" \"{3}\"" +
                            " to the endpoint", name, email, gender, status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
  testRunner.Then("I should receive a response with status code 201", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 19
  testRunner.Then(string.Format("the JSON path \"name\" should have value \"{0}\"", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 20
  testRunner.Then(string.Format("the JSON path \"email\" should have value \"{0}\"", email), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 21
  testRunner.Then(string.Format("the JSON path \"gender\" should have value \"{0}\"", gender), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
  testRunner.Then(string.Format("the JSON path \"status\" should have value \"{0}\"", status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("PUT new data to the endpoint")]
        [NUnit.Framework.CategoryAttribute("APItests")]
        [NUnit.Framework.CategoryAttribute("3")]
        [NUnit.Framework.TestCaseAttribute("7636791", "kamal", "kamal@example.com", "male", "active", null)]
        public void PUTNewDataToTheEndpoint(string iD, string name, string email, string gender, string status, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "APItests",
                    "3"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("ID", iD);
            argumentsOfScenario.Add("Name", name);
            argumentsOfScenario.Add("Email", email);
            argumentsOfScenario.Add("Gender", gender);
            argumentsOfScenario.Add("Status", status);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PUT new data to the endpoint", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 29
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 30
  testRunner.Given(string.Format("The API endpoint has baseURI \"https://gorest.co.in\" and basePath \'/public/v2/user" +
                            "s/\' and ID \'{0}\'", iD), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 31
  testRunner.When(string.Format("I send a PUT request with access token in the header and \"{0}\" \"{1}\" \"{2}\" \"{3}\" " +
                            "to the endpoint", name, email, gender, status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
  testRunner.Then("I should receive a response with status code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 33
  testRunner.Then(string.Format("the JSON path \"name\" should have value \"{0}\"", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 34
  testRunner.Then(string.Format("the JSON path \"email\" should have value \"{0}\"", email), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 35
  testRunner.Then(string.Format("the JSON path \"gender\" should have value \"{0}\"", gender), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 36
  testRunner.Then(string.Format("the JSON path \"status\" should have value \"{0}\"", status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("PATCH new Name and Gender to the endpoint")]
        [NUnit.Framework.CategoryAttribute("APItests")]
        [NUnit.Framework.CategoryAttribute("4")]
        [NUnit.Framework.TestCaseAttribute("7636791", "kane", "kamal@example.com", "female", "active", null)]
        public void PATCHNewNameAndGenderToTheEndpoint(string iD, string name, string email, string gender, string status, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "APItests",
                    "4"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("ID", iD);
            argumentsOfScenario.Add("Name", name);
            argumentsOfScenario.Add("Email", email);
            argumentsOfScenario.Add("Gender", gender);
            argumentsOfScenario.Add("Status", status);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PATCH new Name and Gender to the endpoint", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 42
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 43
  testRunner.Given(string.Format("The API endpoint has baseURI \"https://gorest.co.in\" and basePath \'/public/v2/user" +
                            "s/\' and ID \'{0}\'", iD), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 44
  testRunner.When(string.Format("I send a PATCH request with access token in the header and \"{0}\" \"{1}\" to the end" +
                            "point", name, gender), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 45
  testRunner.Then("I should receive a response with status code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 46
  testRunner.Then(string.Format("the JSON path \"name\" should have value \"{0}\"", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 47
  testRunner.Then(string.Format("the JSON path \"email\" should have value \"{0}\"", email), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 48
  testRunner.Then(string.Format("the JSON path \"gender\" should have value \"{0}\"", gender), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 49
  testRunner.Then(string.Format("the JSON path \"status\" should have value \"{0}\"", status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DELETE data from the endpoint")]
        [NUnit.Framework.CategoryAttribute("APItests")]
        [NUnit.Framework.CategoryAttribute("5")]
        [NUnit.Framework.TestCaseAttribute("7632167", null)]
        public void DELETEDataFromTheEndpoint(string iD, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "APItests",
                    "5"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("ID", iD);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DELETE data from the endpoint", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 55
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 56
  testRunner.Given(string.Format("The API endpoint has baseURI \"https://gorest.co.in\" and basePath \'/public/v2/user" +
                            "s/\' and ID \'{0}\'", iD), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 57
  testRunner.When(string.Format("I send a DELETE request with access token in the header and \"{0}\" to the endpoint" +
                            "", iD), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 58
  testRunner.Then("I should receive a response with status code 204", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create new post to the endpoint")]
        [NUnit.Framework.CategoryAttribute("APItests")]
        [NUnit.Framework.CategoryAttribute("6")]
        [NUnit.Framework.TestCaseAttribute("7631899", "To create a new post for a user.", "New post for the given user is created and unquie ID is assigned for the new post" +
            ".", null)]
        public void CreateNewPostToTheEndpoint(string iD, string title, string body, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "APItests",
                    "6"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("ID", iD);
            argumentsOfScenario.Add("Title", title);
            argumentsOfScenario.Add("Body", body);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create new post to the endpoint", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 64
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 65
  testRunner.Given(string.Format("The API endpoint has baseURL \"https://gorest.co.in\" and basePath \"/public/v2/user" +
                            "s/\" and ID \"{0}\" and endpoint \"/posts\"", iD), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 66
  testRunner.When(string.Format("I send a CREATE POST request with access token in the header and \"{0}\" \"{1}\" to t" +
                            "he endpoint", title, body), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 67
  testRunner.Then("I should receive a response with status code 201", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 68
  testRunner.Then(string.Format("the JSON path \"title\" should have value \"{0}\"", title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 69
  testRunner.Then(string.Format("the JSON path \"body\" should have value \"{0}\"", body), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create new todo to the endpoint")]
        [NUnit.Framework.CategoryAttribute("APItests")]
        [NUnit.Framework.CategoryAttribute("7")]
        [NUnit.Framework.TestCaseAttribute("7631899", "This is a new todo.", "completed", null)]
        public void CreateNewTodoToTheEndpoint(string iD, string title, string status, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "APItests",
                    "7"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("ID", iD);
            argumentsOfScenario.Add("Title", title);
            argumentsOfScenario.Add("Status", status);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create new todo to the endpoint", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 76
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 77
  testRunner.Given(string.Format("The API endpoint has baseURL \"https://gorest.co.in\" and basePath \"/public/v2/user" +
                            "s/\" and ID \"{0}\" and endpoint \"/todos\"", iD), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 78
  testRunner.When(string.Format("I send a CREATE TODO request with access token in the header and \"{0}\" \"{1}\" to t" +
                            "he endpoint", title, status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 79
  testRunner.Then("I should receive a response with status code 201", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 80
  testRunner.Then(string.Format("the JSON path \"title\" should have value \"{0}\"", title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 81
  testRunner.Then(string.Format("the JSON path \"status\" should have value \"{0}\"", status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
