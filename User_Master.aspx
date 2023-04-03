<%@ Page Title="User Master" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="User_Master.aspx.cs" Inherits="WebApplication4.User_Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script src="../js/float_value_enter.js" type="text/javascript"></script>
    <link href="bootstrap/css/tables.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" language="javascript">
        function Validate() {
            var txt_name = document.getElementById('<%=txt_name.ClientID%>');
            var txt_username = document.getElementById('<%=txt_username.ClientID%>');
            var txt_Password = document.getElementById('<%=txt_Password.ClientID%>');
            var txt_Address = document.getElementById('<%=txt_Address.ClientID%>');
            var txt_mobileno = document.getElementById('<%=txt_mobileno.ClientID%>');

            if (txt_name.value.trim() == "") {
                txt = "Please Enter Name....!";
                alert(txt);
                txt_name.focus();
                return false;
            }
            else if (txt_username.value.trim() == "") {
                txt = "Please Enter UserName....!";
                alert(txt);
                txt_username.focus();
                return false;
            }
            if (txt_Password.value.trim() == "") {
                txt = "Please Enter Password....!";
                alert(txt);
                txt_Password.focus();
                return false;
            }
            if (txt_Address.value.trim() == "") {
                txt = "Please Enter Address....!";
                alert(txt);
                txt_Address.focus();
                return false;
            }

            if (txt_mobileno.value.trim() == "") {
                txt = "Please Enter Mobile No....!";
                alert(txt);
                txt_mobileno.focus();
                return false;
            }

        }
        function isNumber(evt) {
            evt = (evt) ? evt : window.event;
            var charCode = (evt.which) ? evt.which : evt.keyCode;
            if (charCode > 31 && (charCode < 48 || charCode > 57)) {
                return false;

            }
            return true;
        }
        function Validate_Delete() {
            if (confirm("Are You Sure To Delete.....?")) {
                return true;
            }
            else {
                return false;
            }
        }
       
    </script>
       <div class="container-fluid">
                <div class="row">
                    <div class="card">
                        <div class="card-header">
                            <div class="row">
                                <div class="col-lg-6 text-left">
                                    User Master</div>
                                <div class="col-lg-6 text-right">
                                    Records <span class="badge badge-primary">
                                        <asp:Label ID="lbl_record_count" runat="server" TabIndex="11" Text="0"></asp:Label></span>
                                </div>
                            </div>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-md-5" style="border-right: 1px solid #d8d8d8;">
                                    <div class="form-group">
                                        <label for="email">
                                            ID</label>
                                        <div class="input-group">
                                            <asp:TextBox ID="txt_ID" runat="server" CssClass="form-control col-md-6" Enabled="false"
                                                TabIndex="1" AutoCompleteType="Disabled" autocomplete="off"></asp:TextBox>
                                            <div class="input-group-append">
                                            </div>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label for="email">
                                            Name</label><div class="input-group">
                                            <asp:TextBox ID="txt_name" runat="server" CssClass="form-control" MaxLength="100"
                                                TabIndex="2" AutoCompleteType="Disabled" autocomplete="off"></asp:TextBox>
                                            <div class="input-group-append">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_name"
                                                    InitialValue="" ForeColor="red" Display="Dynamic" Text="*" ValidationGroup="save"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label for="email">
                                            Address</label>
                                        <div class="input-group">
                                            <asp:TextBox ID="txt_Address" runat="server" CssClass="form-control" TabIndex="3"
                                                AutoCompleteType="Disabled" autocomplete="off" MaxLength="200"></asp:TextBox>
                                            <div class="input-group-append">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_Address"
                                                    InitialValue="" ForeColor="red" Display="Dynamic" Text="*" ValidationGroup="save"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label for="email">
                                            Mobile No.</label>
                                        <div class="input-group">
                                            <asp:TextBox ID="txt_mobileno" runat="server" CssClass="form-control" TabIndex="4"
                                                AutoCompleteType="Disabled" autocomplete="off" onkeypress="return isNumber(event);"
                                                MaxLength="10"></asp:TextBox>
                                            <div class="input-group-append">
                                                <asp:RequiredFieldValidator ID="rfv_mobile" runat="server" ControlToValidate="txt_mobileno"
                                                    InitialValue="" ForeColor="red" Display="Dynamic" Text="*" ValidationGroup="save"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label for="email">
                                            User Name</label>
                                        <div class="input-group">
                                            <asp:TextBox ID="txt_username" runat="server" CssClass="form-control" MaxLength="50"
                                                AutoCompleteType="Disabled" autocomplete="off" TabIndex="2"></asp:TextBox>
                                            <div class="input-group-append">
                                                <asp:RequiredFieldValidator ID="rfv_userID" runat="server" ControlToValidate="txt_username"
                                                    ForeColor="red" Display="Dynamic" Text="*" ValidationGroup="save" InitialValue=""></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label for="email">
                                            Password</label>
                                        <div class="input-group">
                                            <asp:TextBox ID="txt_Password" runat="server" CssClass="form-control" MaxLength="50"
                                                AutoCompleteType="Disabled" autocomplete="off" TabIndex="6" ForeColor="White"></asp:TextBox>
                                            <div class="input-group-append">
                                                <asp:RequiredFieldValidator ID="rfv_pass" runat="server" ControlToValidate="txt_Password"
                                                    InitialValue="" ForeColor="red" Display="Dynamic" Text="*" ValidationGroup="save"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label for="email">
                                            Block</label>
                                        <div class="input-group">
                                            <asp:CheckBox ID="chk_Block" runat="server" AutoPostBack="true" TabIndex="7" />
                                            <div class="input-group-append">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_Password"
                                                    InitialValue="" ForeColor="red" Display="Dynamic" Text="*" ValidationGroup="save"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-7">
                                    <div class="row">
                                        <div class="col-md-12">
                                            <div class="input-group">
                                                <asp:TextBox ID="txt_search_value" runat="server" CssClass="form-control" TabIndex="12"></asp:TextBox>
                                                <div class="input-group-append">
                                                    <asp:Button ID="btn_search" runat="server" CssClass="btn btn-primary btnCustom" TabIndex="8"
                                                        Text="Search" OnClick="btn_search_Click" />
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-12">
                                            <div class="grdRow">
                                                <asp:Panel ID="pnl_gv_details" runat="server">
                                                    <asp:GridView ID="gv_details" runat="server" CssClass="mGrid" AutoGenerateColumns="False"
                                                        TabIndex="14" DataKeyNames="ID,USER_NAME, NAME, PASSWORD, MOBILE_NO, ADDRESS,BLOCK,BLOCK_STATUS"
                                                        Width="100%" OnRowCommand="gv_details_RowCommand" OnRowUpdating="gv_details_RowUpdating">
                                                        <Columns>
                                                            <asp:ButtonField CommandName="Update" HeaderText="Update" Text="Update" ItemStyle-HorizontalAlign="Center"
                                                                ButtonType="Image" ImageUrl="~/images/edit.png" ItemStyle-Width="15px" />
                                                            <asp:BoundField DataField="NAME" HeaderText="Name" ItemStyle-Width="250px" />
                                                            <asp:BoundField DataField="ADDRESS" HeaderText="Address" ItemStyle-Width="150px" />
                                                            <asp:BoundField DataField="MOBILE_NO" HeaderText="Mobile No." ItemStyle-Width="150px" />
                                                            <asp:BoundField DataField="USER_NAME" HeaderText="User Name" ItemStyle-Width="200px" />
                                                            <asp:BoundField DataField="BLOCK_STATUS" HeaderText="Block" ItemStyle-Width="60px" />
                                                        </Columns>
                                                    </asp:GridView>
                                                </asp:Panel>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="card-footer">
                            <div class="btn-group">
                                <asp:Button ID="btn_save" runat="server" Text="Save" CssClass="btn btn-success btnCustom"
                                    TabIndex="8" OnClientClick="returnValidate();" ValidationGroup="save" OnClick="btn_save_Click" />
                                <asp:Button ID="btn_clear" runat="server" Text="Clear" CssClass="btn btn-warning btnCustom"
                                    TabIndex="9" OnClick="btn_clear_Click" />
                                <asp:Button ID="btn_delete" runat="server" Text="Delete" OnClick="btn_delete_Click" CssClass="btn btn-danger btnCustom"
                                    TabIndex="10" />
                                <asp:HiddenField ID="hf_per" runat="server" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
</asp:Content>

