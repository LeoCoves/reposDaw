<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
 <xsl:template match="/">
    <xsl:apply-templates/>
 </xsl:template>

 <xsl:template match="Ventas">
    <html>
        <head>
            <title> Ventas del día</title>
        </head>
        <body>
            <xsl:apply-templates/>
        </body>
    </html>
 </xsl:template>

 <xsl:template match="fecha">
    <h1 style="color:blue; text-align:center; font-family:Tahoma,Arial">
    Ventas de discos del día:
    <xsl:value-of select="."/>
    </h1>
    <br />
 </xsl:template>


 <xsl:template match="libro">
</xsl:template>

 <xsl:template match="disco">
    <xsl:apply-templates/>
    <br />
    <br />
 </xsl:template>

 <xsl:template match="titulo">
    <strong>
        <xsl:value-of select="."/>
    </strong>
 <br />
 </xsl:template>

 <xsl:template match="direccion">
    <br />
        <a>
        <xsl:attribute name="href">
            <xsl:value-of select="."/>
        </xsl:attribute>
        Más información
        </a>
    <br />
 </xsl:template>
</xsl:stylesheet>
