<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Predator_Victim.WebForm1" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Chart ID="Chart1" runat="server" Height="603px" OnLoad="Chart1_Load" Width="1142px">
            <series>
                <asp:Series ChartType="Spline" Name="Series1">
                </asp:Series>
                <asp:Series ChartArea="ChartArea1" ChartType="Spline" Name="Series2">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
        <br />
        <br />
        Рождаемость жертвы:&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Смертность жертвы:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="140px">0,1</asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="135px">0,001</asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Смертность хищника:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Коэф. хищничества:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox3" runat="server" Width="139px">0,05</asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Width="136px">0,00005</asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Поколение:"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Width="136px">5</asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Нач. кол-во жертв:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" Text="Нач. кол-во хищников:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox6" runat="server" Width="136px">1000</asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox7" runat="server" Width="143px">100</asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Вычислить" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Сбросить" />
    
    </div>
    </form>
</body>
</html>
