namespace Avika.Forum.LogDLL
{
    public interface ILogger
    {
        void EscribirError(string formato, params string[] parametros);
        void EscribirLog(string texto = null);
    }
}