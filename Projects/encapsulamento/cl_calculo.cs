using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace encapsulamento
{
    class cl_calculo
    {
        private int porcent1 = 5;
        private int porcent2 = 12;
        private int porcent3 = 23;

        public int CalcFinal (int price_initial, int product)
        {
            int price_final = 0;
            
            //calculo de valores de porcemtagem
            switch (product)
            {
                //alimento
                case 1:
                    price_final = price_initial + (price_initial * porcent1 / 100);
                    break;
                //Objeto
                case 2:
                    price_final = price_initial + (price_initial * porcent2 / 100);
                    break;
                //produto de beleza
                case 3:
                    price_final = price_initial + (price_initial * porcent2 / 100);
                    break;
            }

            return price_final;

        }
    }
}
