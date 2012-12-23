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

public partial class TuitterDisplay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        welcomeLabel.Text = "Welcome " + Session["User"].ToString() + " !";
        tuitDisplayTextBox.Text = tuitDisplay();
    }

    protected string tuitDisplay()
    {
        tuitDisplayTextBox.Text = "";
        
        string tuitDisplayString = "";

        string[] tuitLogFilePath = File.ReadAllLines(Server.MapPath("~") + "/App_Data/tuitLogFile.txt");
        Array.Reverse(tuitLogFilePath);
        for (int i = 0; i < tuitLogFilePath.Length; i++)
        {
            tuitDisplayString += tuitLogFilePath[i].ToString() + System.Environment.NewLine;
        }

        return tuitDisplayString;
    }

    protected void backImageButton_Click(object sender, ImageClickEventArgs e)
    {
        Session["temp"] = "display";
        Response.Redirect("TuitterMain.aspx");
    }

    protected void tuitButton_Click(object sender, EventArgs e)
    {
        string usernameString = Session["User"].ToString();
        string postContentString = tuitPostTextBox.Text;
        string dayTimeString = DateTime.Now.ToString();
        bool booleanAppend = true;

        StreamWriter myStreamWriter = new StreamWriter(Server.MapPath("~" + "/App_Data/tuitLogFile.txt"), booleanAppend);
        myStreamWriter.WriteLine(dayTimeString);
        myStreamWriter.WriteLine(postContentString);
        myStreamWriter.WriteLine(usernameString + System.Environment.NewLine);
        myStreamWriter.Close();

        tuitPostTextBox.Text = "";

        tuitDisplayTextBox.Text = tuitDisplay();
    }
}
