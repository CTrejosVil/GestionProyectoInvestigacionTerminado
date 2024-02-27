namespace Entidades
{
    public class Proyecto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string GrupoInvestigacion { get; set; }
        public string LineaInvestigacion { get; set; }
        public string EnteFinanciero { get; set; }
        public string Convocatoria { get; set; }
        public string EntidadesCooperantes { get; set; }
        public int Duracion { get; set; }
        public string Actividades { get; set; }
        public string Objetivos { get; set; }
        public string Comentarios { get; set; }
        public string RequiereAjuste { get; set; }
        public decimal Ajustes { get; set; }

    }
}