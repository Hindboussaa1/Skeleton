<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 440px">
            <asp:Label ID="lblStaffId" runat="server" Text="StaffId" width="63px"></asp:Label>
&nbsp;<asp:TextBox ID="txtStaffId" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblStaffFullName" runat="server" Text="Full Name"></asp:Label>
&nbsp;<asp:TextBox ID="txtStaffFullName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblStaffStartDate" runat="server" Text="Start Date" width="63px"></asp:Label>
&nbsp;<asp:TextBox ID="txtStaffStartDate" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblStaffRole" runat="server" Text="Role" width="63px"></asp:Label>
&nbsp;<asp:TextBox ID="txtStaffRole" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblStaffEmail" runat="server" Text="E-Mail" width="63px"></asp:Label>
&nbsp;<asp:TextBox ID="txtStaffEmail" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkAvailable" runat="server" Text="Available" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
