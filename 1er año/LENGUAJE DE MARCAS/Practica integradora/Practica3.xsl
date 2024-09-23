<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
 <xsl:template match="/">
    <xsl:apply-templates/>
 </xsl:template>

<xsl:template match="CONCESIONARIO">
    <html>
        <head>
            <style>
                body{font-family: Arial; background-color: #efebdd}
                h1{margin-top:30px; margin-bottom:0; text-align:center; background: #373024; color: white}
                banner{margin-top: 0; padding-top: -10px}
                .div1 td{border: 1px solid #ddd}
                .div3{text-align:center; align-items:center}
                .div2 {
                    font-family: Arial, Helvetica, sans-serif;
                    border-collapse: collapse;
                    width: 100%;
                    text-align:center;
                    }
                
                .div2 table{margin:auto}

                .div2 td, .div2 th {
                    border: 1px solid #ddd;
                    padding: 8px;
                    }

                .div2 tr:nth-child(even){background-color: #f2f2f2;}

                .div2 tr:hover {background-color: #ddd;}

                .div2 th {
                    padding-top: 12px;
                    padding-bottom: 12px;
                    text-align: left;
                    background-color: #04AA6D;
                    color: white;
                    }

                .div3 tr{background: }
                .div3 td{border:1px solid #ddd}
            </style>
        </head>
        <body>
            <h1>Concesionario</h1>
            <img src="coches.jpg" width="100%" class="banner"/>
            <div class="div1">
                <h2>Informacion</h2>
                <xsl:apply-templates select="informacion_concesionario"/>
            </div>

            <hr style="width: 80%; align:center"/>

            <div class="div2">
                <h2>Vehiculos en Venta</h2>
                    <xsl:apply-templates select="VEHICULOS"/>
            </div>

            <hr style="width: 80%; align:center"/>

            <div class="div3">
                <h2>Financiamiento</h2>
                <xsl:apply-templates select="financiamiento"/>
            </div>
        </body>
    </html>
</xsl:template>


<!-- Informacion del concesionario -->
<xsl:template match="informacion_concesionario">
    <h3>
        <xsl:apply-templates select="nombre"/>
    </h3>
    <table>
        <tr style="font-weight:bold; background:#a08f79">
            <td>Direccion</td>
            <td>Telefono</td>
            <td>Email</td>
            <td>Sitio Web</td>
        </tr>
        <tr>
            <xsl:apply-templates select="direccion"/>
            <xsl:apply-templates select="telefono"/>
            <xsl:apply-templates select="email"/>
            <xsl:apply-templates select="sitio_web"/>
        </tr>
    </table>
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

<xsl:template match="email">
    <td>
        <xsl:value-of select="."/>
    </td>
</xsl:template>

<xsl:template match="sitio_web">
    <td>
        <xsl:value-of select="."/>
    </td>
</xsl:template>

<!-- Venta de todos los vehiculos -->
<xsl:template match="VEHICULOS">
        <table>
            <tr style="font-weight:bold; background: #a08f79">
                <td>Nombre</td>
                <td>Tipo</td>
                <td>Estado</td>
                <td>Año</td>
                <td>Kilometraje</td>
                <td>Precio</td>
                <td>Transmision</td>
                <td>Combustible</td>
                <td>Carroceria</td>
                <td>Detalles</td>
            </tr>

            <xsl:apply-templates select="vehiculo"/>

        </table>
</xsl:template>

<xsl:template match="vehiculo">
        <tr>
            <xsl:apply-templates select="nombre"/>
            <xsl:apply-templates select ="@tipo"/>
            <xsl:apply-templates select ="@estado"/>
            <xsl:apply-templates select="año"/>
            <xsl:apply-templates select="kilometraje"/>
            <xsl:apply-templates select="precio"/>
            <xsl:apply-templates select="transmision"/>
            <xsl:apply-templates select="combustible"/>
            <xsl:apply-templates select="carroceria"/>
            <xsl:apply-templates select="detalles"/>
        </tr>
</xsl:template>

<xsl:template match="nombre">
    <td>
        <xsl:value-of select="."/>
        <xsl:value-of select="./../color"/>
    </td>
</xsl:template>

<xsl:template match="@tipo">
    <td>
        <xsl:value-of select="."/>
    </td>
</xsl:template>

<xsl:template match="@estado">
    <td>
        <xsl:value-of select="."/>
    </td>
</xsl:template>


<xsl:template match="año">
    <td>
        <xsl:value-of select="."/>
    </td>
</xsl:template>

<xsl:template match="kilometraje">
    <td>
        <xsl:value-of select="."/>
        <xsl:value-of select="@unidades"/>
    </td>
</xsl:template>

<xsl:template match="precio">
    <td>
        <xsl:value-of select="."/>
        <xsl:value-of select="@moneda"/>
    </td>
</xsl:template>

<xsl:template match="color">

    <xsl:value-of select="."/>

</xsl:template>

<xsl:template match="transmision">
    <td>
        <xsl:value-of select="."/>
    </td>
</xsl:template>

<xsl:template match="combustible">
    <td>
        <xsl:value-of select="."/>
    </td>
</xsl:template>

<xsl:template match="carroceria">
    <td>
        <xsl:value-of select="."/>
    </td>
</xsl:template>

<xsl:template match="detalles">
    <td>
            <p>Motor: <xsl:apply-templates select="motor"/></p>
            <p>Cilindrada: <xsl:apply-templates select="cilindrada"/></p>

        <xsl:if test="../@tipo = 'Turismo'">
            <p>Traccion: <xsl:apply-templates select="traccion"/></p>
        </xsl:if>

            <p>Num Puertas: <xsl:apply-templates select="num_puertas"/></p>
            <p>Num Asientos: <xsl:apply-templates select="num_asientos"/></p>

        <xsl:if test="../@tipo = 'Turismo'">
            <p>Aire Acondicionado: <xsl:apply-templates select="aire_acondicionado"/></p>
            <p>bluetooth: <xsl:apply-templates select="bluetooth"/></p>
            <p>GPS: <xsl:apply-templates select="gps"/></p>
        </xsl:if>

        <xsl:if test="../@tipo = 'Motocicleta'">
            <p>Abs: <xsl:apply-templates select="abs"/></p>
            <p>Control de Traccion: <xsl:apply-templates select="control_traccion"/></p>
            <p>Suspension Ajustable: <xsl:apply-templates select="suspension_ajustable"/></p>
        </xsl:if>
    </td>
</xsl:template>

<!-- Para turismos -->

<xsl:template match="traccion">
    <xsl:value-of select="."/>
</xsl:template>

<xsl:template match="aire_acondicionado">

    <xsl:if test=".='true'">Si</xsl:if>
    <xsl:if test=".= 'false'">No</xsl:if>

</xsl:template>

<xsl:template match="bluetooth">

    <xsl:if test=".='true'">Si</xsl:if>
    <xsl:if test=".= 'false'">No</xsl:if>

</xsl:template>

<xsl:template match="gps">

    <xsl:if test=".='true'">Si</xsl:if>
    <xsl:if test=".= 'false'">No</xsl:if>

</xsl:template>

<!-- Para motocicletas -->

<xsl:template match="abs">

    <xsl:if test=".='true'">Si</xsl:if>
    <xsl:if test=".= 'false'">No</xsl:if>

</xsl:template>

<xsl:template match="control_traccion">

    <xsl:if test=".='true'">Si</xsl:if>
    <xsl:if test=".= 'false'">No</xsl:if>

</xsl:template>

<xsl:template match="suspension_ajustable">

    <xsl:if test=".='true'">Si</xsl:if>
    <xsl:if test=".= 'false'">No</xsl:if>

</xsl:template>

<!-- Tipos de financiamiento -->

<xsl:template match="financiamiento">
    <xsl:apply-templates select="opcion"/>
</xsl:template>

<xsl:template match="opcion">
    <h3>
        Opcion <xsl:value-of select="@id"/>
    </h3>
    <xsl:apply-templates select="tasa_interes"/>
    <xsl:apply-templates select="entrada"/>
    <xsl:apply-templates select="plazo"/>
    <xsl:apply-templates select="requesitos"/>
    <hr style="width: 50%; align:center"/>
</xsl:template>

<xsl:template match="tasa_interes">
    <p>Tasa de interes</p>
    <xsl:value-of select="."/>
</xsl:template>

<xsl:template match="entrada">
    <p>Entrada</p>
    <xsl:value-of select="."/>
</xsl:template>

<xsl:template match="plazo">
    <p>Plazo</p>
    <xsl:value-of select="."/>
    <xsl:value-of select="@unidad"/>
</xsl:template>

<xsl:template match="requesitos">
    <table style="align:center; margin:auto; margin-top: 20px">
        <tr>
            <td colspan="3" style="text-align:center; font-weight:bold; background: #a08f79">Documentos a Entregar</td>
        </tr>

        <xsl:apply-templates select="documento"/>
    </table>
</xsl:template>

<xsl:template match="documento">
<td>
    <xsl:value-of select="."/>
</td>
</xsl:template>
</xsl:stylesheet>

