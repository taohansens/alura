using System.Collections.Generic;

namespace TaoBank.Models.Comparadores {

    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente> {

        public int Compare(ContaCorrente x, ContaCorrente y) {
            if (x == y) {
                return 0;
            }

            if (x == null) {
                return 1;
            }
            if (y == null) {
                return -1;
            }
            
            // Comparação números inteiros. 
            return x.Agencia.CompareTo(y.Agencia);

            //Mesma lógica.
            //if (x.Agencia < y.Agencia) {
            //    return -1;
            //}
            //if (x.Agencia == y.Agencia) {
            //    return 0;
            //}
            //return 1;
        }
    }
}