﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tienda
{
    public partial class ProductosMantener : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FnDeshabilitarControles()
        {
            txtIdProducto.Enabled = false;
            txtDesPro.Enabled = false;
            txtPrePro.Enabled = false;
            ddlIdUnidad.Enabled = false;
            ddlIdTipo.Enabled = false;
        }

        protected void FnHabilitarControles()
        {
            txtIdProducto.Enabled = true;
            txtDesPro.Enabled = true;
            txtPrePro.Enabled = true;
            ddlIdUnidad.Enabled = true;
            ddlIdTipo.Enabled = true;
        }

        protected string FnComaPorPunto(decimal Numero)
        {
            string StrNumero = Convert.ToString(Numero);
            string stNumeroConPunto = String.Format("{0}", StrNumero.Replace(',', '.'));
            return (stNumeroConPunto);
        }

        protected void grdProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMensajes.Text = "";
            FnDeshabilitarControles();
            string StrIdProducto = grdProductos.SelectedRow.Cells[1].Text;

            string StrCadenaConexion = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            
            string StrComandoSql = "SELECT IdProducto,DesPro,PrePro,IdUnidad,PRODUCTO.IdTipo,DesTip " +
            " FROM PRODUCTO INNER JOIN TIPO ON PRODUCTO.IdTipo = TIPO.IdTipo " +
            "WHERE PRODUCTO.IdProducto = '" + StrIdProducto + "';";

            using (SqlConnection conexion = new SqlConnection(StrCadenaConexion))
            {
                try
                {
                    conexion.Open();
                    SqlCommand comando = conexion.CreateCommand();
                    comando.CommandText = StrComandoSql;
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        txtIdProducto.Text = reader.GetString(0);
                        txtDesPro.Text = reader.GetString(1);
                        txtPrePro.Text = string.Format("{0:C}", reader.GetDecimal(2));
                        ddlIdUnidad.SelectedItem.Selected = false;
                        ddlIdUnidad.SelectedItem.Text = reader.GetString(3);
                        ddlIdTipo.SelectedItem.Selected = false;
                        ddlIdTipo.SelectedItem.Text = reader.GetString(5);
                    }
                    else
                    {
                        lblMensajes.Text = "No existen registros resultantes de la consulta";
                    }
                    reader.Close();
                    btnNuevo.Visible = true;
                    btnEditar.Visible = true;
                    btnEliminar.Visible = true;
                    btnInsertar.Visible = false;
                    btnModificar.Visible = false;
                    btnBorrar.Visible = false;
                    btnCancelar.Visible = false;
                }
                catch (SqlException ex)
                {
                    string StrError = "<p>Se han producido errores en el acceso a la base de datos</p>";
                    StrError += "<div>Codigo: " + ex.Number + "</div>";
                    StrError += "<div>Descripción: " + ex.Message + "</div>";
                    lblMensajes.Text = StrError;
                    return;
                }
            }

        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            lblMensajes.Text = "";
            btnNuevo.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            btnInsertar.Visible = true;
            btnModificar.Visible = false;
            btnCancelar.Visible = true;
            txtIdProducto.Text = "";
            txtDesPro.Text = "";
            txtPrePro.Text = Convert.ToString(0);
            ddlIdUnidad.DataBind();
            ddlIdTipo.DataBind();
            grdProductos.SelectedIndex = -1;
            FnHabilitarControles();
            txtIdProducto.Focus();
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            lblMensajes.Text = "";
            String strIdProducto, strDescripcion, strIdUnidad, strIdTipo, strPrecio;
            Decimal dcPrecio;

            strIdProducto = txtIdProducto.Text;
            strDescripcion = txtDesPro.Text;
            strIdUnidad = ddlIdUnidad.SelectedItem.Value;
            strIdTipo = ddlIdTipo.SelectedItem.Value;
            strPrecio = txtPrePro.Text.Replace("€", "").Replace(".", ",").Trim();
            dcPrecio = Convert.ToDecimal(strPrecio);

            string StrCadenaConexion = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string StrComandoSql = "INSERT PRODUCTO " +
                     "(IdProducto,DesPro,PrePro,IdUnidad,IdTipo) VALUES (" + "'" + strIdProducto + "','" + strDescripcion +
                     "'," + FnComaPorPunto(dcPrecio) + ",'" + strIdUnidad + "','" + strIdTipo + "');";

            using(SqlConnection conexion = new SqlConnection(StrCadenaConexion))
            {
                try
                {
                    conexion.Open();
                    SqlCommand comando = conexion.CreateCommand();
                    comando.CommandText = StrComandoSql;
                    int inRegistrosAfectados = comando.ExecuteNonQuery();
                    
                    if(inRegistrosAfectados == 1)
                    {
                        lblMensajes.Text = "Registro insertado correctamente";
                    }
                    else
                    {
                        lblMensajes.Text = "Error al insertar el registro";
                    }

                    btnNuevo.Visible = true;
                    btnEditar.Visible = false;
                    btnEliminar.Visible = false;
                    btnInsertar.Visible = false;
                    btnModificar.Visible = false;
                    btnBorrar.Visible = false;
                    btnCancelar.Visible = false;
                }
                catch (SqlException ex)
                {
                    string StrError = "<p>Se han producido errores en el acceso a la base de datos.</p>";
                    StrError += "<div>Código: " + ex.Number + "</div>";
                    StrError += "<div>Descripción: " + ex.Message + "</div>";
                    lblMensajes.Text = StrError;
                    return;
                }
            }
            grdProductos.DataBind();
            grdProductos.SelectedIndex = -1;
            FnDeshabilitarControles();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            lblMensajes.Text = "";
            btnNuevo.Visible = true;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            btnInsertar.Visible = false;
            btnModificar.Visible = false;
            btnBorrar.Visible = false;
            btnCancelar.Visible = false;
            txtIdProducto.Text = "";
            txtDesPro.Text = "";
            txtPrePro.Text = Convert.ToString(0);
            ddlIdUnidad.DataBind();
            ddlIdTipo.DataBind();
            grdProductos.SelectedIndex = -1;
            FnDeshabilitarControles();

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            lblMensajes.Text = "";

            btnNuevo.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            btnInsertar.Visible = false;
            btnModificar.Visible = true;
            btnCancelar.Visible = true;
            txtPrePro.Text = Convert.ToString(txtPrePro.Text);
            FnHabilitarControles();
            txtIdProducto.Enabled = false;
            txtIdProducto.Focus();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            lblMensajes.Text = "";
            String strIdProducto, strDescripcion, strIdUnidad, strIdTipo, strPrecio;
            Decimal dcPrecio;

            strIdProducto = txtIdProducto.Text;
            strDescripcion = txtDesPro.Text;
            strIdUnidad = ddlIdUnidad.SelectedItem.Value;
            strIdTipo = ddlIdTipo.SelectedItem.Value;
            strPrecio = txtPrePro.Text.Replace("€", "").Replace(".",",").Trim(); //Lo convierte a decimal ya sea con punto o coma para que no de errores
                                                                                 //Trim libera los espacios vacios
            ///////////////////
            dcPrecio = Convert.ToDecimal(strPrecio); //Solo acepta el punto de separador en decimales


            string StrCadenaConexion = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string StrComandoSql = "UPDATE PRODUCTO " +
                "SET IdProducto = '" + strIdProducto + "', " + "DesPro = '" + strDescripcion + "', PrePro = " + FnComaPorPunto(dcPrecio) //Sql acepta solo comas
                + ", IdUnidad = '" + strIdUnidad + "', IdTipo = '" + strIdTipo + "'"
                + "WHERE IdProducto = '" + strIdProducto + "'";


            using (SqlConnection conexion = new SqlConnection(StrCadenaConexion))
            {
                    try
                    {
                        conexion.Open();
                        SqlCommand comando = conexion.CreateCommand();
                        comando.CommandText = StrComandoSql;
                        int inRegistrosAfectados = comando.ExecuteNonQuery();

                        if (inRegistrosAfectados == 1)
                        {
                            lblMensajes.Text = "Registro actualizado correctamente";
                        }
                        else
                        {
                            lblMensajes.Text = "Error al actualizar el registro";
                        }

                        btnNuevo.Visible = true;
                        btnEditar.Visible = false;
                        btnEliminar.Visible = false;
                        btnInsertar.Visible = false;
                        btnModificar.Visible = false;
                        btnBorrar.Visible = false;
                        btnCancelar.Visible = false;

                    }
                    catch (SqlException ex)
                    {
                        string StrError = "<p>Se han producido errores en el acceso a la base de datos</p>";
                        StrError += "<div>Codigo: " + ex.Number + "</div>";
                        StrError += "<div>Descripción: " + ex.Message + "</div>";
                        return;
                    }
                    grdProductos.DataBind();
                    grdProductos.SelectedIndex = -1;
                    FnDeshabilitarControles();
            }
            
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            lblMensajes.Text = "";

            String strIdProducto, strDescripcion, strIdUnidad, strIdTipo, strPrecio;
            Decimal dcPrecio;

            strIdProducto = txtIdProducto.Text;
            strDescripcion = txtDesPro.Text;
            strIdUnidad = ddlIdUnidad.SelectedItem.Value;
            strIdTipo = ddlIdTipo.SelectedItem.Value;

            strPrecio = txtPrePro.Text.Replace("€", "").Trim();
            dcPrecio = Convert.ToDecimal(strPrecio);

            string StrCadenaConexion = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string StrComandoSql = "DELETE FROM PRODUCTO WHERE idProducto = '" + strIdProducto + "'";

            using(SqlConnection conexion = new SqlConnection(StrCadenaConexion))
            {
                try
                {
                    conexion.Open();
                    SqlCommand comando = conexion.CreateCommand();
                    comando.CommandText = StrComandoSql;
                    int inRegistrosAfectados = comando.ExecuteNonQuery();

                    if (inRegistrosAfectados == 1)
                    {
                        lblMensajes.Text = "Registro Eliminado Correctamente";
                    }
                    else
                    {
                        lblMensajes.Text = "Error al eliminar un registro";
                    }

                    btnNuevo.Visible = true;
                    btnEditar.Visible = false;
                    btnEliminar.Visible = false;
                    btnInsertar.Visible = false;
                    btnModificar.Visible = false;
                    btnBorrar.Visible = false;
                    btnCancelar.Visible = false;
                }
                catch (SqlException ex)
                {
                    string StrError = "<p>Se han producido errores en el acceso a la base de datos</p>";
                    StrError += "<div>Codigo: " + ex.Number + "</div>";
                    StrError += "<div>Descripción: " + ex.Message + "</div>";
                    return;
                }
                grdProductos.DataBind();
                grdProductos.SelectedIndex = -1;
                txtIdProducto.Text = "";
                txtDesPro.Text = "";
                txtPrePro.Text = Convert.ToString(0);
                ddlIdUnidad.DataBind();
                ddlIdTipo.DataBind();
                FnDeshabilitarControles();
            }
            
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            lblMensajes.Text = "";
            btnNuevo.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            btnInsertar.Visible = false;
            btnModificar.Visible = false;
            btnBorrar.Visible = true;
            btnCancelar.Visible = true;
            grdProductos.SelectedIndex = -1;
            FnDeshabilitarControles();
            txtIdProducto.Focus();
        }
    }
}