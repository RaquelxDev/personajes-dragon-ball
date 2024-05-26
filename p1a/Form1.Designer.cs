namespace p1a
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
            this.buttonPrueba = new System.Windows.Forms.Button();
            this.dataGridView1Personajes = new System.Windows.Forms.DataGridView();
            this.button2Cargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1Nivelpoder = new System.Windows.Forms.NumericUpDown();
            this.textBox1ID = new System.Windows.Forms.TextBox();
            this.textBox2Nombre = new System.Windows.Forms.TextBox();
            this.button3Crear = new System.Windows.Forms.Button();
            this.button4Buscar = new System.Windows.Forms.Button();
            this.comboBoxraza = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxHistoria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Personajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Nivelpoder)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrueba
            // 
            this.buttonPrueba.Location = new System.Drawing.Point(634, 353);
            this.buttonPrueba.Name = "buttonPrueba";
            this.buttonPrueba.Size = new System.Drawing.Size(89, 66);
            this.buttonPrueba.TabIndex = 0;
            this.buttonPrueba.Text = "Boton prueba conexion";
            this.buttonPrueba.UseVisualStyleBackColor = true;
            this.buttonPrueba.Click += new System.EventHandler(this.buttonPrueba_Click);
            // 
            // dataGridView1Personajes
            // 
            this.dataGridView1Personajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Personajes.Location = new System.Drawing.Point(52, 232);
            this.dataGridView1Personajes.Name = "dataGridView1Personajes";
            this.dataGridView1Personajes.RowHeadersWidth = 51;
            this.dataGridView1Personajes.RowTemplate.Height = 24;
            this.dataGridView1Personajes.Size = new System.Drawing.Size(554, 206);
            this.dataGridView1Personajes.TabIndex = 1;
            this.dataGridView1Personajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2Cargar
            // 
            this.button2Cargar.Location = new System.Drawing.Point(398, 175);
            this.button2Cargar.Name = "button2Cargar";
            this.button2Cargar.Size = new System.Drawing.Size(102, 39);
            this.button2Cargar.TabIndex = 2;
            this.button2Cargar.Text = "Cargar datos";
            this.button2Cargar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Raza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Power";
            // 
            // numericUpDown1Nivelpoder
            // 
            this.numericUpDown1Nivelpoder.Location = new System.Drawing.Point(136, 132);
            this.numericUpDown1Nivelpoder.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown1Nivelpoder.Name = "numericUpDown1Nivelpoder";
            this.numericUpDown1Nivelpoder.Size = new System.Drawing.Size(155, 22);
            this.numericUpDown1Nivelpoder.TabIndex = 7;
            // 
            // textBox1ID
            // 
            this.textBox1ID.Location = new System.Drawing.Point(136, 17);
            this.textBox1ID.Name = "textBox1ID";
            this.textBox1ID.Size = new System.Drawing.Size(155, 22);
            this.textBox1ID.TabIndex = 4;
            // 
            // textBox2Nombre
            // 
            this.textBox2Nombre.Location = new System.Drawing.Point(136, 51);
            this.textBox2Nombre.Name = "textBox2Nombre";
            this.textBox2Nombre.Size = new System.Drawing.Size(155, 22);
            this.textBox2Nombre.TabIndex = 9;
            // 
            // button3Crear
            // 
            this.button3Crear.Location = new System.Drawing.Point(302, 175);
            this.button3Crear.Name = "button3Crear";
            this.button3Crear.Size = new System.Drawing.Size(75, 39);
            this.button3Crear.TabIndex = 11;
            this.button3Crear.Text = "Crear";
            this.button3Crear.UseVisualStyleBackColor = true;
            this.button3Crear.Click += new System.EventHandler(this.button3Crear_Click);
            // 
            // button4Buscar
            // 
            this.button4Buscar.Location = new System.Drawing.Point(171, 175);
            this.button4Buscar.Name = "button4Buscar";
            this.button4Buscar.Size = new System.Drawing.Size(120, 39);
            this.button4Buscar.TabIndex = 13;
            this.button4Buscar.Text = "Buscar nombre";
            this.button4Buscar.UseVisualStyleBackColor = true;
            this.button4Buscar.Click += new System.EventHandler(this.button4Buscar_Click);
            // 
            // comboBoxraza
            // 
            this.comboBoxraza.FormattingEnabled = true;
            this.comboBoxraza.Location = new System.Drawing.Point(136, 85);
            this.comboBoxraza.Name = "comboBoxraza";
            this.comboBoxraza.Size = new System.Drawing.Size(155, 24);
            this.comboBoxraza.TabIndex = 15;
            this.comboBoxraza.SelectedIndexChanged += new System.EventHandler(this.comboBoxraza_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(398, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(267, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // textBoxHistoria
            // 
            this.textBoxHistoria.Location = new System.Drawing.Point(398, 132);
            this.textBoxHistoria.Name = "textBoxHistoria";
            this.textBoxHistoria.Size = new System.Drawing.Size(237, 22);
            this.textBoxHistoria.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Historia";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(52, 175);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(96, 39);
            this.buttonLimpiar.TabIndex = 19;
            this.buttonLimpiar.Text = "Limpiar todo";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxHistoria);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxraza);
            this.Controls.Add(this.button4Buscar);
            this.Controls.Add(this.button3Crear);
            this.Controls.Add(this.textBox2Nombre);
            this.Controls.Add(this.textBox1ID);
            this.Controls.Add(this.numericUpDown1Nivelpoder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2Cargar);
            this.Controls.Add(this.dataGridView1Personajes);
            this.Controls.Add(this.buttonPrueba);
            this.Name = "Form1";
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Personajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Nivelpoder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrueba;
        private System.Windows.Forms.DataGridView dataGridView1Personajes;
        private System.Windows.Forms.Button button2Cargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1Nivelpoder;
        private System.Windows.Forms.TextBox textBox1ID;
        private System.Windows.Forms.TextBox textBox2Nombre;
        private System.Windows.Forms.Button button3Crear;
        private System.Windows.Forms.Button button4Buscar;
        private System.Windows.Forms.ComboBox comboBoxraza;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxHistoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}

