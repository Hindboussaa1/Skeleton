<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 99px; width: 647px">
            Are you sure you want to delete this record?<br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Yes" />
            <asp:Button ID="Button1" runat="server" Text="No" />
        </div>
    </form>
</body>
</html>
