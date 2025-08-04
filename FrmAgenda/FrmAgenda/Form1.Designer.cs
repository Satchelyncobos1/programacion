namespace FrmAgenda
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtApellido = new TextBox();
            txtID = new TextBox();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtobservaciones = new TextBox();
            txtDireccion = new TextBox();
            txtCorreoelectronico = new TextBox();
            rdbMASCULINO = new RadioButton();
            rdbFEMENINO = new RadioButton();
            btneliminar = new Button();
            btnagregar = new Button();
            btnactualizar = new Button();
            btnsalir = new Button();
            dtgAgenda = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            APELLIDO = new DataGridViewTextBoxColumn();
            TELEFONO = new DataGridViewTextBoxColumn();
            CORREO = new DataGridViewTextBoxColumn();
            DIRECCION = new DataGridViewTextBoxColumn();
            GENERO = new DataGridViewTextBoxColumn();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgAgenda).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(481, 22);
            label1.Name = "label1";
            label1.Size = new Size(166, 20);
            label1.TabIndex = 0;
            label1.Text = "AGENDA TELEFONICA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(159, 89);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 0;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(110, 119);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 0;
            label3.Text = "NOMBRE:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(104, 149);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 0;
            label6.Text = "APELLIDO:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(55, 269);
            label8.Name = "label8";
            label8.Size = new Size(133, 20);
            label8.TabIndex = 0;
            label8.Text = "OBSERVACIONES:";
            label8.Click += label5_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(95, 239);
            label9.Name = "label9";
            label9.Size = new Size(93, 20);
            label9.TabIndex = 0;
            label9.Text = "DIRECCION:";
            label9.Click += label5_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 209);
            label10.Name = "label10";
            label10.Size = new Size(176, 20);
            label10.TabIndex = 0;
            label10.Text = "CORREO ELECTRONICO:";
            label10.Click += label5_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(100, 179);
            label11.Name = "label11";
            label11.Size = new Size(88, 20);
            label11.TabIndex = 0;
            label11.Text = "TELEFONO:";
            label11.Click += label5_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(194, 142);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(251, 27);
            txtApellido.TabIndex = 3;
            // 
            // txtID
            // 
            txtID.Location = new Point(194, 82);
            txtID.Name = "txtID";
            txtID.Size = new Size(251, 27);
            txtID.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(194, 112);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(251, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(194, 175);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(251, 27);
            txtTelefono.TabIndex = 4;
            // 
            // txtobservaciones
            // 
            txtobservaciones.Location = new Point(194, 265);
            txtobservaciones.Name = "txtobservaciones";
            txtobservaciones.Size = new Size(251, 27);
            txtobservaciones.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(194, 236);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(251, 27);
            txtDireccion.TabIndex = 6;
            // 
            // txtCorreoelectronico
            // 
            txtCorreoelectronico.Location = new Point(194, 208);
            txtCorreoelectronico.Name = "txtCorreoelectronico";
            txtCorreoelectronico.Size = new Size(251, 27);
            txtCorreoelectronico.TabIndex = 5;
            // 
            // rdbMASCULINO
            // 
            rdbMASCULINO.AutoSize = true;
            rdbMASCULINO.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdbMASCULINO.Location = new Point(178, 298);
            rdbMASCULINO.Name = "rdbMASCULINO";
            rdbMASCULINO.Size = new Size(119, 24);
            rdbMASCULINO.TabIndex = 8;
            rdbMASCULINO.TabStop = true;
            rdbMASCULINO.Text = "MASCULINO";
            rdbMASCULINO.UseVisualStyleBackColor = true;
            // 
            // rdbFEMENINO
            // 
            rdbFEMENINO.AutoSize = true;
            rdbFEMENINO.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdbFEMENINO.Location = new Point(308, 298);
            rdbFEMENINO.Name = "rdbFEMENINO";
            rdbFEMENINO.Size = new Size(108, 24);
            rdbFEMENINO.TabIndex = 9;
            rdbFEMENINO.TabStop = true;
            rdbFEMENINO.Text = "FEMENINO";
            rdbFEMENINO.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            btneliminar.Image = Properties.Resources.Delete_80_icon_icons_com_57340;
            btneliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btneliminar.Location = new Point(209, 360);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(114, 46);
            btneliminar.TabIndex = 11;
            btneliminar.Text = "Eliminar";
            btneliminar.TextAlign = ContentAlignment.MiddleRight;
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnagregar
            // 
            btnagregar.Image = Properties.Resources.Add_User_80_icon_icons_com_57380;
            btnagregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnagregar.Location = new Point(38, 360);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(111, 46);
            btnagregar.TabIndex = 10;
            btnagregar.Text = "Agregar";
            btnagregar.TextAlign = ContentAlignment.MiddleRight;
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.Image = Properties.Resources.Edit_User_80_icon_icons1;
            btnactualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnactualizar.Location = new Point(194, 426);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(111, 44);
            btnactualizar.TabIndex = 13;
            btnactualizar.Text = "Actualizar";
            btnactualizar.TextAlign = ContentAlignment.MiddleRight;
            btnactualizar.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            btnsalir.Image = Properties.Resources.Remove_User_80_icon_icons1;
            btnsalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalir.Location = new Point(38, 426);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(111, 44);
            btnsalir.TabIndex = 12;
            btnsalir.Text = "Salir";
            btnsalir.TextAlign = ContentAlignment.MiddleRight;
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // dtgAgenda
            // 
            dtgAgenda.AllowUserToAddRows = false;
            dtgAgenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAgenda.Columns.AddRange(new DataGridViewColumn[] { ID, NOMBRE, APELLIDO, TELEFONO, CORREO, DIRECCION, GENERO });
            dtgAgenda.Location = new Point(518, 82);
            dtgAgenda.Name = "dtgAgenda";
            dtgAgenda.ReadOnly = true;
            dtgAgenda.RowHeadersVisible = false;
            dtgAgenda.RowHeadersWidth = 51;
            dtgAgenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgAgenda.Size = new Size(925, 388);
            dtgAgenda.TabIndex = 5;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.MinimumWidth = 6;
            NOMBRE.Name = "NOMBRE";
            NOMBRE.ReadOnly = true;
            // 
            // APELLIDO
            // 
            APELLIDO.HeaderText = "APELLIDO";
            APELLIDO.MinimumWidth = 6;
            APELLIDO.Name = "APELLIDO";
            APELLIDO.ReadOnly = true;
            // 
            // TELEFONO
            // 
            TELEFONO.HeaderText = "TELEFONO";
            TELEFONO.MinimumWidth = 6;
            TELEFONO.Name = "TELEFONO";
            TELEFONO.ReadOnly = true;
            // 
            // CORREO
            // 
            CORREO.HeaderText = "CORREO";
            CORREO.MinimumWidth = 6;
            CORREO.Name = "CORREO";
            CORREO.ReadOnly = true;
            // 
            // DIRECCION
            // 
            DIRECCION.HeaderText = "DIRECCION";
            DIRECCION.MinimumWidth = 6;
            DIRECCION.Name = "DIRECCION";
            DIRECCION.ReadOnly = true;
            // 
            // GENERO
            // 
            GENERO.HeaderText = "GENERO";
            GENERO.MinimumWidth = 6;
            GENERO.Name = "GENERO";
            GENERO.ReadOnly = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 300);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 0;
            label4.Text = "GENERO";
            label4.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1508, 492);
            Controls.Add(dtgAgenda);
            Controls.Add(btnsalir);
            Controls.Add(btnactualizar);
            Controls.Add(btnagregar);
            Controls.Add(btneliminar);
            Controls.Add(rdbFEMENINO);
            Controls.Add(rdbMASCULINO);
            Controls.Add(txtID);
            Controls.Add(txtNombre);
            Controls.Add(txtCorreoelectronico);
            Controls.Add(txtDireccion);
            Controls.Add(txtobservaciones);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(label6);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgAgenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtApellido;
        private TextBox txtID;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtobservaciones;
        private TextBox txtDireccion;
        private TextBox txtCorreoelectronico;
        private RadioButton rdbMASCULINO;
        private RadioButton rdbFEMENINO;
        private Button btneliminar;
        private Button btnagregar;
        private Button btnactualizar;
        private Button btnsalir;
        private DataGridView dtgAgenda;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn APELLIDO;
        private DataGridViewTextBoxColumn TELEFONO;
        private DataGridViewTextBoxColumn CORREO;
        private DataGridViewTextBoxColumn DIRECCION;
        private DataGridViewTextBoxColumn GENERO;
        private Label label4;
    }
}
