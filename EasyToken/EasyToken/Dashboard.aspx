<%@ Page Title="" Language="C#" MasterPageFile="~/ETMaster.Master" AutoEventWireup="true" EnableEventValidation="true"  CodeBehind="Dashboard.aspx.cs" Inherits="EasyToken.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <!--content-->
			<div class="content">
					<div class="monthly-grid">
						<div class="panel panel-widget">
							
                            
                            <div class="panel-title">
							  Active Tokens
							  
							    </div>
							<div class="panel-body">
                                <asp:Label ID="lblActiveTokens" runat="server" Text=""></asp:Label>
                                </div>

                            


                            </div>
                        </div>
</div>



</asp:Content>
