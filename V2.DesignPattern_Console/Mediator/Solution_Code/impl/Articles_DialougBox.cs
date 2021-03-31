using V2.DesignPattern_Console.Mediator.Solution_Code.abstraction;

namespace V2.DesignPattern_Console.Mediator.Solution_Code.impl
{
    public class Articles_DialougBox : DialougBox
    {
        private ListBox articles_ListBox => new ListBox(this);
        private TextBox articles_TextBox => new TextBox(this);
        private Button articles_SaveButton => new Button(this);
        

        
        public override void changed(UI_Control changed)
        {
            if (changed == articles_ListBox)
                articleSelected();
            if (changed == articles_TextBox)
                titleChanged();
        }


        #region BusinessLogic

        private void articleSelected() 
        {
            articles_TextBox.setContent(articles_ListBox.getSelection());
            articles_SaveButton.setEnabled(true);
        }

        private void titleChanged() 
        { 
            //var content = tit
        }

        #endregion
    }
}
