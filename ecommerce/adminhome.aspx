<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminhome.aspx.cs" Inherits="ecommerce.adminhome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 32px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td>
                
                <asp:Label ID="Label1" runat="server" Text="Add Category"></asp:Label>
                
            <td>
               
            <td>
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/category.aspx" OnCommand="LinkButton1_Command">Click Here.....!</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Update Category"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/categoryedit.aspx" OnCommand="LinkButton2_Command">Click Here.....!</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label3" runat="server" Text="Add product"></asp:Label>
            </td>
            <td class="auto-style1"></td>
            <td class="auto-style1">
                <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/product.aspx" OnCommand="LinkButton3_Command">Click Here.....!</asp:LinkButton>
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Update product"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:LinkButton ID="LinkButton4" runat="server" OnCommand="LinkButton4_Command">Click Here.....!</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
