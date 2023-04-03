<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication4._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



    <br />



    <table class="nav-justified" style="height: 426px; margin-top: 20px">

        <tr>
            
            <td colspan="2" style="font-size: x-large; font-family: Arial, Helvetica, sans-serif; font-weight: bold; color: #000000">Complete CRUD Operation in Asp.Net c# with SQL Using Stored Procedure</td>
            
        </tr>


        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Product ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button4" runat="server" BackColor="#993399" Font-Size="Large" ForeColor="White" OnClick="Button4_Click" Text="Search" Width="120px" style="margin-left: 0; margin-top: 8;" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Item Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Specification"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 20px;">
                <asp:Label ID="Label4" runat="server" Text="Unit"></asp:Label>
            </td>
            <td style="height: 20px">
                <asp:DropDownList ID="DropDownList1" runat="server" Font-Size="Medium"  Width="203px" Height="27px">
                    <asp:ListItem>PCS</asp:ListItem>
                    <asp:ListItem>KG</asp:ListItem>
                    <asp:ListItem>DZ</asp:ListItem>
                    <asp:ListItem>Ltr</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Status"></asp:Label>
            </td>
            <td>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" Height="16px" Width="196px">
                    <asp:ListItem>Running</asp:ListItem>
                    <asp:ListItem>Unused</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td style="height: 28px">
                <asp:Label ID="Label6" runat="server" Text="Creation Date"></asp:Label>
            </td>
            <td style="height: 28px">
                <asp:TextBox ID="TextBox4" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 27px"></td>
            <td style="height: 27px"></td>
        </tr>
        <tr>
            <td style="height: 16px"></td>
            <td style="height: 16px">
                <asp:Button ID="Button1" runat="server" BackColor="#993399" Font-Size="Large" ForeColor="White" OnClick="Button1_Click" Text="Insert" Width="120px" />
                &nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" BackColor="#993399" Font-Size="Large" ForeColor="White" OnClick="Button2_Click" Text="Update" Width="120px" style="margin-left: 0" />
                &nbsp;
                <asp:Button ID="Button3" runat="server" BackColor="#993399" Font-Size="Large" ForeColor="White" OnClick="Button3_Click" Text="Delete" Width="120px" OnClientClick="return confirm('Are you sure to delete ?');" style="margin-left: 0" />
                &nbsp;
                <asp:Button ID="Button5" runat="server" BackColor="#993399" Font-Size="Large" ForeColor="White" OnClick="Button5_Click" Text="Load" Width="120px" style="margin-left: 0" />
                </td>
        </tr>
        <tr>
            <td style="height: 28px" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 28px" colspan="2">
                <asp:GridView ID="GridView1" runat="server" Width="988px">
                    <HeaderStyle BackColor="#993399" ForeColor="White" />
                </asp:GridView>
            </td>
        </tr>
    </table>



</asp:Content>
