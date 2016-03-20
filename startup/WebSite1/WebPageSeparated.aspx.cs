using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebPageSeparated : System.Web.UI.Page
{
    delegate List<string> del(string description);
    del Keying = x => x.Split(new char[] { ' ', '!', '\'', '.', ';', '(', ')', '+', '=', '*', '/', '?', '#', '№' }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            TextBox2.Text = string.Empty;
            List<string> keywords = Keying(TextBox1.Text);
            List<int> indexes = new List<int>();
            indexes = Class1.Comparing(DropDownList1.Text, keywords, keywords);
            if (indexes.Count() == 0)
                throw new Exception("I do not understand this text. Try learning some English. Or you can actually write the description inside the box.");
            TextBox2.Text = Class1.Answer(indexes, keywords);
            TextBox1.Text = string.Empty;
        }
        catch (Exception ex)
        {
            throw new Exception("Что-то пошло не так, попробуйте изменить описание.");
        }
    }
}