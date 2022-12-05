using Diagnosticos.Models;

namespace Diagnosticos
{
    internal static class Program
    {
        public static DBDiagnosticosContext database = new();
        public static Diagnostico diagnostico = new();
        public static DiagnosticoCactus diagnosticocac = new();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormPlantasDiagnostico());
        }
    }
}