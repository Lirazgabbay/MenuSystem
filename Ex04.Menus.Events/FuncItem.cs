using System;

namespace Ex04.Menus.Events
{
    public class FuncItem : MenuItem
    {
        public event Action FunctionLeafDelegate;

        public FuncItem(string i_Title, MenuItem i_Ancestor)
        {
            TitleName = i_Title;
            Father = i_Ancestor;
        }

        internal override MenuItem Activate()
        {
            notifyLeafAction();

            return this.Father.Activate();
        }

        private void notifyLeafAction()
        {
            if (FunctionLeafDelegate != null)
            {
                FunctionLeafDelegate.Invoke();
            }
        }
    }
}
