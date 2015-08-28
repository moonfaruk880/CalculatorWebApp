<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculatorPage.aspx.cs" Inherits="CalculatorWebApp.calculatorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="First Number"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="firstNumberTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Second Number"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="secondNumberTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Result"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="resultTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="addButton" runat="server" Text="Add" OnClick="addButton_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="subButton" runat="server" Text="Subtract" OnClick="subtractButton" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="mulButton" runat="server" Text="Multiply" OnClick="multiplyButton" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="divButton" runat="server" Text="Division" OnClick="divisionButton" />
        <br />
    
    </div>
    </form>
</body>
</html>
