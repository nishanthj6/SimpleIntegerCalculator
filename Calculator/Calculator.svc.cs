using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Calculator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calculator" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Calculator.svc or Calculator.svc.cs at the Solution Explorer and start debugging.
    public class Calculator : ICalculator
    {
        //public void dowork()
        //{
        //}
        #region ICalculator Members

        string ICalculator.add(int a, int b)
        {
            return "Computed Sum: " + (a + b).ToString();
        }

        string ICalculator.Sub(int a, int b)
        {
            if (a >= b)
            {
                return "Computed Sum: " + (a - b).ToString();
            }
            else
            {
                return "Computed Sum: " + (b - a).ToString();
            }
        }

        public string Mul(int a, int b)
        {
            return "Computed Sum: " + (a * b).ToString();
        }

        public string Div(int a, int b)
        {
            if (a >= b)
                try { return (a / b).ToString(); }
                catch
                { return 0.ToString(); }
            else
                return "Computed Sum: " + (b / a).ToString();
        }
        public string XMLData(string id)
        {
            return "Computed Sum: " + id;
        }

        public string JSONData(string id)
        {
            return "Computed Sum: " + id.ToString();
        }

        #endregion
    }

}
