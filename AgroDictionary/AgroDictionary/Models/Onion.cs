using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroDictionary.Models
{
    public class Onion : Plant
    {
        public string Color { get; set; }
        public double HarvestPotential { get; set; }

        public Onion(string name, string kind, string description, string climate, double height, double weight, int maturationTime, string color, double harvestPotential)
            : base(name, kind, description, climate, height, weight, maturationTime)
        {
            Color = color;
            HarvestPotential = harvestPotential;
        }
        public override string GetDescription()
        {
            string baseDescription = base.GetDescription();
            return $"{baseDescription}\n\n Колір цибулі: {Color}\n\n Потенціал врожаю: {HarvestPotential}";
        }
    }
}
