
namespace proyecto_Topicos
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.BarraMenuVertical = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.panData = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.pbMarca = new System.Windows.Forms.PictureBox();
            this.panContenido = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.BarraMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BarraTitulo.Controls.Add(this.lblTitulo);
            this.BarraTitulo.Controls.Add(this.pbMinimize);
            this.BarraTitulo.Controls.Add(this.pbClose);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1092, 35);
            this.BarraTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(98, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "VM Software v1.00";
            // 
            // pbMinimize
            // 
            this.pbMinimize.BackColor = System.Drawing.Color.Transparent;
            this.pbMinimize.Location = new System.Drawing.Point(1025, 5);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(25, 25);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimize.TabIndex = 0;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbClose
            // 
            this.pbClose.Location = new System.Drawing.Point(1056, 2);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(30, 30);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 1;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // BarraMenuVertical
            // 
            this.BarraMenuVertical.BackColor = System.Drawing.Color.DarkBlue;
            this.BarraMenuVertical.Controls.Add(this.button6);
            this.BarraMenuVertical.Controls.Add(this.button5);
            this.BarraMenuVertical.Controls.Add(this.button4);
            this.BarraMenuVertical.Controls.Add(this.button3);
            this.BarraMenuVertical.Controls.Add(this.btn);
            this.BarraMenuVertical.Controls.Add(this.panData);
            this.BarraMenuVertical.Controls.Add(this.button1);
            this.BarraMenuVertical.Controls.Add(this.btnData);
            this.BarraMenuVertical.Controls.Add(this.pbMarca);
            this.BarraMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraMenuVertical.Location = new System.Drawing.Point(0, 35);
            this.BarraMenuVertical.Name = "BarraMenuVertical";
            this.BarraMenuVertical.Size = new System.Drawing.Size(203, 559);
            this.BarraMenuVertical.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkBlue;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(12, 272);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(191, 33);
            this.button6.TabIndex = 10;
            this.button6.Text = "Papeles";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkBlue;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(12, 239);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(191, 33);
            this.button5.TabIndex = 8;
            this.button5.Text = "Directores";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnDirector_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(12, 206);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 33);
            this.button4.TabIndex = 8;
            this.button4.Text = "Actores";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnActor_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(12, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "Peliculas";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnPelicula_Click);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.DarkBlue;
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn.Image = ((System.Drawing.Image)(resources.GetObject("btn.Image")));
            this.btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn.Location = new System.Drawing.Point(12, 140);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(191, 33);
            this.btn.TabIndex = 8;
            this.btn.Text = "Cassettes";
            this.btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btnCassette_Click);
            // 
            // panData
            // 
            this.panData.BackColor = System.Drawing.Color.Black;
            this.panData.Location = new System.Drawing.Point(0, 74);
            this.panData.Name = "panData";
            this.panData.Size = new System.Drawing.Size(12, 484);
            this.panData.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(12, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Miembros";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.DarkBlue;
            this.btnData.FlatAppearance.BorderSize = 0;
            this.btnData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnData.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnData.Image = ((System.Drawing.Image)(resources.GetObject("btnData.Image")));
            this.btnData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnData.Location = new System.Drawing.Point(12, 74);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(191, 33);
            this.btnData.TabIndex = 6;
            this.btnData.Text = "Prestamos";
            this.btnData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // pbMarca
            // 
            this.pbMarca.BackColor = System.Drawing.Color.Black;
            this.pbMarca.Image = ((System.Drawing.Image)(resources.GetObject("pbMarca.Image")));
            this.pbMarca.Location = new System.Drawing.Point(0, 0);
            this.pbMarca.Name = "pbMarca";
            this.pbMarca.Size = new System.Drawing.Size(203, 75);
            this.pbMarca.TabIndex = 0;
            this.pbMarca.TabStop = false;
            // 
            // panContenido
            // 
            this.panContenido.BackColor = System.Drawing.Color.Black;
            this.panContenido.Location = new System.Drawing.Point(203, 35);
            this.panContenido.Name = "panContenido";
            this.panContenido.Size = new System.Drawing.Size(889, 559);
            this.panContenido.TabIndex = 3;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 594);
            this.Controls.Add(this.panContenido);
            this.Controls.Add(this.BarraMenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Principal";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.BarraMenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMarca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel BarraMenuVertical;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Panel panData;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.PictureBox pbMarca;
        private System.Windows.Forms.Panel panContenido;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button button1;
    }
}