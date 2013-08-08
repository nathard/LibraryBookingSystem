using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_3
{
    public class Menu
    {
        private string _Title;
        public string Title
        {
            get { return _Title; }
        }

        private MenuOption[] _MenuOptions;
        public MenuOption[] MenuOptions
        {
            get { return _MenuOptions; }
        }

        private MenuOption _ExitOption;
        public MenuOption ExitOption
        {
            get { return _ExitOption; }
        }

        public Menu(string title, MenuOption[] menuOptions, MenuOption exitOption)
        {
            _Title = title;
            _MenuOptions = menuOptions;
            _ExitOption = exitOption;
        }
    }
}