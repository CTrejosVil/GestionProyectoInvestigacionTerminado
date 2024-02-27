namespace Entidades
{
    public class Convocatoria
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public string PaginaWeb { get; set; }
        public string TerminosReferencia { get; set; }
        public DateTime FechaAperturaConvocatoria { get; set; }
        public DateTime FechaCierreConvocatoria { get; set; }


    }
}