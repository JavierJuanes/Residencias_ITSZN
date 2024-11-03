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
            panelMenuLateral = new Panel();
            panelnfoPersonal = new Panel();
            panelPerfil = new Panel();
            labelNombrePersona = new Label();
            button1 = new Button();
            panelLOGO = new Panel();
            panel2 = new Panel();
            panelMenuArriba = new Panel();
            labelTitulo = new Label();
            panelMenuLateral.SuspendLayout();
            panelnfoPersonal.SuspendLayout();
            panelLOGO.SuspendLayout();
            panelMenuArriba.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.BackColor = Color.MidnightBlue;
            panelMenuLateral.Controls.Add(panelnfoPersonal);
            panelMenuLateral.Controls.Add(panelLOGO);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(250, 561);
            panelMenuLateral.TabIndex = 0;
            // 
            // panelnfoPersonal
            // 
            panelnfoPersonal.BackColor = Color.MidnightBlue;
            panelnfoPersonal.Controls.Add(panelPerfil);
            panelnfoPersonal.Controls.Add(labelNombrePersona);
            panelnfoPersonal.Controls.Add(button1);
            panelnfoPersonal.Location = new Point(0, 187);
            panelnfoPersonal.Name = "panelnfoPersonal";
            panelnfoPersonal.Size = new Size(250, 155);
            panelnfoPersonal.TabIndex = 2;
            // 
            // panelPerfil
            // 
            panelPerfil.BackColor = Color.Transparent;
            panelPerfil.BackgroundImage = Properties.Resources.usuariou;
            panelPerfil.Location = new Point(90, 3);
            panelPerfil.Name = "panelPerfil";
            panelPerfil.Size = new Size(70, 71);
            panelPerfil.TabIndex = 3;
            // 
            // labelNombrePersona
            // 
            labelNombrePersona.AutoSize = true;
            labelNombrePersona.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombrePersona.ForeColor = Color.White;
            labelNombrePersona.Location = new Point(77, 94);
            labelNombrePersona.Name = "labelNombrePersona";
            labelNombrePersona.Size = new Size(92, 16);
            labelNombrePersona.TabIndex = 2;
            labelNombrePersona.Text = "Nombre Completo";
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Dock = DockStyle.Bottom;
            button1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(0, 132);
            button1.Name = "button1";
            button1.Size = new Size(250, 23);
            button1.TabIndex = 0;
            button1.Text = "CERRAR SESIÓN";
            button1.UseVisualStyleBackColor = false;
            // 
            // panelLOGO
            // 
            panelLOGO.BackgroundImage = Properties.Resources.tec12;
            panelLOGO.Controls.Add(panel2);
            panelLOGO.Dock = DockStyle.Top;
            panelLOGO.Location = new Point(0, 0);
            panelLOGO.Name = "panelLOGO";
            panelLOGO.Size = new Size(250, 128);
            panelLOGO.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 147);
            panel2.TabIndex = 2;
            // 
            // panelMenuArriba
            // 
            panelMenuArriba.BackColor = Color.Navy;
            panelMenuArriba.Controls.Add(labelTitulo);
            panelMenuArriba.Dock = DockStyle.Top;
            panelMenuArriba.Location = new Point(250, 0);
            panelMenuArriba.Name = "panelMenuArriba";
            panelMenuArriba.Size = new Size(684, 45);
            panelMenuArriba.TabIndex = 1;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(6, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(349, 23);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = " Gestión de Residencias Profesionales";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(934, 561);
            Controls.Add(panelMenuArriba);
            Controls.Add(panelMenuLateral);
            Name = "Form1";
            Text = "Form1";
            panelMenuLateral.ResumeLayout(false);
            panelnfoPersonal.ResumeLayout(false);
            panelnfoPersonal.PerformLayout();
            panelLOGO.ResumeLayout(false);
            panelMenuArriba.ResumeLayout(false);
            panelMenuArriba.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenuLateral;
        private Panel panelMenuArriba;
        private Panel panelLOGO;
        private Panel panel2;
        private Panel panelnfoPersonal;
        private Panel panelPerfil;
        private Label labelNombrePersona;
        private Button button1;
        private Label labelTitulo;
    }
}
