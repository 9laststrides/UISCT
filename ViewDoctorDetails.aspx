<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="ViewDoctorDetails.aspx.cs" Inherits="tcs.construct.UI.ViewDoctorDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="grvDoctorDetails" runat="server" AutoGenerateColumns="false" OnRowCommand="grvDoctorDetails_RowCommand" OnSelectedIndexChanged="grvDoctorDetails_SelectedIndexChanged">
        <Columns>
            <asp:BoundField HeaderText="Name" DataField="DoctorName" />
            <asp:BoundField HeaderText="Department" DataField="Department" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnEdit" runat="server" Text="Edit" CommandName="cmdEdit" CommandArgument='<%#Eval("DoctorId") %>' />
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" CommandName="cmdDelete" CommandArgument='<%#Eval("DoctorId") %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
