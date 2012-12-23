<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TuitterDisplay.aspx.cs" Inherits="TuitterDisplay" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Tuitter Display</title>
    <link href="TuitterStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body class="tuitterBg">
    <form id="form1" runat="server">
    
<div id="mainContainer">
<div id="contentWrapper">
    <table cellpadding="0" class="table">
        <tr>
            <td class="cellOneOfThree">
                <asp:Image ID="Image3" runat="server" ImageUrl="~/img/tuitter-logo-white.jpg" /></td>
            <td class="cellTwoOfThree">
                <h3><asp:Label ID="welcomeLabel" runat="server" Text="Label"></asp:Label></h3></td>
            <td class="cellThreeOfThree">
                <asp:ImageButton ID="bacImageButton" runat="server" 
                    ImageUrl="~/img/tuitter-back-button.png" onclick="backImageButton_Click" /></td>
        </tr>
        <tr>
            <td colspan="3">
                <p class="tuitterText">
                    <asp:TextBox ID="tuitPostTextBox" runat="server" Height="100px" TextMode="MultiLine" 
                        Width="600px"></asp:TextBox></p>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <p class="tuitterText">
                    <asp:Button ID="tuitButton" runat="server" Text="Tuit" Width="80px" 
                        onclick="tuitButton_Click" /></p>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <h3>All past tuits</h3>
                </td>
        </tr>
        <tr>
            <td colspan="3">
                <p class="tuitterText">
                    <asp:TextBox ID="tuitDisplayTextBox" runat="server" Height="250px" TextMode="MultiLine" 
                        Width="800px"></asp:TextBox></p>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Image ID="Image2" runat="server" ImageUrl="~/img/tuitter-banner.png" Width="960px" />
            </td>
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
