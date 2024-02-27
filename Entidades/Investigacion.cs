namespace Entidades
{
    public class Investigacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Proyecto Proyecto { get; set; }
    }
}