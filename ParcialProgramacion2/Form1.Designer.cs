namespace ParcialProgramacion2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.nombre_lbl = new System.Windows.Forms.Label();
            this.apellido_lbl = new System.Windows.Forms.Label();
            this.edad_lbl = new System.Windows.Forms.Label();
            this.nacimiento_lbl = new System.Windows.Forms.Label();
            this.id_lbl = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.nacimiento_dtp = new System.Windows.Forms.DateTimePicker();
            this.apellido_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.agregar_btn = new System.Windows.Forms.Button();
            this.modificar_btn = new System.Windows.Forms.Button();
            this.buscar_txt = new System.Windows.Forms.TextBox();
            this.buscar_btn = new System.Windows.Forms.Button();
            this.ingreso_lbl = new System.Windows.Forms.Label();
            this.ingreso_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eliminar_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_txt
            // 
            this.nombre_txt.Location = new System.Drawing.Point(12, 81);
            this.nombre_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombre_txt.Multiline = true;
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(396, 27);
            this.nombre_txt.TabIndex = 0;
            // 
            // nombre_lbl
            // 
            this.nombre_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nombre_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_lbl.Location = new System.Drawing.Point(12, 52);
            this.nombre_lbl.Name = "nombre_lbl";
            this.nombre_lbl.Size = new System.Drawing.Size(396, 27);
            this.nombre_lbl.TabIndex = 1;
            this.nombre_lbl.Text = "Nombre";
            // 
            // apellido_lbl
            // 
            this.apellido_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.apellido_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido_lbl.Location = new System.Drawing.Point(12, 119);
            this.apellido_lbl.Name = "apellido_lbl";
            this.apellido_lbl.Size = new System.Drawing.Size(396, 26);
            this.apellido_lbl.TabIndex = 2;
            this.apellido_lbl.Text = "Apellido";
            // 
            // edad_lbl
            // 
            this.edad_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.edad_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edad_lbl.Location = new System.Drawing.Point(12, 254);
            this.edad_lbl.Name = "edad_lbl";
            this.edad_lbl.Size = new System.Drawing.Size(396, 27);
            this.edad_lbl.TabIndex = 4;
            this.edad_lbl.Text = "Correo Electronico";
            // 
            // nacimiento_lbl
            // 
            this.nacimiento_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nacimiento_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nacimiento_lbl.Location = new System.Drawing.Point(12, 186);
            this.nacimiento_lbl.Name = "nacimiento_lbl";
            this.nacimiento_lbl.Size = new System.Drawing.Size(396, 27);
            this.nacimiento_lbl.TabIndex = 5;
            this.nacimiento_lbl.Text = "Nacimiento";
            // 
            // id_lbl
            // 
            this.id_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.id_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.Location = new System.Drawing.Point(12, 13);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(216, 27);
            this.id_lbl.TabIndex = 11;
            this.id_lbl.Text = "Codigo de Alumno (ID)";
            // 
            // id_txt
            // 
            this.id_txt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.id_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_txt.ForeColor = System.Drawing.SystemColors.Window;
            this.id_txt.Location = new System.Drawing.Point(234, 13);
            this.id_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_txt.Multiline = true;
            this.id_txt.Name = "id_txt";
            this.id_txt.ReadOnly = true;
            this.id_txt.Size = new System.Drawing.Size(174, 27);
            this.id_txt.TabIndex = 12;
            this.id_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nacimiento_dtp
            // 
            this.nacimiento_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nacimiento_dtp.Location = new System.Drawing.Point(12, 215);
            this.nacimiento_dtp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nacimiento_dtp.Name = "nacimiento_dtp";
            this.nacimiento_dtp.Size = new System.Drawing.Size(396, 22);
            this.nacimiento_dtp.TabIndex = 13;
            // 
            // apellido_txt
            // 
            this.apellido_txt.Location = new System.Drawing.Point(12, 147);
            this.apellido_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.apellido_txt.Multiline = true;
            this.apellido_txt.Name = "apellido_txt";
            this.apellido_txt.Size = new System.Drawing.Size(396, 27);
            this.apellido_txt.TabIndex = 14;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(12, 283);
            this.email_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email_txt.Multiline = true;
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(396, 27);
            this.email_txt.TabIndex = 15;
            // 
            // agregar_btn
            // 
            this.agregar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.agregar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.agregar_btn.Location = new System.Drawing.Point(37, 412);
            this.agregar_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agregar_btn.Name = "agregar_btn";
            this.agregar_btn.Size = new System.Drawing.Size(120, 78);
            this.agregar_btn.TabIndex = 17;
            this.agregar_btn.Text = "Agregar";
            this.agregar_btn.UseVisualStyleBackColor = false;
            this.agregar_btn.Click += new System.EventHandler(this.agregar_btn_Click);
            // 
            // modificar_btn
            // 
            this.modificar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar_btn.Location = new System.Drawing.Point(289, 412);
            this.modificar_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modificar_btn.Name = "modificar_btn";
            this.modificar_btn.Size = new System.Drawing.Size(120, 78);
            this.modificar_btn.TabIndex = 20;
            this.modificar_btn.Text = "Modificar";
            this.modificar_btn.UseVisualStyleBackColor = true;
            this.modificar_btn.Click += new System.EventHandler(this.modificar_btn_Click);
            // 
            // buscar_txt
            // 
            this.buscar_txt.Location = new System.Drawing.Point(427, 11);
            this.buscar_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buscar_txt.Multiline = true;
            this.buscar_txt.Name = "buscar_txt";
            this.buscar_txt.Size = new System.Drawing.Size(698, 39);
            this.buscar_txt.TabIndex = 23;
            // 
            // buscar_btn
            // 
            this.buscar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_btn.Location = new System.Drawing.Point(1133, 11);
            this.buscar_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Size = new System.Drawing.Size(118, 39);
            this.buscar_btn.TabIndex = 24;
            this.buscar_btn.Text = "Buscar";
            this.buscar_btn.UseVisualStyleBackColor = true;
            this.buscar_btn.Click += new System.EventHandler(this.buscar_btn_Click);
            // 
            // ingreso_lbl
            // 
            this.ingreso_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ingreso_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingreso_lbl.Location = new System.Drawing.Point(12, 325);
            this.ingreso_lbl.Name = "ingreso_lbl";
            this.ingreso_lbl.Size = new System.Drawing.Size(396, 27);
            this.ingreso_lbl.TabIndex = 25;
            this.ingreso_lbl.Text = "Año de Ingreso";
            // 
            // ingreso_txt
            // 
            this.ingreso_txt.Location = new System.Drawing.Point(12, 354);
            this.ingreso_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ingreso_txt.Multiline = true;
            this.ingreso_txt.Name = "ingreso_txt";
            this.ingreso_txt.Size = new System.Drawing.Size(396, 27);
            this.ingreso_txt.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(427, 56);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1125, 434);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VerTabla_CellClick);
            // 
            // eliminar_btn
            // 
            this.eliminar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.eliminar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eliminar_btn.Location = new System.Drawing.Point(163, 412);
            this.eliminar_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eliminar_btn.Name = "eliminar_btn";
            this.eliminar_btn.Size = new System.Drawing.Size(120, 78);
            this.eliminar_btn.TabIndex = 28;
            this.eliminar_btn.Text = "Eliminar";
            this.eliminar_btn.UseVisualStyleBackColor = false;
            this.eliminar_btn.Click += new System.EventHandler(this.eliminar_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1565, 505);
            this.Controls.Add(this.eliminar_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ingreso_txt);
            this.Controls.Add(this.ingreso_lbl);
            this.Controls.Add(this.buscar_btn);
            this.Controls.Add(this.buscar_txt);
            this.Controls.Add(this.apellido_txt);
            this.Controls.Add(this.modificar_btn);
            this.Controls.Add(this.agregar_btn);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.nacimiento_dtp);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.nacimiento_lbl);
            this.Controls.Add(this.edad_lbl);
            this.Controls.Add(this.apellido_lbl);
            this.Controls.Add(this.nombre_lbl);
            this.Controls.Add(this.nombre_txt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.DateTimePicker nacimiento_dtp;
        private System.Windows.Forms.TextBox apellido_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Button agregar_btn;
        private System.Windows.Forms.Button modificar_btn;
        private System.Windows.Forms.TextBox buscar_txt;
        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.Label ingreso_lbl;
        private System.Windows.Forms.TextBox ingreso_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button eliminar_btn;
    }
}