namespace Views.src
{
    partial class Historial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.nombreLibro = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.codigoISBN = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.numEdicion = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.idSocio = new System.Windows.Forms.Label();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.fechaPrestamo = new System.Windows.Forms.Label();
            this.estadoPrestamo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.nombreLibro);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(984, 461);
            this.splitContainer1.SplitterDistance = 307;
            this.splitContainer1.TabIndex = 0;
            // 
            // nombreLibro
            // 
            this.nombreLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombreLibro.Dock = System.Windows.Forms.DockStyle.Top;
            this.nombreLibro.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombreLibro.Location = new System.Drawing.Point(0, 0);
            this.nombreLibro.Name = "nombreLibro";
            this.nombreLibro.Size = new System.Drawing.Size(307, 421);
            this.nombreLibro.TabIndex = 0;
            this.nombreLibro.Text = "Nombre Libro\r\n--------------------------------";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.codigoISBN);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(673, 461);
            this.splitContainer2.SplitterDistance = 174;
            this.splitContainer2.TabIndex = 0;
            // 
            // codigoISBN
            // 
            this.codigoISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigoISBN.Dock = System.Windows.Forms.DockStyle.Top;
            this.codigoISBN.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codigoISBN.Location = new System.Drawing.Point(0, 0);
            this.codigoISBN.Name = "codigoISBN";
            this.codigoISBN.Size = new System.Drawing.Size(174, 421);
            this.codigoISBN.TabIndex = 1;
            this.codigoISBN.Text = "Codigo ISBN\r\n----------------";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.numEdicion);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(495, 461);
            this.splitContainer3.SplitterDistance = 101;
            this.splitContainer3.TabIndex = 0;
            // 
            // numEdicion
            // 
            this.numEdicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numEdicion.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numEdicion.Location = new System.Drawing.Point(0, 0);
            this.numEdicion.Name = "numEdicion";
            this.numEdicion.Size = new System.Drawing.Size(99, 421);
            this.numEdicion.TabIndex = 1;
            this.numEdicion.Text = "Edicion\r\n--------";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.idSocio);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(390, 461);
            this.splitContainer4.SplitterDistance = 96;
            this.splitContainer4.TabIndex = 0;
            // 
            // idSocio
            // 
            this.idSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idSocio.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idSocio.Location = new System.Drawing.Point(0, 0);
            this.idSocio.Name = "idSocio";
            this.idSocio.Size = new System.Drawing.Size(94, 421);
            this.idSocio.TabIndex = 1;
            this.idSocio.Text = "Id Socio\r\n--------";
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.fechaPrestamo);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.estadoPrestamo);
            this.splitContainer5.Size = new System.Drawing.Size(290, 461);
            this.splitContainer5.SplitterDistance = 132;
            this.splitContainer5.TabIndex = 0;
            // 
            // fechaPrestamo
            // 
            this.fechaPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fechaPrestamo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fechaPrestamo.Location = new System.Drawing.Point(0, 0);
            this.fechaPrestamo.Name = "fechaPrestamo";
            this.fechaPrestamo.Size = new System.Drawing.Size(130, 421);
            this.fechaPrestamo.TabIndex = 1;
            this.fechaPrestamo.Text = "Fecha\r\n----------";
            // 
            // estadoPrestamo
            // 
            this.estadoPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.estadoPrestamo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.estadoPrestamo.Location = new System.Drawing.Point(0, 0);
            this.estadoPrestamo.Name = "estadoPrestamo";
            this.estadoPrestamo.Size = new System.Drawing.Size(154, 421);
            this.estadoPrestamo.TabIndex = 2;
            this.estadoPrestamo.Text = "Estado\r\n----------";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Historial";
            this.Text = "Historial";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Label nombreLibro;
        private SplitContainer splitContainer2;
        private Label codigoISBN;
        private SplitContainer splitContainer3;
        private Label numEdicion;
        private SplitContainer splitContainer4;
        private Label idSocio;
        private Label fechaPrestamo;
        private SplitContainer splitContainer5;
        private Label estadoPrestamo;
        private Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}