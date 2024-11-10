using System.Data.SQLite;

namespace TECNM_Residencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Habilitar soporte de arrastrar y soltar para el PictureBox
            flechaSubir.AllowDrop = true;
            flechaSubir.DragEnter += flechaSubir_DragEnter;
            flechaSubir.DragDrop += flechaSubir_DragDrop;
        }

        private void flechaSubir_DragDrop(object? sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string filePath = files[0];

            // Verificar nuevamente que el archivo sea un PDF
            if (Path.GetExtension(filePath).ToLower() == ".pdf")
            {
                // Definir la ruta de destino
                string destinationPath = Path.Combine(@"C:\Users\LENOVO\Desktop\Ruta_Destino", Path.GetFileName(filePath));

                try
                {
                    // Copiar el archivo a la carpeta de destino
                    File.Copy(filePath, destinationPath, true);
                    MessageBox.Show("El archivo PDF se ha subido correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al subir el archivo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Solo se permiten archivos PDF.");
            }
        }
    

        private void flechaSubir_DragEnter(object? sender, DragEventArgs e)
        {
            // Verificar si el archivo es un PDF
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (Path.GetExtension(files[0]).ToLower() == ".pdf")
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    MessageBox.Show("Solo se permiten archivos PDF.");
                    e.Effect = DragDropEffects.None;
                }
            }
        }




        private void panelLOGO_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Subir_Click(object sender, EventArgs e)
        {
            // Abrir un diálogo para seleccionar el archivo
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Seleccione un archivo PDF"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string filePath = openFileDialog.FileName;

                // Verificar que el archivo tenga extensión .pdf
                if (Path.GetExtension(filePath).ToLower() == ".pdf")
                {
                    // Copiar el archivo a una ubicación deseada
                    string destinationPath = Path.Combine(@"C:\Users\LENOVO\Desktop\Ruta_Destino", Path.GetFileName(filePath));

                    try
                    {
                        File.Copy(filePath, destinationPath, true);
                        MessageBox.Show("El archivo PDF se ha subido correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al subir el archivo: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Solo se permiten archivos PDF.");
                }
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            // Confirmación antes de salir
            var confirmResult = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}