using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebPageSeparated : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox2.Text = string.Empty;
        List<string> keywords = new List<string>();
        List<string> indexes = new List<string>();
        keywords = ClassLibrary1.Methods.Keying(TextBox1.Text);
        indexes = ClassLibrary1.Methods.Comparing(DropDownList1.Text, some shit, keywords);
        TextBox2.Text = ClassLibrary1.Methods.Answer(indexes, govno again);
        TextBox1.Text = string.Empty;
    }   
}