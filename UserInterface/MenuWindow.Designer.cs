
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
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.btnScenes = new System.Windows.Forms.Button();
            this.btnModels = new System.Windows.Forms.Button();
            this.btnMaterials = new System.Windows.Forms.Button();
            this.btnFigures = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonsPanel.Controls.Add(this.btnScenes);
            this.buttonsPanel.Controls.Add(this.btnModels);
            this.buttonsPanel.Controls.Add(this.btnMaterials);
            this.buttonsPanel.Controls.Add(this.btnFigures);
            this.buttonsPanel.Controls.Add(this.btnExit);
            this.buttonsPanel.Location = new System.Drawing.Point(16, 15);
            this.buttonsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(228, 447);
            this.buttonsPanel.TabIndex = 0;
            // 
            // btnScenes
            // 
            this.btnScenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScenes.Location = new System.Drawing.Point(0, 236);
            this.btnScenes.Margin = new System.Windows.Forms.Padding(4);
            this.btnScenes.Name = "btnScenes";
            this.btnScenes.Size = new System.Drawing.Size(227, 55);
            this.btnScenes.TabIndex = 7;
            this.btnScenes.Text = "Scenes";
            this.btnScenes.UseVisualStyleBackColor = true;
            this.btnScenes.Click += new System.EventHandler(this.btnScenes_Click);
            // 
            // btnModels
            // 
            this.btnModels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModels.Location = new System.Drawing.Point(1, 173);
            this.btnModels.Margin = new System.Windows.Forms.Padding(4);
            this.btnModels.Name = "btnModels";
            this.btnModels.Size = new System.Drawing.Size(227, 55);
            this.btnModels.TabIndex = 6;
            this.btnModels.Text = "Models";
            this.btnModels.UseVisualStyleBackColor = true;
            this.btnModels.Click += new System.EventHandler(this.btnModels_Click);
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
            this.btnMaterials.Click += new System.EventHandler(this.btnMaterials_Click);
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
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(0, 372);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(227, 55);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(252, 15);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(504, 447);
            this.mainPanel.TabIndex = 1;
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(768, 476);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.buttonsPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu | 3D Renderer";
            this.buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMaterials;
        private System.Windows.Forms.Button btnFigures;
        private System.Windows.Forms.Button btnScenes;
        private System.Windows.Forms.Button btnModels;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel mainPanel;
    }
}