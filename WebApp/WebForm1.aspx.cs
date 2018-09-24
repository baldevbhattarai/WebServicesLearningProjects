using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            CalculatorWebServices.CalculatorWebServiceSoapClient client = new CalculatorWebServices.CalculatorWebServiceSoapClient();
            int Result = client.Add(Convert.ToInt32(txtFirstNumber.Text), Convert.ToInt32(txtSecondNumber.Text));
            lblResult.Text = Result.ToString();

            gvRecentCalculations.DataSource = client.GetRecentTransection();
            gvRecentCalculations.DataBind();

            gvRecentCalculations.HeaderRow.Cells[0].Text = "Recent Calculations";

        }
    }
}