namespace pryAccesoBaseDeDatosYLogs
{
    partial class frmConexionBaseDeDatos
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
            this.lblIngreseUsuario = new System.Windows.Forms.Label();
            this.lblIngreseContraseña = new System.Windows.Forms.Label();
            this.txtIngreseUsuario = new System.Windows.Forms.TextBox();
            this.txtIngreseContraseña = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIngreseUsuario
            // 
            this.lblIngreseUsuario.AutoSize = true;
            this.lblIngreseUsuario.Location = new System.Drawing.Point(12, 12);
            this.lblIngreseUsuario.Name = "lblIngreseUsuario";
            this.lblIngreseUsuario.Size = new System.Drawing.Size(82, 13);
            this.lblIngreseUsuario.TabIndex = 0;
            this.lblIngreseUsuario.Text = "Ingrese usuario:";
            // 
            // lblIngreseContraseña
            // 
            this.lblIngreseContraseña.AutoSize = true;
            this.lblIngreseContraseña.Location = new System.Drawing.Point(12, 45);
            this.lblIngreseContraseña.Name = "lblIngreseContraseña";
            this.lblIngreseContraseña.Size = new System.Drawing.Size(101, 13);
            this.lblIngreseContraseña.TabIndex = 1;
            this.lblIngreseContraseña.Text = "Ingrese contraseña:";
            // 
            // txtIngreseUsuario
            // 
            this.txtIngreseUsuario.Location = new System.Drawing.Point(124, 5);
            this.txtIngreseUsuario.Name = "txtIngreseUsuario";
            this.txtIngreseUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtIngreseUsuario.TabIndex = 2;
            // 
            // txtIngreseContraseña
            // 
            this.txtIngreseContraseña.Location = new System.Drawing.Point(124, 38);
            this.txtIngreseContraseña.Name = "txtIngreseContraseña";
            this.txtIngreseContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtIngreseContraseña.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(131, 73);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(93, 31);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // frmConexionBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 281);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtIngreseContraseña);
            this.Controls.Add(this.txtIngreseUsuario);
            this.Controls.Add(this.lblIngreseContraseña);
            this.Controls.Add(this.lblIngreseUsuario);
            this.Name = "frmConexionBaseDeDatos";
            this.Text = "Conexión a base de datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreseUsuario;
        private System.Windows.Forms.Label lblIngreseContraseña;
        private System.Windows.Forms.TextBox txtIngreseUsuario;
        private System.Windows.Forms.TextBox txtIngreseContraseña;
        private System.Windows.Forms.Button btnIngresar;
    }
}

