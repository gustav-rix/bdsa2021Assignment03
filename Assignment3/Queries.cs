using System;
using System.Linq;
using System.Collections.Generic;

namespace Assignment3
{
    public class Queries
    {
        public static readonly IReadOnlyCollection<Wizard> wizards = Wizard.Wizards.Value;
        public static IEnumerable<string> wizards_invented_by_rowling()
        {
            IEnumerable<string> list = 
                from w in wizards
                where w.Creator.Contains("Rowling")
                select w.Name;
            ;
            return list.Distinct();
        }
        public static IEnumerable<string> wizards_invented_by_rowling_extension()
        {
            IEnumerable<string> list = wizards
                .Where(c => c.Creator.Contains("Rowling"))
                .Select(n => n.Name);
            return list.Distinct();
        }

        public static int year_the_first_sith_lord_was_introduced()
        {
            IEnumerable<int?> list = 
                from w in wizards
                where w.Name.Contains("Darth")
                orderby w.Year ascending
                select w.Year;
            return (int) list.Distinct().First();
        }

        public static IEnumerable<(string, int)> unique_list_of_harry_potter_wizards()
        {
            IEnumerable<(string, int)> list = 
                from w in wizards
                where w.Medium.Contains("Harry Potter")
                select (w.Name, (int) w.Year);
            return list.Distinct();

        }

        public static IEnumerable<(string, int)> unique_list_of_harry_potter_wizards_extension()
        {
            IEnumerable<(string,int)> list = wizards
                .Select(c => new{c.Medium, c.Name, c.Year})
                .Where(c => c.Medium.Contains("Harry Potter"))
                .AsEnumerable()
                .Select(c => (c.Name, (int) c.Year))
                .Distinct();
            return list;
        }
        
        public static IEnumerable<string> list_of_wizard_names_grouped_by_creator_in_reverse_order()
        {
            IEnumerable<string> list = 
                from w in wizards
                orderby w.Name
                orderby w.Creator
                select w.Name;
            return list.Distinct().Reverse();
                
        }


        public static IEnumerable<string> list_of_wizard_names_grouped_by_creator_in_reverse_order_extension()
        {
            IEnumerable<string> list = wizards
                .OrderBy(w => w.Creator)
                .ThenBy(w => w.Name)
                .Reverse()
                .Select(w => w.Name)
                .Distinct();
            return list;
        }
    }
}
