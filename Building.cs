using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class Building
    {
        public string name;
        public int height;
        public int area;
        public string adress;

        public Building(string name, int height, int area, string adress)
        {
            this.name = name;
            this.height = height;
            this.area = area;
            this.adress = adress;
        
        }

        public string GetDetails()
        {
            int volume = height * area;
            return $"{volume}";
        }

    }
}
