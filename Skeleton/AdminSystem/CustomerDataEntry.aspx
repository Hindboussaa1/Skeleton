<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>hi everyone </title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 51px; top: 377px; position: absolute" Text="CustomerActive"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 57px; top: 328px; position: absolute" Text="Address"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 60px; top: 167px; position: absolute" Text="Name"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 56px; top: 275px; position: absolute" Text="Date"></asp:Label>
        <asp:Label ID="CustomerId" runat="server" style="z-index: 1; left: 63px; top: 116px; position: absolute" Text="CustomerId"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 59px; top: 224px; position: absolute; bottom: 263px" Text="Email"></asp:Label>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 40px; top: 590px; position: absolute; height: 38px" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 212px; top: 588px; position: absolute" Text="Cancel" />
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 294px; top: 322px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 294px; top: 165px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 291px; top: 116px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 294px; top: 269px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 295px; top: 219px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 295px; top: 379px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 54px; top: 442px; position: absolute"></asp:Label>
    </form>
</body>
</html>
