<?xml version="1.0" encoding="utf-8" ?> 
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"> 
<xsl:template match="/">
    <html>
        <head>
            <style>
                td{border:1px solid black}
            </style>
        </head>
        <body>
            <h1>Receta</h1>
            <xsl:apply-templates select="receta"/>

        </body>
    </html>
</xsl:template>

<xsl:template match="receta">
    <xsl:apply-templates select="titulo"/>
    <xsl:apply-templates select="tiempo_elaboracion"/>
    <xsl:apply-templates select="cocina"/>
    <xsl:apply-templates select="especialidad"/>

    <h3>Ingredientes para <xsl:value-of select="ingredientes/@comensales"/> personas</h3>
        <table>
            <tr>
                <td>Nombre</td>
                <td>Cantidad</td>
                <td>Medida</td>
                <td>Categoria</td>
            </tr>
            <xsl:apply-templates select="ingredientes"/>
        </table>
    <h3>Proceso</h3>
        <ol>
        <xsl:apply-templates select="procedimiento"/>
        </ol>
</xsl:template>

<xsl:template match="titulo">
    <h2><xsl:value-of select="."/></h2>
</xsl:template>

<xsl:template match="tiempo_elaboracion">
    <p>Tiempo de Elaboracion: <xsl:value-of select="."/> minutos</p>
</xsl:template>

<xsl:template match="cocina">
 <p>Origen: <xsl:value-of select="."/> </p>
</xsl:template>

<xsl:template match="especialidad">
    <p>Especialidad: <xsl:value-of select="."/></p>
</xsl:template>

<xsl:template match="ingredientes">
        <xsl:apply-templates select="ingrediente"/>
</xsl:template>

<xsl:template match="ingrediente">
<tr>
    <xsl:apply-templates select="nombre"/>
    <xsl:apply-templates select="cantidad"/>
    <xsl:apply-templates select="medida"/>
    <td>
        <xsl:value-of select="@categoria"/>
    </td>
</tr>
</xsl:template>

<xsl:template match="nombre">
    <td><xsl:value-of select="."/></td>
</xsl:template>

<xsl:template match="cantidad">
    <td><xsl:value-of select="."/></td>
</xsl:template>

<xsl:template match="medida">
    <td><xsl:value-of select="."/></td>
</xsl:template>

<xsl:template match="procedimiento">
        <xsl:apply-templates select="paso"/>
</xsl:template>

<xsl:template match="paso">
    <li>
    <xsl:value-of select="."/>
    </li>
</xsl:template>
</xsl:stylesheet>