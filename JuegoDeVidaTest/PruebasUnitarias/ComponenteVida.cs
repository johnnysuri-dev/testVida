namespace PruebasUnitarias
{
    internal class ComponenteVida : UnitTest1
    {
        public float VidaTotal;
        public ComponenteVida()
        {

        }
        public void PierdeVida(float damage)
        {
            VidaTotal -= damage;
        }
    }
}