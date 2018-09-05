namespace QR
{
    partial class QRForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRForm));
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.mlQR = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.mtcMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.QR = new System.Windows.Forms.TabPage();
            this.txtIngresaQR = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAbrirArchivo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CodeBarras = new System.Windows.Forms.TabPage();
            this.btnAbrirArchivo2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtIngreseCB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblIngreseCB = new MaterialSkin.Controls.MaterialLabel();
            this.pbMostrarArchivo = new System.Windows.Forms.PictureBox();
            this.txtMostrar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.seleccionMenu = new MaterialSkin.Controls.MaterialTabSelector();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pbGenerar = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblQRCB = new MaterialSkin.Controls.MaterialLabel();
            this.mtcMenu.SuspendLayout();
            this.QR.SuspendLayout();
            this.CodeBarras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarArchivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenerar)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(104, 24);
            this.materialCheckBox1.TabIndex = 0;
            // 
            // mlQR
            // 
            this.mlQR.AutoSize = true;
            this.mlQR.BackColor = System.Drawing.Color.Transparent;
            this.mlQR.Depth = 0;
            this.mlQR.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlQR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlQR.Location = new System.Drawing.Point(12, 34);
            this.mlQR.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlQR.Name = "mlQR";
            this.mlQR.Size = new System.Drawing.Size(182, 19);
            this.mlQR.TabIndex = 0;
            this.mlQR.Text = "QR Y CÓDIGO DE BARRAS";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 22);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(89, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Ingrese QR: ";
            // 
            // mtcMenu
            // 
            this.mtcMenu.Controls.Add(this.QR);
            this.mtcMenu.Controls.Add(this.CodeBarras);
            this.mtcMenu.Depth = 0;
            this.mtcMenu.Location = new System.Drawing.Point(2, 92);
            this.mtcMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtcMenu.Name = "mtcMenu";
            this.mtcMenu.SelectedIndex = 0;
            this.mtcMenu.Size = new System.Drawing.Size(691, 82);
            this.mtcMenu.TabIndex = 2;
            // 
            // QR
            // 
            this.QR.BackColor = System.Drawing.Color.White;
            this.QR.Controls.Add(this.txtIngresaQR);
            this.QR.Controls.Add(this.materialLabel1);
            this.QR.Controls.Add(this.btnAbrirArchivo);
            this.QR.Location = new System.Drawing.Point(4, 22);
            this.QR.Name = "QR";
            this.QR.Padding = new System.Windows.Forms.Padding(3);
            this.QR.Size = new System.Drawing.Size(683, 56);
            this.QR.TabIndex = 0;
            this.QR.Text = "QR";
            // 
            // txtIngresaQR
            // 
            this.txtIngresaQR.Depth = 0;
            this.txtIngresaQR.Hint = "";
            this.txtIngresaQR.Location = new System.Drawing.Point(108, 18);
            this.txtIngresaQR.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIngresaQR.Name = "txtIngresaQR";
            this.txtIngresaQR.PasswordChar = '\0';
            this.txtIngresaQR.SelectedText = "";
            this.txtIngresaQR.SelectionLength = 0;
            this.txtIngresaQR.SelectionStart = 0;
            this.txtIngresaQR.Size = new System.Drawing.Size(310, 23);
            this.txtIngresaQR.TabIndex = 8;
            this.txtIngresaQR.UseSystemPasswordChar = false;
            this.txtIngresaQR.TextChanged += new System.EventHandler(this.txtIngreseQR_TextChanged);
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.Depth = 0;
            this.btnAbrirArchivo.Location = new System.Drawing.Point(454, 12);
            this.btnAbrirArchivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Primary = true;
            this.btnAbrirArchivo.Size = new System.Drawing.Size(209, 41);
            this.btnAbrirArchivo.TabIndex = 4;
            this.btnAbrirArchivo.Text = "Abrir Archivo QR";
            this.btnAbrirArchivo.UseVisualStyleBackColor = true;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrirArchivo_Click);
            // 
            // CodeBarras
            // 
            this.CodeBarras.BackColor = System.Drawing.Color.White;
            this.CodeBarras.Controls.Add(this.btnAbrirArchivo2);
            this.CodeBarras.Controls.Add(this.txtIngreseCB);
            this.CodeBarras.Controls.Add(this.lblIngreseCB);
            this.CodeBarras.Location = new System.Drawing.Point(4, 22);
            this.CodeBarras.Name = "CodeBarras";
            this.CodeBarras.Padding = new System.Windows.Forms.Padding(3);
            this.CodeBarras.Size = new System.Drawing.Size(683, 56);
            this.CodeBarras.TabIndex = 1;
            this.CodeBarras.Text = "Código de barras";
            // 
            // btnAbrirArchivo2
            // 
            this.btnAbrirArchivo2.Depth = 0;
            this.btnAbrirArchivo2.Location = new System.Drawing.Point(454, 12);
            this.btnAbrirArchivo2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAbrirArchivo2.Name = "btnAbrirArchivo2";
            this.btnAbrirArchivo2.Primary = true;
            this.btnAbrirArchivo2.Size = new System.Drawing.Size(209, 41);
            this.btnAbrirArchivo2.TabIndex = 14;
            this.btnAbrirArchivo2.Text = "Abrir Archivo CB";
            this.btnAbrirArchivo2.UseVisualStyleBackColor = true;
            this.btnAbrirArchivo2.Click += new System.EventHandler(this.btnAbrirArchivo2_Click);
            // 
            // txtIngreseCB
            // 
            this.txtIngreseCB.Depth = 0;
            this.txtIngreseCB.Hint = "";
            this.txtIngreseCB.Location = new System.Drawing.Point(108, 18);
            this.txtIngreseCB.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIngreseCB.Name = "txtIngreseCB";
            this.txtIngreseCB.PasswordChar = '\0';
            this.txtIngreseCB.SelectedText = "";
            this.txtIngreseCB.SelectionLength = 0;
            this.txtIngreseCB.SelectionStart = 0;
            this.txtIngreseCB.Size = new System.Drawing.Size(310, 23);
            this.txtIngreseCB.TabIndex = 13;
            this.txtIngreseCB.UseSystemPasswordChar = false;
            this.txtIngreseCB.TextChanged += new System.EventHandler(this.txtIngreseCB_TextChanged);
            // 
            // lblIngreseCB
            // 
            this.lblIngreseCB.AutoSize = true;
            this.lblIngreseCB.BackColor = System.Drawing.Color.Transparent;
            this.lblIngreseCB.Depth = 0;
            this.lblIngreseCB.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIngreseCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIngreseCB.Location = new System.Drawing.Point(13, 22);
            this.lblIngreseCB.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIngreseCB.Name = "lblIngreseCB";
            this.lblIngreseCB.Size = new System.Drawing.Size(89, 19);
            this.lblIngreseCB.TabIndex = 9;
            this.lblIngreseCB.Text = "Ingrese CB: ";
            // 
            // pbMostrarArchivo
            // 
            this.pbMostrarArchivo.BackColor = System.Drawing.Color.White;
            this.pbMostrarArchivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMostrarArchivo.Location = new System.Drawing.Point(460, 180);
            this.pbMostrarArchivo.Name = "pbMostrarArchivo";
            this.pbMostrarArchivo.Size = new System.Drawing.Size(209, 185);
            this.pbMostrarArchivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMostrarArchivo.TabIndex = 6;
            this.pbMostrarArchivo.TabStop = false;
            // 
            // txtMostrar
            // 
            this.txtMostrar.Depth = 0;
            this.txtMostrar.Enabled = false;
            this.txtMostrar.Hint = "";
            this.txtMostrar.Location = new System.Drawing.Point(460, 371);
            this.txtMostrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.PasswordChar = '\0';
            this.txtMostrar.SelectedText = "";
            this.txtMostrar.SelectionLength = 0;
            this.txtMostrar.SelectionStart = 0;
            this.txtMostrar.Size = new System.Drawing.Size(209, 23);
            this.txtMostrar.TabIndex = 5;
            this.txtMostrar.UseSystemPasswordChar = false;
            // 
            // seleccionMenu
            // 
            this.seleccionMenu.BaseTabControl = this.mtcMenu;
            this.seleccionMenu.Depth = 0;
            this.seleccionMenu.Location = new System.Drawing.Point(-7, 63);
            this.seleccionMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.seleccionMenu.Name = "seleccionMenu";
            this.seleccionMenu.Size = new System.Drawing.Size(1323, 23);
            this.seleccionMenu.TabIndex = 0;
            this.seleccionMenu.Text = "mtsMenu";
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(244, 277);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(194, 88);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbGenerar
            // 
            this.pbGenerar.BackColor = System.Drawing.Color.White;
            this.pbGenerar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGenerar.Location = new System.Drawing.Point(14, 180);
            this.pbGenerar.Name = "pbGenerar";
            this.pbGenerar.Size = new System.Drawing.Size(209, 185);
            this.pbGenerar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbGenerar.TabIndex = 12;
            this.pbGenerar.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(244, 180);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(194, 91);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblQRCB
            // 
            this.lblQRCB.AutoSize = true;
            this.lblQRCB.BackColor = System.Drawing.Color.Transparent;
            this.lblQRCB.Depth = 0;
            this.lblQRCB.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblQRCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblQRCB.Location = new System.Drawing.Point(10, 377);
            this.lblQRCB.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblQRCB.Name = "lblQRCB";
            this.lblQRCB.Size = new System.Drawing.Size(252, 19);
            this.lblQRCB.TabIndex = 13;
            this.lblQRCB.Text = "Generador de QR y código de barras.";
            // 
            // QRForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(690, 405);
            this.Controls.Add(this.lblQRCB);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pbGenerar);
            this.Controls.Add(this.pbMostrarArchivo);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.seleccionMenu);
            this.Controls.Add(this.mtcMenu);
            this.Controls.Add(this.mlQR);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "QRForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mtcMenu.ResumeLayout(false);
            this.QR.ResumeLayout(false);
            this.QR.PerformLayout();
            this.CodeBarras.ResumeLayout(false);
            this.CodeBarras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarArchivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenerar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private MaterialSkin.Controls.MaterialLabel mlQR;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTabControl mtcMenu;
        private System.Windows.Forms.TabPage QR;
        private MaterialSkin.Controls.MaterialTabSelector seleccionMenu;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMostrar;
        private System.Windows.Forms.PictureBox pbMostrarArchivo;
        private MaterialSkin.Controls.MaterialRaisedButton btnAbrirArchivo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIngresaQR;
        private System.Windows.Forms.TabPage CodeBarras;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIngreseCB;
        private System.Windows.Forms.PictureBox pbGenerar;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private MaterialSkin.Controls.MaterialLabel lblIngreseCB;
        private MaterialSkin.Controls.MaterialRaisedButton btnAbrirArchivo2;
        private MaterialSkin.Controls.MaterialLabel lblQRCB;
    }
}

