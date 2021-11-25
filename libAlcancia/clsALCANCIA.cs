using System;
using System.Collections.Generic;

namespace appAlcancia.Dominio
{
    public class clsALCANCIA
    {
        #region Atributos
        #region AtributosPropios
        private string atrNombre = "ninguno";
        private int atrCapacidadMonedas = 0;
        private List<int> atrDenominacionesAceptadasMonedas = null;
        private int atrCapacidadBilletes = 0;
        private List<int> atrDenominacionesAceptadasBilletes = null;
        #endregion
        #region AtributosDerivables
        private List<int> atrSaldoPorDenominacionMonedas = null;
        private List<int> atrConteoPorDenominacionMonedas = null;
        private int atrSaldoTotalMonedas = 0;
        private List<int> atrSaldoPorDenominacionBilletes = null;
        private List<int> atrConteoPorDenominacionBilletes = null;
        private int atrSaldoTotalBilletes = 0;
        private int atrSaldoTotal = 0;
        #endregion
        #region atributosasociativos
        private List<clsMONEDA> atrMonedas = null;
        private List<clsBILLETE> atrBilletes = null;
        #endregion
        #endregion
        #region Metodos
        #region Constructores
        /// <summary>
        /// El proposito de este metodo es crear una nueva instancia de Alcancia
        /// </summary>
        /// <param name="prmNombre">El Nombre que el usuario quiere  asignar a su nueva alcancia </param>
        /// <param name="prmCapacidadMonedas">indica cuantas monedas acepta la alcancia para todas las denominaciones No puede ser Negativa</param>
        /// <param name="prmCapacidadBilletes">indica cuantos Billetes acepta la alcancia para todas las denominaciones No puede ser Negativa</param>
        /// <param name="prmDenMonedas"> especifica las denominaciones ( de Monedas) aceptadas por la alcancia </param>
        /// <param name="prmDenBilletes"> especifica las denominaciones (de Billetes)aceptadas por la alcancia</param>
        public clsALCANCIA(string prmNombre, int prmCapacidadMonedas, int prmCapacidadBilletes, List<int> prmDenMonedas, List<int> prmDenBilletes)
        {
            //TODO
            throw new NotImplementedException();
        }
        #endregion
        #region Accesores
        #region Propios 
        /// <summary>
        /// Retorna el nombre dado a la Alcancia en su momento de su creacion 
        /// </summary>
        /// <returns>cadena de texto </returns>
        public string darNombre()
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// Retrona la capacidad en Monedas  que tiene la Alcancia en el momento de su creacion 
        /// </summary>
        /// <returns> numero entero </returns>
        public int darCapacidadMonedas()
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// Retorna la Capacidad en Billetes que tiene la alcancia en el momento de su creacion 
        /// </summary>
        /// <returns >numero entero </returns>
        public int darCapaicadaBilletes()
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// retorna una lista que contiene las denominaciones en (Monedas) que son aceptadas por la alcancia en el momento de su creacion 
        /// </summary>
        /// <returns>Lista de enteros </returns>
        public List<int> darDenominacionesMonedas()
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// retorna una lista que contiene las denominaciones en (Billetes) que son aceptadas por la Alcancia en el momento de su creacion 
        /// </summary>
        /// <returns>retorna lista de enteros </returns>
        public List<int> darDenominacionesBilletes()
        {
            //TODO
            throw new NotImplementedException();

        }
        #endregion
        #region Derivables 
        /// <summary>
        /// Retorna el saldo  de monedas por cada Denominacion aceptada por la alcancia 
        /// </summary>
        /// <returns>lista de enteros </returns>
        public  List<int> darSaldoDenominacionMonedas()
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// Retorna el conteo de monedas por cada denominacion aceptada por la alcancia 
        /// </summary>
        /// <returns>lista de enteros</returns>
        public List<int> darConteoPorDenominacionMonedas()
        {

            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// Retorna el saldo  de billetes por cada Denominacion aceptada por la alcancia 
        /// </summary>
        /// <returns>lista de enteros </returns>
        public List<int> darSaldoPorDenominacionBilletes()
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// Retorna el conteo de billetes por cada denominacion aceptada por la alcancia 
        /// </summary>
        /// <returns></returns>
        public List<int> darConteoPorDenominacionBilletes()
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// retrona el saldo total de monedas que tiene almacenada la Alcancia para todas las denominaciones 
        /// </summary>
        /// <returns> numero entero </returns>
        public int darSaldoTotalMonedas()
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// retrona el saldo total de Billetes que tiene almacenada la Alcancia para todas las denominaciones 
        /// </summary>
        /// <returns>numero entero</returns>
        public int darSaldoBilletes()
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// Retorna el saldo total de monedas y billetes que tiene almacenada la alcancia para todas sus denominaciones 
        /// </summary>
        /// <returns></returns>
        public int darSaldoTotal()
        {
            //TODO
            throw new NotImplementedException();
        }
        #endregion
        #region Asociativos 
        /// <summary>
        /// Retorna la colecion  ( modo lectura ) de monedas en la Alcancia 
        /// </summary>
        /// <returns>LISTA MONEDAS </returns>
        public List<clsMONEDA> darMonedas()
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// Retorna la colecion  ( modo lectura ) de billetes  en la Alcancia 
        /// </summary>
        /// <returns>LISTA MONEDAS </returns>
        public List<clsBILLETE> darBilletes()
        {
            //TODO
            throw new NotImplementedException();
        }
        #endregion
        #endregion
        #region Mutadores
        /// <summary>
        /// Modifica el nombre de la alcancia en el momento de su creacion o posterior
        /// </summary>
        /// <param name="prmValor"></param>
        /// <returns>retorna true o false </returns>
        public bool ponerNombre(string prmValor)
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// Ajusta la capacidad de monedas establecida para la alcancia por una capacidad Mayor
        /// </summary>
        /// <param name="prmValor"></param>
        /// <returns>numero entero </returns>
        public bool ponerCapacidadMonedas(int prmValor)
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// Ajusta la capacidad de billetes  establecida para la alcancia por una capacidad Mayor
        /// </summary>
        /// <param name="prmValor"></param>
        /// <returns>numero entero </returns>
        public bool ponerCapacidadBilletes(int prmValor)
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// establece la nueva coleccion  de denominaciones aceptadas para Monedas
        /// </summary>
        /// <param name="prmColeccion"></param>
        /// <returns>lista de enteros </returns>
        public bool ponerDenominacionesMonedas(List<int> prmColeccion)
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// establece la nueva coleccion  de denominaciones aceptadas para Billetes 
        /// </summary>
        /// <param name="prmColeccion"></param>
        /// <returns>lista de enteros </returns>
        public bool ponerDenominacionesBilletes(List<int> prmColeccion)
        {
            //TODO
            throw new NotImplementedException();
        }
        #endregion
        #endregion

    }
}
