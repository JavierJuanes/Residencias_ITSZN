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
            panelnfoPersonal = new Panel();
            labelNombrePersona = new Label();
            button1 = new Button();
            panelMenuArriba = new Panel();
            labelTitulo = new Label();
            pb_logo_tecnm = new PictureBox();
            pictureBox1 = new PictureBox();
            panelMenuLateral.SuspendLayout();
            panelnfoPersonal.SuspendLayout();
            panelMenuArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_logo_tecnm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1334, 935);
            Controls.Add(panelMenuArriba);
            Controls.Add(panelMenuLateral);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelMenuLateral.ResumeLayout(false);
            panelnfoPersonal.ResumeLayout(false);
            panelnfoPersonal.PerformLayout();
            panelMenuArriba.ResumeLayout(false);
            panelMenuArriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_logo_tecnm).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}
