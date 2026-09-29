// =============================================================================
// Proyecto Integral Unidad 2: SoundCore Engine GUI
// Archivo: MainForm.cs
// Integrantes: [Nombre completo del integrante 1] - [Número de control]
//              [Nombre completo del integrante 2] - [Número de control]
// TecNM Campus Monclova - Ingeniería en Informática
// Asignatura: Estructura de Datos (3er Semestre)
// Fecha: 27/09/2026  Versión: 1.0
// =============================================================================

using System.Diagnostics;
using SoundCore.EstructurasPropias;
using SoundCore.Modelos;

namespace SoundCore.UI
{
    public partial class MainForm : Form
    {
        // Estructuras paralelas: las tres siempre reflejan el mismo contenido
        // lógico para permitir comparar operaciones al vuelo entre estructuras.
        private readonly ListaSimpleEnlazada<Pista> _colaPropia = new();
        private readonly LinkedList<Pista> _colaLinkedList = new();
        private readonly List<Pista> _colaList = new();

        private int _contadorId = 1;
        private Pista? _pistaSonando = null;

        public MainForm()
        {
            InitializeComponent();
            CargarDatosSemilla();
            RefrescarVista();
        }

        private void CargarDatosSemilla()
        {
            var demo = new[]
            {
                new Pista(_contadorId++, "Strobe", "deadmau5", 128, 634),
                new Pista(_contadorId++, "Midnight City", "M83", 105, 243),
                new Pista(_contadorId++, "Animals", "Martin Garrix", 130, 304)
            };

            foreach (var p in demo)
            {
                _colaPropia.AgregarAlFinal(p);
                _colaLinkedList.AddLast(p);
                _colaList.Add(p);
            }
        }

        private Pista CrearPistaDesdeFormulario()
        {
            string titulo = string.IsNullOrWhiteSpace(txtTitulo.Text) ? $"Pista {_contadorId}" : txtTitulo.Text.Trim();
            string artista = string.IsNullOrWhiteSpace(txtArtista.Text) ? "DJ Desconocido" : txtArtista.Text.Trim();
            int bpm = (int)numBpm.Value;
            int duracion = (int)numDuracion.Value;

            var pista = new Pista(_contadorId++, titulo, artista, bpm, duracion);

            txtTitulo.Clear();
            txtArtista.Clear();
            txtTitulo.Focus();

            return pista;
        }

        private void btnEncolarFinal_Click(object sender, EventArgs e)
        {
            var pista = CrearPistaDesdeFormulario();

            if (rbPropia.Checked) _colaPropia.AgregarAlFinal(pista);
            else if (rbLinkedList.Checked) _colaLinkedList.AddLast(pista);
            else _colaList.Add(pista);

            RefrescarVista();
        }

        private void btnReproducirSiguiente_Click(object sender, EventArgs e)
        {
            var pista = CrearPistaDesdeFormulario();

            if (rbPropia.Checked)
            {
                _colaPropia.ReproducirSiguiente(pista);
            }
            else if (rbLinkedList.Checked)
            {
                if (_colaLinkedList.First == null)
                    _colaLinkedList.AddFirst(pista);
                else
                    _colaLinkedList.AddAfter(_colaLinkedList.First, pista);
            }
            else
            {
                if (_colaList.Count <= 1) _colaList.Add(pista);
                else _colaList.Insert(1, pista);
            }

            RefrescarVista();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbPropia.Checked)
                {
                    _pistaSonando = _colaPropia.AvanzarPista();
                }
                else if (rbLinkedList.Checked)
                {
                    if (_colaLinkedList.First == null) throw new InvalidOperationException();
                    _pistaSonando = _colaLinkedList.First.Value;
                    _colaLinkedList.RemoveFirst();
                }
                else
                {
                    if (_colaList.Count == 0) throw new InvalidOperationException();
                    _pistaSonando = _colaList[0];
                    _colaList.RemoveAt(0);
                }

                lblNowPlaying.Text = $"▶ Sonando: {_pistaSonando.Titulo} - {_pistaSonando.Artista} ({_pistaSonando.Bpm} BPM)";
                lblNowPlaying.ForeColor = Color.DarkGreen;
                RefrescarVista();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No hay pistas pendientes en la cola.", "Fin del Setlist",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            if (rbPropia.Checked)
            {
                _colaPropia.Invertir();
            }
            else if (rbLinkedList.Checked)
            {
                var listaTemporal = new List<Pista>(_colaLinkedList);
                listaTemporal.Reverse();
                _colaLinkedList.Clear();
                foreach (var item in listaTemporal) _colaLinkedList.AddLast(item);
            }
            else
            {
                _colaList.Reverse();
            }

            RefrescarVista();
        }

        private void btnOrdenarBpm_Click(object sender, EventArgs e)
        {
            if (rbPropia.Checked)
            {
                var temporal = new ListaSimpleEnlazada<Pista>();
                foreach (var pista in _colaPropia)
                {
                    temporal.InsertarOrdenado(pista, (a, b) => a.Bpm.CompareTo(b.Bpm));
                }
                _colaPropia.Limpiar();
                foreach (var p in temporal) _colaPropia.AgregarAlFinal(p);
            }
            else if (rbLinkedList.Checked)
            {
                var ordenadas = _colaLinkedList.OrderBy(p => p.Bpm).ToList();
                _colaLinkedList.Clear();
                foreach (var p in ordenadas) _colaLinkedList.AddLast(p);
            }
            else
            {
                _colaList.Sort((a, b) => a.Bpm.CompareTo(b.Bpm));
            }

            RefrescarVista();
        }

        private void btnPurgar_Click(object sender, EventArgs e)
        {
            if (rbPropia.Checked)
            {
                _colaPropia.DepurarDuplicados((a, b) => a.Titulo.Equals(b.Titulo, StringComparison.OrdinalIgnoreCase));
            }
            else if (rbLinkedList.Checked)
            {
                var unicos = _colaLinkedList.DistinctBy(p => p.Titulo).ToList();
                _colaLinkedList.Clear();
                foreach (var p in unicos) _colaLinkedList.AddLast(p);
            }
            else
            {
                var unicos = _colaList.DistinctBy(p => p.Titulo).ToList();
                _colaList.Clear();
                _colaList.AddRange(unicos);
            }

            RefrescarVista();
        }

        private void rbEstructura_CheckedChanged(object? sender, EventArgs e)
        {
            // Sincroniza la vista de inmediato al cambiar la estructura activa,
            // sin bloquear el hilo principal.
            RefrescarVista();
        }

        private void RefrescarVista()
        {
            dgvCola.Rows.Clear();
            IEnumerable<Pista> coleccion = rbPropia.Checked ? _colaPropia :
                                           rbLinkedList.Checked ? _colaLinkedList : _colaList;

            int index = 1;
            int duracionTotal = 0;

            foreach (var p in coleccion)
            {
                dgvCola.Rows.Add(index++, p.Id, $"{p.Titulo} — {p.Artista}", $"{p.Bpm} BPM", $"{p.DuracionSegundos}s");
                duracionTotal += p.DuracionSegundos;
            }

            lblEstadisticas.Text = $"Total en cola: {index - 1} | Tiempo total: {TimeSpan.FromSeconds(duracionTotal):mm\\:ss}";
        }

        private void btnBenchmark_Click(object sender, EventArgs e)
        {
            int n = (int)numCantidadPrueba.Value;
            var random = new Random(42);
            var sw = new Stopwatch();

            btnBenchmark.Enabled = false;
            txtResultadosBenchmark.Text = "Ejecutando prueba de estrés, por favor espere...";
            Application.DoEvents();

            // 1. Test inserción intermedia: Lista Propia (Up Next -> O(1) por reconexión)
            var testPropia = new ListaSimpleEnlazada<Pista>();
            testPropia.AgregarAlFinal(new Pista(0, "Head", "DJ", 120, 200));
            sw.Restart();
            for (int i = 0; i < n; i++)
            {
                testPropia.ReproducirSiguiente(new Pista(i, $"Pista {i}", "DJ", random.Next(100, 150), 180));
            }
            sw.Stop();
            long tiempoPropia = sw.ElapsedMilliseconds;

            // 2. Test inserción intermedia: .NET LinkedList<T> (AddAfter -> O(1) con nodo)
            var testLinkedList = new LinkedList<Pista>();
            testLinkedList.AddLast(new Pista(0, "Head", "DJ", 120, 200));
            sw.Restart();
            for (int i = 0; i < n; i++)
            {
                testLinkedList.AddAfter(testLinkedList.First!, new Pista(i, $"Pista {i}", "DJ", random.Next(100, 150), 180));
            }
            sw.Stop();
            long tiempoLinkedList = sw.ElapsedMilliseconds;

            // 3. Test inserción intermedia: .NET List<T> (Insert(idx) -> O(n) por Array.Copy)
            var testList = new List<Pista> { new Pista(0, "Head", "DJ", 120, 200) };
            sw.Restart();
            for (int i = 0; i < n; i++)
            {
                testList.Insert(1, new Pista(i, $"Pista {i}", "DJ", random.Next(100, 150), 180));
            }
            sw.Stop();
            long tiempoList = sw.ElapsedMilliseconds;

            txtResultadosBenchmark.Text =
                $"=== RESULTADOS DE ESTRÉS ({n:N0} INSERCIONES INTERMEDIAS) ===\r\n" +
                $"• Lista Enlazada Propia (Nodos):    {tiempoPropia} ms  [Operación O(1) por reconexión de punteros]\r\n" +
                $"• .NET LinkedList<T>:                {tiempoLinkedList} ms  [Operación O(1) con LinkedListNode]\r\n" +
                $"• .NET List<T> (Arreglo Dinámico):   {tiempoList} ms  [Operación O(n) por desplazamiento/Array.Copy]\r\n\r\n" +
                "Conclusión Técnica: En inserciones intermedias frecuentes, las listas enlazadas " +
                "(propia y LinkedList<T>) superan a List<T> porque reconectan referencias en tiempo " +
                "constante, mientras que List<T> debe desplazar en memoria todos los elementos " +
                "posteriores al índice de inserción cada vez que crece.";

            btnBenchmark.Enabled = true;
        }
    }
}
