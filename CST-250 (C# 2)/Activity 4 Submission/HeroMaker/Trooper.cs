using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMaker
{
    internal class Trooper
    {
        // Attributes
        public string Name;
        string ServiceBranch;
        string Type;
        int Accuracy;
        int Stamina;
        int Sanity;
        string Deplyoment;
        string EnlistDate;
        string CombatDate;
        int YearsService;
        int DarkSideCorruption;
        string ArmorColor;

        public Trooper(string name, string serviceBranch, string type, int accuracy, int stamina, int sanity, string deplyoment, string enlistDate, string combatDate, int yearsService, int darkSideCorruption, string armorColor)
        {
            Name = name;
            ServiceBranch = serviceBranch;
            Type = type;
            Accuracy = accuracy;
            Stamina = stamina;
            Sanity = sanity;
            Deplyoment = deplyoment;
            EnlistDate = enlistDate;
            CombatDate = combatDate;
            YearsService = yearsService;
            DarkSideCorruption = darkSideCorruption;
            ArmorColor = armorColor;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} of the {2} branch dedicated {3} years of service to the Empire. Enlisting on {4}, they were deployed to {5}. " +
                "From there, they saw first combat on {6}. " +
                "With an accuracy of {7}%, stamina of {8}, " +
                "they retired with a sanity level of {9}% and a corruption level of {10}0%.\n{1} had a signature armor color of {11}",
                Type, Name, ServiceBranch, YearsService, EnlistDate, Deplyoment, CombatDate, Accuracy, Stamina, Sanity, DarkSideCorruption, ArmorColor);
        }
    }
}
