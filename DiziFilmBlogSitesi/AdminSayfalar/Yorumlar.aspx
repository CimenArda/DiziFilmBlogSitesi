<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yorumlar.aspx.cs" Inherits="DiziFilmBlogSitesi.AdminSayfalar.Yorumlar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">

       <table class="table table-bordered" >
       <tr>
           <th>Yorum Numarası</th>
           <th>Kullanıcı Ad</th>
           <th>Yorum Yapılan Blog</th>
         
           <th>Yorum Sil</th>
           <th>Yorum Güncelle</th>
       </tr>
       <asp:Repeater ID="Repeater1" runat="server">
           <ItemTemplate>
               <tr>
                   <td><%# Eval("YorumID") %></td>
                   <td><%# Eval("KullanıcıAd") %></td>
                   <td><%# Eval("BlogBaslik") %></td>
                 
<td><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "YorumSil.Aspx?YorumID="+Eval("YorumID")%>' CssClass="btn btn-danger">Sil</asp:HyperLink></td> 
    <td><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "YorumGuncelle.Aspx?YorumID="+Eval("YorumID")%>' CssClass="btn btn-success">Güncelle</asp:HyperLink>   </td>
               
               </tr>
           </ItemTemplate>
       </asp:Repeater>
   </table>


















</asp:Content>
