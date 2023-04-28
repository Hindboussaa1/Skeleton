<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <p>
            &nbsp;</p>
        <p>
             &nbsp;</p>
        <p>
            &nbsp;</p>
         <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 59px; top: 377px; position: absolute; width: 190px;" Text="CustomerActive" BackColor="#D5AAFF" BorderColor="#838383" BorderStyle="Inset" CssClass="auto-style2" height="29px"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 57px; top: 328px; position: absolute; width: 190px;" Text="Address" BackColor="#D5AAFF" BorderColor="#838383" BorderStyle="Inset" CssClass="auto-style2" height="29px"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 60px; top: 167px; position: absolute; width: 190px;" Text="Name" BackColor="#D5AAFF" BorderColor="#838383" BorderStyle="Inset" CssClass="auto-style2" height="29px"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 64px; top: 277px; position: absolute; width: 190px;" Text="Date" BackColor="#D5AAFF" BorderColor="#838383" BorderStyle="Inset" CssClass="auto-style2" height="29px"></asp:Label>
        <asp:Label ID="CustomerId" runat="server" style="z-index: 1; left: 63px; top: 116px; position: absolute; width: 190px;" Text="CustomerId" BackColor="#D5AAFF" BorderColor="#838383" BorderStyle="Inset" CssClass="auto-style2" height="29px"></asp:Label>
            <asp:Label ID="Label7" runat="server" BackColor="#D5AAFF" BorderColor="#838383" BorderStyle="Inset" CssClass="auto-style2" height="29px" style="z-index: 1; left: 63px; top: 224px; position: absolute; width: 190px" Text="Email"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 294px; top: 322px; position: absolute" height="29px" width="190px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 294px; top: 165px; position: absolute" CssClass="auto-style2" height="29px" width="190px"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 291px; top: 116px; position: absolute; height: 29px; width: 190px;" CssClass="auto-style2"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 294px; top: 269px; position: absolute" height="29px" width="190px"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 295px; top: 219px; position: absolute" height="29px" width="190px"></asp:TextBox>
        
       <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 295px; top: 379px; position: absolute" Text="Active" CssClass="auto-style2" height="29px" width="190px" />
       <style>
           #GridView1{
               float:right;
           }
       </style>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 59px; top: 490px; position: absolute; height: 27px; width: 86px;" Text="Delete" BackColor="#DDDDDD" BorderColor="#666699" CssClass="auto-style2" OnClick="Button1_Click" />
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 200px; top: 490px; position: absolute; height: 27px; width: 86px;" Text="ADD" BackColor="#DDDDDD" BorderColor="#666699" CssClass="auto-style2" OnClick="btnOK_Click" />
        <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 320px; top: 490px; position: absolute;  height: 27px; width: 86px;" Text="Edit" BackColor="#DDDDDD" BorderColor="#666699" CssClass="auto-style2" OnClick="Button2_Click"  />
        
        <asp:Label ID="Label_Postcode" runat="server" style="z-index: 1; left: 59px; top: 550px; position: absolute; width: 190px;" Text="Enter Your Address:" height="29px"></asp:Label>
        <asp:TextBox ID="TextBox_Postcode" runat="server" style="z-index: 1; left: 200px; top: 550px; position: absolute" height="29px" width="190px"></asp:TextBox>

        
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 59px; top: 600px; position: absolute;  height: 27px; width: 86px;" Text="Apply" BackColor="#DDDDDD" BorderColor="#666699" CssClass="auto-style2" />
        <asp:Button ID="btnClear_" runat="server" style="z-index: 1; left: 200px; top: 600px; position: absolute; height: 27px; width: 86px;" Text="Clear" BackColor="#DDDDDD" BorderColor="#666699" CssClass="auto-style2"  />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="CustomerId" AutoGenerateSelectButton="true" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
    <Columns>
        <asp:BoundField HeaderText="Customer ID" DataField="CustomerId" />
        <asp:BoundField HeaderText="Name" DataField="Name" />
        <asp:BoundField HeaderText="Address" DataField="Address" />
        <asp:BoundField HeaderText="Email" DataField="Email" />
        <asp:BoundField HeaderText="Date" DataField="Date" />
        <asp:TemplateField HeaderText="Active">
            <ItemTemplate>
                <asp:CheckBox ID="chkActive" runat="server" Checked='<%# Eval("CustomerActive") %>' Enabled="false" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
    </form>
</body>
</html>
