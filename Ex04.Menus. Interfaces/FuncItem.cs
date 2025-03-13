namespace Ex04.Menus.Interfaces
{
    public class FuncItem : MenuItem
    {
        private readonly IFuncLeaf r_OurFunction;

        public FuncItem(string i_Title, MenuItem i_Ancestor, IFuncLeaf i_OurFunction)
        {
            TitleName = i_Title;
            r_OurFunction = i_OurFunction;
            Father = i_Ancestor;
        }

        internal override MenuItem Activate()
        {
            r_OurFunction.LeafFunction();

            return this.Father.Activate();
        }
    }
}
