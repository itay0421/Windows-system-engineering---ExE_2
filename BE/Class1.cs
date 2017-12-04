using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;

namespace BE
{
    public class Flower
    {
        string description;
        string color;
        string area;
        string image;


        public Flower(string description, string color, string area, string imagePath)
        {
            this.Description = description;
            this.Color = color;
            this.Area = area;
            this.Image = imagePath;
        }

        public string Color { get => color; set => color = value; }
        public string Description { get => description; set => description = value; }
        public string Area { get => area; set => area = value; }
        public string Image { get => image; set => image = value; }
    }
}
