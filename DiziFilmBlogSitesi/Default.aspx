<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DiziFilmBlogSitesi.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container">
 <div class="content-grids">
	 <div class="col-md-8 content-main">

		 <asp:Repeater ID="Repeater1" runat="server">
			 <ItemTemplate>
			 <div class="content-grid">					 
 
 
 
	 <div class="content-grid-info">

	 <img src="<%# Eval("BlogGorsel") %>" alt="" style="height:400px"/>
	 <div class="post-info">
	 <h4><a href="BlogDetay.Aspx?BlogID=<%# Eval("BlogID") %>"><%# Eval("BlogBaslik") %></a>  <%# Eval("BlogTarih") %> / 27 Comments</h4>
	 <p><%# Eval("BlogIcerik") %></p>
	 <a href="BlogDetay.Aspx?BlogID=<%# Eval("BlogID") %>"><span></span>Devamını Oku</a>
	 </div>
		 </div>

 
	</div>
				 </ItemTemplate>
		 </asp:Repeater>

		  
	  </div>

	  <div class="col-md-4 content-right">
		 <div class="recent">
			 <h3>En Son Bloglar</h3>
			 <ul>
				 <asp:Repeater ID="Repeater3" runat="server">
					 <ItemTemplate>
					 			 <li><a href="#"><%# Eval("BlogBaslik") %></a></li>
						 </ItemTemplate>
				 </asp:Repeater>
			
			 </ul>
		 </div>

		 <div class="comments">
			 <h3>Son Yorumlar</h3>
			
				 <asp:Repeater ID="Repeater4" runat="server">

					<ItemTemplate>
						 <ul>
						 <li><a href="#"><%# Eval("KullanıcıAd") %> </a> : <a href="#"><%# Eval("YorumIcerik") %></a></li>
						</ul>
					</ItemTemplate>

				 </asp:Repeater>

			
			
			
		 </div>


		 <div class="categories">
			 <h3>Kategoriler</h3>
			 <ul>
				 <asp:Repeater ID="Repeater2" runat="server">
					 <ItemTemplate>
						 			 <li><a href="KategoriDetay.Aspx?KategoriID=<%# Eval("KategoriID") %>"><%# Eval("KategoriAd") %></a></li>

					 </ItemTemplate>
				 </asp:Repeater>
			
			 </ul>
		 </div>
		 <div class="clearfix"></div>
	  </div>
	  <div class="clearfix"></div>
  </div>
 </div>
		
</asp:Content>
