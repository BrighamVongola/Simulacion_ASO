using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion_ASO
{
    public partial class Frm_ASO : Form
    {

        private List<ResultadoAlgoritmo> ultimosResultados = new List<ResultadoAlgoritmo>();
        private Timer timerAnimacion = new Timer();
        private int pasoAnimacionIndex = 0;
        public Frm_ASO()
        {
            InitializeComponent();
        }


        //Funciones de validacion
        //Validar que el campo no este vacio
        private bool ValidarTextoVacio(Guna2TextBox text)
        {
            if (string.IsNullOrWhiteSpace(text.Text))
            {
                return false;
            }
            return true;
        }

        //Validar que el campo contenga solo numeros
        private bool ValidarSoloNumeros(Guna2TextBox text)
        {
            foreach (char c in text.Text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        //validar que el numero mayor a 0
        private bool ValidarNumeroMayorAZero(Guna2TextBox text)
        {
            if (int.TryParse(text.Text, out int numero))
            {
                if (numero > 0)
                {
                    return true;
                }
            }
            return false;
        }
        
        //Validar que el contenido del textbox este separado por comas y que cada elemento sea un numero
        private bool ValidarTextoSeparadoPorComas(Guna2TextBox text)
        {
            string[] elementos = text.Text.Split(',');
            foreach (string elemento in elementos)
            {
                if (!int.TryParse(elemento.Trim(), out int numero))
                {
                    return false;
                }
            }
            return true;
        }
        
        private void Frm_ASO_Load(object sender, EventArgs e)
        {
            Panel_Modulo2.Enabled = false;
            Panel_Grafico.Enabled = false;
            Panel_Resultados.Enabled = false;
        }

        private void G_btn_proceder_Click(object sender, EventArgs e)
        {

            List<string> errores = new List<string>();

            // 1. Validaciones para Cantidad de Cilindros
            if (!ValidarTextoVacio(G_txt_cilindros)) errores.Add("- La cantidad de cilindros no puede estar vacía.");
            else if (!ValidarSoloNumeros(G_txt_cilindros)) errores.Add("- La cantidad de cilindros debe contener solo números.");
            else if (!ValidarNumeroMayorAZero(G_txt_cilindros)) errores.Add("- La cantidad de cilindros debe ser mayor a 0.");

            // 2. Validaciones para Posición del Cabezal
            if (!ValidarTextoVacio(G_txt_cabezal)) errores.Add("- La posición del cabezal no puede estar vacía.");
            else if (!ValidarSoloNumeros(G_txt_cabezal)) errores.Add("- La posición del cabezal debe contener solo números.");
            else if (!ValidarNumeroMayorAZero(G_txt_cabezal)) errores.Add("- La posición del cabezal debe ser mayor a 0.");

            // 3. Validación del ComboBox
            if (G_cmb_direccion.SelectedIndex == -1) errores.Add("- Por favor, seleccione una dirección.");

            // 4. Evaluar si se encontraron errores
            if (errores.Count > 0)
            {
                // Une todos los errores separados por un salto de línea (\n)
                string mensajeError = "Se encontraron los siguientes problemas:\n\n" + string.Join("\n", errores);
                MessageBox.Show(mensajeError, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución si hay errores
            }

            // 5. Si no hay errores, el código continúa aquí de forma segura
            Panel_Modulo2.Enabled = true;
            MessageBox.Show($"¡Datos válidos!\nDirección seleccionada: {G_cmb_direccion.Text}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void G_btn_agg_manualmente_Click(object sender, EventArgs e)
        {
            G_txt_solicitudes.Enabled = true;
        }

        private void G_btn_generar_automartico_Click(object sender, EventArgs e)
        {

            int maxCilindros = int.Parse(G_txt_cilindros.Text);
            G_txt_solicitudes.Clear();
            G_txt_solicitudes.Enabled = false;
            Random random = new Random();
            List<int> numerosRandoms = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                // random.Next(min, max) incluye el 'min' pero excluye el 'max'. 
                // Al poner (1, maxCilindros) generará números desde 1 hasta (maxCilindros - 1).
                int numero = random.Next(1, maxCilindros);
                numerosRandoms.Add(numero);
            }

            // 5. Unirlos todos con una coma y mostrarlos en el TextBox
            G_txt_solicitudes.Text = string.Join(", ", numerosRandoms);
        }

        private void G_btn_cargar_SA_Click(object sender, EventArgs e)
        {

            try
            {
                int cilindroMaximo = int.Parse(G_txt_cilindros.Text);
                int cabezaInicial = int.Parse(G_txt_cabezal.Text);
                bool direccionDerecha = G_cmb_direccion.SelectedItem != null && G_cmb_direccion.SelectedItem.ToString() == "Derecha";

                List<int> solicitudes = G_txt_solicitudes.Text
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                ultimosResultados.Clear();

                if (G_chk_fcfs.Checked) ultimosResultados.Add(AlgoritmosDisco.EjecutarFCFS(cabezaInicial, solicitudes));
                if (G_chk_sstf.Checked) ultimosResultados.Add(AlgoritmosDisco.EjecutarSSTF(cabezaInicial, solicitudes));
                if (G_chk_scan.Checked) ultimosResultados.Add(AlgoritmosDisco.EjecutarSCAN(cabezaInicial, solicitudes, cilindroMaximo, direccionDerecha));
                if (G_chk_Cscan.Checked) ultimosResultados.Add(AlgoritmosDisco.EjecutarCSCAN(cabezaInicial, solicitudes, cilindroMaximo));
                if (G_chk_look.Checked) ultimosResultados.Add(AlgoritmosDisco.EjecutarLOOK(cabezaInicial, solicitudes, direccionDerecha));
                if (G_chk_Clook.Checked) ultimosResultados.Add(AlgoritmosDisco.EjecutarCLOOK(cabezaInicial, solicitudes));

                if (ultimosResultados.Count == 0)
                {
                    MessageBox.Show("Selecciona al menos un algoritmo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                G_dgv_resultados.DataSource = null;
                G_dgv_resultados.DataSource = ultimosResultados;

                // Dibujar el gráfico completo en el FormsPlot
                ActualizarGraficoScottPlot(ultimosResultados);
                Panel_Grafico.Enabled = true;
                Panel_Resultados.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Método para renderizar las líneas de todos los algoritmos seleccionados en ScottPlot
        private void ActualizarGraficoStyled(List<ResultadoAlgoritmo> resultados, int limitePaso = -1)
        {
            frm_plot.Plot.Clear(); // Limpiar gráfico previo

            foreach (var res in resultados)
            {
                var rutaAUsar = limitePaso == -1 ? res.RutaCompleta : res.RutaCompleta.Take(limitePaso + 1).ToList();

                double[] xValues = Enumerable.Range(0, rutaAUsar.Count).Select(i => (double)i).ToArray();
                double[] yValues = rutaAUsar.Select(c => (double)c).ToArray();

                if (xValues.Length > 0)
                {
                    // Sintaxis actualizada para ScottPlot v5
                    var scatter = frm_plot.Plot.Add.Scatter(xValues, yValues);
                    scatter.LegendText = res.Algoritmo;
                    scatter.LineStyle.Width = 2;
                    scatter.MarkerSize = 6;
                }
            }

            frm_plot.Plot.XLabel("Pasos / Secuencia de Solicitudes");
            frm_plot.Plot.YLabel("Cilindros del Disco");
            // Forzar a que los ejes inicien en 0 para que se visualicen los ejes X=0 e Y=0
            frm_plot.Plot.Axes.SetLimitsX(0, double.NaN);
            frm_plot.Plot.Axes.SetLimitsY(0, double.NaN);

            // Mostrar la leyenda correctamente en la versión v5
            frm_plot.Plot.ShowLegend();
            frm_plot.Refresh();
        }
        
        private void ActualizarGraficoScottPlot(List<ResultadoAlgoritmo> resultados)
        {
            ActualizarGraficoStyled(resultados, -1);
        }

        private void G_btn_AnimarGrafico_Click(object sender, EventArgs e)
        {
            // Validar que existan resultados previos generados en la tabla
            if (ultimosResultados == null || ultimosResultados.Count == 0)
            {
                MessageBox.Show("Primero debes cargar y ejecutar los algoritmos para poder animar el gráfico.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            pasoAnimacionIndex = 0;

            // Configurar e iniciar el Timer (intervalo de 400ms por cada paso de la animación)
            timer_animacion.Interval = 400;
            timer_animacion.Tick -= timer_animacion_Tick; // Prevenir doble suscripción
            timer_animacion.Tick += timer_animacion_Tick;
            timer_animacion.Start();
        }

        private void timer_animacion_Tick(object sender, EventArgs e)
        {
            // Obtener la longitud de la ruta más larga para saber cuándo detener la animación
            int maxPasos = ultimosResultados.Max(r => r.RutaCompleta.Count);

            if (pasoAnimacionIndex < maxPasos)
            {
                ActualizarGraficoStyled(ultimosResultados, pasoAnimacionIndex);
                pasoAnimacionIndex++;
            }
            else
            {
                timerAnimacion.Stop(); // Detener el temporizador al completar el recorrido
            }
        }

        private void G_btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
