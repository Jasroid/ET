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
                                                        <br/>
                                                        <cc1:ComboBox ID="cbusers" runat="server" DataSourceID="SqlDataSource1" DataTextField="Username" DataValueField="Username" MaxLength="0" style="display: inline;" AutoCompleteMode="SuggestAppend" DropDownStyle="DropDownList"></cc1:ComboBox>

                                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ETDBConnectionString1 %>" SelectCommand="Select Username from Users where (UserType=0)"></asp:SqlDataSource>
												<br/>

                                                  <asp:TextBox ID="txtMedication" placeholder="Medication" runat="server"></asp:TextBox>
                                                <br/>  <asp:TextBox ID="txtappointment" placeholder="Next Appointment" runat="server"></asp:TextBox>
                                                  <br/><asp:TextBox ID="txtnote" placeholder="Notes" runat="server"></asp:TextBox>
                                                      <br/>  <asp:Button ID="btncreate" runat="server" Text="Create Token" OnClick="btncreate_Click" />
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
