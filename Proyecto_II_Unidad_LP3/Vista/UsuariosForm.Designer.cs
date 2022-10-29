namespace Vista
{
    partial class UsuariosForm
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
            this.Codigolabel = new System.Windows.Forms.Label();
            this.CodigotextBox = new System.Windows.Forms.TextBox();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.Clavelabel = new System.Windows.Forms.Label();
            this.ClavetextBox = new System.Windows.Forms.TextBox();
            this.Correolabel = new System.Windows.Forms.Label();
            this.CorreotextBox = new System.Windows.Forms.TextBox();
            this.Rollabel = new System.Windows.Forms.Label();
            this.RolcomboBox = new System.Windows.Forms.ComboBox();
            this.EstaActivolabel = new System.Windows.Forms.Label();
            this.EstaActivocheckBox = new System.Windows.Forms.CheckBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.UsuariosdataGridView = new System.Windows.Forms.DataGridView();
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Codigolabel
            // 
            this.Codigolabel.AutoSize = true;
            this.Codigolabel.Location = new System.Drawing.Point(56, 39);
            this.Codigolabel.Name = "Codigolabel";
            this.Codigolabel.Size = new System.Drawing.Size(58, 17);
            this.Codigolabel.TabIndex = 0;
            this.Codigolabel.Text = "Código: ";
            // 
            // CodigotextBox
            // 
            this.CodigotextBox.Location = new System.Drawing.Point(144, 31);
            this.CodigotextBox.Name = "CodigotextBox";
            this.CodigotextBox.Size = new System.Drawing.Size(244, 25);
            this.CodigotextBox.TabIndex = 1;
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Location = new System.Drawing.Point(54, 79);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(60, 17);
            this.Nombrelabel.TabIndex = 2;
            this.Nombrelabel.Text = "Nombre:";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(144, 71);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(244, 25);
            this.NombretextBox.TabIndex = 3;
            // 
            // Clavelabel
            // 
            this.Clavelabel.AutoSize = true;
            this.Clavelabel.Location = new System.Drawing.Point(72, 120);
            this.Clavelabel.Name = "Clavelabel";
            this.Clavelabel.Size = new System.Drawing.Size(42, 17);
            this.Clavelabel.TabIndex = 4;
            this.Clavelabel.Text = "Clave:";
            // 
            // ClavetextBox
            // 
            this.ClavetextBox.Location = new System.Drawing.Point(144, 112);
            this.ClavetextBox.Name = "ClavetextBox";
            this.ClavetextBox.PasswordChar = '*';
            this.ClavetextBox.Size = new System.Drawing.Size(244, 25);
            this.ClavetextBox.TabIndex = 5;
            // 
            // Correolabel
            // 
            this.Correolabel.AutoSize = true;
            this.Correolabel.Location = new System.Drawing.Point(62, 160);
            this.Correolabel.Name = "Correolabel";
            this.Correolabel.Size = new System.Drawing.Size(52, 17);
            this.Correolabel.TabIndex = 6;
            this.Correolabel.Text = "Correo:";
            // 
            // CorreotextBox
            // 
            this.CorreotextBox.Location = new System.Drawing.Point(144, 152);
            this.CorreotextBox.Name = "CorreotextBox";
            this.CorreotextBox.Size = new System.Drawing.Size(244, 25);
            this.CorreotextBox.TabIndex = 7;
            // 
            // Rollabel
            // 
            this.Rollabel.AutoSize = true;
            this.Rollabel.Location = new System.Drawing.Point(80, 198);
            this.Rollabel.Name = "Rollabel";
            this.Rollabel.Size = new System.Drawing.Size(34, 17);
            this.Rollabel.TabIndex = 8;
            this.Rollabel.Text = "Rol: ";
            // 
            // RolcomboBox
            // 
            this.RolcomboBox.FormattingEnabled = true;
            this.RolcomboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.RolcomboBox.Location = new System.Drawing.Point(144, 190);
            this.RolcomboBox.Name = "RolcomboBox";
            this.RolcomboBox.Size = new System.Drawing.Size(244, 25);
            this.RolcomboBox.TabIndex = 9;
            this.RolcomboBox.SelectedIndexChanged += new System.EventHandler(this.RolcomboBox_SelectedIndexChanged);
            // 
            // EstaActivolabel
            // 
            this.EstaActivolabel.AutoSize = true;
            this.EstaActivolabel.Location = new System.Drawing.Point(36, 236);
            this.EstaActivolabel.Name = "EstaActivolabel";
            this.EstaActivolabel.Size = new System.Drawing.Size(78, 17);
            this.EstaActivolabel.TabIndex = 10;
            this.EstaActivolabel.Text = "Esta Activo: ";
            // 
            // EstaActivocheckBox
            // 
            this.EstaActivocheckBox.AutoSize = true;
            this.EstaActivocheckBox.Location = new System.Drawing.Point(144, 239);
            this.EstaActivocheckBox.Name = "EstaActivocheckBox";
            this.EstaActivocheckBox.Size = new System.Drawing.Size(15, 14);
            this.EstaActivocheckBox.TabIndex = 11;
            this.EstaActivocheckBox.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(144, 276);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 35);
            this.Nuevobutton.TabIndex = 12;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // UsuariosdataGridView
            // 
            this.UsuariosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosdataGridView.Location = new System.Drawing.Point(12, 339);
            this.UsuariosdataGridView.Name = "UsuariosdataGridView";
            this.UsuariosdataGridView.RowTemplate.Height = 25;
            this.UsuariosdataGridView.Size = new System.Drawing.Size(776, 159);
            this.UsuariosdataGridView.TabIndex = 13;
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Location = new System.Drawing.Point(225, 276);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(75, 35);
            this.Modificarbutton.TabIndex = 14;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(306, 276);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 35);
            this.Guardarbutton.TabIndex = 15;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(387, 276);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 35);
            this.Eliminarbutton.TabIndex = 16;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Location = new System.Drawing.Point(468, 276);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(75, 35);
            this.Cancelarbutton.TabIndex = 17;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 507);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.UsuariosdataGridView);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.EstaActivocheckBox);
            this.Controls.Add(this.EstaActivolabel);
            this.Controls.Add(this.RolcomboBox);
            this.Controls.Add(this.Rollabel);
            this.Controls.Add(this.CorreotextBox);
            this.Controls.Add(this.Correolabel);
            this.Controls.Add(this.ClavetextBox);
            this.Controls.Add(this.Clavelabel);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.Nombrelabel);
            this.Controls.Add(this.CodigotextBox);
            this.Controls.Add(this.Codigolabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "UsuariosForm";
            this.Text = "UsuariosForm";
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Codigolabel;
        private TextBox CodigotextBox;
        private Label Nombrelabel;
        private TextBox NombretextBox;
        private Label Clavelabel;
        private TextBox ClavetextBox;
        private Label Correolabel;
        private TextBox CorreotextBox;
        private Label Rollabel;
        private ComboBox RolcomboBox;
        private Label EstaActivolabel;
        private CheckBox EstaActivocheckBox;
        private Button Nuevobutton;
        private DataGridView UsuariosdataGridView;
        private Button Modificarbutton;
        private Button Guardarbutton;
        private Button Eliminarbutton;
        private Button Cancelarbutton;
    }
}