
namespace UserInterface
{
    partial class MenuWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMaterials = new System.Windows.Forms.Button();
            this.btnFigures = new System.Windows.Forms.Button();
            this.bnSalir = new System.Windows.Forms.Button();
            this.btnModels = new System.Windows.Forms.Button();
            this.btnScenes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnScenes);
            this.panel1.Controls.Add(this.btnModels);
            this.panel1.Controls.Add(this.btnMaterials);
            this.panel1.Controls.Add(this.btnFigures);
            this.panel1.Controls.Add(this.bnSalir);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 447);
            this.panel1.TabIndex = 0;
            // 
            // btnMaterials
            // 
            this.btnMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterials.Location = new System.Drawing.Point(0, 110);
            this.btnMaterials.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaterials.Name = "btnMaterials";
            this.btnMaterials.Size = new System.Drawing.Size(227, 55);
            this.btnMaterials.TabIndex = 5;
            this.btnMaterials.Text = "Materials";
            this.btnMaterials.UseVisualStyleBackColor = true;
            // 
            // btnFigures
            // 
            this.btnFigures.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFigures.Location = new System.Drawing.Point(0, 47);
            this.btnFigures.Margin = new System.Windows.Forms.Padding(4);
            this.btnFigures.Name = "btnFigures";
            this.btnFigures.Size = new System.Drawing.Size(227, 55);
            this.btnFigures.TabIndex = 4;
            this.btnFigures.Text = "Figures";
            this.btnFigures.UseVisualStyleBackColor = true;
            this.btnFigures.Click += new System.EventHandler(this.btnFigures_Click);
            // 
            // bnSalir
            // 
            this.bnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnSalir.Location = new System.Drawing.Point(0, 372);
            this.bnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.bnSalir.Name = "bnSalir";
            this.bnSalir.Size = new System.Drawing.Size(227, 55);
            this.bnSalir.TabIndex = 3;
            this.bnSalir.Text = "Exit";
            this.bnSalir.UseVisualStyleBackColor = true;
            this.bnSalir.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnModels
            // 
            this.btnModels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModels.Location = new System.Drawing.Point(0, 173);
            this.btnModels.Margin = new System.Windows.Forms.Padding(4);
            this.btnModels.Name = "btnModels";
            this.btnModels.Size = new System.Drawing.Size(227, 55);
            this.btnModels.TabIndex = 6;
            this.btnModels.Text = "Scenes";
            this.btnModels.UseVisualStyleBackColor = true;
            // 
            // btnScenes
            // 
            this.btnScenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScenes.Location = new System.Drawing.Point(0, 236);
            this.btnScenes.Margin = new System.Windows.Forms.Padding(4);
            this.btnScenes.Name = "btnScenes";
            this.btnScenes.Size = new System.Drawing.Size(227, 55);
            this.btnScenes.TabIndex = 7;
            this.btnScenes.Text = "Models";
            this.btnScenes.UseVisualStyleBackColor = true;
            this.btnScenes.Click += new System.EventHandler(this.btnScenes_Click);
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(768, 476);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu | 3D Renderer";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bnSalir;
        private System.Windows.Forms.Button btnMaterials;
        private System.Windows.Forms.Button btnFigures;
        private System.Windows.Forms.Button btnScenes;
        private System.Windows.Forms.Button btnModels;
    }
}