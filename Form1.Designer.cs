namespace Simulacion_ASO
{
    partial class Frm_ASO : System.Windows.Forms .Form
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna_B_Frm_ASO = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Panel_Modulo1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Panel_Modulo2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Panel_Grafico = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Panel_Resultados = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.G_btn_proceder = new Guna.UI2.WinForms.Guna2Button();
            this.G_txt_cilindros = new Guna.UI2.WinForms.Guna2TextBox();
            this.G_txt_cabezal = new Guna.UI2.WinForms.Guna2TextBox();
            this.G_cmb_direccion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.G_txt_solicitudes = new Guna.UI2.WinForms.Guna2TextBox();
            this.G_btn_agg_manualmente = new Guna.UI2.WinForms.Guna2Button();
            this.G_btn_generar_automartico = new Guna.UI2.WinForms.Guna2Button();
            this.gbx_Algoritmos = new Guna.UI2.WinForms.Guna2GroupBox();
            this.G_chk_fcfs = new Guna.UI2.WinForms.Guna2CheckBox();
            this.G_chk_sstf = new Guna.UI2.WinForms.Guna2CheckBox();
            this.G_chk_scan = new Guna.UI2.WinForms.Guna2CheckBox();
            this.G_chk_Clook = new Guna.UI2.WinForms.Guna2CheckBox();
            this.G_chk_look = new Guna.UI2.WinForms.Guna2CheckBox();
            this.G_chk_Cscan = new Guna.UI2.WinForms.Guna2CheckBox();
            this.G_btn_cargar_SA = new Guna.UI2.WinForms.Guna2Button();
            this.frm_plot = new ScottPlot.WinForms.FormsPlot();
            this.G_btn_AnimarGrafico = new Guna.UI2.WinForms.Guna2Button();
            this.G_dgv_resultados = new Guna.UI2.WinForms.Guna2DataGridView();
            this.timer_animacion = new System.Windows.Forms.Timer(this.components);
            this.G_btn_close = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Panel_Modulo1.SuspendLayout();
            this.Panel_Modulo2.SuspendLayout();
            this.Panel_Grafico.SuspendLayout();
            this.Panel_Resultados.SuspendLayout();
            this.gbx_Algoritmos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.G_dgv_resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // guna_B_Frm_ASO
            // 
            this.guna_B_Frm_ASO.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.guna_B_Frm_ASO.ContainerControl = this;
            this.guna_B_Frm_ASO.DockIndicatorTransparencyValue = 0.6D;
            this.guna_B_Frm_ASO.TransparentWhileDrag = true;
            // 
            // Panel_Modulo1
            // 
            this.Panel_Modulo1.AutoRoundedCorners = true;
            this.Panel_Modulo1.Controls.Add(this.G_cmb_direccion);
            this.Panel_Modulo1.Controls.Add(this.G_txt_cabezal);
            this.Panel_Modulo1.Controls.Add(this.G_txt_cilindros);
            this.Panel_Modulo1.Controls.Add(this.G_btn_proceder);
            this.Panel_Modulo1.Controls.Add(this.guna2HtmlLabel4);
            this.Panel_Modulo1.Controls.Add(this.guna2HtmlLabel3);
            this.Panel_Modulo1.Controls.Add(this.guna2HtmlLabel2);
            this.Panel_Modulo1.FillColor = System.Drawing.Color.RosyBrown;
            this.Panel_Modulo1.FillColor3 = System.Drawing.Color.Gray;
            this.Panel_Modulo1.FillColor4 = System.Drawing.Color.Firebrick;
            this.Panel_Modulo1.Location = new System.Drawing.Point(12, 60);
            this.Panel_Modulo1.Name = "Panel_Modulo1";
            this.Panel_Modulo1.Size = new System.Drawing.Size(876, 101);
            this.Panel_Modulo1.TabIndex = 0;
            // 
            // Panel_Modulo2
            // 
            this.Panel_Modulo2.AutoRoundedCorners = true;
            this.Panel_Modulo2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.Panel_Modulo2.Controls.Add(this.G_btn_cargar_SA);
            this.Panel_Modulo2.Controls.Add(this.gbx_Algoritmos);
            this.Panel_Modulo2.Controls.Add(this.G_btn_generar_automartico);
            this.Panel_Modulo2.Controls.Add(this.G_btn_agg_manualmente);
            this.Panel_Modulo2.Controls.Add(this.G_txt_solicitudes);
            this.Panel_Modulo2.Controls.Add(this.guna2HtmlLabel5);
            this.Panel_Modulo2.FillColor = System.Drawing.Color.RosyBrown;
            this.Panel_Modulo2.FillColor3 = System.Drawing.Color.DarkGray;
            this.Panel_Modulo2.FillColor4 = System.Drawing.Color.Firebrick;
            this.Panel_Modulo2.Location = new System.Drawing.Point(12, 167);
            this.Panel_Modulo2.Name = "Panel_Modulo2";
            this.Panel_Modulo2.Size = new System.Drawing.Size(876, 173);
            this.Panel_Modulo2.TabIndex = 1;
            // 
            // Panel_Grafico
            // 
            this.Panel_Grafico.BorderRadius = 100;
            this.Panel_Grafico.Controls.Add(this.G_btn_AnimarGrafico);
            this.Panel_Grafico.Controls.Add(this.frm_plot);
            this.Panel_Grafico.Controls.Add(this.guna2HtmlLabel6);
            this.Panel_Grafico.FillColor = System.Drawing.Color.RosyBrown;
            this.Panel_Grafico.FillColor3 = System.Drawing.Color.Silver;
            this.Panel_Grafico.FillColor4 = System.Drawing.Color.Firebrick;
            this.Panel_Grafico.Location = new System.Drawing.Point(12, 346);
            this.Panel_Grafico.Name = "Panel_Grafico";
            this.Panel_Grafico.Size = new System.Drawing.Size(454, 416);
            this.Panel_Grafico.TabIndex = 2;
            // 
            // Panel_Resultados
            // 
            this.Panel_Resultados.BorderRadius = 100;
            this.Panel_Resultados.Controls.Add(this.G_dgv_resultados);
            this.Panel_Resultados.Controls.Add(this.guna2HtmlLabel7);
            this.Panel_Resultados.FillColor = System.Drawing.Color.RosyBrown;
            this.Panel_Resultados.FillColor3 = System.Drawing.Color.DarkGray;
            this.Panel_Resultados.FillColor4 = System.Drawing.Color.Firebrick;
            this.Panel_Resultados.Location = new System.Drawing.Point(472, 346);
            this.Panel_Resultados.Name = "Panel_Resultados";
            this.Panel_Resultados.Size = new System.Drawing.Size(416, 416);
            this.Panel_Resultados.TabIndex = 3;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(175, 20);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(579, 24);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "Simulacion de la comparacion de algoritmos de planificacion de discos";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(25, 3);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(73, 23);
            this.guna2HtmlLabel2.TabIndex = 5;
            this.guna2HtmlLabel2.Text = "Cilindros:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(279, 3);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(135, 23);
            this.guna2HtmlLabel3.TabIndex = 6;
            this.guna2HtmlLabel3.Text = "Posicion Cabezal:";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(605, 3);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(78, 23);
            this.guna2HtmlLabel4.TabIndex = 7;
            this.guna2HtmlLabel4.Text = "Direccion:";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(332, 3);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(204, 24);
            this.guna2HtmlLabel5.TabIndex = 5;
            this.guna2HtmlLabel5.Text = "Solicitudes y Algoritmos";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(189, 17);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(61, 24);
            this.guna2HtmlLabel6.TabIndex = 6;
            this.guna2HtmlLabel6.Text = "Grafico";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(116, 17);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(180, 24);
            this.guna2HtmlLabel7.TabIndex = 7;
            this.guna2HtmlLabel7.Text = "Resultados y Metricas";
            // 
            // G_btn_proceder
            // 
            this.G_btn_proceder.Animated = true;
            this.G_btn_proceder.AutoRoundedCorners = true;
            this.G_btn_proceder.BackColor = System.Drawing.Color.Transparent;
            this.G_btn_proceder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G_btn_proceder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G_btn_proceder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G_btn_proceder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G_btn_proceder.FillColor = System.Drawing.Color.LightSeaGreen;
            this.G_btn_proceder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.G_btn_proceder.ForeColor = System.Drawing.Color.Black;
            this.G_btn_proceder.Location = new System.Drawing.Point(320, 60);
            this.G_btn_proceder.Name = "G_btn_proceder";
            this.G_btn_proceder.Size = new System.Drawing.Size(254, 38);
            this.G_btn_proceder.TabIndex = 8;
            this.G_btn_proceder.Text = "Proceder";
            this.G_btn_proceder.UseTransparentBackground = true;
            this.G_btn_proceder.Click += new System.EventHandler(this.G_btn_proceder_Click);
            // 
            // G_txt_cilindros
            // 
            this.G_txt_cilindros.AutoRoundedCorners = true;
            this.G_txt_cilindros.BackColor = System.Drawing.Color.Transparent;
            this.G_txt_cilindros.BorderColor = System.Drawing.Color.Black;
            this.G_txt_cilindros.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.G_txt_cilindros.DefaultText = "";
            this.G_txt_cilindros.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.G_txt_cilindros.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.G_txt_cilindros.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.G_txt_cilindros.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.G_txt_cilindros.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_txt_cilindros.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.G_txt_cilindros.ForeColor = System.Drawing.Color.Black;
            this.G_txt_cilindros.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_txt_cilindros.Location = new System.Drawing.Point(104, 3);
            this.G_txt_cilindros.Name = "G_txt_cilindros";
            this.G_txt_cilindros.PlaceholderText = "Cantidad de Cilindros:";
            this.G_txt_cilindros.SelectedText = "";
            this.G_txt_cilindros.Size = new System.Drawing.Size(169, 36);
            this.G_txt_cilindros.TabIndex = 9;
            // 
            // G_txt_cabezal
            // 
            this.G_txt_cabezal.AutoRoundedCorners = true;
            this.G_txt_cabezal.BackColor = System.Drawing.Color.Transparent;
            this.G_txt_cabezal.BorderColor = System.Drawing.Color.Black;
            this.G_txt_cabezal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.G_txt_cabezal.DefaultText = "";
            this.G_txt_cabezal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.G_txt_cabezal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.G_txt_cabezal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.G_txt_cabezal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.G_txt_cabezal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_txt_cabezal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.G_txt_cabezal.ForeColor = System.Drawing.Color.Black;
            this.G_txt_cabezal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_txt_cabezal.Location = new System.Drawing.Point(420, 3);
            this.G_txt_cabezal.Name = "G_txt_cabezal";
            this.G_txt_cabezal.PlaceholderText = "Posicion inical del cabezal";
            this.G_txt_cabezal.SelectedText = "";
            this.G_txt_cabezal.Size = new System.Drawing.Size(179, 36);
            this.G_txt_cabezal.TabIndex = 10;
            // 
            // G_cmb_direccion
            // 
            this.G_cmb_direccion.AutoRoundedCorners = true;
            this.G_cmb_direccion.BackColor = System.Drawing.Color.Transparent;
            this.G_cmb_direccion.BorderColor = System.Drawing.Color.Black;
            this.G_cmb_direccion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.G_cmb_direccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.G_cmb_direccion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_cmb_direccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_cmb_direccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.G_cmb_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.G_cmb_direccion.ItemHeight = 30;
            this.G_cmb_direccion.Items.AddRange(new object[] {
            "Derecha",
            "Izquierda"});
            this.G_cmb_direccion.Location = new System.Drawing.Point(689, 3);
            this.G_cmb_direccion.Name = "G_cmb_direccion";
            this.G_cmb_direccion.Size = new System.Drawing.Size(140, 36);
            this.G_cmb_direccion.StartIndex = 0;
            this.G_cmb_direccion.TabIndex = 11;
            // 
            // G_txt_solicitudes
            // 
            this.G_txt_solicitudes.AutoRoundedCorners = true;
            this.G_txt_solicitudes.BackColor = System.Drawing.Color.Transparent;
            this.G_txt_solicitudes.BorderColor = System.Drawing.Color.Black;
            this.G_txt_solicitudes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.G_txt_solicitudes.DefaultText = "";
            this.G_txt_solicitudes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.G_txt_solicitudes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.G_txt_solicitudes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.G_txt_solicitudes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.G_txt_solicitudes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_txt_solicitudes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.G_txt_solicitudes.ForeColor = System.Drawing.Color.Black;
            this.G_txt_solicitudes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_txt_solicitudes.Location = new System.Drawing.Point(25, 74);
            this.G_txt_solicitudes.Name = "G_txt_solicitudes";
            this.G_txt_solicitudes.PlaceholderText = "Cantidad de Cilindros:";
            this.G_txt_solicitudes.SelectedText = "";
            this.G_txt_solicitudes.Size = new System.Drawing.Size(325, 82);
            this.G_txt_solicitudes.TabIndex = 11;
            // 
            // G_btn_agg_manualmente
            // 
            this.G_btn_agg_manualmente.Animated = true;
            this.G_btn_agg_manualmente.AutoRoundedCorners = true;
            this.G_btn_agg_manualmente.BackColor = System.Drawing.Color.Transparent;
            this.G_btn_agg_manualmente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G_btn_agg_manualmente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G_btn_agg_manualmente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G_btn_agg_manualmente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G_btn_agg_manualmente.FillColor = System.Drawing.Color.LightSeaGreen;
            this.G_btn_agg_manualmente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.G_btn_agg_manualmente.ForeColor = System.Drawing.Color.Black;
            this.G_btn_agg_manualmente.Location = new System.Drawing.Point(25, 30);
            this.G_btn_agg_manualmente.Name = "G_btn_agg_manualmente";
            this.G_btn_agg_manualmente.Size = new System.Drawing.Size(159, 38);
            this.G_btn_agg_manualmente.TabIndex = 12;
            this.G_btn_agg_manualmente.Text = "Agregar Manualmente";
            this.G_btn_agg_manualmente.UseTransparentBackground = true;
            this.G_btn_agg_manualmente.Click += new System.EventHandler(this.G_btn_agg_manualmente_Click);
            // 
            // G_btn_generar_automartico
            // 
            this.G_btn_generar_automartico.Animated = true;
            this.G_btn_generar_automartico.AutoRoundedCorners = true;
            this.G_btn_generar_automartico.BackColor = System.Drawing.Color.Transparent;
            this.G_btn_generar_automartico.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G_btn_generar_automartico.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G_btn_generar_automartico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G_btn_generar_automartico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G_btn_generar_automartico.FillColor = System.Drawing.Color.LightSeaGreen;
            this.G_btn_generar_automartico.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.G_btn_generar_automartico.ForeColor = System.Drawing.Color.Black;
            this.G_btn_generar_automartico.Location = new System.Drawing.Point(191, 30);
            this.G_btn_generar_automartico.Name = "G_btn_generar_automartico";
            this.G_btn_generar_automartico.Size = new System.Drawing.Size(159, 38);
            this.G_btn_generar_automartico.TabIndex = 13;
            this.G_btn_generar_automartico.Text = "Generar Automaticamente";
            this.G_btn_generar_automartico.UseTransparentBackground = true;
            this.G_btn_generar_automartico.Click += new System.EventHandler(this.G_btn_generar_automartico_Click);
            // 
            // gbx_Algoritmos
            // 
            this.gbx_Algoritmos.BackColor = System.Drawing.Color.Transparent;
            this.gbx_Algoritmos.BorderColor = System.Drawing.Color.Black;
            this.gbx_Algoritmos.BorderRadius = 15;
            this.gbx_Algoritmos.Controls.Add(this.G_chk_Clook);
            this.gbx_Algoritmos.Controls.Add(this.G_chk_look);
            this.gbx_Algoritmos.Controls.Add(this.G_chk_Cscan);
            this.gbx_Algoritmos.Controls.Add(this.G_chk_scan);
            this.gbx_Algoritmos.Controls.Add(this.G_chk_sstf);
            this.gbx_Algoritmos.Controls.Add(this.G_chk_fcfs);
            this.gbx_Algoritmos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbx_Algoritmos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbx_Algoritmos.Location = new System.Drawing.Point(383, 33);
            this.gbx_Algoritmos.Name = "gbx_Algoritmos";
            this.gbx_Algoritmos.Size = new System.Drawing.Size(266, 135);
            this.gbx_Algoritmos.TabIndex = 14;
            this.gbx_Algoritmos.Text = "Algoritmos";
            this.gbx_Algoritmos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // G_chk_fcfs
            // 
            this.G_chk_fcfs.AutoSize = true;
            this.G_chk_fcfs.Checked = true;
            this.G_chk_fcfs.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_chk_fcfs.CheckedState.BorderRadius = 0;
            this.G_chk_fcfs.CheckedState.BorderThickness = 0;
            this.G_chk_fcfs.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_chk_fcfs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.G_chk_fcfs.Location = new System.Drawing.Point(14, 52);
            this.G_chk_fcfs.Name = "G_chk_fcfs";
            this.G_chk_fcfs.Size = new System.Drawing.Size(52, 19);
            this.G_chk_fcfs.TabIndex = 0;
            this.G_chk_fcfs.Text = "FCFS";
            this.G_chk_fcfs.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.G_chk_fcfs.UncheckedState.BorderRadius = 0;
            this.G_chk_fcfs.UncheckedState.BorderThickness = 0;
            this.G_chk_fcfs.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // G_chk_sstf
            // 
            this.G_chk_sstf.AutoSize = true;
            this.G_chk_sstf.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_chk_sstf.CheckedState.BorderRadius = 0;
            this.G_chk_sstf.CheckedState.BorderThickness = 0;
            this.G_chk_sstf.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_chk_sstf.Location = new System.Drawing.Point(14, 77);
            this.G_chk_sstf.Name = "G_chk_sstf";
            this.G_chk_sstf.Size = new System.Drawing.Size(51, 19);
            this.G_chk_sstf.TabIndex = 1;
            this.G_chk_sstf.Text = "SSTF";
            this.G_chk_sstf.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.G_chk_sstf.UncheckedState.BorderRadius = 0;
            this.G_chk_sstf.UncheckedState.BorderThickness = 0;
            this.G_chk_sstf.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // G_chk_scan
            // 
            this.G_chk_scan.AutoSize = true;
            this.G_chk_scan.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_chk_scan.CheckedState.BorderRadius = 0;
            this.G_chk_scan.CheckedState.BorderThickness = 0;
            this.G_chk_scan.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_chk_scan.Location = new System.Drawing.Point(14, 102);
            this.G_chk_scan.Name = "G_chk_scan";
            this.G_chk_scan.Size = new System.Drawing.Size(57, 19);
            this.G_chk_scan.TabIndex = 2;
            this.G_chk_scan.Text = "SCAN";
            this.G_chk_scan.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.G_chk_scan.UncheckedState.BorderRadius = 0;
            this.G_chk_scan.UncheckedState.BorderThickness = 0;
            this.G_chk_scan.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // G_chk_Clook
            // 
            this.G_chk_Clook.AutoSize = true;
            this.G_chk_Clook.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_chk_Clook.CheckedState.BorderRadius = 0;
            this.G_chk_Clook.CheckedState.BorderThickness = 0;
            this.G_chk_Clook.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_chk_Clook.Location = new System.Drawing.Point(127, 102);
            this.G_chk_Clook.Name = "G_chk_Clook";
            this.G_chk_Clook.Size = new System.Drawing.Size(70, 19);
            this.G_chk_Clook.TabIndex = 5;
            this.G_chk_Clook.Text = "C-LOOK";
            this.G_chk_Clook.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.G_chk_Clook.UncheckedState.BorderRadius = 0;
            this.G_chk_Clook.UncheckedState.BorderThickness = 0;
            this.G_chk_Clook.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // G_chk_look
            // 
            this.G_chk_look.AutoSize = true;
            this.G_chk_look.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_chk_look.CheckedState.BorderRadius = 0;
            this.G_chk_look.CheckedState.BorderThickness = 0;
            this.G_chk_look.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_chk_look.Location = new System.Drawing.Point(127, 77);
            this.G_chk_look.Name = "G_chk_look";
            this.G_chk_look.Size = new System.Drawing.Size(57, 19);
            this.G_chk_look.TabIndex = 4;
            this.G_chk_look.Text = "LOOK";
            this.G_chk_look.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.G_chk_look.UncheckedState.BorderRadius = 0;
            this.G_chk_look.UncheckedState.BorderThickness = 0;
            this.G_chk_look.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // G_chk_Cscan
            // 
            this.G_chk_Cscan.AutoSize = true;
            this.G_chk_Cscan.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_chk_Cscan.CheckedState.BorderRadius = 0;
            this.G_chk_Cscan.CheckedState.BorderThickness = 0;
            this.G_chk_Cscan.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G_chk_Cscan.Location = new System.Drawing.Point(127, 52);
            this.G_chk_Cscan.Name = "G_chk_Cscan";
            this.G_chk_Cscan.Size = new System.Drawing.Size(70, 19);
            this.G_chk_Cscan.TabIndex = 3;
            this.G_chk_Cscan.Text = "C-SCAN";
            this.G_chk_Cscan.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.G_chk_Cscan.UncheckedState.BorderRadius = 0;
            this.G_chk_Cscan.UncheckedState.BorderThickness = 0;
            this.G_chk_Cscan.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // G_btn_cargar_SA
            // 
            this.G_btn_cargar_SA.Animated = true;
            this.G_btn_cargar_SA.AutoRoundedCorners = true;
            this.G_btn_cargar_SA.BackColor = System.Drawing.Color.Transparent;
            this.G_btn_cargar_SA.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G_btn_cargar_SA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G_btn_cargar_SA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G_btn_cargar_SA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G_btn_cargar_SA.FillColor = System.Drawing.Color.LightSeaGreen;
            this.G_btn_cargar_SA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.G_btn_cargar_SA.ForeColor = System.Drawing.Color.Black;
            this.G_btn_cargar_SA.Location = new System.Drawing.Point(718, 17);
            this.G_btn_cargar_SA.Name = "G_btn_cargar_SA";
            this.G_btn_cargar_SA.Size = new System.Drawing.Size(134, 126);
            this.G_btn_cargar_SA.TabIndex = 12;
            this.G_btn_cargar_SA.Text = "Cargar Solicitudes y Algoritmos";
            this.G_btn_cargar_SA.UseTransparentBackground = true;
            this.G_btn_cargar_SA.Click += new System.EventHandler(this.G_btn_cargar_SA_Click);
            // 
            // frm_plot
            // 
            this.frm_plot.Location = new System.Drawing.Point(15, 62);
            this.frm_plot.Name = "frm_plot";
            this.frm_plot.Size = new System.Drawing.Size(422, 298);
            this.frm_plot.TabIndex = 7;
            // 
            // G_btn_AnimarGrafico
            // 
            this.G_btn_AnimarGrafico.Animated = true;
            this.G_btn_AnimarGrafico.AutoRoundedCorners = true;
            this.G_btn_AnimarGrafico.BackColor = System.Drawing.Color.Transparent;
            this.G_btn_AnimarGrafico.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G_btn_AnimarGrafico.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G_btn_AnimarGrafico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G_btn_AnimarGrafico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G_btn_AnimarGrafico.FillColor = System.Drawing.Color.LightSeaGreen;
            this.G_btn_AnimarGrafico.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.G_btn_AnimarGrafico.ForeColor = System.Drawing.Color.Black;
            this.G_btn_AnimarGrafico.Location = new System.Drawing.Point(96, 375);
            this.G_btn_AnimarGrafico.Name = "G_btn_AnimarGrafico";
            this.G_btn_AnimarGrafico.Size = new System.Drawing.Size(254, 38);
            this.G_btn_AnimarGrafico.TabIndex = 9;
            this.G_btn_AnimarGrafico.Text = "Animar grafico";
            this.G_btn_AnimarGrafico.UseTransparentBackground = true;
            this.G_btn_AnimarGrafico.Click += new System.EventHandler(this.G_btn_AnimarGrafico_Click);
            // 
            // G_dgv_resultados
            // 
            this.G_dgv_resultados.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.G_dgv_resultados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.G_dgv_resultados.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.G_dgv_resultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.G_dgv_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.G_dgv_resultados.DefaultCellStyle = dataGridViewCellStyle6;
            this.G_dgv_resultados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.G_dgv_resultados.Location = new System.Drawing.Point(30, 77);
            this.G_dgv_resultados.Name = "G_dgv_resultados";
            this.G_dgv_resultados.Size = new System.Drawing.Size(362, 150);
            this.G_dgv_resultados.TabIndex = 8;
            this.G_dgv_resultados.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.G_dgv_resultados.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.G_dgv_resultados.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G_dgv_resultados.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.G_dgv_resultados.ThemeStyle.HeaderStyle.Height = 4;
            this.G_dgv_resultados.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // timer_animacion
            // 
            this.timer_animacion.Tick += new System.EventHandler(this.timer_animacion_Tick);
            // 
            // G_btn_close
            // 
            this.G_btn_close.Animated = true;
            this.G_btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G_btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G_btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G_btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G_btn_close.FillColor = System.Drawing.Color.Red;
            this.G_btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.G_btn_close.ForeColor = System.Drawing.Color.White;
            this.G_btn_close.HoverState.BorderColor = System.Drawing.Color.Red;
            this.G_btn_close.HoverState.FillColor = System.Drawing.Color.White;
            this.G_btn_close.HoverState.ForeColor = System.Drawing.Color.Black;
            this.G_btn_close.Location = new System.Drawing.Point(853, 12);
            this.G_btn_close.Name = "G_btn_close";
            this.G_btn_close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.G_btn_close.Size = new System.Drawing.Size(35, 42);
            this.G_btn_close.TabIndex = 5;
            this.G_btn_close.Text = "X";
            this.G_btn_close.Click += new System.EventHandler(this.G_btn_close_Click);
            // 
            // Frm_ASO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 787);
            this.Controls.Add(this.G_btn_close);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.Panel_Resultados);
            this.Controls.Add(this.Panel_Grafico);
            this.Controls.Add(this.Panel_Modulo2);
            this.Controls.Add(this.Panel_Modulo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(900, 790);
            this.MinimumSize = new System.Drawing.Size(900, 726);
            this.Name = "Frm_ASO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_ASO_Load);
            this.Panel_Modulo1.ResumeLayout(false);
            this.Panel_Modulo1.PerformLayout();
            this.Panel_Modulo2.ResumeLayout(false);
            this.Panel_Modulo2.PerformLayout();
            this.Panel_Grafico.ResumeLayout(false);
            this.Panel_Grafico.PerformLayout();
            this.Panel_Resultados.ResumeLayout(false);
            this.Panel_Resultados.PerformLayout();
            this.gbx_Algoritmos.ResumeLayout(false);
            this.gbx_Algoritmos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.G_dgv_resultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna_B_Frm_ASO;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Panel_Modulo1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Panel_Resultados;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Panel_Grafico;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Panel_Modulo2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2Button G_btn_proceder;
        private Guna.UI2.WinForms.Guna2TextBox G_txt_cabezal;
        private Guna.UI2.WinForms.Guna2TextBox G_txt_cilindros;
        private Guna.UI2.WinForms.Guna2ComboBox G_cmb_direccion;
        private Guna.UI2.WinForms.Guna2TextBox G_txt_solicitudes;
        private Guna.UI2.WinForms.Guna2GroupBox gbx_Algoritmos;
        private Guna.UI2.WinForms.Guna2Button G_btn_generar_automartico;
        private Guna.UI2.WinForms.Guna2Button G_btn_agg_manualmente;
        private Guna.UI2.WinForms.Guna2CheckBox G_chk_Clook;
        private Guna.UI2.WinForms.Guna2CheckBox G_chk_look;
        private Guna.UI2.WinForms.Guna2CheckBox G_chk_Cscan;
        private Guna.UI2.WinForms.Guna2CheckBox G_chk_scan;
        private Guna.UI2.WinForms.Guna2CheckBox G_chk_sstf;
        private Guna.UI2.WinForms.Guna2CheckBox G_chk_fcfs;
        private Guna.UI2.WinForms.Guna2Button G_btn_cargar_SA;
        private Guna.UI2.WinForms.Guna2Button G_btn_AnimarGrafico;
        private ScottPlot.WinForms.FormsPlot frm_plot;
        private Guna.UI2.WinForms.Guna2DataGridView G_dgv_resultados;
        private System.Windows.Forms.Timer timer_animacion;
        private Guna.UI2.WinForms.Guna2CircleButton G_btn_close;
    }
}

