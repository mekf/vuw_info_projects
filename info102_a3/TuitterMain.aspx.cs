using System;
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
using System.IO;    //using files

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected int userCheck(string usernameString, string passwordString)
    {
        int userCheckInt = 0;
        string[] userFilePath = File.ReadAllLines(Server.MapPath("~") + "/App_Data/userFile.txt");
        for (int i = 0; i < userFilePath.Length; i++)
        {
            string[] usernamePasswordArray = userFilePath[i].Split(' ');
            if (usernamePasswordArray[0] == usernameString && usernamePasswordArray[1] == passwordString)
            {
                userCheckInt = 1;  //user exist, correct password
                break;  //Stop going through the loop
            }
            if (usernamePasswordArray[0] == usernameString && usernamePasswordArray[1] != passwordString)
            {
                userCheckInt = 2;  //user exist, wrong password
                break;  //Stop going through the loop
            }
        }
        return userCheckInt;
    }

    protected void logInButton_Click(object sender, EventArgs e)
    {
        string logInUsername = logInUsernameTextBox.Text;
        string logInPassword = logInPasswordTextBox.Text;

        if (string.IsNullOrEmpty(logInUsername) || string.IsNullOrEmpty(logInPassword))
        {
            logInLabel.Text = "Error: blank field";
        }
        else
        {
            int userCheckInt = userCheck(logInUsername, logInPassword);

            if (userCheckInt == 1)
            {
                Session["User"] = logInUsername;
                Response.Redirect("TuitterDisplay.aspx");
            }
            else
            {
                logInLabel.Text = userCheckInt.ToString() + " Error: wrong combination";
            }
        }
    }

    protected void signUpButton_Click(object sender, EventArgs e)
    {
        //need two variables for username n' password
        string newUsername = signUpUsernameTextBox.Text;
        string newPassword = signUpPasswordTextBox.Text;
        bool booleanAppend = true;

        if (string.IsNullOrEmpty(newUsername) || string.IsNullOrEmpty(newPassword))
        {
            signUpLabel.Text = "Error: blank field";
        }
        else
        {
            int userCheckInt = userCheck(newUsername, newPassword);

            if (userCheckInt == 1 || userCheckInt == 2)
            {
                signUpLabel.Text = userCheckInt.ToString() + " Error: user already exist";
            }
            else
            {
                StreamWriter myStreamWriter = new StreamWriter(Server.MapPath("~" + "/App_Data/userFile.txt"), booleanAppend);
                myStreamWriter.WriteLine(newUsername + " " + newPassword);
                myStreamWriter.Close();

                signUpLabel.Text = "sweet";
                Session["User"] = newUsername;
                Response.Redirect("TuitterDisplay.aspx");
            }
        }
    }

    protected void searchImageButton_Click(object sender, ImageClickEventArgs e)
    {
        if (string.IsNullOrEmpty(searchInPutTextBox.Text))
        {
            searchInPutTextBox.Text = "error, need to put in something";
        }
        else
        {
            Session["Search"] = searchInPutTextBox.Text;
            Response.Redirect("TuitterSearch.aspx");
        }
    }

    protected void forwardImageButton_Click(object sender, ImageClickEventArgs e)
    {
        var dummySession = "null";

        if (Session["temp"] == null)
        {
            Session["temp"] = dummySession;
        }

        if (Session["temp"].ToString() == "search")
        {
            Response.Redirect("TuitterSearch.aspx");
        }
        else if (Session["temp"].ToString() == "display")
        {
            Response.Redirect("TuitterDisplay.aspx");
        }
    }
}
