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
namespace DevEduEducationSystemQAA.WEB.Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Registration_Window")]
    public partial class Registration_WindowFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Registration_Window.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Registration_Window", "Registration window (окно регистрации)", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("As a user, I want to register")]
        [NUnit.Framework.CategoryAttribute("RegistrationWindow")]
        [NUnit.Framework.TestCaseAttribute("1920", "1080", null)]
        public virtual void AsAUserIWantToRegister(string length, string width, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "RegistrationWindow"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("length", length);
            argumentsOfScenario.Add("width", width);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("As a user, I want to register", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
    testRunner.Given(string.Format("I enter the registration window with the window size {0} and {1}", length, width), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                            "Surname",
                            "Name",
                            "Patronymic",
                            "BirthDate",
                            "Password",
                            "RepeatPassword",
                            "Email",
                            "Phone"});
                table21.AddRow(new string[] {
                            "Джеймс",
                            "Гарри",
                            "Поттер",
                            "31.07.1998",
                            "HarryPotter",
                            "HarryPotter",
                            "Harry@mail.ru",
                            "+79211234567"});
#line 8
 testRunner.And("I am a user fill in all required fields", ((string)(null)), table21, "And ");
#line hidden
#line 11
 testRunner.When("Click on register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.Given("Click checkbox on the privacy policy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 15
 testRunner.When("Click on register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.Then("Сheck that a registered user will log into the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 17
 testRunner.And("Delete User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("As a user when registering, I want to click on the \"Cancel\" button")]
        [NUnit.Framework.CategoryAttribute("RegistrationWindow")]
        [NUnit.Framework.TestCaseAttribute("1920", "1080", null)]
        public virtual void AsAUserWhenRegisteringIWantToClickOnTheCancelButton(string length, string width, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "RegistrationWindow"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("length", length);
            argumentsOfScenario.Add("width", width);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("As a user when registering, I want to click on the \"Cancel\" button", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 23
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 24
 testRunner.Given(string.Format("I enter the registration window with the window size {0} and {1}", length, width), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                            "Surname",
                            "Name",
                            "Patronymic",
                            "BirthDate",
                            "Password",
                            "RepeatPassword",
                            "Email",
                            "Phone"});
                table22.AddRow(new string[] {
                            "Джеймс",
                            "Гарри",
                            "Поттер",
                            "31.07.1998",
                            "HarryPotter",
                            "HarryPotter",
                            "Harry@mail.ru",
                            "+79211234567"});
#line 25
 testRunner.And("I am a user fill in all required fields", ((string)(null)), table22, "And ");
#line hidden
#line 28
 testRunner.And("Click checkbox on the privacy policy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.When("Click on \"Cancel\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
 testRunner.Then("The registration window should return to the Login window.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("As a user, I want to register.Negative")]
        [NUnit.Framework.CategoryAttribute("Negative")]
        [NUnit.Framework.TestCaseAttribute("Джеймс", "Гарри", "Поттер", "30.01.1800", "HarryPotter", "HarryPotter", "Harry1@mail.ru", "+79211234567", "1920", "1080", null)]
        [NUnit.Framework.TestCaseAttribute("Джеймс", "Гарри", "Поттер", "31.07.1998", "HarryPotter", "HarryPotter", "Harry2@mail.ru", "Чукча кушать хочет", "1920", "1080", null)]
        [NUnit.Framework.TestCaseAttribute("Джеймс", "Гарри", "Поттер", "31.07.1998", "HarryPotter", "HarryPotter", "Я email", "+79211234567", "1920", "1080", null)]
        public virtual void AsAUserIWantToRegister_Negative(string surname, string name, string patronymic, string birthDate, string password, string repeatPassword, string email, string phone, string length, string width, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Negative"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Surname", surname);
            argumentsOfScenario.Add("Name", name);
            argumentsOfScenario.Add("Patronymic", patronymic);
            argumentsOfScenario.Add("BirthDate", birthDate);
            argumentsOfScenario.Add("Password", password);
            argumentsOfScenario.Add("RepeatPassword", repeatPassword);
            argumentsOfScenario.Add("Email", email);
            argumentsOfScenario.Add("Phone", phone);
            argumentsOfScenario.Add("length", length);
            argumentsOfScenario.Add("width", width);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("As a user, I want to register.Negative", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 37
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 38
 testRunner.Given(string.Format("I enter the registration window with the window size {0} and {1}", length, width), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                            "Surname",
                            "Name",
                            "Patronymic",
                            "BirthDate",
                            "Password",
                            "RepeatPassword",
                            "Email",
                            "Phone"});
                table23.AddRow(new string[] {
                            string.Format("{0}", surname),
                            string.Format("{0}", name),
                            string.Format("{0}", patronymic),
                            string.Format("{0}", birthDate),
                            string.Format("{0}", password),
                            string.Format("{0}", repeatPassword),
                            string.Format("{0}", email),
                            string.Format("{0}", phone)});
#line 39
 testRunner.And("I am a user fill in all required fields", ((string)(null)), table23, "And ");
#line hidden
#line 42
 testRunner.And("Click checkbox on the privacy policy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.When("Click on register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.Then("The system should respond, the register button will be inactive", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 45
 testRunner.And("Delete users", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion