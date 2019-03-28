using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coladera
{
    class vector
    {
        private int[] vec;

        public vector()//constructor
        {
            vec = new int[1000];

        }

        /// <summary>
        /// Funcion que llena el vector con 1
        /// </summary>
        public void llenar()
        {
            for(int i=1;i<vec.Length;i++)
            {
                vec[i] = 1;
            }
        }

        /// <summary>
        /// funcion que aplica el metodo de coladera
        /// empezamos a partir del 2, si el valor que tiene el vector con subindice i
        /// es 1, usamos otro ciclo para comparar si el numero de un ciclo es multiplo del 
        /// otro ciclo, si es multiplo, el valor del vector con subindice j será 0
        /// </summary>
        public void colar()
        {
            for(int i=2;i<1000;i++)
            {
                if (vec[i]==1)
                {
                    for(int j=i+1;j<1000;j++)
                    {
                        if(j%i==0)
                        {
                            vec[j] = 0;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// una vez generado y llenado el vector, con un ciclo comparamos que el valor
        /// del vector con subindice i es igual a 1 lo mostraremos
        /// </summary>
        /// <returns></returns>
        public string mostrar()
        {
            string valor = " ";
            for(int i=2;i<vec.Length;i++)
            {
                if(vec[i]==1)
                {
                    valor += "Numero:" + i + " es primo"+Environment.NewLine;
                }
            }
            return valor;
        }
    }
}
