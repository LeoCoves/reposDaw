<?xml version="1.0" encoding="utf-8" ?> 
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"> 
<xsl:template match="/">
    <html>
        <head>
            <style>
                h1{color:blue}
                td{border:1px solid blue}
            </style>
        </head>
        <body>
            <h1>Clientes</h1>
            <table>
                <tr>
                    <td>Nombre</td>
                    <td>Direccion</td>
                    <td>Telefono</td>
                </tr>
            
            <xsl:apply-templates select="clientes"/>
            </table>
        </body>
    </html>
</xsl:template>

<xsl:template match="clientes">
    <tr>
        <xsl:apply-templates select="cliente"/>
    </tr>
</xsl:template>

<xsl:template match="cliente">
    <tr>
        <td>
            <xsl:value-of select="nombre/."/>
        </td>
        <td>
            <xsl:value-of select="direccion/."/>
        </td>
        <td>
            <xsl:value-of select="telefono/."/>
        </td>
    </tr>
</xsl:template>

</xsl:stylesheet>
