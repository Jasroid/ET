<%@ Page Title="" Language="C#" MasterPageFile="~/ETMaster.Master" AutoEventWireup="true" CodeBehind="CreateToken.aspx.cs" Inherits="EasyToken.CreateToken" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
      <div class="content">
<div class="women_main">
	<!-- start content -->
	<div class="catalog">				
			<div id="tabs" class="tabs">
                	<div class="content tab">
									<section id="section-1" class="content-current">
										<div class="fo-top">
											<div class="form-group">
										
												
                                                 
                                                    
                                                   <br/>  
											
                                                	<div class="col-sm-2 hp">
                                                        <asp:TextBox ID="txtsearch" placeholder="Patient Name" runat="server"></asp:TextBox><asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="btnsearch_Click" />
                                                        <br/>
                                                        <asp:Label ID="lblpatientlist" runat="server" Text=""></asp:Label>
												</div>
												<div class="clearfix">
                                                    </div>
											</div>

										</div>
                                        </section>
</div>
</div>
                </div>
        </div>

</div>
</asp:Content>
