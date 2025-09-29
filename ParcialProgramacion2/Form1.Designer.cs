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
            this.listar_btn = new System.Windows.Forms.Button();
            this.modificar_btn = new System.Windows.Forms.Button();
            this.VerTabla = new System.Windows.Forms.DataGridView();
            this.buscar_txt = new System.Windows.Forms.TextBox();
            this.buscar_btn = new System.Windows.Forms.Button();
            this.ingreso_lbl = new System.Windows.Forms.Label();
            this.ingreso_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.VerTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_txt
            // 
            this.nombre_txt.Location = new System.Drawing.Point(117, 82);
            this.nombre_txt.Margin = new System.Windows.Forms.Padding(2);
            this.nombre_txt.Multiline = true;
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(190, 23);
            this.nombre_txt.TabIndex = 0;
            // 
            // nombre_lbl
            // 
            this.nombre_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nombre_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_lbl.Location = new System.Drawing.Point(10, 82);
            this.nombre_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombre_lbl.Name = "nombre_lbl";
            this.nombre_lbl.Size = new System.Drawing.Size(93, 22);
            this.nombre_lbl.TabIndex = 1;
            this.nombre_lbl.Text = "Nombre";
            // 
            // apellido_lbl
            // 
            this.apellido_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.apellido_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido_lbl.Location = new System.Drawing.Point(10, 113);
            this.apellido_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apellido_lbl.Name = "apellido_lbl";
            this.apellido_lbl.Size = new System.Drawing.Size(93, 21);
            this.apellido_lbl.TabIndex = 2;
            this.apellido_lbl.Text = "Apellido";
            // 
            // edad_lbl
            // 
            this.edad_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.edad_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edad_lbl.Location = new System.Drawing.Point(10, 176);
            this.edad_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edad_lbl.Name = "edad_lbl";
            this.edad_lbl.Size = new System.Drawing.Size(93, 22);
            this.edad_lbl.TabIndex = 4;
            this.edad_lbl.Text = "Email";
            this.edad_lbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // nacimiento_lbl
            // 
            this.nacimiento_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nacimiento_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nacimiento_lbl.Location = new System.Drawing.Point(10, 144);
            this.nacimiento_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nacimiento_lbl.Name = "nacimiento_lbl";
            this.nacimiento_lbl.Size = new System.Drawing.Size(93, 22);
            this.nacimiento_lbl.TabIndex = 5;
            this.nacimiento_lbl.Text = "Nacimiento";
            // 
            // id_lbl
            // 
            this.id_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.id_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.Location = new System.Drawing.Point(9, 53);
            this.id_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(93, 22);
            this.id_lbl.TabIndex = 11;
            this.id_lbl.Text = "id";
            this.id_lbl.Click += new System.EventHandler(this.label6_Click);
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(117, 53);
            this.id_txt.Margin = new System.Windows.Forms.Padding(2);
            this.id_txt.Multiline = true;
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(190, 23);
            this.id_txt.TabIndex = 12;
            // 
            // nacimiento_txt
            // 
            this.nacimiento_txt.Location = new System.Drawing.Point(117, 144);
            this.nacimiento_txt.Margin = new System.Windows.Forms.Padding(2);
            this.nacimiento_txt.Multiline = true;
            this.nacimiento_txt.Name = "nacimiento_txt";
            this.nacimiento_txt.Size = new System.Drawing.Size(190, 23);
            this.nacimiento_txt.TabIndex = 13;
            // 
            // apellido_txt
            // 
            this.apellido_txt.Location = new System.Drawing.Point(117, 112);
            this.apellido_txt.Margin = new System.Windows.Forms.Padding(2);
            this.apellido_txt.Multiline = true;
            this.apellido_txt.Name = "apellido_txt";
            this.apellido_txt.Size = new System.Drawing.Size(190, 23);
            this.apellido_txt.TabIndex = 14;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(117, 180);
            this.email_txt.Margin = new System.Windows.Forms.Padding(2);
            this.email_txt.Multiline = true;
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(190, 23);
            this.email_txt.TabIndex = 15;
            // 
            // agregar_btn
            // 
            this.agregar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_btn.Location = new System.Drawing.Point(12, 256);
            this.agregar_btn.Margin = new System.Windows.Forms.Padding(2);
            this.agregar_btn.Name = "agregar_btn";
            this.agregar_btn.Size = new System.Drawing.Size(90, 32);
            this.agregar_btn.TabIndex = 17;
            this.agregar_btn.Text = "Agregar";
            this.agregar_btn.UseVisualStyleBackColor = true;
            this.agregar_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // listar_btn
            // 
            this.listar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listar_btn.Location = new System.Drawing.Point(107, 256);
            this.listar_btn.Margin = new System.Windows.Forms.Padding(2);
            this.listar_btn.Name = "listar_btn";
            this.listar_btn.Size = new System.Drawing.Size(90, 32);
            this.listar_btn.TabIndex = 19;
            this.listar_btn.Text = "Listar";
            this.listar_btn.UseVisualStyleBackColor = true;
            this.listar_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // modificar_btn
            // 
            this.modificar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar_btn.Location = new System.Drawing.Point(202, 256);
            this.modificar_btn.Margin = new System.Windows.Forms.Padding(2);
            this.modificar_btn.Name = "modificar_btn";
            this.modificar_btn.Size = new System.Drawing.Size(90, 32);
            this.modificar_btn.TabIndex = 20;
            this.modificar_btn.Text = "Modificar";
            this.modificar_btn.UseVisualStyleBackColor = true;
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
            this.buscar_txt.Location = new System.Drawing.Point(374, 40);
            this.buscar_txt.Margin = new System.Windows.Forms.Padding(2);
            this.buscar_txt.Multiline = true;
            this.buscar_txt.Name = "buscar_txt";
            this.buscar_txt.Size = new System.Drawing.Size(350, 33);
            this.buscar_txt.TabIndex = 23;
            // 
            // buscar_btn
            // 
            this.buscar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_btn.Location = new System.Drawing.Point(728, 40);
            this.buscar_btn.Margin = new System.Windows.Forms.Padding(2);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Size = new System.Drawing.Size(90, 32);
            this.buscar_btn.TabIndex = 24;
            this.buscar_btn.Text = "Buscar";
            this.buscar_btn.UseVisualStyleBackColor = true;
            // 
            // ingreso_lbl
            // 
            this.ingreso_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ingreso_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingreso_lbl.Location = new System.Drawing.Point(10, 207);
            this.ingreso_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ingreso_lbl.Name = "ingreso_lbl";
            this.ingreso_lbl.Size = new System.Drawing.Size(93, 22);
            this.ingreso_lbl.TabIndex = 25;
            this.ingreso_lbl.Text = "Ingreso";
            this.ingreso_lbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ingreso_txt
            // 
            this.ingreso_txt.Location = new System.Drawing.Point(117, 210);
            this.ingreso_txt.Margin = new System.Windows.Forms.Padding(2);
            this.ingreso_txt.Multiline = true;
            this.ingreso_txt.Name = "ingreso_txt";
            this.ingreso_txt.Size = new System.Drawing.Size(190, 23);
            this.ingreso_txt.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(374, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 396);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(873, 530);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ingreso_txt);
            this.Controls.Add(this.ingreso_lbl);
            this.Controls.Add(this.buscar_btn);
            this.Controls.Add(this.buscar_txt);
            this.Controls.Add(this.VerTabla);
            this.Controls.Add(this.apellido_txt);
            this.Controls.Add(this.modificar_btn);
            this.Controls.Add(this.listar_btn);
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
        private System.Windows.Forms.Button listar_btn;
        private System.Windows.Forms.Button modificar_btn;
        private System.Windows.Forms.DataGridView VerTabla;
        private System.Windows.Forms.TextBox buscar_txt;
        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.Label ingreso_lbl;
        private System.Windows.Forms.TextBox ingreso_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}