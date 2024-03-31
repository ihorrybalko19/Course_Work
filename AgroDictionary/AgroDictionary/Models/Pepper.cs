using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroDictionary.Models
{
    internal class Pepper : Plant
    {
        public string Color { get; set; }
        public string Spiciness { get; set; }
        public bool IsCuboid { get; set; }

        public Pepper(string name, string kind, string description, string climate, double height, double weight, int maturationTime, string color, string spiciness, bool isCuboid)
            : base(name, kind, description, climate, height, weight, maturationTime)
        {
            Color = color;
            Spiciness = spiciness;
            IsCuboid = isCuboid;
        }

        public override string GetDescription()
        {
            string baseDescription = base.GetDescription();
            string cuboid = IsCuboid ? "Кубоподібний" : "Не кубоподібний";
            return $"{baseDescription}\n\nКолір перцю: {Color}\nГострота: {Spiciness}\nФорма: {cuboid}";
        }
    }
}
