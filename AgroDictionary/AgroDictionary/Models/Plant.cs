using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroDictionary.Models
{
    public class Plant
    {
        //властивості
        public string Name { get; set; }
        public string Kind {  get; set; }// помідор, цибуля ...
        public string Description { get; set; }
        public string Climate { get; set; }// континентальний .....
        public double Height { get; set; }
        public double Weight { get; set; }  
        public int MaturationTime { get; set; }

        // конструктор
        public Plant(string name, string kind, string description, string climate, double height, double weight, int maturationTime) {
            Name = name;
            Kind = kind;
            Description = description;
            Climate = climate;
            Height = height;
            Weight = weight;
            MaturationTime = maturationTime;
        }


        //методи
        public virtual string GetDescription()
        {
            return $"Назва: {Name}\n\n Вид: {Kind}\n\n Опис: {Description}\n\n Клімат: {Climate}\n\n Висота рослини: {Height}\n\n Вага плоду: {Weight}\n\n Тривалість дозрівання: {MaturationTime} днів";
        }
    }
}
