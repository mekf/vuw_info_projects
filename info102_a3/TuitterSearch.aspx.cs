using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        searchResultLabel.Text = "Results for search string " + "'" + Session["Search"].ToString() + "'";

        string tuitSearchInputString = Session["Search"].ToString();

        searchResultTextBox.Text = "";

        string tuitSearchResultString = "";

        string[] tuitLogFilePath = File.ReadAllLines(Server.MapPath("~") + "/App_Data/tuitLogFile.txt");
        Array.Reverse(tuitLogFilePath);
        bool found = false;
        for (int i = 2; i < tuitLogFilePath.Length; i += 4)
        {
            if (tuitLogFilePath[i].Contains(tuitSearchInputString))
            {
                found = true;
                tuitSearchResultString += tuitLogFilePath[i - 1].ToString() + System.Environment.NewLine;
                tuitSearchResultString += tuitLogFilePath[i].ToString() + System.Environment.NewLine;
                tuitSearchResultString += tuitLogFilePath[i + 1].ToString() + System.Environment.NewLine;
                tuitSearchResultString += System.Environment.NewLine;
            }
        }

        if (found == true)
        {
            searchResultTextBox.Text = tuitSearchResultString;
        }
        else
        {
            searchResultTextBox.Text = "sorry, couldn't find anything that contains " + Session["Search"].ToString();
        }
    }

    protected void backImageButton_Click(object sender, ImageClickEventArgs e)
    {
        Session["temp"] = "search";
        Response.Redirect("TuitterMain.aspx");
    }
}
