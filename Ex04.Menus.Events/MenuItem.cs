namespace Ex04.Menus.Events
{
    public abstract class MenuItem
    {
        private string m_TitleName;
        private MenuItem m_Father;

        public string TitleName
        {
            get { return m_TitleName; }
            set { m_TitleName = value; }
        }

        public MenuItem Father
        {
            get { return m_Father; }
            set { m_Father = value; }
        }

        internal abstract MenuItem Activate();
    }
}
