<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YeniBlog.aspx.cs" Inherits="DiziFilmBlogSitesi.AdminSayfalar.YeniBlog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">



    <form runat="server" class="form-group"> 
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Blog Başlık"></asp:TextBox>
        <br />
       <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Blog Tarih"></asp:TextBox>
        <br />
       <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Blog Gorsel"></asp:TextBox>
         <br />
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" DataValueField="TurID" DataTextField="TurAd"></asp:DropDownList>
         <br />
        <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control" DataValueField="KategoriID" DataTextField="KategoriAd"></asp:DropDownList>

        <br />
         <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" placeholder="Blog Icerik" Height="100" TextMode="MultiLine"></asp:TextBox>
   <br />

        <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-primary" OnClick="Button1_Click" />


    </form>
</asp:Content>
