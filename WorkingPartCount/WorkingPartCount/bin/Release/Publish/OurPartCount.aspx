<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OurPartCount.aspx.cs" Inherits="WorkingPartCount.WebForm1" runat="server"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
     
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
        </div>
        <asp:Label ID="lblParam1Name" runat="server" Text="PartCount : "></asp:Label>
        
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblParam1Output" runat="server" Text="an empty label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblParam2Name" runat="server" Text="Mansione : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Label ID="lblParam2Output" runat="server" Text="another empty label"></asp:Label>
        <br />
        <br />
        
        <asp:Label ID="lblMoreInfos" runat="server" Text=" "></asp:Label>
        
    </form>
</body>
</html>
