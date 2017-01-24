<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="AddDoctorDetails.aspx.cs" Inherits="tcs.construct.UI.AddDoctorDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table>
        <tr>
            <td>
                <asp:Label ID="lblDoctorName" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDoctorName" runat="server"></asp:TextBox>
            </td>
        </tr>
           <tr>
            <td>
                <asp:Label ID="lblDoctorDepartment" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDoctorDepartment" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td colspan="2">
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"/>
            </td>
        </tr>
    </table>
</asp:Content>
