namespace CalcularDescuento
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
            this.NameProduct = new System.Windows.Forms.Label();
            this.NombreProducto = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.PrecioProducto = new System.Windows.Forms.TextBox();
            this.TipoProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultadoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameProduct
            // 
            this.NameProduct.AutoSize = true;
            this.NameProduct.Location = new System.Drawing.Point(113, 47);
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.Size = new System.Drawing.Size(153, 13);
            this.NameProduct.TabIndex = 0;
            this.NameProduct.Text = "Ingrese el nombre del producto";
            // 
            // NombreProducto
            // 
            this.NombreProducto.Location = new System.Drawing.Point(116, 63);
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.Size = new System.Drawing.Size(150, 20);
            this.NombreProducto.TabIndex = 1;
            this.NombreProducto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(113, 100);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(147, 13);
            this.Price.TabIndex = 2;
            this.Price.Text = "Ingrese el precio del producto";
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.Location = new System.Drawing.Point(116, 117);
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.Size = new System.Drawing.Size(150, 20);
            this.PrecioProducto.TabIndex = 3;
            // 
            // TipoProducto
            // 
            this.TipoProducto.FormattingEnabled = true;
            this.TipoProducto.Items.AddRange(new object[] {
            "Tecnología",
            "Alimento",
            "General"});
            this.TipoProducto.Location = new System.Drawing.Point(116, 168);
            this.TipoProducto.Name = "TipoProducto";
            this.TipoProducto.Size = new System.Drawing.Size(150, 21);
            this.TipoProducto.TabIndex = 4;
            this.TipoProducto.SelectedIndexChanged += new System.EventHandler(this.TipoProducto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese el tipo de producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ResultadoButton
            // 
            this.ResultadoButton.Location = new System.Drawing.Point(146, 209);
            this.ResultadoButton.Name = "ResultadoButton";
            this.ResultadoButton.Size = new System.Drawing.Size(75, 23);
            this.ResultadoButton.TabIndex = 6;
            this.ResultadoButton.Text = "Calcular descuento";
            this.ResultadoButton.UseVisualStyleBackColor = true;
            this.ResultadoButton.Click += new System.EventHandler(this.ResultadoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultadoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TipoProducto);
            this.Controls.Add(this.PrecioProducto);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.NombreProducto);
            this.Controls.Add(this.NameProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameProduct;
        private System.Windows.Forms.TextBox NombreProducto;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox PrecioProducto;
        private System.Windows.Forms.ComboBox TipoProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResultadoButton;
    }
}

