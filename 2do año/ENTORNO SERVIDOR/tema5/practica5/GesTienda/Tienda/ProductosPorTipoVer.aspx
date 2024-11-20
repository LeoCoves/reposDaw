﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ProductosPorTipoVer.aspx.cs" Inherits="Tienda.ProductosPorTipoVer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="InfoContenido" runat="server">
     
    <div style="text-align: center">
        
        <div class="contenidotitulo">
            Productos por tipo
        </div>

         <div style="font-weight:bold; font-size: large">
            Tipos de productos
         </div>
              <br />
         <div>
              <asp:Label ID="lblResultado" runat="server"></asp:Label>
         </div>

        <div>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [TIPO]"></asp:SqlDataSource>
        <asp:GridView ID="grdTipos" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="IdTipo" DataSourceID="SqlDataSource1" HorizontalAlign="Center" PageSize="5" Width="50%" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" ButtonType="Button" />
                <asp:BoundField DataField="IdTipo" HeaderText="Código" ReadOnly="True" SortExpression="IdTipo" />
                <asp:BoundField DataField="DesTip" HeaderText="Descripción" SortExpression="DesTip" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerSettings FirstPageText="Primero" LastPageText="Ultimo" NextPageText="Siguiente" PreviousPageText="Anterior" Mode="NextPreviousFirstLast" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>

        </div>
             <br />

        <div style="font-weight:bold; font-size: large">
            Productos
        </div>


        <div>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [IdProducto], [DesPro], [PrePro], [IdUnidad], [DesTip] FROM [ProductosDet] WHERE ([IdTipo] = @IdTipo)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="grdTipos" Name="IdTipo" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>

            <asp:GridView ID="grdProductos" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="IdProducto" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None" AllowPaging="True" Height="180px" HorizontalAlign="Center" Width="80%">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="IdProducto" HeaderText="Id Producto" ReadOnly="True" SortExpression="IdProducto" />
                <asp:BoundField DataField="DesPro" HeaderText="Descripción" SortExpression="DesPro" >
                <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="PrePro" HeaderText="Precio" SortExpression="PrePro" DataFormatString="{0:C}" >
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="IdUnidad" HeaderText="Unidad" SortExpression="IdUnidad" />
                <asp:BoundField DataField="DesTip" HeaderText="Tipo" SortExpression="DesTip" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerSettings FirstPageText="Primero" LastPageText="Ultimo" Mode="NextPreviousFirstLast" NextPageText="Siguiente" PreviousPageText="Anterior" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </div>
    </div>
         
         <br />
</asp:Content>
