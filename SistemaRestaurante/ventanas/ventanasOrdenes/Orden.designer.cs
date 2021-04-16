namespace Proyecto_Final_Periodo3
{
    partial class Orden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orden));
            this.flpMesas = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpMesas
            // 
            this.flpMesas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMesas.Location = new System.Drawing.Point(0, 0);
            this.flpMesas.Margin = new System.Windows.Forms.Padding(2);
            this.flpMesas.Name = "flpMesas";
            this.flpMesas.Size = new System.Drawing.Size(517, 486);
            this.flpMesas.TabIndex = 0;
            this.flpMesas.Paint += new System.Windows.Forms.PaintEventHandler(this.flpMesas_Paint);
            // 
            // Orden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(517, 486);
            this.Controls.Add(this.flpMesas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Orden";
            this.Text = "Orden";
            this.Load += new System.EventHandler(this.Orden_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpMesas;
    }
}