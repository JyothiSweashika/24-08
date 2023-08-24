using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ProductRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TxtCategory.Items.Add("Elctronics");
                TxtCategory.Items.Add("Sports");
                TxtCategory.Items.Add("Toys");
                TxtCategory.Items.Add("Medicines");
            }
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "<h1>Registration Successfull!!!</h1>";
            lblMsg.Text += "<br> ProductName : " + TxtName.Text;
            lblMsg.Text += "<br> Category : " + TxtCategory.Text;
            lblMsg.Text += "<br> Price : " + TxtPrice.Text;
            lblMsg.Text += "<br> description : " + TxtDesc.Text;
            lblMsg.Text += "<br> Calender : " + TxtCal.SelectedDate;




        }
    }
}