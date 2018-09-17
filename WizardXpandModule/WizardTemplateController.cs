using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.SystemModule;
using WizardXpandModule;


namespace WizardXpandModule
{
    public class WizardTemplateController : ViewController {
        protected override void OnActivated() {
            base.OnActivated();
            var controller = Frame.GetController<NewObjectViewController>(); 
            if(controller!=null)
              controller.NewObjectAction.Executed += Action_Executed;
          
           var controller1 = Frame.GetController<NewObjectViewController>();
            if (controller1 != null)
                controller1.ObjectCreated += ObjectCreated;
            var controller2 = Frame.GetController<ListViewProcessCurrentObjectController>();
            if (controller2 != null)
                controller2.ProcessCurrentObjectAction.Executed += Action_Executed;
            var controller3 = Frame.GetController<ShowNavigationItemController>();
            if (controller3 != null)
                controller3.ShowNavigationItemAction.Executed += Action_Executed;
        }

        protected override void OnDeactivated() {
            //var controller = Frame.GetController<NewObjectViewController>();
            //controller.NewObjectAction.Executed -= Action_Executed;
            //var controller1 = Frame.GetController<NewObjectViewController>();
            //controller1.ObjectCreated -= ObjectCreated;
            //var controller2 = Frame.GetController<ListViewProcessCurrentObjectController>();
            //controller2.ProcessCurrentObjectAction.Executed -= Action_Executed;
            //var controller3 = Frame.GetController<ShowNavigationItemController>();
            //controller3.ShowNavigationItemAction.Executed -= Action_Executed;
            base.OnDeactivated();
        }

        IObjectSpace _objectSpace;
        object _newObject;

        private void ObjectCreated(object sender, ObjectCreatedEventArgs e) {
            _objectSpace = e.ObjectSpace;
            _newObject = e.CreatedObject;
        }

        private void Action_Executed(object sender, ActionBaseEventArgs e)
        {
            var newObject = _newObject;
            var sourceView = View;
            e.CreateWizardViewInternal(_objectSpace, newObject, sourceView);

            _objectSpace = null;
            _newObject = null;
        }

        
    }
}
