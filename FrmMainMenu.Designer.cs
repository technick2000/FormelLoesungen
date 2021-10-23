
namespace AbcFormelLöser
{
    partial class FrmMainMenu
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
            this.btnFormelABC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormelABC
            // 
            this.btnFormelABC.Location = new System.Drawing.Point(220, 94);
            this.btnFormelABC.Name = "btnFormelABC";
            this.btnFormelABC.Size = new System.Drawing.Size(75, 23);
            this.btnFormelABC.TabIndex = 0;
            this.btnFormelABC.Text = "ABC Formel";
            this.btnFormelABC.UseVisualStyleBackColor = true;
            this.btnFormelABC.Click += new System.EventHandler(this.btnFormelABC_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFormelABC);
            this.Name = "FrmMainMenu";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormelABC;
    }
}