using System;
namespace appAlcancia.Dominio
{
    public class clsBILLETE:clsMONEDA
    {
        #region ATRIBUTOS 
        #region PROPIOS
        private string atrSerie = "ninguna";
        private int atrMes = -1;
        private int atrDia = -1;
        #endregion
        #endregion
        #region Metodos
        #region Constructores
        /// <summary>
        /// 
        /// </summary>
        /// <param name="prmSerie"></param>
        /// <param name="prmNombre"></param>
        /// <param name="prmDenominacion"></param>
        /// <param name="prmAño"></param>
        /// <param name="prmMes"></param>
        /// <param name="prmDia"></param>
        public clsBILLETE(string prmSerie, string prmNombre, int prmDenominacion, int prmAño, int prmMes, int prmDia):base(prmNombre,prmDenominacion,prmAño)
        {
            //TODO
            throw new NotImplementedException();

        }
        #endregion
        #region Accesores 
        /// <summary>
        /// devuelve el nombre del billete segun el pais Ej : peso, dolar
        /// </summary>
        /// <returns>cadena</returns>
        public String darSerie()
        {
            //TODO:Implementar
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int darMes()
        {
            //TODO:Implementar
            throw new NotImplementedException();
        }
        public int darDia()
        {
            //TODO:Implementar
            throw new NotImplementedException();
        }
        #endregion
        #region Mutadores
        /// <summary>
        /// Modifica  la serie  asigando al billete  ej:cambia  de " "
        /// 
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
