<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WeatherTest._Default" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Obregon Weather App</h1>
        <p class="lead">
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </p>
    </div>

    <div class="row">
        <table style="width: 100%">
            <tr>
                <td style="width: 40%" align="center">
                    <asp:Chart ID="chrtGraph" runat="server" EnableViewState="True" Width="1000px">
                        <series>
                            <asp:Series ChartType="Line" Name="sSerie">
                            </asp:Series>
                        </series>
                        <chartareas>
                            <asp:ChartArea Name="caChartArea">
                            </asp:ChartArea>
                        </chartareas>
                    </asp:Chart>
                </td>
                <td style="width: 60%">
                    <table style="width: 100%">
                        <tr>
                            <td style="width: 25%">
                                <strong>City
                            </strong>
                            </td>
                            <td style="width: 75%">

                            </td>
                        </tr>
                        <tr>
                            <td style="width: 25%">
                                <asp:DropDownList ID="ddlCity" runat="server" Width="100%" AutoPostBack="True" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged">
                                    <asp:ListItem Selected="True" Value="Cajeme">Obregon</asp:ListItem>
                                    <asp:ListItem Value="Navojoa">Navojoa</asp:ListItem>
                                    <asp:ListItem Value="Hermosillo">Hermosillo</asp:ListItem>
                                    <asp:ListItem Value="Nogales">Nogales</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td style="width: 75%">

                            </td>
                        </tr>
                        <tr>
                            <td style="width: 25%">
                                <strong>Scale
                            </strong>
                            </td>
                            <td style="width: 75%">

                            </td>
                        </tr>
                        <tr>
                            <td style="width: 25%">
                                <asp:DropDownList ID="ddlScale" runat="server" Width="100%" AutoPostBack="True" OnSelectedIndexChanged="ddlScale_SelectedIndexChanged">
                                    <asp:ListItem Selected="True" Value="C">Celsius</asp:ListItem>
                                    <asp:ListItem Value="F">Fahrenheit</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td style="width: 75%">

                            </td>
                        </tr>
                        <tr>
                            <td style="width: 25%">
                                <asp:Calendar ID="calDate" runat="server" Width="100%" OnSelectionChanged="calDate_SelectionChanged"></asp:Calendar>
                            </td>
                            <td style="width: 75%">

                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:GridView ID="gvwTemperatures" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <Columns>
                            <asp:BoundField DataField="datetime" HeaderText="Date" />
                            <asp:BoundField DataField="temp" HeaderText="Temperature" />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
