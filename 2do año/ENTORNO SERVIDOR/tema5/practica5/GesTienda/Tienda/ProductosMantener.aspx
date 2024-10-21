<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdm.Master" AutoEventWireup="true" CodeBehind="ProductosMantener.aspx.cs" Inherits="Tienda.ProductosMantener" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="InfoContenido" runat="server">
    <div>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [IdProducto], [DesPro], [PrePro] FROM [PRODUCTO]"></asp:SqlDataSource>
        
       <asp:GridView ID="grdProductos" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="IdProducto" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="grdProductos_SelectedIndexChanged">
           <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
           <Columns>
               <asp:CommandField ShowSelectButton="True" />
               <asp:BoundField DataField="IdProducto" HeaderText="IdProducto" ReadOnly="True" SortExpression="IdProducto" />
               <asp:BoundField DataField="DesPro" HeaderText="DesPro" SortExpression="DesPro" />
               <asp:BoundField DataField="PrePro" HeaderText="PrePro" SortExpression="PrePro" />
           </Columns>
           <EditRowStyle BackColor="#999999" />
           <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
           <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
           <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
           <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
           <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
           <SortedAscendingCellStyle BackColor="#E9E7E2" />
           <SortedAscendingHeaderStyle BackColor="#506C8C" />
           <SortedDescendingCellStyle BackColor="#FFFDF8" />
           <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
       </asp:GridView>
    </div>

    <div style="display: table">

        <div style="display: table-row">
            <div style="display: table-cell">
                <asp:Label ID="lblIdProducto" runat="server" Text="Id.Producto"></asp:Label>
            </div>
            <div style="display: table-cell">
                <asp:TextBox ID="txtIdProducto" runat="server"></asp:TextBox>
            </div>
        </div>

        <div style="display: table-row">
            <div style="display: table-cell">
                <asp:Label ID="lblDesPro" runat="server" Text="Descricion"></asp:Label>
            </div>
            <div style="display: table-cell">
                <asp:TextBox ID="txtDesPro" runat="server"></asp:TextBox>
            </div>
        </div>

        <div style="display: table-row">
            <div style="display: table-cell">
                <asp:Label ID="lblPrePro" runat="server" Text="Pre"></asp:Label>
            </div>
            <div style="display: table-cell">
                <asp:TextBox ID="txtPrePro" runat="server" Text="0"></asp:TextBox>
            </div>
        </div>

        <div style="display: table-row">
            <div style="display: table-cell">
                <asp:Label ID="lblIdUnidad" runat="server" Text="Unidad"></asp:Label>
            </div>
            <div style="display: table-cell">
                <asp:DropDownList ID="ddlIdUnidad" runat="server" DataSourceID="SqlDataSource2" DataTextField="IdUnidad" DataValueField="IdUnidad">
                </asp:DropDownList>
            </div>
        </div>

        <div style="display: table-row">
            <div style="display: table-cell">
                <asp:Label ID="lblIdTipo" runat="server" Text="Tipo Producto"></asp:Label>
            </div>
            <div style="display: table-cell">
                <asp:DropDownList ID="ddlIdTipo" runat="server" DataSourceID="SqlDataSource3" DataTextField="DesTip" DataValueField="IdTipo">
                </asp:DropDownList>
            </div>
        </div>

        <div style="display: table-row">
            <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" Visible="True" />
            <asp:Button ID="btnEditar" runat="server" Text="Editar" Visible="False" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" Visible="False" />
            <asp:Button ID="btnInsertar" runat="server" Text="Insertar" Visible="False" />
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" Visible="False" />
            <asp:Button ID="btnBorrar" runat="server" Text="Borrar" Visible="False" />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Visible="False" />
        </div>
    </div>

    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [UNIDAD]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [TIPO]"></asp:SqlDataSource>
    <br />

    <div>
     <asp:Label ID="lblResultado" runat="server"></asp:Label>
       <br />
    <asp:Label ID="lblMensajes" ForeColor="red" runat="server"></asp:Label>
       <br />
</div>
</asp:Content>
