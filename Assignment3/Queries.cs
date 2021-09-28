using System;
using System.Collections.Generic;
using System.IO;
using CsvHelper;
using System.Linq;
using System.Globalization;

namespace BDSA2021.Assignment03
{
    public static class Queries
    {
        public static int FindRowlingWizards()
        {
            var repo = Wizard.Wizards.Value;
            
            var rowlingWizards =    (from w in repo
                                    where w.Creator.Contains("Rowling")
                                    select new { Name = w.Name }).Count();

            return rowlingWizards;
        }


        public static int? FindFirstSith()
        {
            var repo = Wizard.Wizards.Value;

            var firstSith =     (from w in repo
                                where w.Name.Contains("Darth")
                                select w.Year).First();

            return firstSith;
        }

        public static List<(string, int?)> FindHarryPotterWizards()
        {
            var repo = Wizard.Wizards.Value;
            var list = new Dictionary<string,int?>();

            var uniqueHpWizards =   from w in repo
                                    where w.Medium.Contains("Harry Potter")
                                    select (w.Name, w.Year);
            
            /* foreach (var w in uniqueHpWizards)
            {
                list.Add(string.Join("",w.Name),w.Year);
            } */

            return uniqueHpWizards.Distinct().ToList();
        }

        public static List<string> GroupWizardsByCreator()
        {
            var repo = Wizard.Wizards.Value;

            var wizNamesByCreator = from w in repo
                                    orderby w.Name, w.Creator descending
                                    select ( w.Name );

            return wizNamesByCreator.ToList();
        }
    }
}
