<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PizzaForm.aspx.cs" Inherits="PizzaInfo.PizzaForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 79%;
            height: 358px;
        }
        .auto-style4 {
            width: 201px;
        }
        .auto-style5 {
            width: 100%;
            height: 208px;
        }
        .auto-style6 {
            height: 55px;
            width: 70px;
        }
        .auto-style7 {
            height: 92px;
            width: 70px;
        }
        .auto-style8 {
            height: 65px;
            width: 480px;
        }
        .auto-style9 {
            height: 65px;
            width: 70px;
        }
        .auto-style10 {
            width: 480px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ABC Pizzas</h1>
            <table class="auto-style3">
                <tr>
                    <td class="auto-style4">
                        <table class="auto-style5">
                            <tr>
                                <td>Date</td>
                                <td>
                                    <asp:TextBox ID="tbdate" runat="server" TextMode="DateTime"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Phone</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="tbphone" runat="server" TextMode="Number"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2" colspan="2">
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="btnfind" runat="server" Text="Find Customer" Enabled="False" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2" colspan="2">
                                    <asp:TextBox ID="tbfirst" runat="server"></asp:TextBox>
                                    <asp:TextBox ID="tblast" runat="server"></asp:TextBox>
                                    <asp:TextBox ID="tbaddr" runat="server" Height="89px" TextMode="MultiLine" Width="211px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2" colspan="2">
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="btncomplete" runat="server" Text="Order Complete" Enabled="False" /><br />
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="btnbuild" runat="server" Text="Build Pizza" OnClick="btnbuild_Click" />
                                    <asp:Button ID="btnexit" runat="server" Text="Exit" OnClick="btnexit_Click" />
                                </td>
                            </tr>
                        </table>
                        <asp:Label ID="output" runat="server"></asp:Label>
                        <br />
                        <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
                            <AlternatingRowStyle BackColor="PaleGoldenrod" />
                            <FooterStyle BackColor="Tan" />
                            <HeaderStyle BackColor="Tan" Font-Bold="True" />
                            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                            <SortedAscendingCellStyle BackColor="#FAFAE7" />
                            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                            <SortedDescendingCellStyle BackColor="#E1DB9C" />
                            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
                        </asp:GridView>
                        <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" />
                            <EditRowStyle BackColor="#7C6F57" />
                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#E3EAEB" />
                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F8FAFA" />
                            <SortedAscendingHeaderStyle BackColor="#246B61" />
                            <SortedDescendingCellStyle BackColor="#D4DFE1" />
                            <SortedDescendingHeaderStyle BackColor="#15524A" />
                        </asp:GridView>
                    </td>
                    <td>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style6">
                                    <p>Size</p>
                                    <asp:RadioButtonList ID="rbsize" runat="server">
                                        <asp:ListItem>Small</asp:ListItem>
                                        <asp:ListItem>Medium</asp:ListItem>
                                        <asp:ListItem>Large</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                                <td rowspan="2" class="auto-style10">
                                    <p>Toppings</p>
                                    <asp:CheckBoxList ID="cbtoppings" runat="server">
                                        <asp:ListItem>Extra Cheese</asp:ListItem>
                                        <asp:ListItem>Pepperoni</asp:ListItem>
                                        <asp:ListItem>Mushrooms</asp:ListItem>
                                        <asp:ListItem>Salami</asp:ListItem>
                                        <asp:ListItem>Black Olives</asp:ListItem>
                                        <asp:ListItem>Sausage</asp:ListItem>
                                        <asp:ListItem>Onions</asp:ListItem>
                                        <asp:ListItem>Ground Beef</asp:ListItem>
                                        <asp:ListItem>Green Peppers</asp:ListItem>
                                        <asp:ListItem>Shrimp</asp:ListItem>
                                        <asp:ListItem>Tomatoes</asp:ListItem>
                                        <asp:ListItem>Anchovies</asp:ListItem>
                                    </asp:CheckBoxList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style7">
                                    <asp:CheckBox ID="cbdeliver" runat="server" Text="Deliver" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Special Info</td>
                                <td class="auto-style8">
                                    <asp:TextBox ID="tbspecial" runat="server" TextMode="MultiLine" Width="124px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
