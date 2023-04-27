<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 299px; margin-left: 0px">
            <asp:Label ID="lblCarId" runat="server" height="19px" style="z-index: 1; left: 9px; top: 14px; position: absolute; right: 1139px; width: 83px" Text="Car ID"></asp:Label>
            <asp:TextBox ID="txtCarID" runat="server" style="z-index: 1; left: 92px; top: 13px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblCarBrand" runat="server" style="z-index: 1; left: 9px; top: 46px; position: absolute; height: 19px; width: 83px" Text="Car Brand"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblCarYear" runat="server" height="19px" style="z-index: 1; left: 9px; top: 98px; position: absolute" Text="Car Year" width="83px"></asp:Label>
            <asp:TextBox ID="txtCarYear" runat="server" style="z-index: 1; left: 93px; top: 94px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtCarBrand" runat="server" style="z-index: 1; left: 91px; top: 42px; position: absolute"></asp:TextBox>
            <br />
            <asp:Label ID="lblCarModel" runat="server" height="19px" style="z-index: 1; left: 9px; position: absolute; width: 83px" Text="Car Model"></asp:Label>
            <asp:TextBox ID="txtCarModel" runat="server" style="z-index: 1; left: 93px; top: 65px; position: absolute"></asp:TextBox>
            <br />
            <asp:Label ID="lblCarColor" runat="server" height="19px" style="z-index: 1; left: 9px; top: 129px; position: absolute" Text="Car Color" width="83px"></asp:Label>
            <asp:TextBox ID="txtCarColor" runat="server" style="z-index: 1; left: 92px; top: 129px; position: absolute"></asp:TextBox>
            <br />
            <asp:CheckBox ID="chkAvailable" runat="server" style="z-index: 1; left: 108px; top: 158px; position: absolute" Text="Available" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; position: absolute"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 30px; top: 237px; position: absolute; height: 19px; width: 43px" Text=" OK" />
            <asp:Button ID="btnCancek" runat="server" style="z-index: 1; top: 236px; position: absolute; left: 101px" Text="Cancel" />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
