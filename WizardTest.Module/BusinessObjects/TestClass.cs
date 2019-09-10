using DevExpress.Xpo;
using System.ComponentModel;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace WizardTest.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    [DefaultProperty("Page1")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class TestClass : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public TestClass(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
   
        private string _page2;
        private string _page1;

        public string FirstField
        {
            get { return _page1; }
            set
            {
                _page1 = value;
            }
        }
        [RuleRequiredField]
        public string SecondFieldRequired
        {
            get { return _page2; }
            set
            {
                _page2 = value;
            }
        }

        TestClassType type;
        public TestClassType Type
        {
            get => type;
            set => SetPropertyValue(nameof(Type), ref type, value);
        }

      
        [Association("TestClass-TestClassChilds")]
        public XPCollection<TestClassChild> TestClassChilds
        {
            get
            {
                return GetCollection<TestClassChild>(nameof(TestClassChilds));
            }
        }
    }
}