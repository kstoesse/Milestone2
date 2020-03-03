using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is where the code required for our tests to run will be stored.
namespace Verification_Tests
{
    class Skeleton_Class
    {
        private string location;
        private double mean, median;
        private int mode;
        private string safetyRange;
        public Skeleton_Class(string loc, double mea, double med, int mo, string safe)
        {
            location = loc;
            mean = mea;
            median = med;
            mode = mo;
            safetyRange = safe;
        }

        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }
        public double Mean
        {
            get
            {
                return mean;
            }
            set
            {
                mean = value;
            }
        }

        public double Median
        {
            get
            {
                return median;
            }
            set
            {
                median = value;
            }
        }

        public int Mode
        {
            get
            {
                return mode;
            }
            set
            {
                mode = value;
            }
        }



        public string SafetyRange
        {
            get
            {
                return safetyRange;
            }
            set
            {
                safetyRange = value;
            }
        }
        
    }
}
