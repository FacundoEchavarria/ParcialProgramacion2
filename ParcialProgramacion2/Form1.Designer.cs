namespace ParcialProgramacion2
{
partial class Form1
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
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.nombre_lbl = new System.Windows.Forms.Label();
            this.apellido_lbl = new System.Windows.Forms.Label();
            this.edad_lbl = new System.Windows.Forms.Label();
            this.nacimiento_lbl = new System.Windows.Forms.Label();
            this.id_lbl = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.nacimiento_txt = new System.Windows.Forms.TextBox();
            this.apellido_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.agregar_btn = new System.Windows.Forms.Button();
            this.modificar_btn = new System.Windows.Forms.Button();
            this.VerTabla = new System.Windows.Forms.DataGridView();
            this.buscar_txt = new System.Windows.Forms.TextBox();
            this.buscar_btn = new System.Windows.Forms.Button();
            this.ingreso_lbl = new System.Windows.Forms.Label();
            this.ingreso_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Reset_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VerTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_txt
            // 
            this.nombre_txt.Location = new System.Drawing.Point(148, 95);
            this.nombre_txt.Margin = new System.Windows.Forms.Padding(2);
            this.nombre_txt.Multiline = true;
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(190, 23);
            this.nombre_txt.TabIndex = 2;
            // 
            // nombre_lbl
            // 
            this.nombre_lbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.nombre_lbl.Enabled = false;
            this.nombre_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.nombre_lbl.Location = new System.Drawing.Point(9, 96);
            this.nombre_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombre_lbl.Name = "nombre_lbl";
            this.nombre_lbl.Size = new System.Drawing.Size(109, 22);
            this.nombre_lbl.TabIndex = 199;
            this.nombre_lbl.Text = "Nombre";
            this.nombre_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // apellido_lbl
            // 
            this.apellido_lbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.apellido_lbl.Enabled = false;
            this.apellido_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.apellido_lbl.Location = new System.Drawing.Point(9, 139);
            this.apellido_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apellido_lbl.Name = "apellido_lbl";
            this.apellido_lbl.Size = new System.Drawing.Size(109, 21);
            this.apellido_lbl.TabIndex = 288;
            this.apellido_lbl.Text = "Apellido";
            this.apellido_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // edad_lbl
            // 
            this.edad_lbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.edad_lbl.Enabled = false;
            this.edad_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edad_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.edad_lbl.Location = new System.Drawing.Point(9, 224);
            this.edad_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edad_lbl.Name = "edad_lbl";
            this.edad_lbl.Size = new System.Drawing.Size(109, 22);
            this.edad_lbl.TabIndex = 488;
            this.edad_lbl.Text = "Email";
            this.edad_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nacimiento_lbl
            // 
            this.nacimiento_lbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.nacimiento_lbl.Enabled = false;
            this.nacimiento_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nacimiento_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.nacimiento_lbl.Location = new System.Drawing.Point(9, 181);
            this.nacimiento_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nacimiento_lbl.Name = "nacimiento_lbl";
            this.nacimiento_lbl.Size = new System.Drawing.Size(109, 22);
            this.nacimiento_lbl.TabIndex = 588;
            this.nacimiento_lbl.Text = "Nacimiento";
            this.nacimiento_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // id_lbl
            // 
            this.id_lbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.id_lbl.Enabled = false;
            this.id_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.id_lbl.Location = new System.Drawing.Point(9, 53);
            this.id_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(109, 22);
            this.id_lbl.TabIndex = 100;
            this.id_lbl.Text = "id";
            this.id_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // id_txt
            // 
            this.id_txt.Enabled = false;
            this.id_txt.Location = new System.Drawing.Point(148, 52);
            this.id_txt.Margin = new System.Windows.Forms.Padding(2);
            this.id_txt.Multiline = true;
            this.id_txt.Name = "id_txt";
            this.id_txt.ReadOnly = true;
            this.id_txt.Size = new System.Drawing.Size(190, 23);
            this.id_txt.TabIndex = 1;
            // 
            // nacimiento_txt
            // 
            this.nacimiento_txt.Location = new System.Drawing.Point(148, 180);
            this.nacimiento_txt.Margin = new System.Windows.Forms.Padding(2);
            this.nacimiento_txt.Multiline = true;
            this.nacimiento_txt.Name = "nacimiento_txt";
            this.nacimiento_txt.Size = new System.Drawing.Size(190, 23);
            this.nacimiento_txt.TabIndex = 4;
            // 
            // apellido_txt
            // 
            this.apellido_txt.Location = new System.Drawing.Point(148, 137);
            this.apellido_txt.Margin = new System.Windows.Forms.Padding(2);
            this.apellido_txt.Multiline = true;
            this.apellido_txt.Name = "apellido_txt";
            this.apellido_txt.Size = new System.Drawing.Size(190, 23);
            this.apellido_txt.TabIndex = 3;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(148, 223);
            this.email_txt.Margin = new System.Windows.Forms.Padding(2);
            this.email_txt.Multiline = true;
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(190, 23);
            this.email_txt.TabIndex = 5;
            // 
            // agregar_btn
            // 
            this.agregar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_btn.Location = new System.Drawing.Point(62, 309);
            this.agregar_btn.Margin = new System.Windows.Forms.Padding(2);
            this.agregar_btn.Name = "agregar_btn";
            this.agregar_btn.Size = new System.Drawing.Size(90, 32);
            this.agregar_btn.TabIndex = 7;
            this.agregar_btn.Text = "Agregar";
            this.agregar_btn.UseVisualStyleBackColor = true;
            this.agregar_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // modificar_btn
            // 
            this.modificar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar_btn.Location = new System.Drawing.Point(168, 309);
            this.modificar_btn.Margin = new System.Windows.Forms.Padding(2);
            this.modificar_btn.Name = "modificar_btn";
            this.modificar_btn.Size = new System.Drawing.Size(90, 32);
            this.modificar_btn.TabIndex = 20;
            this.modificar_btn.Text = "Modificar";
            this.modificar_btn.UseVisualStyleBackColor = true;
            this.modificar_btn.Click += new System.EventHandler(this.modificar_btn_Click);
            // 
            // VerTabla
            // 
            this.VerTabla.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.VerTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VerTabla.Location = new System.Drawing.Point(374, 82);
            this.VerTabla.Margin = new System.Windows.Forms.Padding(2);
            this.VerTabla.Name = "VerTabla";
            this.VerTabla.RowHeadersWidth = 51;
            this.VerTabla.RowTemplate.Height = 24;
            this.VerTabla.Size = new System.Drawing.Size(444, 396);
            this.VerTabla.TabIndex = 21;
            // 
            // buscar_txt
            // 
            this.buscar_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_txt.Location = new System.Drawing.Point(374, 42);
            this.buscar_txt.Margin = new System.Windows.Forms.Padding(2);
            this.buscar_txt.Multiline = true;
            this.buscar_txt.Name = "buscar_txt";
            this.buscar_txt.Size = new System.Drawing.Size(350, 33);
            this.buscar_txt.TabIndex = 23;
            // 
            // buscar_btn
            // 
            this.buscar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_btn.Location = new System.Drawing.Point(741, 42);
            this.buscar_btn.Margin = new System.Windows.Forms.Padding(2);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Size = new System.Drawing.Size(90, 32);
            this.buscar_btn.TabIndex = 24;
            this.buscar_btn.Text = "Buscar";
            this.buscar_btn.UseVisualStyleBackColor = true;
            this.buscar_btn.Click += new System.EventHandler(this.buscar_btn_Click);
            // 
            // ingreso_lbl
            // 
            this.ingreso_lbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.ingreso_lbl.Enabled = false;
            this.ingreso_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingreso_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.ingreso_lbl.Location = new System.Drawing.Point(9, 267);
            this.ingreso_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ingreso_lbl.Name = "ingreso_lbl";
            this.ingreso_lbl.Size = new System.Drawing.Size(109, 22);
            this.ingreso_lbl.TabIndex = 258;
            this.ingreso_lbl.Text = "Ingreso";
            this.ingreso_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ingreso_txt
            // 
            this.ingreso_txt.Location = new System.Drawing.Point(148, 266);
            this.ingreso_txt.Margin = new System.Windows.Forms.Padding(2);
            this.ingreso_txt.Multiline = true;
            this.ingreso_txt.Name = "ingreso_txt";
            this.ingreso_txt.Size = new System.Drawing.Size(190, 23);
            this.ingreso_txt.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(374, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(628, 396);
            this.dataGridView1.TabIndex = 27;
            // 
            // Reset_btn
            // 
            this.Reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_btn.Location = new System.Drawing.Point(835, 42);
            this.Reset_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(90, 32);
            this.Reset_btn.TabIndex = 589;
            this.Reset_btn.Text = "Reset";
            this.Reset_btn.UseVisualStyleBackColor = true;
            this.Reset_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1029, 555);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ingreso_txt);
            this.Controls.Add(this.ingreso_lbl);
            this.Controls.Add(this.buscar_btn);
            this.Controls.Add(this.buscar_txt);
            this.Controls.Add(this.VerTabla);
            this.Controls.Add(this.apellido_txt);
            this.Controls.Add(this.modificar_btn);
            this.Controls.Add(this.agregar_btn);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.nacimiento_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.nacimiento_lbl);
            this.Controls.Add(this.edad_lbl);
            this.Controls.Add(this.apellido_lbl);
            this.Controls.Add(this.nombre_lbl);
            this.Controls.Add(this.nombre_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.VerTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.Label nombre_lbl;
        private System.Windows.Forms.Label apellido_lbl;
        private System.Windows.Forms.Label edad_lbl;
        private System.Windows.Forms.Label nacimiento_lbl;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox nacimiento_txt;
        private System.Windows.Forms.TextBox apellido_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Button agregar_btn;
        private System.Windows.Forms.Button modificar_btn;
        private System.Windows.Forms.DataGridView VerTabla;
        private System.Windows.Forms.TextBox buscar_txt;
        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.Label ingreso_lbl;
        private System.Windows.Forms.TextBox ingreso_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Reset_btn;
    }
}