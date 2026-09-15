using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_ASO
{
    public class ResultadoAlgoritmo
    {
        public string Algoritmo { get; set; }
        public int MovimientosTotales { get; set; } // <--- Número total de movimientos en lugar del texto de la secuencia
        public int RecorridoTotal { get; set; }
        public double PromedioBusqueda { get; set; }
        public double TiempoPromedioEspera { get; set; }

        // Esta lista se queda internamente para que el gráfico y la animación funcionen correctamente
        public List<int> RutaCompleta { get; set; }
    }

    public static class AlgoritmosDisco
    {
        private static ResultadoAlgoritmo EmpaquetarResultado(string nombre, int cabezaInicial, List<int> ordenAtencion, int recorridoTotal)
        {
            double promedioBusqueda = ordenAtencion.Count > 0 ? (double)recorridoTotal / ordenAtencion.Count : 0;

            double acumuladoEspera = 0;
            double sumaEsperaTotal = 0;
            int posicionActual = cabezaInicial;

            foreach (var destino in ordenAtencion)
            {
                int distancia = Math.Abs(destino - posicionActual);
                acumuladoEspera += distancia;
                sumaEsperaTotal += acumuladoEspera;
                posicionActual = destino;
            }

            double tiempoPromedioEspera = ordenAtencion.Count > 0 ? sumaEsperaTotal / ordenAtencion.Count : 0;

            // Construir ruta completa agregando la cabeza inicial al inicio para graficar y animar
            var ruta = new List<int> { cabezaInicial };
            ruta.AddRange(ordenAtencion);

            return new ResultadoAlgoritmo
            {
                Algoritmo = nombre,
                MovimientosTotales = recorridoTotal, // Asignamos el total de movimientos/desplazamientos
                RecorridoTotal = recorridoTotal,
                PromedioBusqueda = Math.Round(promedioBusqueda, 2),
                TiempoPromedioEspera = Math.Round(tiempoPromedioEspera, 2),
                RutaCompleta = ruta
            };
        }

        public static ResultadoAlgoritmo EjecutarFCFS(int cabezaInicial, List<int> solicitudes)
        {
            var secuencia = new List<int>(solicitudes);
            int recorridoTotal = 0;
            int actual = cabezaInicial;

            foreach (var destino in secuencia)
            {
                recorridoTotal += Math.Abs(destino - actual);
                actual = destino;
            }

            return EmpaquetarResultado("FCFS", cabezaInicial, secuencia, recorridoTotal);
        }

        public static ResultadoAlgoritmo EjecutarSSTF(int cabezaInicial, List<int> solicitudes)
        {
            var pendientes = new List<int>(solicitudes);
            var secuencia = new List<int>();
            int recorridoTotal = 0;
            int actual = cabezaInicial;

            while (pendientes.Count > 0)
            {
                int masCercano = pendientes.OrderBy(s => Math.Abs(s - actual)).First();
                recorridoTotal += Math.Abs(masCercano - actual);
                actual = masCercano;
                secuencia.Add(actual);
                pendientes.Remove(masCercano);
            }

            return EmpaquetarResultado("SSTF", cabezaInicial, secuencia, recorridoTotal);
        }

        public static ResultadoAlgoritmo EjecutarSCAN(int cabezaInicial, List<int> solicitudes, int cilindroMaximo, bool direccionDerecha)
        {
            var secuencia = new List<int>();
            int recorridoTotal = 0;
            int actual = cabezaInicial;
            var pendientes = new List<int>(solicitudes);
            pendientes.Sort();

            if (direccionDerecha)
            {
                var mayores = pendientes.Where(s => s >= actual).ToList();
                var menores = pendientes.Where(s => s < actual).OrderByDescending(s => s).ToList();

                foreach (var m in mayores)
                {
                    recorridoTotal += Math.Abs(m - actual);
                    actual = m;
                    secuencia.Add(actual);
                }

                if (menores.Count > 0 && actual != cilindroMaximo)
                {
                    recorridoTotal += Math.Abs(cilindroMaximo - actual);
                    actual = cilindroMaximo;
                }

                foreach (var m in menores)
                {
                    recorridoTotal += Math.Abs(m - actual);
                    actual = m;
                    secuencia.Add(actual);
                }
            }
            else
            {
                var menores = pendientes.Where(s => s <= actual).OrderByDescending(s => s).ToList();
                var mayores = pendientes.Where(s => s > actual).OrderBy(s => s).ToList();

                foreach (var m in menores)
                {
                    recorridoTotal += Math.Abs(m - actual);
                    actual = m;
                    secuencia.Add(actual);
                }

                if (mayores.Count > 0 && actual != 0)
                {
                    recorridoTotal += Math.Abs(0 - actual);
                    actual = 0;
                }

                foreach (var m in mayores)
                {
                    recorridoTotal += Math.Abs(m - actual);
                    actual = m;
                    secuencia.Add(actual);
                }
            }

            return EmpaquetarResultado("SCAN", cabezaInicial, secuencia, recorridoTotal);
        }

        public static ResultadoAlgoritmo EjecutarCSCAN(int cabezaInicial, List<int> solicitudes, int cilindroMaximo)
        {
            var secuencia = new List<int>();
            int recorridoTotal = 0;
            int actual = cabezaInicial;
            var pendientes = new List<int>(solicitudes);
            pendientes.Sort();

            var mayores = pendientes.Where(s => s >= actual).ToList();
            var menores = pendientes.Where(s => s < actual).ToList();

            foreach (var m in mayores)
            {
                recorridoTotal += Math.Abs(m - actual);
                actual = m;
                secuencia.Add(actual);
            }

            if (menores.Count > 0)
            {
                if (actual != cilindroMaximo)
                {
                    recorridoTotal += Math.Abs(cilindroMaximo - actual);
                    actual = cilindroMaximo;
                }
                recorridoTotal += cilindroMaximo;
                actual = 0;

                foreach (var m in menores)
                {
                    recorridoTotal += Math.Abs(m - actual);
                    actual = m;
                    secuencia.Add(actual);
                }
            }

            return EmpaquetarResultado("C-SCAN", cabezaInicial, secuencia, recorridoTotal);
        }

        public static ResultadoAlgoritmo EjecutarLOOK(int cabezaInicial, List<int> solicitudes, bool direccionDerecha)
        {
            var secuencia = new List<int>();
            int recorridoTotal = 0;
            int actual = cabezaInicial;
            var pendientes = new List<int>(solicitudes);
            pendientes.Sort();

            if (direccionDerecha)
            {
                var mayores = pendientes.Where(s => s >= actual).ToList();
                var menores = pendientes.Where(s => s < actual).OrderByDescending(s => s).ToList();

                foreach (var m in mayores)
                {
                    recorridoTotal += Math.Abs(m - actual);
                    actual = m;
                    secuencia.Add(actual);
                }

                foreach (var m in menores)
                {
                    recorridoTotal += Math.Abs(m - actual);
                    actual = m;
                    secuencia.Add(actual);
                }
            }
            else
            {
                var menores = pendientes.Where(s => s <= actual).OrderByDescending(s => s).ToList();
                var mayores = pendientes.Where(s => s > actual).OrderBy(s => s).ToList();

                foreach (var m in menores)
                {
                    recorridoTotal += Math.Abs(m - actual);
                    actual = m;
                    secuencia.Add(actual);
                }

                foreach (var m in mayores)
                {
                    recorridoTotal += Math.Abs(m - actual);
                    actual = m;
                    secuencia.Add(actual);
                }
            }

            return EmpaquetarResultado("LOOK", cabezaInicial, secuencia, recorridoTotal);
        }

        public static ResultadoAlgoritmo EjecutarCLOOK(int cabezaInicial, List<int> solicitudes)
        {
            var secuencia = new List<int>();
            int recorridoTotal = 0;
            int actual = cabezaInicial;
            var pendientes = new List<int>(solicitudes);
            pendientes.Sort();

            var mayores = pendientes.Where(s => s >= actual).ToList();
            var menores = pendientes.Where(s => s < actual).ToList();

            foreach (var m in mayores)
            {
                recorridoTotal += Math.Abs(m - actual);
                actual = m;
                secuencia.Add(actual);
            }

            if (menores.Count > 0)
            {
                int menorPendiente = menores.First();
                recorridoTotal += Math.Abs(menorPendiente - actual);
                actual = menorPendiente;
                secuencia.Add(actual);

                foreach (var m in menores.Skip(1))
                {
                    recorridoTotal += Math.Abs(m - actual);
                    actual = m;
                    secuencia.Add(actual);
                }
            }

            return EmpaquetarResultado("C-LOOK", cabezaInicial, secuencia, recorridoTotal);
        }
    }

}
