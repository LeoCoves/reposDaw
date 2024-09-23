<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
    <html> 
        <head>
            <style>
                h1{color:red}
                h2{color:grey}
                table{width: 70%}
                td{border-bottom:1px solid grey}
                .tr1{text-align:center; font-weight:bold}

            </style>
        </head>
        <body>
            <h1>Libreria</h1>
            <table>
                <tr class="tr1">
                    <td>Titulo</td>
                    <td>Autor</td>
                    <td>Editorial</td>
                    <td>ISBN</td>
                    <td>Version Kindle</td>
                    <td>Precio</td>
                </tr>
                <xsl:apply-templates select="libreria/libro">
                    <xsl:sort select="precio" order="ascending" />
                </xsl:apply-templates>
            </table>
            <h2>Instrucciones de compra</h2>
            <xsl:apply-templates select="libreria/instruccionesCompra"/>
        </body>
    </html>
</xsl:template>


<xsl:template match="libro">
        <tr>
        <xsl:apply-templates select="titulo"/>
        <xsl:apply-templates select="autor"/>
        <xsl:apply-templates select="editorial"/>
        <xsl:apply-templates select="titulo/@ISBN"/>
        <xsl:apply-templates select="disponibleKindle"/>
        <xsl:apply-templates select="precio"/>
        </tr>
</xsl:template>

<xsl:template match="titulo">
    <td>
        <xsl:value-of select="."/>
    </td>
</xsl:template>

<xsl:template match="autor">
    <td>
        <xsl:value-of select="nombre "/> 
        <xsl:value-of select="apellido"/>
    </td>
</xsl:template>

<xsl:template match="editorial">
    <td>
        <xsl:value-of select="."/>
    </td>
</xsl:template>

<xsl:template match="@ISBN">
    <td style="text-align:center">
        <xsl:value-of select="."/>
    </td>
</xsl:template>

<xsl:template match="disponibleKindle">
    <td style="text-align:center">
        <xsl:if test=". = 'false'" >No</xsl:if>
        <xsl:if test=". = 'true'">Si</xsl:if>
    </td>
</xsl:template>

<xsl:template match="precio">
    <xsl:choose>
        <xsl:when test=". &lt;= 20">
            <td style="color:green">
                <xsl:value-of select="." />
                <xsl:value-of select="@moneda"/>
            </td>
        </xsl:when>
        <xsl:when test=". &gt; 20">
            <td style="color:red">
                <xsl:value-of select="." />
                <xsl:value-of select="@moneda"/>
            </td>
        </xsl:when>
    </xsl:choose>
</xsl:template>

<xsl:template match="instruccionesCompra">
    <ol>
        <xsl:apply-templates select="paso"/>
    </ol>
</xsl:template>

<xsl:template match="paso">
    <li>
        <xsl:value-of select="."/>
    </li>
</xsl:template>

</xsl:stylesheet>


  