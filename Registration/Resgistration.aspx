<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Resgistration.aspx.cs" Inherits="Registration.Resgistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 466px;
            width: 801px;
        }
    </style>
</head>
<body style="width: 533px; height: 33px; margin-left: 15px; margin-right: 379px; margin-bottom: 519px;">
    <form id="form1" runat="server">
        <div>
            <p style="margin-left: 240px;">
            <span style="font-size:24px">Register yourself!</span>
                </p>
                </div>
        <p style="margin-left: 120px">
            First Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server" Height="24px" style="margin-left: 0px" Width="206px"></asp:TextBox>
            
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="First Name Empty" ForeColor="Red"></asp:RequiredFieldValidator>
            
        </p>
        <p style="margin-left: 120px">
            Last Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server" Height="24px" style="margin-left: 0px" Width="206px"></asp:TextBox>
            
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Last Name Empty" ForeColor="Red"></asp:RequiredFieldValidator>
            
        </p>
        <p style="margin-left: 120px">
            Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox3" runat="server" Height="24px" style="margin-left: 0px" Width="210px"></asp:TextBox>
            
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Empty" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Invalid Email id" Font-Bold="True" ForeColor="#993333" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            
        </p>
        <p style="margin-left: 120px">
            Phone&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox4" runat="server" Height="24px" style="margin-left: 0px" Width="210px"></asp:TextBox>
            
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Invalid" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox4" ErrorMessage="Invalid Phone Number" Font-Bold="True" ForeColor="#CC6600" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
            
        </p>
        <p style="margin-left: 280px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
        <p style=" margin-left: 120px">
        DOB
        </p>
        <p style="margin-left: 280px">
            <asp:Calendar ID="Calendar1" runat="server" style="    margin-top: -33px; margin-left: 268px;"></asp:Calendar>
            
        </p>
        
        <asp:Button ID="Button1" runat="server" style="margin-left: 196px; font-size: 16px;" Text="Submit" Width="307px"  />
       
    </form>
</body>
</html>
