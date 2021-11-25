using System;
namespace appAlcancia.Dominio
{
    public class clsMONEDA
    {
        #region Atributos 
        #region ATRIBUTOSPROPIOS
        protected string atrNombre = "n.n";
        protected int atrDenominacion = -1;
        protected int atrAño = -1;
        #endregion
        #region ATRIBUTOS ASOCIATIVOS
        protected clsALCANCIA atrAlcancia = null;

        public clsALCANCIA alcancia;
        #endregion
        #endregion
        #region Metodos
        #region Constructores
        /// <summary>
        /// crea una nueva instancia de moneda con nombre, denominacion y año de emision
        /// </summary>
        /// <param name="prmNombre">nombre de la Moneda segun el pais ej : Peso, Dolar</param>
        /// <param name="prmDenominacion">valor monetario. ej: 100 pesos</param>
        /// <param name="prmAño">año de Emision de la Moneda.</param>
        public clsMONEDA(string prmNombre, int prmDenominacion,int prmAño)
        {
            //TODO:Implementar
            throw new NotImplementedException();

        }
        #endregion
        #region Accesores 
        /// <summary>
        /// devuelve el Nombre de la Moneda segun el pais Ej : peso, dolar
        /// </summary>
        /// <returns>cadena</returns>
        public String darNombre()
        {
            //TODO:Implementar
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int darDenominacion()
        {
            //TODO:Implementar
            throw new NotImplementedException();
        }
        public int darAño()
        {
            //TODO:Implementar
            throw new NotImplementedException();
        }
        #endregion
        #region Mutadores
        /// <summary>
        /// Modifica el  nombre asigando a la moneda ej:cambia el nombre de dolar a peso 
        /// </summary>
        /// <param name="prmValor">nuevo nombre que se tomara la moneda </param>
        /// <returns>true si la moneda esta fuera de la alcancia y el cambio fue posible false de lo contrario</returns>
        public bool ponerNombre(string prmValor)
        {
            //TODO:Implementar
            throw new NotImplementedException();
        }
        /// <summary>
        /// Modifica el  valor monetario asigando a la moneda ej:cambia de 10 a 100 
        /// </summary>
        /// <param name="prmValor">nuevo nombre que se tomara la moneda </param>
        /// <returns>true si la moneda esta fuera de la alcancia y el cambio fue posible false de lo contrario</returns>
        public bool ponerDenominacion(int prmValor)
        {
            //TODO:Implementar
            throw new NotImplementedException();
        }
        /// <summary>
        /// Modifica el  año de  emision asigando a la moneda ej:cambia de 1990 a 2010 
        /// </summary>
        /// <param name="prmValor">nuevo nombre que se tomara la moneda </param>
        /// <returns>true di el año no esta en el futuro y el cambio fue posible  false de lo contrario</returns>
        public bool ponerAño(int prmValor)
        {
            //TODO:Implementar
            throw new NotImplementedException();
        }

        #endregion
        #endregion
       
    }
}
