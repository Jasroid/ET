<%@ Page Title="" Language="C#" MasterPageFile="~/ETMaster.Master" AutoEventWireup="true" CodeBehind="CreateToken.aspx.cs" Inherits="EasyToken.CreateToken" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    	<div class="content">
					<div class="monthly-grid">
						<div class="panel panel-widget">
							
                            
                            <div class="panel-title">
							 Create New Token
							  
							    </div>
							<div class="panel-body">
                                                    Patient: <br/>   <cc1:ComboBox ID="cbusers" runat="server" DataSourceID="SqlDataSource1" DataTextField="Username" DataValueField="Username" MaxLength="0" style="display: inline;" AutoCompleteMode="SuggestAppend" DropDownStyle="DropDownList"></cc1:ComboBox>

                                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ETDBConnectionString1 %>" SelectCommand="Select Username from Users where (UserType=0)"></asp:SqlDataSource>
												<br/>

                                              <br/>  Medication x Dosage:  <br/>   <asp:TextBox ID="txtMedication" placeholder="Medication"  Width="198px" runat="server"></asp:TextBox>
                                            <br/>    <br/> Next Appointment: <br/><asp:TextBox ID="txtappointment" placeholder="Next Appointment"  Width="198px" runat="server"></asp:TextBox>
                                                 <br/> <br/> Notes:<br/> <asp:TextBox ID="txtnote" placeholder="Notes" runat="server" Height="99px" Width="198px"></asp:TextBox>
                                                      <br/>  <asp:Button ID="btncreate" class="btn btn-sm btn-warning warning_33" ForeColor="white" BackColor="#b52e31"  runat="server" Text="Create Token" OnClick="btncreate_Click" />
                                                           </div>
												<div class="clearfix">
                                                    </div>
											</div>

										</div>
                                   </div>

</asp:Content>
