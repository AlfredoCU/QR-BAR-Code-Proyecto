//Biblitecas por defecto.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Biblotecas para mejorar el FORM.
using MaterialSkin;
using MaterialSkin.Controls;

//BibliotecaS para el QR Y code barra.
using ZXing;
// using BarcodeLib; using QR; using QRCoder; BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();

namespace QR
{
    public partial class QRForm : MaterialForm
    {
        public QRForm()
        {
            InitializeComponent();
            txtMostrar.Enabled = false;
            // Crea un administrador de temas materiales y agrega al formulario para administrar (esto).
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configura colores.
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Blue700, TextShade.WHITE);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // SaveFileDialog Pide al usuario que seleccione una ubicación para guardar un archivo. 
            // Esta clase no puede heredarse.
            SaveFileDialog guardarImagen = new SaveFileDialog()
            {
                // Obtiene o establece una cadena de nombres de archivo.
                // *Guarda como tipo de archvio o archivos a cuadro de tipo en el cuadro de dialogo.
                // *InitialDirectory es la dirección donde se agurda el archivo.
                Filter = "Imagen jpg|*.jpg",
                InitialDirectory = @"C:\Users\Desktop"
            };
            // Genera la ventana para aguardar la imagen.
            if (guardarImagen.ShowDialog() == DialogResult.OK)
            {
                // Del panel toma la imagen generada para aguardarla con un nombre. 
                pbGenerar.Image.Save(guardarImagen.FileName);
            }
        }

        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            // OpenFileDialog Muestra un cuadro de diálogo que pide al usuario que abra un archivo. 
            // Esta clase no puede heredarse.
            OpenFileDialog abrirImagen = new OpenFileDialog()
            {
                Filter = "Imagen jpg|*.jpg",
                InitialDirectory = @"C:\Users\Desktop"
            };
            // Genera la ventana para abrir la imagen.
            if(abrirImagen.ShowDialog() == DialogResult.OK)
            {
                // Se manda la imagen a un panel, con la imagen aguardada con el nombre.
                pbMostrarArchivo.Image = Image.FromFile(abrirImagen.FileName);
                //Clase para leer un QR.
                BarcodeReader code = new BarcodeReader();
                //Bitmap se utiliza imágenes mediante datos de pixeles.
                string texto = code.Decode((Bitmap)pbMostrarArchivo.Image).ToString();
                txtMostrar.Text = texto;
            }
        }

        private void btnAbrirArchivo2_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = "";
            OpenFileDialog abrirImagen = new OpenFileDialog()
            {
                Filter = "Imagen jpg|*.jpg",
                InitialDirectory = @"C:\Users\Desktop"
            };
            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                pbMostrarArchivo.Image = Image.FromFile(abrirImagen.FileName);
                //Clase para leer un CB.
                BarcodeReader code = new BarcodeReader();
                code.Decode((Bitmap)pbMostrarArchivo.Image);
            }
        }

        private void txtIngreseQR_TextChanged(Object sender, EventArgs e)
        {
            if (txtIngresaQR.Text != "")
            {
                // Clase para escribir un QR.
                BarcodeWriter code1 = new BarcodeWriter();
                // EAN:13 CODE_128 PDF_417 Son para código de barras.
                // CODE_128 es la mejor presentación.
                // PDF_417 se forma la palabra en las barras.
                code1.Format = BarcodeFormat.QR_CODE; // Este es el formato de código QR.
                Bitmap pixeles = new Bitmap(code1.Write(txtIngresaQR.Text), 200, 200); // Tamaño del QR.
                pbGenerar.Image = pixeles;
            }
        }

        private void txtIngreseCB_TextChanged(Object sender, EventArgs e)
        {
            if (txtIngreseCB.Text != "")
            {
                BarcodeWriter code2 = new BarcodeWriter();
                code2.Format = BarcodeFormat.CODE_128;
                Bitmap pixeles = new Bitmap(code2.Write(txtIngreseCB.Text), 150, 150);
                pbGenerar.Image = pixeles;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}