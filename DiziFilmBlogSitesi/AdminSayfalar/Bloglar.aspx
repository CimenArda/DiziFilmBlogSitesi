<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Bloglar.aspx.cs" Inherits="DiziFilmBlogSitesi.AdminSayfalar.Bloglar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
    <table class="table table-bordered" >
        <tr>
            <th>Blog Numarası</th>
            <th>Blog Başlığı</th>
            <th>Blog Tarih</th>
            <th>Blog Tür</th>
            <th>Blog Kategori</th>
            <th>Blog Sil</th>
            <th>Blog Güncelle</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("BlogID") %></td>
                    <td><%# Eval("BlogBaslik") %></td>
                    <td><%# Eval("BlogTarih") %></td>
                    <td><%# Eval("BlogTur") %></td>
                    <td><%# Eval("BlogKategori") %></td>
 <td><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "BlogSil.Aspx?BlogID="+Eval("BlogID")%>' CssClass="btn btn-danger">Sil</asp:HyperLink></td> 
     <td><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "BlogGuncelle.Aspx?BlogID="+Eval("BlogID")%>' CssClass="btn btn-success">Güncelle</asp:HyperLink>   </td>
                
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="YeniBlog.Aspx" class="btn btn-primary">Ekle</a>
    
</asp:Content>
