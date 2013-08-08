using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_3
{
    public class MenuOption
    {
        public delegate void MenuHandler(object selectedObject);
        public delegate Menu SelectionMenuProvider();

        public readonly static MenuOption Cancel = new MenuOption("Cancel", null, null, null);
        public readonly static MenuOption Exit = new MenuOption("Exit", null, null, null);

        private string _Text;
        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
        }

        private object _RelatedObject;
        public object RelatedObject
        {
            get { return _RelatedObject; }
            set { _RelatedObject = value; }
        }
        private SelectionMenuProvider _SelectionsProvider;
        public SelectionMenuProvider SelectionsProvider
        {
            get { return _SelectionsProvider; }
            set { _SelectionsProvider = value; }
        }

        private MenuHandler _Handler;
        public MenuHandler Handler
        {
            get { return _Handler; }
            set { _Handler = value; }
        }

        public MenuOption(string text, object relatedObject, SelectionMenuProvider selectionProvider, MenuHandler handler)
        {
            _Text = text;
            RelatedObject = relatedObject;
            _SelectionsProvider = selectionProvider;
            _Handler = handler;

        }

        public override string ToString()
        {
            return _Text;
        }
    }
}
