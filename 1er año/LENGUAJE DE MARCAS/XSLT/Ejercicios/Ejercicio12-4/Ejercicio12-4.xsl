<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
    <html>
        <head>
            <style>
                td{padding: 5px; border-bottom: 1px solid black}
            </style>
        </head>
        <body>
            <h1 style="color:blue">Hoteles</h1>
            <table>
                <tr style="font-weight:bold;">
                    <td>Nombre</td>
                    <td>Categoria</td>
                    <td>Piscina</td>
                    <td>Localizacion</td>
                    <td>Precio Hab. Doble (€)</td>
                </tr>

                  <xsl:apply-templates select="Hoteles/Hotel"/>
            </table>
        </body>
    </html>
</xsl:template>

<xsl:template match="Hotel">
    <tr>
        <xsl:apply-templates select="Nombre"/>
        <xsl:apply-templates select="Categoria"/>
        <xsl:apply-templates select="Piscina"/>
        <xsl:apply-templates select="Localizacion"/>
        <xsl:apply-templates select="Habitaciones/Dobles/Precio"/>
    </tr>
</xsl:template>

<xsl:template match="Nombre">
    <td>
        <xsl:value-of select="."/>
    </td>
</xsl:template>

<xsl:template match="Categoria">
    <td>
        <xsl:value-of select="."/> Estrellas
    </td>
</xsl:template>

<xsl:template match="Piscina">
    <td>
        <xsl:if test=".='false'">No</xsl:if>
        <xsl:if test=".= 'true'">Si</xsl:if>
    </td>
</xsl:template>

<xsl:template match="Localizacion">
    <td>
        <xsl:if test="Region">
            <xsl:value-of select="Region"/>,
        </xsl:if>
        <xsl:value-of select="Ciudad"/>
        (<xsl:value-of select="Pais"/>)
    </td>
</xsl:template>

<xsl:template match="Precio">
    <td>
        <xsl:value-of select="."/>€
    </td>
</xsl:template>

</xsl:stylesheet>