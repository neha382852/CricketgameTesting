﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CricketGame.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class MultiPlayerFeature : Xunit.IClassFixture<MultiPlayerFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "MultiPlayer.feature"
#line hidden
        
        public MultiPlayerFeature(MultiPlayerFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "MultiPlayer", "\tIn order to enjoy a game of cricket bewteen two players\r\n\tAs the audience\r\n\tI wa" +
                    "nt to know the winner of the match", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Player 1 and player 2 score is zero when game starts")]
        [Xunit.TraitAttribute("FeatureTitle", "MultiPlayer")]
        [Xunit.TraitAttribute("Description", "Player 1 and player 2 score is zero when game starts")]
        public virtual void Player1AndPlayer2ScoreIsZeroWhenGameStarts()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player 1 and player 2 score is zero when game starts", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.When("Player one has started a game of cricket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
 testRunner.When("Player two has started a game of cricket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.Then("the player one and player two score should be 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Player 1 should be able to score runs")]
        [Xunit.TraitAttribute("FeatureTitle", "MultiPlayer")]
        [Xunit.TraitAttribute("Description", "Player 1 should be able to score runs")]
        public virtual void Player1ShouldBeAbleToScoreRuns()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player 1 should be able to score runs", ((string[])(null)));
#line 11
this.ScenarioSetup(scenarioInfo);
#line 12
    testRunner.Given("Player one has started a game of cricket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
 testRunner.When("Player one scores 4 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("the player one score should be 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Player 2 should be able to score runs")]
        [Xunit.TraitAttribute("FeatureTitle", "MultiPlayer")]
        [Xunit.TraitAttribute("Description", "Player 2 should be able to score runs")]
        public virtual void Player2ShouldBeAbleToScoreRuns()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player 2 should be able to score runs", ((string[])(null)));
#line 16
this.ScenarioSetup(scenarioInfo);
#line 17
    testRunner.Given("Player two has started a game of cricket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
 testRunner.When("Player two scores 2 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.Then("the player two score should be 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Player 1 has scored some runs and gets out.")]
        [Xunit.TraitAttribute("FeatureTitle", "MultiPlayer")]
        [Xunit.TraitAttribute("Description", "Player 1 has scored some runs and gets out.")]
        public virtual void Player1HasScoredSomeRunsAndGetsOut_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player 1 has scored some runs and gets out.", ((string[])(null)));
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
    testRunner.Given("Player one has started a game of cricket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
 testRunner.Given("Player one has scored 4 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
 testRunner.And("Player one gets out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.When("Player one scores 3 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.Then("the player one score should be 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Player 2 has scored some runs and gets out.")]
        [Xunit.TraitAttribute("FeatureTitle", "MultiPlayer")]
        [Xunit.TraitAttribute("Description", "Player 2 has scored some runs and gets out.")]
        public virtual void Player2HasScoredSomeRunsAndGetsOut_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player 2 has scored some runs and gets out.", ((string[])(null)));
#line 28
this.ScenarioSetup(scenarioInfo);
#line 29
    testRunner.Given("Player two has started a game of cricket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
 testRunner.Given("Player two has scored 2 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 31
    testRunner.And("Player two gets out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.When("Player two scores 3 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
 testRunner.Then("the player two score should be 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="both players gets out and result is to be declared that player one is the winner." +
            "")]
        [Xunit.TraitAttribute("FeatureTitle", "MultiPlayer")]
        [Xunit.TraitAttribute("Description", "both players gets out and result is to be declared that player one is the winner." +
            "")]
        public virtual void BothPlayersGetsOutAndResultIsToBeDeclaredThatPlayerOneIsTheWinner_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("both players gets out and result is to be declared that player one is the winner." +
                    "", ((string[])(null)));
#line 35
this.ScenarioSetup(scenarioInfo);
#line 36
 testRunner.Given("Player one has started a game of cricket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 37
 testRunner.Given("Player one has scored 4 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 38
 testRunner.Given("Player one has scored 3 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
 testRunner.And("Player one gets out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
    testRunner.Given("Player two has started a game of cricket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 41
 testRunner.Given("Player two has scored 2 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 42
    testRunner.And("Player two gets out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.When("Both gets out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.Then("The result is player one is the winner.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="both players gets out and result is to be declared that player two is the winner." +
            "")]
        [Xunit.TraitAttribute("FeatureTitle", "MultiPlayer")]
        [Xunit.TraitAttribute("Description", "both players gets out and result is to be declared that player two is the winner." +
            "")]
        public virtual void BothPlayersGetsOutAndResultIsToBeDeclaredThatPlayerTwoIsTheWinner_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("both players gets out and result is to be declared that player two is the winner." +
                    "", ((string[])(null)));
#line 46
this.ScenarioSetup(scenarioInfo);
#line 47
 testRunner.Given("Player two has started a game of cricket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 48
 testRunner.Given("Player two has scored 2 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
 testRunner.Given("Player two has scored 2 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 50
 testRunner.And("Player two gets out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
    testRunner.Given("Player one has started a game of cricket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 52
 testRunner.Given("Player one has scored 2 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 53
    testRunner.And("Player one gets out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.When("Both gets out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.Then("The result is player two is the winner.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="both players gets out and result is to be declared that match is a tie.")]
        [Xunit.TraitAttribute("FeatureTitle", "MultiPlayer")]
        [Xunit.TraitAttribute("Description", "both players gets out and result is to be declared that match is a tie.")]
        public virtual void BothPlayersGetsOutAndResultIsToBeDeclaredThatMatchIsATie_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("both players gets out and result is to be declared that match is a tie.", ((string[])(null)));
#line 57
 this.ScenarioSetup(scenarioInfo);
#line 58
 testRunner.Given("Player two has started a game of cricket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 59
 testRunner.Given("Player two has scored 2 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 60
 testRunner.And("Player two gets out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
    testRunner.Given("Player one has started a game of cricket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 62
 testRunner.Given("Player one has scored 2 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 63
    testRunner.And("Player one gets out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.When("Both gets out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
 testRunner.Then("The result is match is a tie.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                MultiPlayerFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                MultiPlayerFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion