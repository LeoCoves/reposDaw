<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
 <xsl:template match="/">
    <xsl:apply-templates/>
 </xsl:template>

 <xsl:template match="receta">
    <html>
        <head></head>
        <body>
            <h1>Receta</h1>
            <h2><xsl:value-of select="titulo"/></h2>
        </body>
    </html>
 </xsl:template>