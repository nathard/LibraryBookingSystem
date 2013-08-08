using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_3
{
    public static class MenuSystem
    {
        private static void DisplayMenu(MenuOption[] options, MenuOption exitOption, out int min, out int max)
        {
            min = 1;

            int count;
            for(count = 0 ; count < options.Length ; count++)
            {
                Console.WriteLine("{0,4}. {1}", count + 1, options[count]);
            }
            max = count;
            if (exitOption != null)
                Console.WriteLine("{0,4}. {1}", min = 0, exitOption);
        }

        private static MenuOption GetMenuSelection(Menu menu)
        {
            int opt, min, max;

            if (menu.Title != null)
            {
                Console.WriteLine(menu.Title);
                Console.WriteLine(new string('=', menu.Title.Length));
            }
            else
                Console.WriteLine("Please select from the following items:");

            DisplayMenu(menu.MenuOptions, menu.ExitOption, out min, out max);
            Console.Write("Please enter your selection ({0}-{1}): ", min, max);
            while (int.TryParse(Console.ReadLine(), out opt) == false || opt < min || opt > max)
            {
                Console.WriteLine();
                Console.WriteLine("That is not a valid option.  Please try again.");
                Console.Write("Please enter your selection ({0}-{1}): ", min, max);
            }
            Console.WriteLine();

            MenuOption ret = menu.ExitOption;
            if (opt != 0)
                ret = menu.MenuOptions[opt - 1];

            return ret;
        }

        public static void Run(Menu menu)
        {
            object selectedObject;
            MenuOption opt;
            
            while ((opt = GetMenuSelection(menu)) != menu.ExitOption)
            {
                selectedObject = null;
                if (opt.SelectionsProvider != null)
                {
                    Menu subOpts = opt.SelectionsProvider();
                    selectedObject = GetMenuSelection(subOpts).RelatedObject;
                }
                if ((opt.SelectionsProvider == null || selectedObject != null) && opt.Handler != null)
                {
                        opt.Handler(selectedObject);
                        Console.WriteLine();
                }
                if (opt.RelatedObject is Menu)
                {
                    Menu sm = opt.RelatedObject as Menu;
                    Run(opt.RelatedObject as Menu);
                }
            }
        }
    }
}
