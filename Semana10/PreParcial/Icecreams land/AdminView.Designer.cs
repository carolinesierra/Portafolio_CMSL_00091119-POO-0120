using System.ComponentModel;

namespace Icecreams_land
{
    partial class AdminView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.txtNuevoEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radInactivo = new System.Windows.Forms.RadioButton();
            this.radActivo = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvEmpleados)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(657, 346);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Icecreams_land.Properties.Resources.Rectangle_6;
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnActualizar);
            this.tabPage1.Controls.Add(this.dgvEmpleados);
            this.tabPage1.Controls.Add(this.btnCrearUsuario);
            this.tabPage1.Controls.Add(this.txtNuevoEmpleado);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(649, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar usuario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 83);
            this.textBox1.MaxLength = 25;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 23);
            this.textBox1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(399, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 82);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurar tipo de usuario";
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(45, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(141, 24);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Administrador";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(45, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(141, 24);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cliente";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(65, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Contraseña:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(245, 283);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(129, 27);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar datos";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(87, 175);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.Size = new System.Drawing.Size(447, 102);
            this.dgvEmpleados.TabIndex = 10;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(245, 130);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(129, 27);
            this.btnCrearUsuario.TabIndex = 9;
            this.btnCrearUsuario.Text = "Crear usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            // 
            // txtNuevoEmpleado
            // 
            this.txtNuevoEmpleado.Location = new System.Drawing.Point(199, 44);
            this.txtNuevoEmpleado.MaxLength = 25;
            this.txtNuevoEmpleado.Name = "txtNuevoEmpleado";
            this.txtNuevoEmpleado.Size = new System.Drawing.Size(175, 23);
            this.txtNuevoEmpleado.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(65, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Icecreams_land.Properties.Resources.Rectangle_6;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.cmbUsuario);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(649, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar usuarios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Location = new System.Drawing.Point(59, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 90);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar cuenta:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(57, 38);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 27);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.radInactivo);
            this.groupBox2.Controls.Add(this.radActivo);
            this.groupBox2.Location = new System.Drawing.Point(359, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 90);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurar activo o inactivo:";
            // 
            // radInactivo
            // 
            this.radInactivo.Location = new System.Drawing.Point(45, 52);
            this.radInactivo.Name = "radInactivo";
            this.radInactivo.Size = new System.Drawing.Size(141, 24);
            this.radInactivo.TabIndex = 3;
            this.radInactivo.Text = "Inactivo";
            this.radInactivo.UseVisualStyleBackColor = true;
            // 
            // radActivo
            // 
            this.radActivo.Checked = true;
            this.radActivo.Location = new System.Drawing.Point(45, 22);
            this.radActivo.Name = "radActivo";
            this.radActivo.Size = new System.Drawing.Size(141, 24);
            this.radActivo.TabIndex = 2;
            this.radActivo.TabStop = true;
            this.radActivo.Text = "Activo";
            this.radActivo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(255, 243);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 27);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(134, 44);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(175, 23);
            this.cmbUsuario.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cliente:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Icecreams_land.Properties.Resources.Rectangle_6;
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(649, 318);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Inventario";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Descripción:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Descripción:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Articulo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 27);
            this.button1.TabIndex = 12;
            this.button1.Text = "Actualizar datos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(101, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 112);
            this.dataGridView1.TabIndex = 11;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::Icecreams_land.Properties.Resources.Rectangle_6;
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(649, 318);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Historial de pedidos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Icecreams_land.Properties.Resources.Rectangle_6;
            this.ClientSize = new System.Drawing.Size(657, 346);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminView";
            this.Text = "AdminView";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvEmpleados)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radActivo;
        private System.Windows.Forms.RadioButton radInactivo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNuevoEmpleado;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}