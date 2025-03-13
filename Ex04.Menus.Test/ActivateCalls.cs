using System;

namespace Ex04.Menus.Test
{
    internal class ActivateCalls
    {
        // $G$ CSS-001 (-10) Bad local variable name - meaningless.
        public static void ActivateInterfaces()
        {
            Interfaces.MainMenu mainMenuInterface = new Interfaces.MainMenu("Interfaces Main Menu");
            Interfaces.ListItem a = new Interfaces.ListItem("Version and Capitals", null);
            Interfaces.FuncItem a1 = new Interfaces.FuncItem("Show Version", a, new ShowVersion());
            Interfaces.FuncItem a2 = new Interfaces.FuncItem("Count Capitals", a, new CountCapitals());
            Interfaces.ListItem b = new Interfaces.ListItem("Show Date/ Time", null);
            Interfaces.FuncItem b1 = new Interfaces.FuncItem("Show Time", b, new ShowTime());
            Interfaces.FuncItem b2 = new Interfaces.FuncItem("Show Date", b, new ShowDate());

            a.AddItem(a1);
            a.AddItem(a2);
            b.AddItem(b1);
            b.AddItem(b2);
            mainMenuInterface.Add(a);
            mainMenuInterface.Add(b);
            mainMenuInterface.Show();
        }

        public static void ActivateDelegates()
        {
            Events.MainMenu mainMenuEvents = new Events.MainMenu("Delegates Main Menu");
            Events.ListItem a = new Events.ListItem("Version and Capitals", null);
            Events.FuncItem a1 = new Events.FuncItem("Show Version", a);
            Events.FuncItem a2 = new Events.FuncItem("Count Capitals", a);
            Events.ListItem b = new Events.ListItem("Show Date/Time", null);
            Events.FuncItem b1 = new Events.FuncItem("Show Time", b);
            Events.FuncItem b2 = new Events.FuncItem("Show Date", b);

            a1.FunctionLeafDelegate += new Action(EventsMethods.ShowVersion);
            a2.FunctionLeafDelegate += new Action(EventsMethods.CountCapitals);
            b1.FunctionLeafDelegate += new Action(EventsMethods.ShowTime);
            b2.FunctionLeafDelegate += new Action(EventsMethods.ShowDate);
            a.AddItem(a1);
            a.AddItem(a2);
            b.AddItem(b1);
            b.AddItem(b2);
            mainMenuEvents.Add(a);
            mainMenuEvents.Add(b);
            mainMenuEvents.Show();
        }
    }
}
