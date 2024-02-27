namespace Negocio
{
    public interface INegocioUsuario
    {
        bool ValidarUsiario (string nombreUsuario, string clave);
    }
}