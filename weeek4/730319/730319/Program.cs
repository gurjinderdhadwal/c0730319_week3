using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _730319
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class village
    {
        bool isAstrildeHere;
        public village nextvillage;
        public village prevvillage;
        public string villagename;
    }
    class couyntryside
    {
        village toronto, Maple, Ajax;
        public void run()
        {
            Maple = new village();
            Maple.villagename = "toronto";
            Maple.nextvillage = toronto;

        }
     }
}
