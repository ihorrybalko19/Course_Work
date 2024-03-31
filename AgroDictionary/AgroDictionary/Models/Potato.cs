using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroDictionary.Models
{
    public class Potato : Plant
    {
        public string Color { get; set; }
        public double StarchContent { get; set; }

        public Potato(string name, string kind, string description, string climate, double height, double weight, int maturationTime, string color, string shape, double starchContent)
            : base(name, kind, description, climate, height, weight, maturationTime)
        {
            Color = color;
            StarchContent = starchContent;
        }
        public override string GetDescription()
        {
            string baseDescription = base.GetDescription();
            return $"{baseDescription}\n\nКолір картоплі: {Color}\n\n Вміст крохмалю: {StarchContent}%";
        }
    }
}
