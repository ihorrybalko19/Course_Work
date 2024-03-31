using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroDictionary.Models
{
    public class Cucumber : Plant
    {
        public string PollinationType { get; set; } // тип запилення

        public Cucumber(string name, string kind, string description, string climate, double height, double weight, int maturationTime, string pollinationType)
            : base(name, kind, description, climate, height, weight, maturationTime)
        {
            PollinationType = pollinationType;
        }

        public override string GetDescription()
        {
            string pollinationTypeDescription = PollinationType == "Бджолозапильний" ? "Бджолозапильний" : "Партенокарпічний";
            string description = $"Назва: {Name}\n\n Вид: Огірок \n\nТип запилення: {pollinationTypeDescription}\n\n{base.GetDescription()}";
            return description;
        }
    }
}
