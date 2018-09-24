using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesLearningProjects
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://www.baldebbhattarai.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : System.Web.Services.WebService
    {


        [WebMethod(MessageName = "Add3Numbers")]
        //this message name is used as a function within soap body.
        public int Add(int firstNumber, int secondNumber, int thirdNumber)
        {
            List<string> calculations;

            if (Session["RecentCalculations"] == null)
            {
                calculations = new List<string>();
            }
            else
            {
                calculations = (List<string>)Session["RecentCalculations"];
            }

            string strTransaction = firstNumber.ToString() + " + "
                + secondNumber.ToString()
                + " = " + (firstNumber + secondNumber).ToString();
            calculations.Add(strTransaction);
            Session["RecentCalculations"] = calculations;

            return firstNumber + secondNumber;
        }

        [WebMethod(EnableSession=true, Description="This method adds two numbers.", CacheDuration = 5)]

        public int Add(int firstNumber, int secondNumber)
        {
            List<string> calculations;

            if (Session["RecentCalculations"] == null)
            {
                calculations = new List<string>();
            }
            else
            {
                calculations = (List<string>)Session["RecentCalculations"];
            }

            string strTransaction = firstNumber.ToString() + " + "
                + secondNumber.ToString()
                + " = " + (firstNumber + secondNumber).ToString();
            calculations.Add(strTransaction);
            Session["RecentCalculations"] = calculations;

            return firstNumber +secondNumber;
        }

        [WebMethod(EnableSession = true)]
        public List<string> GetRecentTransection()
        {
            
            if (Session["RecentCalculations"] == null)
            {
                List<string> calculations = new List<string>();
                calculations.Add("You have not performed any calculations");
                return calculations;
            }
            else
            {
                return (List<string>)Session["RecentCalculations"];
            }
        }
    }
}
