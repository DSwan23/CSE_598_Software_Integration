namespace AccessServiceConsoleApplication {
    
    #line 21 "C:\Users\madma\Documents\GitRepos\CSE_598_Software_Integration\Project_2\Assignment_3\AccessServiceConsoleApplication\Workflow1.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\madma\Documents\GitRepos\CSE_598_Software_Integration\Project_2\Assignment_3\AccessServiceConsoleApplication\Workflow1.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 22 "C:\Users\madma\Documents\GitRepos\CSE_598_Software_Integration\Project_2\Assignment_3\AccessServiceConsoleApplication\Workflow1.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\madma\Documents\GitRepos\CSE_598_Software_Integration\Project_2\Assignment_3\AccessServiceConsoleApplication\Workflow1.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\madma\Documents\GitRepos\CSE_598_Software_Integration\Project_2\Assignment_3\AccessServiceConsoleApplication\Workflow1.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\madma\Documents\GitRepos\CSE_598_Software_Integration\Project_2\Assignment_3\AccessServiceConsoleApplication\Workflow1.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 23 "C:\Users\madma\Documents\GitRepos\CSE_598_Software_Integration\Project_2\Assignment_3\AccessServiceConsoleApplication\Workflow1.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 24 "C:\Users\madma\Documents\GitRepos\CSE_598_Software_Integration\Project_2\Assignment_3\AccessServiceConsoleApplication\Workflow1.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 25 "C:\Users\madma\Documents\GitRepos\CSE_598_Software_Integration\Project_2\Assignment_3\AccessServiceConsoleApplication\Workflow1.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 26 "C:\Users\madma\Documents\GitRepos\CSE_598_Software_Integration\Project_2\Assignment_3\AccessServiceConsoleApplication\Workflow1.xaml"
    using AccessServiceConsoleApplication.PythagoreanService;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\madma\Documents\GitRepos\CSE_598_Software_Integration\Project_2\Assignment_3\AccessServiceConsoleApplication\Workflow1.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class Workflow1 : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = Workflow1_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow1_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext2_ForReadOnly valDataContext0 = ((Workflow1_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow1_TypedDataContext2(locations, activityContext, true);
                }
                Workflow1_TypedDataContext2 refDataContext1 = ((Workflow1_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext1.GetLocation<double>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow1_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3_ForReadOnly valDataContext2 = ((Workflow1_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow1_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3_ForReadOnly valDataContext3 = ((Workflow1_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4_ForReadOnly valDataContext4 = ((Workflow1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow1_TypedDataContext4(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4 refDataContext5 = ((Workflow1_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext5.GetLocation<double>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4_ForReadOnly valDataContext6 = ((Workflow1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4_ForReadOnly valDataContext7 = ((Workflow1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow1_TypedDataContext4(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4 refDataContext8 = ((Workflow1_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext8.GetLocation<double>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4_ForReadOnly valDataContext9 = ((Workflow1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4_ForReadOnly valDataContext10 = ((Workflow1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow1_TypedDataContext4(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4 refDataContext11 = ((Workflow1_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext11.GetLocation<double>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow1_TypedDataContext5(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5 refDataContext12 = ((Workflow1_TypedDataContext5)(cachedCompiledDataContext[5]));
                return refDataContext12.GetLocation<string>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5_ForReadOnly valDataContext13 = ((Workflow1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5_ForReadOnly valDataContext14 = ((Workflow1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow1_TypedDataContext5(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5 refDataContext15 = ((Workflow1_TypedDataContext5)(cachedCompiledDataContext[5]));
                return refDataContext15.GetLocation<string>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5_ForReadOnly valDataContext16 = ((Workflow1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5_ForReadOnly valDataContext17 = ((Workflow1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow1_TypedDataContext5(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5 refDataContext18 = ((Workflow1_TypedDataContext5)(cachedCompiledDataContext[5]));
                return refDataContext18.GetLocation<string>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5_ForReadOnly valDataContext19 = ((Workflow1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow1_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3_ForReadOnly valDataContext20 = ((Workflow1_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Workflow1_TypedDataContext3(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3 refDataContext21 = ((Workflow1_TypedDataContext3)(cachedCompiledDataContext[7]));
                return refDataContext21.GetLocation<double>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow1_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext2_ForReadOnly valDataContext22 = ((Workflow1_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow1_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext2_ForReadOnly valDataContext23 = ((Workflow1_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext23.ValueType___Expr23Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                Workflow1_TypedDataContext2_ForReadOnly valDataContext0 = new Workflow1_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                Workflow1_TypedDataContext2 refDataContext1 = new Workflow1_TypedDataContext2(locations, true);
                return refDataContext1.GetLocation<double>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                Workflow1_TypedDataContext3_ForReadOnly valDataContext2 = new Workflow1_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                Workflow1_TypedDataContext3_ForReadOnly valDataContext3 = new Workflow1_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                Workflow1_TypedDataContext4_ForReadOnly valDataContext4 = new Workflow1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                Workflow1_TypedDataContext4 refDataContext5 = new Workflow1_TypedDataContext4(locations, true);
                return refDataContext5.GetLocation<double>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                Workflow1_TypedDataContext4_ForReadOnly valDataContext6 = new Workflow1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                Workflow1_TypedDataContext4_ForReadOnly valDataContext7 = new Workflow1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                Workflow1_TypedDataContext4 refDataContext8 = new Workflow1_TypedDataContext4(locations, true);
                return refDataContext8.GetLocation<double>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set);
            }
            if ((expressionId == 9)) {
                Workflow1_TypedDataContext4_ForReadOnly valDataContext9 = new Workflow1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                Workflow1_TypedDataContext4_ForReadOnly valDataContext10 = new Workflow1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                Workflow1_TypedDataContext4 refDataContext11 = new Workflow1_TypedDataContext4(locations, true);
                return refDataContext11.GetLocation<double>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                Workflow1_TypedDataContext5 refDataContext12 = new Workflow1_TypedDataContext5(locations, true);
                return refDataContext12.GetLocation<string>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                Workflow1_TypedDataContext5_ForReadOnly valDataContext13 = new Workflow1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                Workflow1_TypedDataContext5_ForReadOnly valDataContext14 = new Workflow1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                Workflow1_TypedDataContext5 refDataContext15 = new Workflow1_TypedDataContext5(locations, true);
                return refDataContext15.GetLocation<string>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set);
            }
            if ((expressionId == 16)) {
                Workflow1_TypedDataContext5_ForReadOnly valDataContext16 = new Workflow1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                Workflow1_TypedDataContext5_ForReadOnly valDataContext17 = new Workflow1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                Workflow1_TypedDataContext5 refDataContext18 = new Workflow1_TypedDataContext5(locations, true);
                return refDataContext18.GetLocation<string>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set);
            }
            if ((expressionId == 19)) {
                Workflow1_TypedDataContext5_ForReadOnly valDataContext19 = new Workflow1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                Workflow1_TypedDataContext3_ForReadOnly valDataContext20 = new Workflow1_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                Workflow1_TypedDataContext3 refDataContext21 = new Workflow1_TypedDataContext3(locations, true);
                return refDataContext21.GetLocation<double>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set);
            }
            if ((expressionId == 22)) {
                Workflow1_TypedDataContext2_ForReadOnly valDataContext22 = new Workflow1_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                Workflow1_TypedDataContext2_ForReadOnly valDataContext23 = new Workflow1_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == @"""Welcome to the Service Access Console Application"" +
""\n================================================"" +
""\nThere are 2 services hooked up to this app one "" +
""\nthat calculates the side length of a triangle"" +
""\nusing pythagorean's theorem and the other"" +
""\nencrypts and decrypts strings"" +
""\nSelect an option to proceed: "" +
""\n\t1. Calculate Triangle Side Length. "" +
""\n\t2. String Encryption."" +
""\n\t3. Exit the application. \n"" +
""\nWhich service would you like to run? """) 
                        && (Workflow1_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "userServiceSelection") 
                        && (Workflow1_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Hypotonuse\"") 
                        && (Workflow1_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "userServiceSelection == 1") 
                        && (Workflow1_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"\\nWhat side length would you like to calculate?\" +\n\"\\n\\t 1. Hypotonuse.\" +\n\"\\n\\t" +
                            " 2. Side A.\" +\n\"\\n\\t 3. Side B.\" +\n\"\\n Your side selection: \\n\"") 
                        && (Workflow1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "calcTypeUserSelection") 
                        && (Workflow1_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "userServiceSelection == 0") 
                        && (Workflow1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"/nFirst Side Length: \\n\"") 
                        && (Workflow1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "side1") 
                        && (Workflow1_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"\\nHypotonuse Length: \\n\"") 
                        && (Workflow1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"\\nSecond Side Length: \\n\"") 
                        && (Workflow1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "side2") 
                        && (Workflow1_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "valueToEncrypt") 
                        && (Workflow1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"\\nWhat string would you like to encrypt: \"") 
                        && (Workflow1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "valueToEncrypt") 
                        && (Workflow1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "encryptedValue") 
                        && (Workflow1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"\\nYour encrypted string: \" + encryptedValue") 
                        && (Workflow1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "encryptedValue") 
                        && (Workflow1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "decryptedValue") 
                        && (Workflow1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"\\nYour decrypted string: \" + decryptedValue") 
                        && (Workflow1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"\\n================================================\" +\n\"\\nSelect another process " +
                            "to run: \" +\n\"\\n\\t1. Calculate Triangle Side Length. \" +\n\"\\n\\t2. String Encryptio" +
                            "n.\" +\n\"\\n\\t3. Exit the application. \\n\" +\n\"\\nWhich service would you like to run" +
                            "? \"") 
                        && (Workflow1_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "userServiceSelection") 
                        && (Workflow1_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "userServiceSelection == 1 || userServiceSelection == 2") 
                        && (Workflow1_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"\\nThanks for using this application, have a good day!\\n\"") 
                        && (Workflow1_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new Workflow1_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new Workflow1_TypedDataContext2(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new Workflow1_TypedDataContext3_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new Workflow1_TypedDataContext3_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new Workflow1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new Workflow1_TypedDataContext4(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new Workflow1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new Workflow1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new Workflow1_TypedDataContext4(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new Workflow1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new Workflow1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new Workflow1_TypedDataContext4(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new Workflow1_TypedDataContext5(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new Workflow1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new Workflow1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new Workflow1_TypedDataContext5(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new Workflow1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new Workflow1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new Workflow1_TypedDataContext5(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new Workflow1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new Workflow1_TypedDataContext3_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new Workflow1_TypedDataContext3(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new Workflow1_TypedDataContext2_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new Workflow1_TypedDataContext2_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext1 : Workflow1_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return Workflow1_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext1_ForReadOnly : Workflow1_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return Workflow1_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext2 : Workflow1_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double userServiceSelection;
            
            public Workflow1_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 68 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
          userServiceSelection;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr1Get() {
                
                #line 68 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
          userServiceSelection;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr1Set(double value) {
                
                #line 68 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                
          userServiceSelection = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.userServiceSelection = ((double)(this.GetVariableValue((0 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((0 + locationsOffset), this.userServiceSelection);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 1))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 1);
                }
                expectedLocationsCount = 1;
                if (((locationReferences[(offset + 0)].Name != "userServiceSelection") 
                            || (locationReferences[(offset + 0)].Type != typeof(double)))) {
                    return false;
                }
                return Workflow1_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext2_ForReadOnly : Workflow1_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double userServiceSelection;
            
            public Workflow1_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 53 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          "Welcome to the Service Access Console Application" +
"\n================================================" +
"\nThere are 2 services hooked up to this app one " +
"\nthat calculates the side length of a triangle" +
"\nusing pythagorean's theorem and the other" +
"\nencrypts and decrypts strings" +
"\nSelect an option to proceed: " +
"\n\t1. Calculate Triangle Side Length. " +
"\n\t2. String Encryption." +
"\n\t3. Exit the application. \n" +
"\nWhich service would you like to run? ";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr0Get() {
                
                #line 53 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
          "Welcome to the Service Access Console Application" +
"\n================================================" +
"\nThere are 2 services hooked up to this app one " +
"\nthat calculates the side length of a triangle" +
"\nusing pythagorean's theorem and the other" +
"\nencrypts and decrypts strings" +
"\nSelect an option to proceed: " +
"\n\t1. Calculate Triangle Side Length. " +
"\n\t2. String Encryption." +
"\n\t3. Exit the application. \n" +
"\nWhich service would you like to run? ";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 74 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
        userServiceSelection == 1 || userServiceSelection == 2;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr22Get() {
                
                #line 74 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
        userServiceSelection == 1 || userServiceSelection == 2;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 236 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
        "\nThanks for using this application, have a good day!\n";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr23Get() {
                
                #line 236 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
        "\nThanks for using this application, have a good day!\n";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            protected override void GetValueTypeValues() {
                this.userServiceSelection = ((double)(this.GetVariableValue((0 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 1))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 1);
                }
                expectedLocationsCount = 1;
                if (((locationReferences[(offset + 0)].Name != "userServiceSelection") 
                            || (locationReferences[(offset + 0)].Type != typeof(double)))) {
                    return false;
                }
                return Workflow1_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext3 : Workflow1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double side1;
            
            protected double side2;
            
            public Workflow1_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string calculationType {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 228 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
              userServiceSelection;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr21Get() {
                
                #line 228 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
              userServiceSelection;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr21Set(double value) {
                
                #line 228 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                
              userServiceSelection = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr21Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr21Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.side1 = ((double)(this.GetVariableValue((1 + locationsOffset))));
                this.side2 = ((double)(this.GetVariableValue((2 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((1 + locationsOffset), this.side1);
                this.SetVariableValue((2 + locationsOffset), this.side2);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 3)].Name != "calculationType") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "side1") 
                            || (locationReferences[(offset + 1)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "side2") 
                            || (locationReferences[(offset + 2)].Type != typeof(double)))) {
                    return false;
                }
                return Workflow1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext3_ForReadOnly : Workflow1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double side1;
            
            protected double side2;
            
            public Workflow1_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string calculationType {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 82 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              "Hypotonuse";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr2Get() {
                
                #line 82 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
              "Hypotonuse";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 89 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              userServiceSelection == 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr3Get() {
                
                #line 89 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
              userServiceSelection == 1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 218 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              "\n================================================" +
"\nSelect another process to run: " +
"\n\t1. Calculate Triangle Side Length. " +
"\n\t2. String Encryption." +
"\n\t3. Exit the application. \n" +
"\nWhich service would you like to run? ";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr20Get() {
                
                #line 218 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
              "\n================================================" +
"\nSelect another process to run: " +
"\n\t1. Calculate Triangle Side Length. " +
"\n\t2. String Encryption." +
"\n\t3. Exit the application. \n" +
"\nWhich service would you like to run? ";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            protected override void GetValueTypeValues() {
                this.side1 = ((double)(this.GetVariableValue((1 + locationsOffset))));
                this.side2 = ((double)(this.GetVariableValue((2 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 3)].Name != "calculationType") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "side1") 
                            || (locationReferences[(offset + 1)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "side2") 
                            || (locationReferences[(offset + 2)].Type != typeof(double)))) {
                    return false;
                }
                return Workflow1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext4 : Workflow1_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double calcTypeUserSelection;
            
            protected double calculatedSideLength;
            
            public Workflow1_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string calcPythagorean {
                get {
                    return ((string)(this.GetVariableValue((6 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((6 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 111 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    calcTypeUserSelection;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr5Get() {
                
                #line 111 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
                    calcTypeUserSelection;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(double value) {
                
                #line 111 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                
                    calcTypeUserSelection = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 130 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        side1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr8Get() {
                
                #line 130 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
                        side1;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr8Set(double value) {
                
                #line 130 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                
                        side1 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr8Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr8Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 153 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    side2;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr11Get() {
                
                #line 153 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
                    side2;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(double value) {
                
                #line 153 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                
                    side2 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.calcTypeUserSelection = ((double)(this.GetVariableValue((4 + locationsOffset))));
                this.calculatedSideLength = ((double)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((4 + locationsOffset), this.calcTypeUserSelection);
                this.SetVariableValue((5 + locationsOffset), this.calculatedSideLength);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 7))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 7);
                }
                expectedLocationsCount = 7;
                if (((locationReferences[(offset + 6)].Name != "calcPythagorean") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "calcTypeUserSelection") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "calculatedSideLength") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                return Workflow1_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext4_ForReadOnly : Workflow1_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double calcTypeUserSelection;
            
            protected double calculatedSideLength;
            
            public Workflow1_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string calcPythagorean {
                get {
                    return ((string)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 102 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    "\nWhat side length would you like to calculate?" +
"\n\t 1. Hypotonuse." +
"\n\t 2. Side A." +
"\n\t 3. Side B." +
"\n Your side selection: \n";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr4Get() {
                
                #line 102 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
                    "\nWhat side length would you like to calculate?" +
"\n\t 1. Hypotonuse." +
"\n\t 2. Side A." +
"\n\t 3. Side B." +
"\n Your side selection: \n";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 118 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    userServiceSelection == 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr6Get() {
                
                #line 118 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
                    userServiceSelection == 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 125 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                        "/nFirst Side Length: \n";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr7Get() {
                
                #line 125 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
                        "/nFirst Side Length: \n";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 139 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                        "\nHypotonuse Length: \n";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr9Get() {
                
                #line 139 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
                        "\nHypotonuse Length: \n";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 148 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    "\nSecond Side Length: \n";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr10Get() {
                
                #line 148 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
                    "\nSecond Side Length: \n";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            protected override void GetValueTypeValues() {
                this.calcTypeUserSelection = ((double)(this.GetVariableValue((4 + locationsOffset))));
                this.calculatedSideLength = ((double)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 7))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 7);
                }
                expectedLocationsCount = 7;
                if (((locationReferences[(offset + 6)].Name != "calcPythagorean") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "calcTypeUserSelection") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "calculatedSideLength") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                return Workflow1_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext5 : Workflow1_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string valueToEncrypt {
                get {
                    return ((string)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
            }
            
            protected string encryptedValue {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
                }
            }
            
            protected string decryptedValue {
                get {
                    return ((string)(this.GetVariableValue((6 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((6 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 174 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    valueToEncrypt;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr12Get() {
                
                #line 174 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
                    valueToEncrypt;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(string value) {
                
                #line 174 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                
                    valueToEncrypt = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 181 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    encryptedValue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr15Get() {
                
                #line 181 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
                    encryptedValue;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr15Set(string value) {
                
                #line 181 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                
                    encryptedValue = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr15Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr15Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 198 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    decryptedValue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr18Get() {
                
                #line 198 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
                    decryptedValue;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr18Set(string value) {
                
                #line 198 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                
                    decryptedValue = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr18Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr18Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 7))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 7);
                }
                expectedLocationsCount = 7;
                if (((locationReferences[(offset + 4)].Name != "valueToEncrypt") 
                            || (locationReferences[(offset + 4)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "encryptedValue") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "decryptedValue") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow1_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext5_ForReadOnly : Workflow1_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string valueToEncrypt {
                get {
                    return ((string)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            protected string encryptedValue {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            protected string decryptedValue {
                get {
                    return ((string)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 169 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    "\nWhat string would you like to encrypt: ";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr13Get() {
                
                #line 169 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
                    "\nWhat string would you like to encrypt: ";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 186 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    valueToEncrypt;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr14Get() {
                
                #line 186 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
                    valueToEncrypt;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 192 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  "\nYour encrypted string: " + encryptedValue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr16Get() {
                
                #line 192 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
                  "\nYour encrypted string: " + encryptedValue;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 203 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    encryptedValue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr17Get() {
                
                #line 203 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
                    encryptedValue;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 209 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  "\nYour decrypted string: " + decryptedValue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr19Get() {
                
                #line 209 "C:\USERS\MADMA\DOCUMENTS\GITREPOS\CSE_598_SOFTWARE_INTEGRATION\PROJECT_2\ASSIGNMENT_3\ACCESSSERVICECONSOLEAPPLICATION\WORKFLOW1.XAML"
                return 
                  "\nYour decrypted string: " + decryptedValue;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 7))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 7);
                }
                expectedLocationsCount = 7;
                if (((locationReferences[(offset + 4)].Name != "valueToEncrypt") 
                            || (locationReferences[(offset + 4)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "encryptedValue") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "decryptedValue") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow1_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
