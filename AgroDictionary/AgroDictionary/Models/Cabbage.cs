using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroDictionary.Models
{
    public class Cabbage : Plant
    {
        public string Compactness { get; set; } // Компактність: Компактна / Некомпактна
        public int StorageDuration { get; set; } // Термін зберігання в днях

        public Cabbage(string name, string kind, string description, string climate, double height, double weight, int maturationTime, string color, string shape, string compactness, int storageDuration)
            : base(name, kind, description, climate, height, weight, maturationTime)
        {
            Compactness = compactness;
            StorageDuration = storageDuration;
        }

        public override string GetDescription()
        {
            string baseDescription = base.GetDescription();
            return $"{baseDescription}\n\nКомпактність: {Compactness}\n\n Термін зберігання: {StorageDuration} днів";
        }
    }
}
