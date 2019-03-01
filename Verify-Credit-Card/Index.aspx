<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Verify_Credit_Card.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Verify Credit Card</title>
    <style>
        .panel{
            margin-right: auto;
            margin-left: auto;
            margin-top: auto;    
            margin-bottom: auto;
        }
       .button{
            width: 325px;
            height: 35px;
            background-color: #0099ff;       
            border: none;
            border-radius: 4px;
        }
       .label{
           float: left;
           text-align: center;
           border: 2px solid white;
           border-radius: 10px 10px 10px 10px;
       }
       
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div style:"body">
        <asp:Panel ID="Panel1" runat="server" Height="668px" Width="322px" CssClass="panel">
        <div>
            <asp:Label ID="lbl_check" runat="server" Height="86px" Width="315px" Font-Names="Times New Roman" CssClass="label"></asp:Label>
            <br />
        </div>
        <div >
            <h1>Verify Your Card Here</h1>
        </div>
        <div>
            <asp:Label ID="lbl_creditcard" runat="server" Text="Select Credit Card : " Font-Bold="true"></asp:Label>
            <br />
            &nbsp;
            <br />
            <asp:DropDownList ID="ddl_creditcard" runat="server" Width="319px" Height="35px">
                <asp:ListItem>VISA</asp:ListItem>
                <asp:ListItem>MasterCard</asp:ListItem>
                <asp:ListItem>Diners Club</asp:ListItem>
                <asp:ListItem>American Express</asp:ListItem>
                <asp:ListItem>Maestro</asp:ListItem>
                <asp:ListItem>Discover</asp:ListItem>
            </asp:DropDownList>
            &nbsp;<br />
            <asp:Image ID="img0" runat="server" Height="33px" Width="45px" />
            &nbsp;<asp:Image ID="img1" runat="server" Height="33px" Width="45px" />
            &nbsp;<asp:Image ID="img2" runat="server" Height="33px" Width="45px" />
            &nbsp;<asp:Image ID="img3" runat="server" Height="33px" Width="45px" />
            &nbsp;<asp:Image ID="img4" runat="server" Height="33px" Width="45px" />
            &nbsp;<asp:Image ID="img5" runat="server" Height="33px" Width="45px" />
            <br />
            <br />
            <br />
            <asp:Label ID="lbl_number" runat="server" Font-Bold="true" Text="Enter Card Number :"></asp:Label>
&nbsp;<br />
            <br />
            <asp:TextBox ID="txt_cardnumber" runat="server" Width="315px" Height="35px" OnTextChanged="txt_cardnumber_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lbl_warning" runat="server" Height="35px" Width="325px" BackColor="#FFFFCC" Font-Italic="True" Font-Names="Calibri" Font-Size="Small"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btn_check" runat="server" Text="Verify" OnClick="btn_check_Click" CssClass="button" Font-Bold="true" ForeColor="White"/>
            <br />
        </div>
        <div>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Image ID="img_card" runat="server" Height="181px" Width="260px" style="margin-left: 0px" />
            <br />
        </div>
        </asp:Panel>
            </div>
    </form>
</body>
</html>
