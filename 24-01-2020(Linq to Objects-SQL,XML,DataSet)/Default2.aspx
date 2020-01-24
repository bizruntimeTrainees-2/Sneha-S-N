<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>  
  
<!DOCTYPE html>  
  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head runat="server">  
    <title></title>  
</head>  
<body>  
    <form id="form1" runat="server">  
          
            <div class="GridviewDiv">  
  
<asp:GridView runat="server" ID="gvDetails" ShowFooter="true" AllowPaging="true" PageSize="10" AutoGenerateColumns="false" DataKeyNames="Id,Name" OnPageIndexChanging="gvDetails_PageIndexChanging" OnRowCancelingEdit="gvDetails_RowCancelingEdit"  
  
OnRowEditing="gvDetails_RowEditing" OnRowUpdating="gvDetails_RowUpdating" OnRowDeleting="gvDetails_RowDeleting" OnRowCommand ="gvDetails_RowCommand" >  
  
<HeaderStyle CssClass="headerstyle" />  
  
<Columns>  
  
<asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="true" />  
  
<asp:TemplateField HeaderText="Name">  
  
<ItemTemplate>  
  
<asp:Label ID="lblName" runat="server" Text='<%# Eval("Name")%>'/>  
  
</ItemTemplate>  
  
<EditItemTemplate>  
  
<asp:TextBox ID="txtName" runat="server" Text='<%# Eval("Name")%>'/>  
  
</EditItemTemplate>  
  
<FooterTemplate>  
  
<asp:TextBox ID="txtfName" runat="server" />  
  
</FooterTemplate>  
  
</asp:TemplateField>  
  
<asp:TemplateField HeaderText = "Location">  
  
<ItemTemplate>  
  
<asp:Label ID="lblLocation" runat="server" Text='<%# Eval("Location")%>'></asp:Label>  
  
</ItemTemplate>  
  
<EditItemTemplate>  
  
<asp:TextBox ID="txtLocation" runat="server" Text='<%# Eval("Location")%>'/>  
  
</EditItemTemplate>  
  
<FooterTemplate>  
  
<asp:TextBox ID="txtfLocation" runat="server" />  
  
</FooterTemplate>  
  
</asp:TemplateField>  
  
<asp:TemplateField HeaderText="Gender">  
  
<ItemTemplate>  
  
<asp:Label ID="lblGender" runat="server" Text='<%# Eval("Gender")%>'/>  
  
</ItemTemplate>  
  
<EditItemTemplate>  
  
<asp:TextBox ID="txtGender" runat="server" Text='<%# Eval("Gender")%>'/>  
  
</EditItemTemplate>  
  
<FooterTemplate>  
  
<asp:TextBox ID="txtfGender" runat="server" />  
  
<asp:Button ID="btnAdd" CommandName="AddNew" runat="server" Text="Add" />  
  
</FooterTemplate>  
  
</asp:TemplateField>  
  
<asp:CommandField ShowEditButton="True" ShowDeleteButton="true" />  
  
</Columns>  
  
</asp:GridView>  
  
<asp:Label ID="lblresult" runat="server"></asp:Label>  
        </div>  
    </form>  
</body>  
</html>  