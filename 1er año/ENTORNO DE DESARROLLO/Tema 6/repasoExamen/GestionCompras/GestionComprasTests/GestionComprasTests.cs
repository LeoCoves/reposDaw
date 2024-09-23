using Gestion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GestionComprasTests
{
    [TestClass]
    public class GestionComprasTests
    {
        [TestMethod]
        public void RegistrarCompraAgregaProductoInventario()
        {
            // Preparacion
            GestionCompras gestionCompras = new GestionCompras();

            // Actuacion
            gestionCompras.RegistrarCompra("ProductoA", 5);

            // Comprobacion
            Assert.AreEqual(5, gestionCompras.ObtenerInventario("ProductoA"));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RegistrarCompraAgregaProductoInventarioCantidadNegativa()
        {
            // Preparacion
            GestionCompras gestionCompras = new GestionCompras();

            // Actuacion
            gestionCompras.RegistrarCompra("ProductoA", -5);

            // Comprobacion
            Assert.AreEqual(-5, gestionCompras.ObtenerInventario("ProductoA"));
        }

        [TestMethod]

        public void RegistrarDevolucionProductoCantidadPositivaMenInventario()
        {
            // Preparacion
            GestionCompras gestionCompras = new GestionCompras();

            // Actuacion
            gestionCompras.RegistrarCompra("ProductoA", 5);

            gestionCompras.RegistrarDevolucion("ProductoA", 4);

            // Comprobacion
            Assert.AreEqual(1, gestionCompras.ObtenerInventario("ProductoA"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RegistrarDevolucionProductoCantidadNegativaInventario()
        {
            // Preparacion
            GestionCompras gestionCompras = new GestionCompras();

            // Actuacion
            gestionCompras.RegistrarCompra("ProductoA", 5);

            gestionCompras.RegistrarDevolucion("ProductoA", -5);

            // Comprobacion
            Assert.AreEqual(5, gestionCompras.ObtenerInventario("ProductoA"));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RegistrarDevolucionProductoNoExistenteCantidadNegativaInventario()
        {
            // Preparacion
            GestionCompras gestionCompras = new GestionCompras();

            // Actuacion
            gestionCompras.RegistrarDevolucion("ProductoA", -5);

            // Comprobacion
            Assert.AreEqual(0, gestionCompras.ObtenerInventario("ProductoA"));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RegistrarDevolucionProductoNoExistenteInventario()
        {
            // Preparacion
            GestionCompras gestionCompras = new GestionCompras();

            // Actuacion
            gestionCompras.RegistrarDevolucion("ProductoA", 6);

            // Comprobacion
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RegistrarDevolucionProductoCantidadPositivaMayInventario()
        {
            // Preparacion
            GestionCompras gestionCompras = new GestionCompras();

            // Actuacion
            gestionCompras.RegistrarCompra("ProductoA", 5);

            gestionCompras.RegistrarDevolucion("ProductoA", 6);

            // Comprobacion
            Assert.AreEqual(-1, gestionCompras.ObtenerInventario("ProductoA"));
        }
    }
}
