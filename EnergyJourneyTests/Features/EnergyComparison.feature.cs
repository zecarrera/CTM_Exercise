﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace EnergyJourneyTests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("EnergyComparison")]
    public partial class EnergyComparisonFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "EnergyComparison.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "EnergyComparison", "\tIn order to find the one that suits me best\r\n\tAs a customer\r\n\tI want to compare " +
                    "energy providers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Energy Comparison is properly loaded")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void EnergyComparisonIsProperlyLoaded()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Energy Comparison is properly loaded", new string[] {
                        "smoke"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I have navigated to energy comparison page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.Then("the page\'s title should be  Energy - Compare Gas and Electricity Suppliers | Comp" +
                    "are The Market", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User can provide supplier information")]
        [NUnit.Framework.CategoryAttribute("acceptance")]
        [NUnit.Framework.TestCaseAttribute("PE2 6YS", "False", "Gas Only", "British Gas", "null", new string[0])]
        [NUnit.Framework.TestCaseAttribute("PE2 6YS", "True", "Gas Only", "British Gas", "null", new string[0])]
        public virtual void UserCanProvideSupplierInformation(string postCode, string billHandy, string compareItem, string gasSupplier, string energySupplier, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "acceptance"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User can provide supplier information", @__tags);
#line 12
this.ScenarioSetup(scenarioInfo);
#line 13
 testRunner.And(string.Format("I have entered a post code {0}", postCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And(string.Format("I have entered the bill handy {0}", billHandy), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And(string.Format("I have selected what to compare {0}", compareItem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.And(string.Format("I have selected my gas supplier {0}", gasSupplier), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And(string.Format("I have selected my electricity supplier {0}", energySupplier), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.When("I click next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.Then("Your Energy Form is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
