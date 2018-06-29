namespace FileServer.Presentation.WinSite
{
  partial class frmAlumno
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
			this.txtBox_CodiClient = new System.Windows.Forms.TextBox();
			this.lb_CodiClient = new System.Windows.Forms.Label();
			this.lb_Nom = new System.Windows.Forms.Label();
			this.txtBox_Nom = new System.Windows.Forms.TextBox();
			this.lb_Cognoms = new System.Windows.Forms.Label();
			this.txtBox_Cognoms = new System.Windows.Forms.TextBox();
			this.lb_Dni = new System.Windows.Forms.Label();
			this.txtBox_Dni = new System.Windows.Forms.TextBox();
			this.btn_Afegir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtBox_CodiClient
			// 
			this.txtBox_CodiClient.Location = new System.Drawing.Point(112, 58);
			this.txtBox_CodiClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtBox_CodiClient.Name = "txtBox_CodiClient";
			this.txtBox_CodiClient.Size = new System.Drawing.Size(76, 20);
			this.txtBox_CodiClient.TabIndex = 0;
			// 
			// lb_CodiClient
			// 
			this.lb_CodiClient.AutoSize = true;
			this.lb_CodiClient.Location = new System.Drawing.Point(51, 61);
			this.lb_CodiClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lb_CodiClient.Name = "lb_CodiClient";
			this.lb_CodiClient.Size = new System.Drawing.Size(57, 13);
			this.lb_CodiClient.TabIndex = 1;
			this.lb_CodiClient.Text = "Codi Client";
			// 
			// lb_Nom
			// 
			this.lb_Nom.AutoSize = true;
			this.lb_Nom.Location = new System.Drawing.Point(51, 85);
			this.lb_Nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lb_Nom.Name = "lb_Nom";
			this.lb_Nom.Size = new System.Drawing.Size(29, 13);
			this.lb_Nom.TabIndex = 3;
			this.lb_Nom.Text = "Nom";
			// 
			// txtBox_Nom
			// 
			this.txtBox_Nom.Location = new System.Drawing.Point(112, 82);
			this.txtBox_Nom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtBox_Nom.Name = "txtBox_Nom";
			this.txtBox_Nom.Size = new System.Drawing.Size(111, 20);
			this.txtBox_Nom.TabIndex = 2;
			// 
			// lb_Cognoms
			// 
			this.lb_Cognoms.AutoSize = true;
			this.lb_Cognoms.Location = new System.Drawing.Point(51, 108);
			this.lb_Cognoms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lb_Cognoms.Name = "lb_Cognoms";
			this.lb_Cognoms.Size = new System.Drawing.Size(51, 13);
			this.lb_Cognoms.TabIndex = 5;
			this.lb_Cognoms.Text = "Cognoms";
			// 
			// txtBox_Cognoms
			// 
			this.txtBox_Cognoms.Location = new System.Drawing.Point(112, 106);
			this.txtBox_Cognoms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtBox_Cognoms.Name = "txtBox_Cognoms";
			this.txtBox_Cognoms.Size = new System.Drawing.Size(270, 20);
			this.txtBox_Cognoms.TabIndex = 4;
			// 
			// lb_Dni
			// 
			this.lb_Dni.AutoSize = true;
			this.lb_Dni.Location = new System.Drawing.Point(51, 134);
			this.lb_Dni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lb_Dni.Name = "lb_Dni";
			this.lb_Dni.Size = new System.Drawing.Size(29, 13);
			this.lb_Dni.TabIndex = 7;
			this.lb_Dni.Text = "D.n.i";
			// 
			// txtBox_Dni
			// 
			this.txtBox_Dni.Location = new System.Drawing.Point(112, 131);
			this.txtBox_Dni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtBox_Dni.Name = "txtBox_Dni";
			this.txtBox_Dni.Size = new System.Drawing.Size(76, 20);
			this.txtBox_Dni.TabIndex = 6;
			// 
			// btn_Afegir
			// 
			this.btn_Afegir.Location = new System.Drawing.Point(112, 164);
			this.btn_Afegir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Afegir.Name = "btn_Afegir";
			this.btn_Afegir.Size = new System.Drawing.Size(126, 23);
			this.btn_Afegir.TabIndex = 8;
			this.btn_Afegir.Text = "Add";
			this.btn_Afegir.UseVisualStyleBackColor = true;
			this.btn_Afegir.Click += new System.EventHandler(this.btn_Afegir_Click);
			// 
			// frmAlumno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 366);
			this.Controls.Add(this.btn_Afegir);
			this.Controls.Add(this.lb_Dni);
			this.Controls.Add(this.txtBox_Dni);
			this.Controls.Add(this.lb_Cognoms);
			this.Controls.Add(this.txtBox_Cognoms);
			this.Controls.Add(this.lb_Nom);
			this.Controls.Add(this.txtBox_Nom);
			this.Controls.Add(this.lb_CodiClient);
			this.Controls.Add(this.txtBox_CodiClient);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "frmAlumno";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtBox_CodiClient;
    private System.Windows.Forms.Label lb_CodiClient;
    private System.Windows.Forms.Label lb_Nom;
    private System.Windows.Forms.TextBox txtBox_Nom;
    private System.Windows.Forms.Label lb_Cognoms;
    private System.Windows.Forms.TextBox txtBox_Cognoms;
    private System.Windows.Forms.Label lb_Dni;
    private System.Windows.Forms.TextBox txtBox_Dni;
    private System.Windows.Forms.Button btn_Afegir;
  }
}

