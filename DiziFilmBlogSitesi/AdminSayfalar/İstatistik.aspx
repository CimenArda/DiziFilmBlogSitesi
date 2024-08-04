<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="İstatistik.aspx.cs" Inherits="DiziFilmBlogSitesi.AdminSayfalar.İstatistik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">


        
    <table class="table table-bordered">
        <tr>
            <td>
               Toplam Blog Sayısı:<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

            </td>

            <td>
   Toplam Yorum Sayısı: <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

            </td>

            <td>
   Film Sayısı :<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>

            </td>

        </tr>
             <tr>
         <td>
            Dizi Sayısı :<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>

         </td>

         <td>
Animasyon Sayısı :<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>

         </td>

         <td>
En fazla yorumlu blog: <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>

         </td>

     </tr>


             
    </table>
</asp:Content>
