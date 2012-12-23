<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="TuitterMain.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to Tuitter</title>
    <link href="TuitterStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body class="tuitterBg">
    <form id="form1" runat="server">
    
<div id="mainContainer">
<div id="contentWrapper">
    <table cellpadding="0" class="table">
            <tr>
                <td class="cellOne" rowspan="5">
                    <asp:Image ID="Image3" runat="server" ImageUrl="~/img/tuitter-logo-white.jpg" /></td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <p class="tuitterText"><asp:TextBox ID="logInUsernameTextBox" runat="server"></asp:TextBox></p></td>
            </tr>
            <tr>
                <td>
                    <p class="tuitterText"><asp:TextBox ID="logInPasswordTextBox" runat="server"></asp:TextBox></p></td>
            </tr>
            <tr>
                <td>
                    <p class="tuitterText"><asp:Button ID="logInButton" runat="server" Text="Log in" 
                            Width="80px" onclick="logInButton_Click" /></p></td>
            </tr>
            <tr>
                <td>
                    <p class="tuitterText"><asp:Label ID="logInLabel" runat="server" Text="Label"></asp:Label></p></td>
            </tr>
            <tr>
                <td class="cellOne">
                    <h1 class="tuitterHeading">Follow Your interests!</h1></td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="cellOne">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="cellOne">
                    <p class="tuitterText">Instant updates from your NZ friends, celebrities and what's happening in New Zealand</p></td>
                <td>
                    <h5>New to Tuitter? Join Now!</h5></td>
            </tr>
            <tr>
                <td class="cellOne">
                    &nbsp;</td>
                <td>
                    <p class="tuitterText"><asp:TextBox ID="signUpUsernameTextBox" runat="server"></asp:TextBox></p></td>
            </tr>
            <tr>
                <td class="cellOne">
                    &nbsp;</td>
                <td>
                    <p class="tuitterText"><asp:TextBox ID="signUpPasswordTextBox" runat="server"></asp:TextBox></p></td>
            </tr>
            <tr>
                <td class="cellOne">
                    &nbsp;</td>
                <td>
                    <p class="tuitterText"><asp:Button ID="signUpButton" runat="server" Text="Sign Up" 
                            Width="80px" onclick="signUpButton_Click" /></p></td>
            </tr>
            
            <tr>
                <td class="cellOne">
                    &nbsp;</td>
                <td>
                    <p class="tuitterText"><asp:Label ID="signUpLabel" runat="server" Text="Label"></asp:Label></p></td>
            </tr>
            <tr>
                <td class="cellOne">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="cellOne">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="cellOne">
                    <p class="tuitterText"><asp:TextBox ID="searchInPutTextBox" runat="server" Width="500px">search tuits</asp:TextBox>
                    <asp:ImageButton ID="searchImageButton" runat="server" 
                            ImageUrl="~/img/tuitter-search-button.png" Width="20px" 
                            onclick="searchImageButton_Click" /></p></td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="cellOne">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="cellOne">
                    <p class="tuitterText"><asp:Label ID="tuitterDisplayLabel" runat="server" Text="Label"></asp:Label></p>
                </td>
                <td style="text-align: right; padding-right: 10px;">
                    <asp:ImageButton ID="forwardImageButton" runat="server" 
                        ImageUrl="~/img/tuitter-forward-button.png" 
                        onclick="forwardImageButton_Click" />
                </td>
            </tr>
            <tr>
                <td class="cellOne" colspan="2">
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/img/tuitter-banner.png" Width="960px" /></td>
            </tr>
        </table>
</div>
   
<div class="push"></div>
</div>
   
<div id="footer">
	<div class="footerContent">
		&#169; <a href="http://creativecommons.org/licenses/by-nc-sa/3.0/" target="_blank" class="footerLink">Creative Commons Attribution-Noncommercial-Share Alike 3.0 Unported License</a> (CC-BY-NC-SA)
		<br />
		best view in Firefox
	</div>
</div>
</form>
</body>
</html>
