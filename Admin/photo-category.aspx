<%@ Page Language="C#" AutoEventWireup="true" CodeFile="photo-category.aspx.cs" Inherits="Admin_photo_category" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <table width="100%" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td>
                Add/Delete Photo Category Name
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="panelforDirectory" runat="server">
                    <table id="tblMain" width="100%" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                            <td align="left" valign="top">
                                <table width="100%" border="0" cellspacing="0" cellpadding="6">
                                    <tr>
                                        <td colspan="2" align="right" style="color: Red">
                                            Note : * Indicates mandatory field.
                                        </td>
                                    </tr>
                                    <%--<tr>
                                        <td align="right" class="body_text">
                                            <asp:Label ID="lblId" runat="server" Visible="false"></asp:Label>
                                        </td>
                                        <td class="body_text">
                                        </td>
                                    </tr>--%>
                                    <tr>
                                        <td align="right" class="body_text">
                                            <span style="color: Red">*</span>&nbsp;Category Name:
                                        </td>
                                        <td class="body_text">
                                            <asp:TextBox ID="txtCategory" ToolTip="Create Category for which you would like to insert Photos later."
                                                runat="server" ValidationGroup="Submit" Width="200px"></asp:TextBox>
                                            <cc1:AutoCompleteExtender ID="acbCategory" runat="server" BehaviorID="AutoCompleteEx"
                                                TargetControlID="txtCategory" ServicePath="~/AutoComplete.asmx" ServiceMethod="GetCompletionList"
                                                MinimumPrefixLength="2" CompletionInterval="1000" EnableCaching="true" CompletionSetCount="20"
                                               
                                                DelimiterCharacters=";, :">
                                                <Animations>
                    <OnShow>
                        <Sequence>
                            <%-- Make the completion list transparent and then show it --%>
                            <OpacityAction Opacity="0" />
                            <HideAction Visible="true" />
                            
                            <%--Cache the original size of the completion list the first time
                                the animation is played and then set it to zero --%>
                            <ScriptAction Script="
                                // Cache the size and setup the initial size
                                var behavior = $find('AutoCompleteEx');
                                if (!behavior._height) {
                                    var target = behavior.get_completionList();
                                    behavior._height = target.offsetHeight - 2;
                                    target.style.height = '0px';
                                }" />
                            
                            <%-- Expand from 0px to the appropriate size while fading in --%>
                            <Parallel Duration=".4">
                                <FadeIn />
                                <Length PropertyKey="height" StartValue="0" EndValueScript="$find('AutoCompleteEx')._height" />
                            </Parallel>
                        </Sequence>
                    </OnShow>
                    <OnHide>
                        <%-- Collapse down to 0px and fade out --%>
                        <Parallel Duration=".4">
                            <FadeOut />
                            <Length PropertyKey="height" StartValueScript="$find('AutoCompleteEx')._height" EndValue="0" />
                        </Parallel>
                    </OnHide>
                </Animations>
                                            </cc1:AutoCompleteExtender>
                                            <asp:RequiredFieldValidator ID="validCategory" runat="server" ControlToValidate="txtCategory"
                                                Display="None" ErrorMessage="Category name is required." ValidationGroup="Submit"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td width="120px" align="right">
                                        </td>
                                        <td class="body_text">
                                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"
                                                ShowSummary="False" ValidationGroup="Submit" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                        </td>
                                        <td class="body_text">
                                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
                                            &nbsp;
                                            <asp:Button ID="btnReset" runat="server" Text="Reset" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" height="15">
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td class="table-title1">
                                &raquo; Category List :
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="body_text">
                                <asp:Label ID="lblId" runat="server" Visible="false"></asp:Label>
                            </td>
                            <td class="body_text">
                            </td>
                        </tr>
                        <tr>
                            <td align="left" valign="top">
                                <asp:GridView ID="gvCategory" runat="server" AutoGenerateColumns="False" Width="40%"
                                    EmptyDataText="No Record Found." DataKeyNames="PhotoCatId" AllowPaging="True">
                                    <RowStyle VerticalAlign="Middle" Height="20px"></RowStyle>
                                    <Columns>
                                        <asp:BoundField DataField="PhotoCatId" HeaderText="PhotoCatId" InsertVisible="False"
                                            ReadOnly="True" SortExpression="PhotoCatId" Visible="False"></asp:BoundField>
                                        <asp:BoundField DataField="Title" HeaderText="Album Name" SortExpression="Title">
                                        </asp:BoundField>
                                        <asp:TemplateField HeaderText="Edit">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lnkBtnEdit" Text="Edit" runat="server" CommandName="change" CommandArgument='<%# Eval("PhotoCatId") %>'>
                                                </asp:LinkButton>
                                            </ItemTemplate>
                                            <ItemStyle Width="15%"></ItemStyle>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Delete">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lnkBtndelete" Text="Delete" runat="server" CommandName="remove"
                                                    CommandArgument='<%# Eval("PhotoCatId") %>' OnClientClick="return confirm('Are you sure to delete this record?')">
                                                </asp:LinkButton>
                                            </ItemTemplate>
                                            <ItemStyle Width="15%" />
                                        </asp:TemplateField>
                                    </Columns>
                                    <AlternatingRowStyle CssClass="adminGVAlternatingRow" />
                                    <PagerStyle CssClass="adminGVPageStyle" />
                                    <HeaderStyle CssClass="adminGVHeader" />
                                    <EmptyDataRowStyle CssClass="adminGVHeader" />
                                </asp:GridView>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
    </table>
    <pre>
    [System.Web.Services.WebMethod] [System.Web.Script.Services.ScriptMethod] public
    string[] GetCompletionList(string prefixText, int count) { ... }
    </form>
</body>
</html>
