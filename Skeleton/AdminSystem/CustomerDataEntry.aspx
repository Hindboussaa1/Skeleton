<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AMG </title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            font-style: italic;
        }
    </style>
</head>
<body style="background-color: #9999FF">
    <form id="form1" runat="server">
        <div class="auto-style1">
        <div>
        </div>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="true" ValidationGroup="InputValidation" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 59px; top: 377px; position: absolute; width: 190px;" Text="CustomerActive" BackColor="#D5AAFF" BorderColor="#838383" BorderStyle="Inset" CssClass="auto-style2" height="29px"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 57px; top: 328px; position: absolute; width: 190px;" Text="Address" BackColor="#D5AAFF" BorderColor="#838383" BorderStyle="Inset" CssClass="auto-style2" height="29px"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 60px; top: 167px; position: absolute; width: 190px;" Text="Name" BackColor="#D5AAFF" BorderColor="#838383" BorderStyle="Inset" CssClass="auto-style2" height="29px"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 64px; top: 277px; position: absolute; width: 190px;" Text="Date" BackColor="#D5AAFF" BorderColor="#838383" BorderStyle="Inset" CssClass="auto-style2" height="29px"></asp:Label>
        <asp:Label ID="CustomerId" runat="server" style="z-index: 1; left: 63px; top: 116px; position: absolute; width: 190px;" Text="CustomerId" BackColor="#D5AAFF" BorderColor="#838383" BorderStyle="Inset" CssClass="auto-style2" height="29px"></asp:Label>
            <asp:Label ID="Label7" runat="server" BackColor="#D5AAFF" BorderColor="#838383" BorderStyle="Inset" CssClass="auto-style2" height="29px" style="z-index: 1; left: 63px; top: 224px; position: absolute; width: 190px" Text="Email"></asp:Label>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 151px; top: 497px; position: absolute; height: 27px; width: 86px;" Text="Ok" BackColor="#DDDDDD" BorderColor="#666699" CssClass="auto-style2" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 388px; top: 495px; position: absolute; height: 30px; bottom: 198px;" Text="Cancel" BackColor="#DDDDDD" BorderStyle="Inset" CssClass="auto-style2" />
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 294px; top: 322px; position: absolute" height="29px" width="190px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 294px; top: 165px; position: absolute" CssClass="auto-style2" height="29px" width="190px"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 291px; top: 116px; position: absolute; height: 29px; width: 190px;" CssClass="auto-style2"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 294px; top: 269px; position: absolute" height="29px" width="190px"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 295px; top: 219px; position: absolute" height="29px" width="190px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 295px; top: 379px; position: absolute" Text="Active" CssClass="auto-style2" height="29px" width="190px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 54px; top: 442px; position: absolute"></asp:Label>
        </div>
        <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 561px; top: 117px; position: absolute" Text="Find" />
    </form>
</body>
</html>
