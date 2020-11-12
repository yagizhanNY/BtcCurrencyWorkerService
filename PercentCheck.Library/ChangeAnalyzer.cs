using System;
using System.Collections.Generic;
using System.Text;

namespace PercentCheck.Library
{
    public class ChangeAnalyzer
    {
        public bool AnalyzeChange(double currentValue, double pastValue, double percent)
        {
            try
            {
                double percentChange = ((pastValue - currentValue) / currentValue) * 100;

                if (percentChange >= percent || percentChange <= -percent)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new ArgumentException("Analyze Error");
            }
            
        }
    }
}
