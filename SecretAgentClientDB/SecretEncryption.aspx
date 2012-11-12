<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SecretEncryption.aspx.cs" Inherits="SecretAgentClientDB.SecretEncryption" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <div class="post">
        <h2 class="title">
            <a href="#">The Secret Encryption Database </a>
        </h2>
        <div style="clear: both;">
        <hr/>
            <asp:Label class="Label" ID="LabelMessage" runat="server" Text="Message:" Font-Bold="True" 
                Font-Size="Small"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox class="Box" ID="TextBoxMessage" runat="server" Width="860px"></asp:TextBox>
        </div>
        <div>
            <hr />
            <asp:Label class="Label" ID="LabelKey" runat="server" Text="Encryption Key:" Font-Bold="True" 
                Font-Size="Small"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox class="Box" ID="TextBoxKey" runat="server" Width="20px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button class="Button" ID="ButtonEncrypt" runat="server" Text="Encrypt" 
                onclick="ButtonEncrypt_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button class="Button" ID="ButtonDecrypt" runat="server" Text="Decrypt" 
                onclick="ButtonDecrypt_Click" />
            <hr />
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolder2">
    <div id="menu">
        <ul>
            <li><a href="Index.aspx">Main page</a></li>
            <li><a href="SecretAgent.aspx">Secret Agents</a></li>
            <li class="current_page_item"><a href="SecretEncryption.aspx">Secret Encryption</a></li>
        </ul>
    </div>
</asp:Content>

