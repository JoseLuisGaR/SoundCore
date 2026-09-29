namespace SoundCore.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.pnlRegistro = new Panel();
            this.lblTitulo = new Label();
            this.txtTitulo = new TextBox();
            this.lblArtista = new Label();
            this.txtArtista = new TextBox();
            this.lblBpm = new Label();
            this.numBpm = new NumericUpDown();
            this.lblDuracion = new Label();
            this.numDuracion = new NumericUpDown();
            this.lblModo = new Label();
            this.rbPropia = new RadioButton();
            this.rbLinkedList = new RadioButton();
            this.rbList = new RadioButton();

            this.pnlAcciones = new Panel();
            this.btnEncolarFinal = new Button();
            this.btnReproducirSiguiente = new Button();
            this.btnAvanzar = new Button();
            this.btnInvertir = new Button();
            this.btnOrdenarBpm = new Button();
            this.btnPurgar = new Button();

            this.pnlPlaylist = new Panel();
            this.lblNowPlaying = new Label();
            this.dgvCola = new DataGridView();
            this.lblEstadisticas = new Label();

            this.pnlBenchmark = new Panel();
            this.lblCantidadPrueba = new Label();
            this.numCantidadPrueba = new NumericUpDown();
            this.btnBenchmark = new Button();
            this.txtResultadosBenchmark = new TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.numBpm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadPrueba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.SuspendLayout();

            // ===================== pnlRegistro =====================
            this.pnlRegistro.Dock = DockStyle.Top;
            this.pnlRegistro.Height = 90;
            this.pnlRegistro.Padding = new Padding(10);

            this.lblTitulo.Location = new Point(10, 15);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Text = "Título:";

            this.txtTitulo.Location = new Point(65, 12);
            this.txtTitulo.Width = 160;

            this.lblArtista.Location = new Point(235, 15);
            this.lblArtista.AutoSize = true;
            this.lblArtista.Text = "Artista:";

            this.txtArtista.Location = new Point(290, 12);
            this.txtArtista.Width = 160;

            this.lblBpm.Location = new Point(465, 15);
            this.lblBpm.AutoSize = true;
            this.lblBpm.Text = "BPM:";

            this.numBpm.Location = new Point(510, 12);
            this.numBpm.Width = 70;
            this.numBpm.Minimum = 60;
            this.numBpm.Maximum = 220;
            this.numBpm.Value = 124;

            this.lblDuracion.Location = new Point(595, 15);
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Text = "Duración (s):";

            this.numDuracion.Location = new Point(680, 12);
            this.numDuracion.Width = 80;
            this.numDuracion.Minimum = 1;
            this.numDuracion.Maximum = 3600;
            this.numDuracion.Value = 210;

            this.lblModo.Location = new Point(10, 50);
            this.lblModo.AutoSize = true;
            this.lblModo.Text = "Modo de Estructura:";

            this.rbPropia.Location = new Point(150, 48);
            this.rbPropia.AutoSize = true;
            this.rbPropia.Text = "Lista Simple Propia (Nodos)";
            this.rbPropia.Checked = true;
            this.rbPropia.CheckedChanged += new EventHandler(this.rbEstructura_CheckedChanged);

            this.rbLinkedList.Location = new Point(370, 48);
            this.rbLinkedList.AutoSize = true;
            this.rbLinkedList.Text = ".NET LinkedList<T>";
            this.rbLinkedList.CheckedChanged += new EventHandler(this.rbEstructura_CheckedChanged);

            this.rbList.Location = new Point(540, 48);
            this.rbList.AutoSize = true;
            this.rbList.Text = ".NET List<T>";
            this.rbList.CheckedChanged += new EventHandler(this.rbEstructura_CheckedChanged);

            this.pnlRegistro.Controls.Add(this.lblTitulo);
            this.pnlRegistro.Controls.Add(this.txtTitulo);
            this.pnlRegistro.Controls.Add(this.lblArtista);
            this.pnlRegistro.Controls.Add(this.txtArtista);
            this.pnlRegistro.Controls.Add(this.lblBpm);
            this.pnlRegistro.Controls.Add(this.numBpm);
            this.pnlRegistro.Controls.Add(this.lblDuracion);
            this.pnlRegistro.Controls.Add(this.numDuracion);
            this.pnlRegistro.Controls.Add(this.lblModo);
            this.pnlRegistro.Controls.Add(this.rbPropia);
            this.pnlRegistro.Controls.Add(this.rbLinkedList);
            this.pnlRegistro.Controls.Add(this.rbList);

            // ===================== pnlAcciones =====================
            this.pnlAcciones.Dock = DockStyle.Left;
            this.pnlAcciones.Width = 220;
            this.pnlAcciones.Padding = new Padding(10);

            this.btnEncolarFinal.Text = "+ Encolar al Final";
            this.btnEncolarFinal.Location = new Point(15, 15);
            this.btnEncolarFinal.Size = new Size(190, 32);
            this.btnEncolarFinal.Click += new EventHandler(this.btnEncolarFinal_Click);

            this.btnReproducirSiguiente.Text = "⏭ Reproducir Siguiente";
            this.btnReproducirSiguiente.Location = new Point(15, 55);
            this.btnReproducirSiguiente.Size = new Size(190, 32);
            this.btnReproducirSiguiente.Click += new EventHandler(this.btnReproducirSiguiente_Click);

            this.btnAvanzar.Text = "⏩ Avanzar Pista";
            this.btnAvanzar.Location = new Point(15, 95);
            this.btnAvanzar.Size = new Size(190, 32);
            this.btnAvanzar.Click += new EventHandler(this.btnAvanzar_Click);

            this.btnInvertir.Text = "⇅ Invertir Lista (In-Place)";
            this.btnInvertir.Location = new Point(15, 135);
            this.btnInvertir.Size = new Size(190, 32);
            this.btnInvertir.Click += new EventHandler(this.btnInvertir_Click);

            this.btnOrdenarBpm.Text = "⚡ Ordenar por Curva BPM";
            this.btnOrdenarBpm.Location = new Point(15, 175);
            this.btnOrdenarBpm.Size = new Size(190, 32);
            this.btnOrdenarBpm.Click += new EventHandler(this.btnOrdenarBpm_Click);

            this.btnPurgar.Text = "🧹 Purgar Duplicados";
            this.btnPurgar.Location = new Point(15, 215);
            this.btnPurgar.Size = new Size(190, 32);
            this.btnPurgar.Click += new EventHandler(this.btnPurgar_Click);

            this.pnlAcciones.Controls.Add(this.btnEncolarFinal);
            this.pnlAcciones.Controls.Add(this.btnReproducirSiguiente);
            this.pnlAcciones.Controls.Add(this.btnAvanzar);
            this.pnlAcciones.Controls.Add(this.btnInvertir);
            this.pnlAcciones.Controls.Add(this.btnOrdenarBpm);
            this.pnlAcciones.Controls.Add(this.btnPurgar);

            // ===================== pnlPlaylist =====================
            this.pnlPlaylist.Dock = DockStyle.Fill;
            this.pnlPlaylist.Padding = new Padding(10);

            this.lblNowPlaying.Dock = DockStyle.Top;
            this.lblNowPlaying.Height = 30;
            this.lblNowPlaying.Font = new Font(this.Font, FontStyle.Bold);
            this.lblNowPlaying.Text = "▶ Sonando: (sin pista actual)";

            this.lblEstadisticas.Dock = DockStyle.Bottom;
            this.lblEstadisticas.Height = 24;
            this.lblEstadisticas.Text = "Total en cola: 0 | Tiempo total: 00:00";

            this.dgvCola.Dock = DockStyle.Fill;
            this.dgvCola.ReadOnly = true;
            this.dgvCola.AllowUserToAddRows = false;
            this.dgvCola.AllowUserToDeleteRows = false;
            this.dgvCola.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCola.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvCola.ColumnCount = 5;
            this.dgvCola.Columns[0].Name = "Pos";
            this.dgvCola.Columns[1].Name = "ID";
            this.dgvCola.Columns[2].Name = "Título / Artista";
            this.dgvCola.Columns[3].Name = "BPM";
            this.dgvCola.Columns[4].Name = "Duración";

            this.pnlPlaylist.Controls.Add(this.dgvCola);
            this.pnlPlaylist.Controls.Add(this.lblEstadisticas);
            this.pnlPlaylist.Controls.Add(this.lblNowPlaying);

            // ===================== pnlBenchmark =====================
            this.pnlBenchmark.Dock = DockStyle.Bottom;
            this.pnlBenchmark.Height = 220;
            this.pnlBenchmark.Padding = new Padding(10);

            this.lblCantidadPrueba.Location = new Point(10, 15);
            this.lblCantidadPrueba.AutoSize = true;
            this.lblCantidadPrueba.Text = "Cantidad de pistas para test de estrés:";

            this.numCantidadPrueba.Location = new Point(260, 12);
            this.numCantidadPrueba.Width = 100;
            this.numCantidadPrueba.Minimum = 100;
            this.numCantidadPrueba.Maximum = 200000;
            this.numCantidadPrueba.Increment = 500;
            this.numCantidadPrueba.Value = 25000;

            this.btnBenchmark.Text = "🚀 Iniciar Prueba de Rendimiento";
            this.btnBenchmark.Location = new Point(380, 10);
            this.btnBenchmark.Size = new Size(230, 30);
            this.btnBenchmark.Click += new EventHandler(this.btnBenchmark_Click);

            this.txtResultadosBenchmark.Location = new Point(10, 50);
            this.txtResultadosBenchmark.Size = new Size(950, 150);
            this.txtResultadosBenchmark.Multiline = true;
            this.txtResultadosBenchmark.ReadOnly = true;
            this.txtResultadosBenchmark.ScrollBars = ScrollBars.Vertical;
            this.txtResultadosBenchmark.Font = new Font("Consolas", 9F);
            this.txtResultadosBenchmark.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            this.pnlBenchmark.Controls.Add(this.txtResultadosBenchmark);
            this.pnlBenchmark.Controls.Add(this.lblCantidadPrueba);
            this.pnlBenchmark.Controls.Add(this.numCantidadPrueba);
            this.pnlBenchmark.Controls.Add(this.btnBenchmark);

            // ===================== MainForm =====================
            this.ClientSize = new Size(1000, 650);
            this.MinimumSize = new Size(900, 600);
            this.Text = "SoundCore Engine v2.0 - DJ Set Controller [TecNM Monclova]";

            this.Controls.Add(this.pnlPlaylist);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.pnlBenchmark);
            this.Controls.Add(this.pnlRegistro);

            ((System.ComponentModel.ISupportInitialize)(this.numBpm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadPrueba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Panel pnlRegistro;
        private Label lblTitulo;
        private TextBox txtTitulo;
        private Label lblArtista;
        private TextBox txtArtista;
        private Label lblBpm;
        private NumericUpDown numBpm;
        private Label lblDuracion;
        private NumericUpDown numDuracion;
        private Label lblModo;
        private RadioButton rbPropia;
        private RadioButton rbLinkedList;
        private RadioButton rbList;

        private Panel pnlAcciones;
        private Button btnEncolarFinal;
        private Button btnReproducirSiguiente;
        private Button btnAvanzar;
        private Button btnInvertir;
        private Button btnOrdenarBpm;
        private Button btnPurgar;

        private Panel pnlPlaylist;
        private Label lblNowPlaying;
        private DataGridView dgvCola;
        private Label lblEstadisticas;

        private Panel pnlBenchmark;
        private Label lblCantidadPrueba;
        private NumericUpDown numCantidadPrueba;
        private Button btnBenchmark;
        private TextBox txtResultadosBenchmark;
    }
}
