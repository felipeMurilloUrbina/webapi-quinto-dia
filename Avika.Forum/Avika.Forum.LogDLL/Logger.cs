using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Avika.Forum.LogDLL
{
    public class Logger : ILogger
    {
        public static string PATH = "~/App_Data/errores";
        string _path = "";
        public Logger(string path)
        {
            this._path = path;
            crearCarpetasDestino(this._path);
        }

        void crearCarpetasDestino(string path)
        {
            if (!Directory.Exists(path))
            {
                string rutaPegada = string.Empty;
                var folders = path.Split(new[] { "\\" }, StringSplitOptions.None);
                foreach (var folder in folders)
                {
                    rutaPegada = Path.Combine(rutaPegada + @"\", folder);
                    if (!Directory.Exists(rutaPegada))
                        try
                        {
                            Directory.CreateDirectory(rutaPegada);
                        }
                        catch { }
                }
            }

        }

        public void EscribirError(string formato, params string[] parametros)
        {
            try
            {
                StreamWriter Adestino;
                string linea = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                linea += "(" + Thread.CurrentThread.ManagedThreadId.ToString() + ")";
                linea += " - " + string.Format(formato, parametros);
                string rutaCompleta = Path.Combine(_path, string.Format("Log.{0}.{1}.{2}.txt", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year));
                Adestino = File.AppendText(rutaCompleta);
                Adestino.WriteLine($"Error: {linea}");
                Adestino.Close();
            }
            catch
            {
            }
        }

        public void EscribirLog(string texto = null)
        {
            try
            {
                StreamWriter Adestino; string linea = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                linea += "(" + Thread.CurrentThread.ManagedThreadId.ToString() + ")";
                linea += " - " + string.Format(texto);
                string rutaCompleta = Path.Combine(_path, string.Format("Peticiones.{0}.{1}.{2}.txt", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year));
                Adestino = File.AppendText(rutaCompleta);
                Adestino.WriteLine($"Actividad: {linea}");
                Adestino.Close();
            }
            catch
            {
            }
        }
    }
}
