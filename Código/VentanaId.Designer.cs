namespace proyecto_Topicos
{
    partial class VentanaId
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaId));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPasarANoDisponible = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnPasarADisponible = new System.Windows.Forms.Button();
            this.btnEntregado = new System.Windows.Forms.Button();
            this.cmbIds = new proyecto_Topicos.SCmb();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // btnPasarANoDisponible
            // 
            this.btnPasarANoDisponible.BackColor = System.Drawing.Color.LightCoral;
            this.btnPasarANoDisponible.FlatAppearance.BorderSize = 0;
            this.btnPasarANoDisponible.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnPasarANoDisponible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasarANoDisponible.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarANoDisponible.ForeColor = System.Drawing.Color.Black;
            this.btnPasarANoDisponible.Image = ((System.Drawing.Image)(resources.GetObject("btnPasarANoDisponible.Image")));
            this.btnPasarANoDisponible.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPasarANoDisponible.Location = new System.Drawing.Point(160, 109);
            this.btnPasarANoDisponible.Name = "btnPasarANoDisponible";
            this.btnPasarANoDisponible.Size = new System.Drawing.Size(138, 44);
            this.btnPasarANoDisponible.TabIndex = 19;
            this.btnPasarANoDisponible.Text = "Marcar como no disponible";
            this.btnPasarANoDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPasarANoDisponible.UseVisualStyleBackColor = false;
            this.btnPasarANoDisponible.Click += new System.EventHandler(this.btnNoDisponible_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.Location = new System.Drawing.Point(15, 64);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(139, 39);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.Red;
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitar.Location = new System.Drawing.Point(160, 64);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(133, 39);
            this.btnQuitar.TabIndex = 16;
            this.btnQuitar.Text = "Eliminar";
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnPasarADisponible
            // 
            this.btnPasarADisponible.BackColor = System.Drawing.Color.Chartreuse;
            this.btnPasarADisponible.FlatAppearance.BorderSize = 0;
            this.btnPasarADisponible.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnPasarADisponible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasarADisponible.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarADisponible.ForeColor = System.Drawing.Color.Black;
            this.btnPasarADisponible.Image = ((System.Drawing.Image)(resources.GetObject("btnPasarADisponible.Image")));
            this.btnPasarADisponible.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPasarADisponible.Location = new System.Drawing.Point(16, 109);
            this.btnPasarADisponible.Name = "btnPasarADisponible";
            this.btnPasarADisponible.Size = new System.Drawing.Size(138, 44);
            this.btnPasarADisponible.TabIndex = 21;
            this.btnPasarADisponible.Text = "Marcar como disponible";
            this.btnPasarADisponible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPasarADisponible.UseVisualStyleBackColor = false;
            this.btnPasarADisponible.Click += new System.EventHandler(this.btnPasarADisponible_Click);
            // 
            // btnEntregado
            // 
            this.btnEntregado.BackColor = System.Drawing.Color.Transparent;
            this.btnEntregado.FlatAppearance.BorderSize = 0;
            this.btnEntregado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btnEntregado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntregado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntregado.ForeColor = System.Drawing.Color.Green;
            this.btnEntregado.Image = ((System.Drawing.Image)(resources.GetObject("btnEntregado.Image")));
            this.btnEntregado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntregado.Location = new System.Drawing.Point(94, 109);
            this.btnEntregado.Name = "btnEntregado";
            this.btnEntregado.Size = new System.Drawing.Size(132, 39);
            this.btnEntregado.TabIndex = 22;
            this.btnEntregado.Text = "Entregado";
            this.btnEntregado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntregado.UseVisualStyleBackColor = false;
            this.btnEntregado.Click += new System.EventHandler(this.btnEntregado_Click);
            // 
            // cmbIds
            // 
            this.cmbIds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIds.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmbIds.ForeColor = System.Drawing.Color.DimGray;
            this.cmbIds.FormattingEnabled = true;
            this.cmbIds.Location = new System.Drawing.Point(39, 24);
            this.cmbIds.Name = "cmbIds";
            this.cmbIds.Size = new System.Drawing.Size(254, 29);
            this.cmbIds.TabIndex = 18;
            // 
            // VentanaId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(305, 163);
            this.Controls.Add(this.btnEntregado);
            this.Controls.Add(this.btnPasarADisponible);
            this.Controls.Add(this.btnPasarANoDisponible);
            this.Controls.Add(this.cmbIds);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaId";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "mainWindowFuncDeactivate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnQuitar;
        private SCmb cmbIds;
        private System.Windows.Forms.Button btnPasarANoDisponible;
        private System.Windows.Forms.Button btnPasarADisponible;
        private System.Windows.Forms.Button btnEntregado;
    }
}