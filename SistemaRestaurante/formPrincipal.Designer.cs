namespace Proyecto_Final_Periodo3
{
    partial class formPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMesas = new System.Windows.Forms.ToolStripButton();
            this.btnMenu = new System.Windows.Forms.ToolStripButton();
            this.tsrExit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMesas,
            this.btnMenu,
            this.tsrExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1192, 63);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMesas
            // 
            this.btnMesas.AutoSize = false;
            this.btnMesas.Image = global::Proyecto_Final_Periodo3.Properties.Resources.Selection;
            this.btnMesas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMesas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(120, 60);
            this.btnMesas.Text = "Mesas";
            this.btnMesas.Click += new System.EventHandler(this.tsrTable_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.AutoSize = false;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(120, 60);
            this.btnMenu.Text = "Menú";
            this.btnMenu.Click += new System.EventHandler(this.tsrMenu_Click);
            // 
            // tsrExit
            // 
            this.tsrExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsrExit.Image = ((System.Drawing.Image)(resources.GetObject("tsrExit.Image")));
            this.tsrExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsrExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsrExit.Name = "tsrExit";
            this.tsrExit.Size = new System.Drawing.Size(171, 60);
            this.tsrExit.Text = "Salir del Sistema";
            this.tsrExit.Click += new System.EventHandler(this.tsrExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 607);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1192, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1192, 629);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formPrincipal";
            this.Text = "Sistema Restaurante";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsrExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton btnMesas;
        private System.Windows.Forms.ToolStripButton btnMenu;
    }
}

