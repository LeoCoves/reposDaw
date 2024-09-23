<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
  <html>
    <head>
      <style>
        body 
        {
          font-family: Arial, sans-serif;
          margin: 20px;
        }

        <!-- TITULO -->
        .title 
        {
          text-align: center;
          padding: 10px;
          font-size: 24px;
          font-weight: bold;
          margin-bottom: -30px;
        }


        .library-title 
        {
          background-color: orange;
          border-width: 3px;
          font-size: 24px;
          font-weight: bold;
          margin-bottom: 20px;
          margin-top: 20px;
          text-align: center;
        }

        .url
        {
          font-size: 15px;
          font-weight: normal;
        }

        table 
        {
          width: 100%;
          border-collapse: collapse;
          margin-top: 20px;
          table-layout: fixed;
        }

        td 
        {
          border: 2px solid green;
          padding: 8px;
          text-align: left;
        }

      </style>
    </head>

    <body>
      <div class="title">
        <h1><xsl:value-of select="novedadesXML/titulo"/></h1>
      </div>
      
      <xsl:apply-templates select="novedadesXML/libreria"/>
    </body>
  </html>
</xsl:template>

  <!-- Template for libreria -->
  <xsl:template match="libreria">
    <div>
      <div class="library-title">
          <xsl:value-of select="nombre"/>
          <p></p>
        <p class="url">
          <xsl:value-of select="url"/>
        </p>
      </div>

      <table>
          <tr>
            <td>Título</td>
            <td>Autor</td>
            <td>Editorial</td>
            <td>Año</td>
            <td>Nivel</td>
            <td>ISBN</td>
            <td>Precio</td>
          </tr>

          <xsl:apply-templates select="libros/libro">
            <xsl:sort select="titulo" order="ascending" />
          </xsl:apply-templates>

      </table>
    </div>
  </xsl:template>

  <!-- Template for libro -->
  <xsl:template match="libro">
    <tr>
      <td><xsl:value-of select="titulo"/></td>
      <td><xsl:value-of select="autor"/></td>
      <td><xsl:value-of select="editorial"/></td>
      <td><xsl:value-of select="año"/></td>
      <td><xsl:value-of select="nivel"/></td>
      <td><xsl:value-of select="isbn"/></td>
      <td>
        <xsl:value-of select = "precio"/>
        <xsl:if test = "precio/@moneda = 'Euro'">€</xsl:if>
        <xsl:if test = "precio/@moneda = 'Dolar'">$</xsl:if>
      </td>
    </tr>
  </xsl:template>
  
</xsl:stylesheet>