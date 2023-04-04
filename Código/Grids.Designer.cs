
namespace proyecto_Topicos
{
    partial class Grids
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grids));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panTop = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.ttAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.ttModificar = new System.Windows.Forms.ToolTip(this.components);
            this.ttQuitar = new System.Windows.Forms.ToolTip(this.components);
            this.ttRecargar = new System.Windows.Forms.ToolTip(this.components);
            this.panVenatanId = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(529, 163);
            this.dataGridView1.TabIndex = 9;
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.Black;
            this.panTop.Controls.Add(this.lblTitulo);
            this.panTop.Controls.Add(this.btnRecargar);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(889, 46);
            this.panTop.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(38, 232);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(200, 42);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar registro";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Broadway", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Aqua;
            this.lblTitulo.Location = new System.Drawing.Point(272, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(313, 32);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Grid de directores";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.Color.Transparent;
            this.btnRecargar.FlatAppearance.BorderSize = 0;
            this.btnRecargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecargar.Location = new System.Drawing.Point(843, 0);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(46, 46);
            this.btnRecargar.TabIndex = 15;
            this.btnRecargar.UseVisualStyleBackColor = false;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // panVenatanId
            // 
            this.panVenatanId.Location = new System.Drawing.Point(563, 63);
            this.panVenatanId.Name = "panVenatanId";
            this.panVenatanId.Size = new System.Drawing.Size(305, 163);
            this.panVenatanId.TabIndex = 11;
            // 
            // Grids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(889, 559);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panVenatanId);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Grids";
            this.Text = "GridDirectores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ToolTip ttAgregar;
        private System.Windows.Forms.ToolTip ttModificar;
        private System.Windows.Forms.ToolTip ttQuitar;
        private System.Windows.Forms.ToolTip ttRecargar;
        private System.Windows.Forms.Panel panVenatanId;
    }
}