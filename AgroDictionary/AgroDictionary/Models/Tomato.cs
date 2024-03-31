using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroDictionary.Models
{
    public class Tomato : Plant
    {
        public bool IsDeterminate { get; set; }

        public Tomato(string name, string kind, string description, string climate, double height, double weight, int maturationTime, bool isDeterminate)
            : base(name, kind, description, climate, height, weight, maturationTime)
        {
            IsDeterminate = isDeterminate;
        }

        public override string GetDescription()
        {
            string determinateType = IsDeterminate ? "детермінантний" : "індетермінантний";
            string description = $"Назва: {Name}\n\n Вид: Помідор \n\nТип помідора: {determinateType}\n\n{base.GetDescription()}";
            return description;
        }
    }
}
