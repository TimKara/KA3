<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SecretAgent.aspx.cs" Inherits="SecretAgentClientDB.SecretAgent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <div class="post">
        <h2 class="title">
            <a href="#">The Secret Agent Database </a>
        </h2>
        <div style="clear: both;">
        <hr/>
            <asp:Label class="Label" ID="LabelCodeName" runat="server" Font-Bold="True" Font-Size="Small" 
                Text="Enter Agent Code Name:"></asp:Label>
            <br />
            <asp:TextBox class="Box" ID="TextBoxCodeName" runat="server" Width="253px" Font-Bold="True"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button class="Button" ID="ButtonFindAgent" runat="server" 
                Text="get top secret information" Font-Bold="True" 
                onclick="ButtonFindAgent_Click" />
                <hr/>
        </div>
        <div>
            <asp:Label class="Label" ID="LabelRealName_Licenses" runat="server" Font-Bold="True" 
                Font-Size="Small" Text="The CLASSIFIED information of the agent:"></asp:Label>
            <br />
            <asp:ListBox class="Box" ID="ListBoxRealName_Licenses" runat="server" Height="188px" 
                Width="950px" Font-Bold="True"></asp:ListBox>
                <hr/>
            
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolder2">
    <div id="menu">
        <ul>
            <li><a href="Index.aspx">Main page</a></li>
            <li class="current_page_item"><a href="SecretAgent.aspx">Secret Agents</a></li>
            <li><a href="SecretEncryption.aspx">Secret Encryption</a></li>
        </ul>
    </div>
</asp:Content>

