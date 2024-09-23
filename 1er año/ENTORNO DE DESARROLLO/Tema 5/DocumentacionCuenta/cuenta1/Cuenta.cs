
namespace Cuenta
{
    /* Clase que representa una cuenta corriente
     * Tiene el campo saldo que representa el saldo de la cuenta, en euros
     * La propiedad saldo devuelve el saldo que hay en la cuenta
     * Los metodos retirar e ingresar sirven para retirar o ingresar la cantidad indicada 
     * 
     * Este comentario se debe eliminar y usar comentarios de documentacion en su lugar
     */

    /// <summary>
    /// <para>Clase que representa una cuenta bancaria de una persona.</para>
    /// <para>La cuenta puede tener dos tipos de acciones
    /// <list type="bullet">
    ///     <item>
    ///         <description>Ingresar</description>
    ///     </item>
    ///     <item>
    ///         <description>Retirar</description>
    ///     </item>
    /// </list>
    /// </para>
    /// </summary>
    public class Cuenta
    {
        /// <summary>
        /// Saldo o dinero de la cuenta en tipo decimal
        /// </summary>
        private decimal saldo;
        /// <summary>
        /// Obtiene el saldo
        /// </summary>
        /// <value>Saldo</value>
        public decimal Saldo
        {
            get { return saldo; }
        }
        /// <summary>
        /// Calcula el dinero que quedaria en la cuenta una vez que ingresas una cantidad de dinero
        ///  <para>El valor del parámetro <paramref name="cantidad"/> debe ser menor que <see cref=0/>
        /// </summary>
        /// Suma la cantidad al saldo
        public void ingresar (decimal cantidad)
        {
            if (cantidad > 0)
                saldo = saldo + cantidad;
        }
        /// <summary>
        /// <para>Calcula el dinero que queda en la cuenta una vez se retira </para>
        /// El valor de parametro es 0
        /// <para>El valor del parámetro <paramref name="cantidad"/> debe ser mayor que <see cref="0"/> y menor o
        /// igual que el saldo</para>
        /// </summary>
        /// La variable retirado ahora es cantidad
        /// Se le resta al saldo la cantidad
        /// <returns>El dinero que se ha retirado de la cuenta</returns>
        public decimal retirar (decimal cantidad)
        {
            decimal retirado = 0; //Cantidad que se retira
            if (cantidad > 0 && cantidad <= saldo)
            {
                retirado = cantidad;
                saldo = saldo - cantidad;
            }

            return retirado;
        }
    }
}
