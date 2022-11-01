namespace TPConstruccion
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_Nombre = new System.Windows.Forms.TextBox();
            this.tbox_Apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_NroRifa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // tbox_Nombre
            // 
            this.tbox_Nombre.Location = new System.Drawing.Point(153, 49);
            this.tbox_Nombre.Name = "tbox_Nombre";
            this.tbox_Nombre.Size = new System.Drawing.Size(182, 23);
            this.tbox_Nombre.TabIndex = 2;
            this.tbox_Nombre.TextChanged += new System.EventHandler(this.tbox_Nombre_TextChanged);
            // 
            // tbox_Apellido
            // 
            this.tbox_Apellido.Location = new System.Drawing.Point(153, 114);
            this.tbox_Apellido.Name = "tbox_Apellido";
            this.tbox_Apellido.Size = new System.Drawing.Size(182, 23);
            this.tbox_Apellido.TabIndex = 4;
            this.tbox_Apellido.TextChanged += new System.EventHandler(this.tbox_Apellido_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido";
            // 
            // tbox_NroRifa
            // 
            this.tbox_NroRifa.Location = new System.Drawing.Point(153, 180);
            this.tbox_NroRifa.Name = "tbox_NroRifa";
            this.tbox_NroRifa.Size = new System.Drawing.Size(182, 23);
            this.tbox_NroRifa.TabIndex = 6;
            this.tbox_NroRifa.TextChanged += new System.EventHandler(this.tbox_NroRifa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero de rifa";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(192, 248);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(107, 29);
            this.btn_Guardar.TabIndex = 7;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.tbox_NroRifa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbox_Apellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbox_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de rifa";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbox_Nombre;
        private TextBox tbox_Apellido;
        private Label label3;
        private TextBox tbox_NroRifa;
        private Label label4;
        private Button btn_Guardar;
        private ErrorProvider errorProvider;
    }
}