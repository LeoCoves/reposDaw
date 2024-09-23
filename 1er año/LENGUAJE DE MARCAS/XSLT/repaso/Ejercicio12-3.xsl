<?xml version="1.0" encoding="utf-8" ?> 
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"> 
<xsl:template match="/">
    <html>
        <head>
            <style>
                .negrita {font-weight:bold}
                h1{text-align:center}
            </style>
        </head>
        <body>
            <xsl:apply-templates match="Ventas"/>
        </body>
    </html>
</xsl:template>

<xsl:template match="Ventas">   
    <h1>Ventas de discos del dia: <xsl:value-of select="fecha/."/></h1>
    <xsl:apply-templates select="disco"/>
</xsl:template>

<xsl:template match="disco">
    <xsl:apply-templates select="titulo"/>
    <xsl:apply-templates select="interprete"/>
    <xsl:apply-templates select="direccion"/>
    <br/>
</xsl:template>

<xsl:template match="titulo">
    <p class="negrita"><xsl:value-of select="."/></p>
</xsl:template>
<xsl:template match="interprete">
    <p><xsl:value-of select="."/></p>
</xsl:template>
<xsl:template match="direccion">
    <p><xsl:value-of select="."/></p>
</xsl:template>
</xsl:stylesheet>