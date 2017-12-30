using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewState
{
    public partial class ViewState2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["Clicks"] == null)
                {
                    ViewState["Clicks"] = 0;
                }
                TextBox1.Text = ViewState["Clicks"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //here the int variable ClicksCount, stores the ViewState clicks and increments up 1.
            int ClicksCount = (int)ViewState["Clicks"] + 1;
            //here convert int to string and passes the ViewState memory in the TextBox1.
            TextBox1.Text = ClicksCount.ToString();
            //here the ViewState memory gets stored back into the int variable ClicksCount.
            ViewState["Clicks"] = ClicksCount;
        }
    }
}