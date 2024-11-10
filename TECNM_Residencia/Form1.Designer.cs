namespace TECNM_Residencia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenuLateral = new Panel();
            pb_logo_tecnm = new PictureBox();
            panelnfoPersonal = new Panel();
            pictureBox1 = new PictureBox();
            labelNombrePersona = new Label();
            button1 = new Button();
            panelMenuArriba = new Panel();
            labelTitulo = new Label();
            SubirPDF = new Panel();
            PDFformato = new Label();
            Subir = new Button();
            Cancelar = new Button();
            flechaSubir = new PictureBox();
            panelMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_logo_tecnm).BeginInit();
            panelnfoPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenuArriba.SuspendLayout();
            SubirPDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flechaSubir).BeginInit();
            SuspendLayout();
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.BackColor = Color.MidnightBlue;
            panelMenuLateral.Controls.Add(pb_logo_tecnm);
            panelMenuLateral.Controls.Add(panelnfoPersonal);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Margin = new Padding(4, 5, 4, 5);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(357, 935);
            panelMenuLateral.TabIndex = 0;
            // 
            // pb_logo_tecnm
            // 
            pb_logo_tecnm.Image = (Image)resources.GetObject("pb_logo_tecnm.Image");
            pb_logo_tecnm.Location = new Point(42, 44);
            pb_logo_tecnm.Name = "pb_logo_tecnm";
            pb_logo_tecnm.Size = new Size(255, 125);
            pb_logo_tecnm.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_logo_tecnm.TabIndex = 3;
            pb_logo_tecnm.TabStop = false;
            // 
            // panelnfoPersonal
            // 
            panelnfoPersonal.BackColor = Color.MidnightBlue;
            panelnfoPersonal.Controls.Add(pictureBox1);
            panelnfoPersonal.Controls.Add(labelNombrePersona);
            panelnfoPersonal.Controls.Add(button1);
            panelnfoPersonal.Location = new Point(0, 312);
            panelnfoPersonal.Margin = new Padding(4, 5, 4, 5);
            panelnfoPersonal.Name = "panelnfoPersonal";
            panelnfoPersonal.Size = new Size(357, 258);
            panelnfoPersonal.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(117, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // labelNombrePersona
            // 
            labelNombrePersona.AutoSize = true;
            labelNombrePersona.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombrePersona.ForeColor = Color.White;
            labelNombrePersona.Location = new Point(110, 157);
            labelNombrePersona.Margin = new Padding(4, 0, 4, 0);
            labelNombrePersona.Name = "labelNombrePersona";
            labelNombrePersona.Size = new Size(136, 22);
            labelNombrePersona.TabIndex = 2;
            labelNombrePersona.Text = "Nombre Completo";
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Dock = DockStyle.Bottom;
            button1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(0, 220);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(357, 38);
            button1.TabIndex = 0;
            button1.Text = "CERRAR SESIÓN";
            button1.UseVisualStyleBackColor = false;
            // 
            // panelMenuArriba
            // 
            panelMenuArriba.BackColor = Color.Navy;
            panelMenuArriba.Controls.Add(labelTitulo);
            panelMenuArriba.Dock = DockStyle.Top;
            panelMenuArriba.Location = new Point(357, 0);
            panelMenuArriba.Margin = new Padding(4, 5, 4, 5);
            panelMenuArriba.Name = "panelMenuArriba";
            panelMenuArriba.Size = new Size(977, 75);
            panelMenuArriba.TabIndex = 1;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(9, 15);
            labelTitulo.Margin = new Padding(4, 0, 4, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(520, 33);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = " Gestión de Residencias Profesionales";
            // 
            // SubirPDF
            // 
            SubirPDF.AllowDrop = true;
            SubirPDF.BorderStyle = BorderStyle.FixedSingle;
            SubirPDF.Controls.Add(PDFformato);
            SubirPDF.Controls.Add(Subir);
            SubirPDF.Controls.Add(Cancelar);
            SubirPDF.Controls.Add(flechaSubir);
            SubirPDF.Location = new Point(357, 75);
            SubirPDF.Name = "SubirPDF";
            SubirPDF.Size = new Size(977, 860);
            SubirPDF.TabIndex = 2;
            // 
            // PDFformato
            // 
            PDFformato.AutoSize = true;
            PDFformato.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PDFformato.Location = new Point(284, 146);
            PDFformato.Name = "PDFformato";
            PDFformato.Size = new Size(407, 21);
            PDFformato.TabIndex = 3;
            PDFformato.Text = "Reporte preliminar de Residencia Profesional";
            // 
            // Subir
            // 
            Subir.Location = new Point(128, 586);
            Subir.Name = "Subir";
            Subir.Size = new Size(157, 40);
            Subir.TabIndex = 4;
            Subir.Text = "Subir";
            Subir.UseVisualStyleBackColor = true;
            Subir.Click += Subir_Click;
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(669, 586);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(157, 40);
            Cancelar.TabIndex = 5;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // flechaSubir
            // 
            flechaSubir.BorderStyle = BorderStyle.FixedSingle;
            flechaSubir.Image = Properties.Resources.flecha2;
            flechaSubir.Location = new Point(128, 210);
            flechaSubir.Name = "flechaSubir";
            flechaSubir.Size = new Size(724, 284);
            flechaSubir.SizeMode = PictureBoxSizeMode.CenterImage;
            flechaSubir.TabIndex = 0;
            flechaSubir.TabStop = false;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1334, 935);
            Controls.Add(SubirPDF);
            Controls.Add(panelMenuArriba);
            Controls.Add(panelMenuLateral);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelMenuLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_logo_tecnm).EndInit();
            panelnfoPersonal.ResumeLayout(false);
            panelnfoPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenuArriba.ResumeLayout(false);
            panelMenuArriba.PerformLayout();
            SubirPDF.ResumeLayout(false);
            SubirPDF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)flechaSubir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenuLateral;
        private Panel panelMenuArriba;
        private Panel panelnfoPersonal;
        private Label labelNombrePersona;
        private Button button1;
        private Label labelTitulo;
        private PictureBox pb_logo_tecnm;
        private PictureBox pictureBox1;
        private Panel SubirPDF;
        private PictureBox flechaSubir;
        private Label PDFformato;
        private Button Subir;
        private Button Cancelar;
    }
}
