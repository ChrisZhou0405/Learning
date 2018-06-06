<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="新增" OnClick="Button1_Click" /><br /><br />
        <asp:Button ID="Button2" runat="server" Text="先查询后删除" OnClick="BtnDel_Click" /><br /><br />
        <asp:Button ID="Button3" runat="server" Text="Model+Attach+Remove" OnClick="BtnDel2_Click" /><br /><br />
        <asp:Button ID="Button4" runat="server" Text="Model+Entry+手动修改代理类状态为Deleted" OnClick="BtnDel3_Click" /><br /><br />
        <asp:Button ID="Button5" runat="server" Text="先查询 后修改" OnClick="Btnedit1_Click" /><br /><br />
        <asp:Button ID="Button6" runat="server" Text="Model+手动要修改的属性值" OnClick="Btnedit2_Click" /><br />


        <div>
        </div>
    </form>
</body>
</html>
