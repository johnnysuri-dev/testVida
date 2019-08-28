using System;
using JuegoDeVidaTest;

namespace PruebasUnitarias
{
    internal class Cell
    {
        public Boolean state = false;
        public Boolean nextStage = false;
        public Cell()
        {
           
        }

        internal void getState()
        {
            throw new NotImplementedException();
        }
       
        public Boolean getNextState() {
            return this.nextStage;
        }
    }
}