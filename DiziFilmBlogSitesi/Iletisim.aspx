<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="DiziFilmBlogSitesi.Iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!DOCTYPE HTML>
<html>

<body>

<div class="contact-content">
	 <div class="container">
		     <div class="contact-info">
			 <h2>İletim</h2>
			 <p>Blog Sayfamızda bulunan film ve dizilere katkıda bulunmak için veya sayfamızda yaşayacağınız sorunlarda bu kısımdan bizlerle irtibata geçebilirsiniz.Formu doldururken mail adresinizi mutlaka girmeyi unutmayınız.</p>
		     </div>
			 <div class="contact-details">				 
			 <form runat="server">
				 <asp:TextBox ID="TextBox1" runat="server" placeholder="Ad" required></asp:TextBox>
				 <asp:TextBox ID="TextBox2" runat="server" placeholder="Mail" required></asp:TextBox>
				 <asp:TextBox ID="TextBox3" runat="server" placeholder="Telefon" required></asp:TextBox>
				 <asp:TextBox ID="TextBox4" runat="server" placeholder="Konu" required></asp:TextBox>
				 <asp:TextBox ID="TextBox5" runat="server" placeholder="Mesajınız" required TextMode="MultiLine" Height="150"></asp:TextBox>

                 <asp:Button ID="Button1" runat="server" Text="Gönder Gelsin" OnClick="Button1_Click" />
			 </form>
		  </div>
		  <div class="contact-details">
			 			  <div class="col-md-3 ">
							   </div>
			  <div class="col-md-6 contact-map">
				 			  <h4>       Bizi burda bulabilirsiniz.</h4>

				<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3008.343510187167!2d28.969800175861295!3d41.06148337134312!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab72325d1a9cf%3A0xaddd3acd2b43b336!2sMemorial%20%C5%9Ei%C5%9Fli%20Hastanesi!5e0!3m2!1str!2str!4v1722506185329!5m2!1str!2str" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
			  </div>
		
	     </div>		 


			 </div>
	 </div>
	

</asp:Content>
