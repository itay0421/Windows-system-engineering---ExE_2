using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Flower
    {
        string description;
        string color;
        string area;

        public Flower(string description, string color, string area)
        {
            this.Description = description;
            this.Color = color;
            this.Area = area;
        }

        public string Color { get => color; set => color = value; }
        public string Description { get => description; set => description = value; }
        public string Area { get => area; set => area = value; }
    }
}
