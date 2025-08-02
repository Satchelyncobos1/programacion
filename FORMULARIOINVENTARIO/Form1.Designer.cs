namespace FORMULARIOINVENTARIO
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
            nombredelproducto = new Label();
            IDProducto = new Label();
            INVENTARIO = new Label();
            descripciondelproducto = new Label();
            preciodelproducto = new Label();
            Stock = new Label();
            comentarios = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            dataGridView1 = new DataGridView();
            btnAGREGAR = new Button();
            btnACTUALIZAR = new Button();
            btnSALIR = new Button();
            btnELIMINAR = new Button();
            PRODUCTOID = new DataGridViewTextBoxColumn();
            PRODUCTONOMBRE = new DataGridViewTextBoxColumn();
            PRODUCTODESCRIPCION = new DataGridViewTextBoxColumn();
            PRODUCTOPRECIO = new DataGridViewTextBoxColumn();
            STOCKK = new DataGridViewTextBoxColumn();
            COMENTARIO = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // nombredelproducto
            // 
            nombredelproducto.AutoSize = true;
            nombredelproducto.Location = new Point(32, 98);
            nombredelproducto.Name = "nombredelproducto";
            nombredelproducto.Size = new Size(157, 20);
            nombredelproducto.TabIndex = 0;
            nombredelproducto.Text = "Nombre del producto:";
            nombredelproducto.Click += label1_Click;
            // 
            // IDProducto
            // 
            IDProducto.AutoSize = true;
            IDProducto.Location = new Point(32, 68);
            IDProducto.Name = "IDProducto";
            IDProducto.Size = new Size(87, 20);
            IDProducto.TabIndex = 0;
            IDProducto.Text = "IDProducto:";
            IDProducto.Click += label2_Click;
            // 
            // INVENTARIO
            // 
            INVENTARIO.AutoSize = true;
            INVENTARIO.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            INVENTARIO.Location = new Point(439, 23);
            INVENTARIO.Name = "INVENTARIO";
            INVENTARIO.Size = new Size(101, 20);
            INVENTARIO.TabIndex = 0;
            INVENTARIO.Text = "INVENTARIO";
            // 
            // descripciondelproducto
            // 
            descripciondelproducto.AutoSize = true;
            descripciondelproducto.Location = new Point(32, 129);
            descripciondelproducto.Name = "descripciondelproducto";
            descripciondelproducto.Size = new Size(180, 20);
            descripciondelproducto.TabIndex = 0;
            descripciondelproducto.Text = "Descripcion del producto:";
            descripciondelproducto.Click += label1_Click;
            // 
            // preciodelproducto
            // 
            preciodelproducto.AutoSize = true;
            preciodelproducto.Location = new Point(398, 68);
            preciodelproducto.Name = "preciodelproducto";
            preciodelproducto.Size = new Size(142, 20);
            preciodelproducto.TabIndex = 1;
            preciodelproducto.Text = "Precio del Producto:";
            // 
            // Stock
            // 
            Stock.AutoSize = true;
            Stock.Location = new Point(760, 65);
            Stock.Name = "Stock";
            Stock.Size = new Size(48, 20);
            Stock.TabIndex = 1;
            Stock.Text = "Stock:";
            // 
            // comentarios
            // 
            comentarios.AutoSize = true;
            comentarios.Location = new Point(398, 98);
            comentarios.Name = "comentarios";
            comentarios.Size = new Size(96, 20);
            comentarios.TabIndex = 1;
            comentarios.Text = "Comentarios:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(195, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(546, 61);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(204, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(209, 126);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(176, 27);
            textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(491, 98);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(481, 27);
            textBox5.TabIndex = 2;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(804, 62);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(168, 27);
            textBox6.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PRODUCTOID, PRODUCTONOMBRE, PRODUCTODESCRIPCION, PRODUCTOPRECIO, STOCKK, COMENTARIO });
            dataGridView1.Location = new Point(75, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(858, 219);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAGREGAR
            // 
            btnAGREGAR.Location = new Point(195, 397);
            btnAGREGAR.Name = "btnAGREGAR";
            btnAGREGAR.Size = new Size(94, 29);
            btnAGREGAR.TabIndex = 4;
            btnAGREGAR.Text = "AGREGAR";
            btnAGREGAR.UseVisualStyleBackColor = true;
            // 
            // btnACTUALIZAR
            // 
            btnACTUALIZAR.Location = new Point(491, 397);
            btnACTUALIZAR.Name = "btnACTUALIZAR";
            btnACTUALIZAR.Size = new Size(106, 29);
            btnACTUALIZAR.TabIndex = 4;
            btnACTUALIZAR.Text = "ACTUALIZAR";
            btnACTUALIZAR.UseVisualStyleBackColor = true;
            // 
            // btnSALIR
            // 
            btnSALIR.Location = new Point(635, 397);
            btnSALIR.Name = "btnSALIR";
            btnSALIR.Size = new Size(94, 29);
            btnSALIR.TabIndex = 4;
            btnSALIR.Text = "SALIR";
            btnSALIR.UseVisualStyleBackColor = true;
            // 
            // btnELIMINAR
            // 
            btnELIMINAR.Location = new Point(347, 397);
            btnELIMINAR.Name = "btnELIMINAR";
            btnELIMINAR.Size = new Size(94, 29);
            btnELIMINAR.TabIndex = 4;
            btnELIMINAR.Text = "ELIMINAR";
            btnELIMINAR.UseVisualStyleBackColor = true;
            // 
            // PRODUCTOID
            // 
            PRODUCTOID.HeaderText = "PRODUCTOID";
            PRODUCTOID.MinimumWidth = 6;
            PRODUCTOID.Name = "PRODUCTOID";
            PRODUCTOID.Width = 125;
            // 
            // PRODUCTONOMBRE
            // 
            PRODUCTONOMBRE.HeaderText = "PRODUCTONOMBRE";
            PRODUCTONOMBRE.MinimumWidth = 6;
            PRODUCTONOMBRE.Name = "PRODUCTONOMBRE";
            PRODUCTONOMBRE.Width = 125;
            // 
            // PRODUCTODESCRIPCION
            // 
            PRODUCTODESCRIPCION.HeaderText = "PRODUCTODESCRIPCION";
            PRODUCTODESCRIPCION.MinimumWidth = 6;
            PRODUCTODESCRIPCION.Name = "PRODUCTODESCRIPCION";
            PRODUCTODESCRIPCION.Width = 125;
            // 
            // PRODUCTOPRECIO
            // 
            PRODUCTOPRECIO.HeaderText = "PRODUCTOPRECIO";
            PRODUCTOPRECIO.MinimumWidth = 6;
            PRODUCTOPRECIO.Name = "PRODUCTOPRECIO";
            PRODUCTOPRECIO.Width = 125;
            // 
            // STOCKK
            // 
            STOCKK.HeaderText = "STOCKK";
            STOCKK.MinimumWidth = 6;
            STOCKK.Name = "STOCKK";
            STOCKK.Width = 125;
            // 
            // COMENTARIO
            // 
            COMENTARIO.HeaderText = "COMENTARIO";
            COMENTARIO.MinimumWidth = 6;
            COMENTARIO.Name = "COMENTARIO";
            COMENTARIO.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 450);
            Controls.Add(btnSALIR);
            Controls.Add(btnELIMINAR);
            Controls.Add(btnACTUALIZAR);
            Controls.Add(btnAGREGAR);
            Controls.Add(dataGridView1);
            Controls.Add(textBox4);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comentarios);
            Controls.Add(Stock);
            Controls.Add(preciodelproducto);
            Controls.Add(INVENTARIO);
            Controls.Add(IDProducto);
            Controls.Add(descripciondelproducto);
            Controls.Add(nombredelproducto);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nombredelproducto;
        private Label IDProducto;
        private Label INVENTARIO;
        private Label descripciondelproducto;
        private Label preciodelproducto;
        private Label Stock;
        private Label comentarios;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private DataGridView dataGridView1;
        private Button btnAGREGAR;
        private Button btnACTUALIZAR;
        private Button btnSALIR;
        private Button btnELIMINAR;
        private DataGridViewTextBoxColumn PRODUCTOID;
        private DataGridViewTextBoxColumn PRODUCTONOMBRE;
        private DataGridViewTextBoxColumn PRODUCTODESCRIPCION;
        private DataGridViewTextBoxColumn PRODUCTOPRECIO;
        private DataGridViewTextBoxColumn STOCKK;
        private DataGridViewTextBoxColumn COMENTARIO;
    }
}
