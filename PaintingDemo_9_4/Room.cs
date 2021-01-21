using System;
using System.Collections.Generic;
using System.Text;

namespace PaintingDemo_9_4
{
    class Room
    {
        int length, width, height, area, gallons;

        public Room(int l, int w, int h)
        {
            length = l;
            width = w;
            height = h;
            area = FindArea();
            gallons = FindGallons();
        }
        public int Length
        { 
            get { return length;}
        }
        public int Width
        {
            get { return width; }
        }

        public int Height
        {
            get { return height; }
        }

        public int Area
        {
            get { return area; }
        }

        public int Gallons
        {
            get { return gallons; }
        }

        private int FindArea()
        {
            return area = length * height * 2 + width * height * 2;
        }

        private int FindGallons()
        {
            int gallonsSqrFt = 350;
            int g = area / gallonsSqrFt;
            
            if(area % gallonsSqrFt > 0)
            {
                ++g;
            }

            return g;
        }




    }
}
