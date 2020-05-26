using System.ComponentModel;

namespace Icecreams_land
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(36, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 23);
            this.textBox2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(293, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 82);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurar tipo de usuario";
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
            // Button1
            // 
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.Location = new System.Drawing.Point(191, 123);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(147, 24);
            this.Button1.TabIndex = 14;
            this.Button1.Text = "Registrarse";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Icecreams_land.Properties.Resources.Rectangle_6;
            this.ClientSize = new System.Drawing.Size(542, 162);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}