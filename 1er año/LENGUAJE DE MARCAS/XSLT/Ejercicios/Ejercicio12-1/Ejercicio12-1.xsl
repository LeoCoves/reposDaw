<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
<html>
    <head>
        <style>
            td{border: 2px solid blue}
        </style>
    </head>
    <body>
        <h1>Clientes</h1>
        <table>
            <tr style="font-weight:bold">
                <td>Nombre</td>
                <td>Direccion</td>
                <td>Telefono</td>
            </tr>

            <xsl:apply-templates select="clientes/cliente"/>
        </table>
    </body>
</html>
</xsl:template>

<xsl:template match="cliente">
    <tr>
        <xsl:apply-templates select="nombre"/>
        <xsl:apply-templates select="direccion"/>
        <xsl:apply-templates select="telefono"/>
    </tr>
</xsl:template>

<xsl:template match="nombre">
    <td>
        <xsl:value-of select="."/>
    </td>
</xsl:template>

<xsl:template match="direccion">
    <td>
        <xsl:value-of select="."/>
    </td>
</xsl:template>

<xsl:template match="telefono">
    <td>
        <xsl:value-of select="."/>
    </td>
</xsl:template>
</xsl:stylesheet>