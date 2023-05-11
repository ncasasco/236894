
namespace UserInterface
{
    partial class MaterialsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeleteMaterial = new System.Windows.Forms.Button();
            this.pnlMaterial = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBlueMaterial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGreenMaterial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRedMaterial = new System.Windows.Forms.TextBox();
            this.txtMaterialName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateMaterial = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMaterials = new System.Windows.Forms.ListView();
            this.pnlMaterial.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteMaterial
            // 
            this.btnDeleteMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMaterial.Location = new System.Drawing.Point(311, 273);
            this.btnDeleteMaterial.Name = "btnDeleteMaterial";
            this.btnDeleteMaterial.Size = new System.Drawing.Size(146, 35);
            this.btnDeleteMaterial.TabIndex = 12;
            this.btnDeleteMaterial.Text = "Delete Material";
            this.btnDeleteMaterial.UseVisualStyleBackColor = true;
            this.btnDeleteMaterial.Click += new System.EventHandler(this.btnDeleteMaterial_Click);
            // 
            // pnlMaterial
            // 
            this.pnlMaterial.Controls.Add(this.label6);
            this.pnlMaterial.Controls.Add(this.txtBlueMaterial);
            this.pnlMaterial.Controls.Add(this.label5);
            this.pnlMaterial.Controls.Add(this.txtGreenMaterial);
            this.pnlMaterial.Controls.Add(this.label4);
            this.pnlMaterial.Controls.Add(this.txtRedMaterial);
            this.pnlMaterial.Controls.Add(this.txtMaterialName);
            this.pnlMaterial.Controls.Add(this.label3);
            this.pnlMaterial.Controls.Add(this.btnCreateMaterial);
            this.pnlMaterial.Controls.Add(this.label2);
            this.pnlMaterial.Location = new System.Drawing.Point(37, 273);
            this.pnlMaterial.Name = "pnlMaterial";
            this.pnlMaterial.Size = new System.Drawing.Size(231, 156);
            this.pnlMaterial.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(-4, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "R:";
            // 
            // txtBlueMaterial
            // 
            this.txtBlueMaterial.Location = new System.Drawing.Point(170, 82);
            this.txtBlueMaterial.Name = "txtBlueMaterial";
            this.txtBlueMaterial.Size = new System.Drawing.Size(36, 22);
            this.txtBlueMaterial.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(144, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "B:";
            // 
            // txtGreenMaterial
            // 
            this.txtGreenMaterial.Location = new System.Drawing.Point(96, 82);
            this.txtGreenMaterial.Name = "txtGreenMaterial";
            this.txtGreenMaterial.Size = new System.Drawing.Size(36, 22);
            this.txtGreenMaterial.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(67, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "G:";
            // 
            // txtRedMaterial
            // 
            this.txtRedMaterial.Location = new System.Drawing.Point(21, 82);
            this.txtRedMaterial.Name = "txtRedMaterial";
            this.txtRedMaterial.Size = new System.Drawing.Size(36, 22);
            this.txtRedMaterial.TabIndex = 6;
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.Location = new System.Drawing.Point(0, 27);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Size = new System.Drawing.Size(206, 22);
            this.txtMaterialName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(0, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Color";
            // 
            // btnCreateMaterial
            // 
            this.btnCreateMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMaterial.Location = new System.Drawing.Point(24, 123);
            this.btnCreateMaterial.Name = "btnCreateMaterial";
            this.btnCreateMaterial.Size = new System.Drawing.Size(167, 30);
            this.btnCreateMaterial.TabIndex = 2;
            this.btnCreateMaterial.Text = "Create Material";
            this.btnCreateMaterial.UseVisualStyleBackColor = true;
            this.btnCreateMaterial.Click += new System.EventHandler(this.btnCreateMaterial_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(124, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "List of Materials";
            // 
            // lstMaterials
            // 
            this.lstMaterials.HideSelection = false;
            this.lstMaterials.Location = new System.Drawing.Point(37, 70);
            this.lstMaterials.Name = "lstMaterials";
            this.lstMaterials.Size = new System.Drawing.Size(430, 191);
            this.lstMaterials.TabIndex = 9;
            this.lstMaterials.UseCompatibleStateImageBehavior = false;
            // 
            // MaterialsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.btnDeleteMaterial);
            this.Controls.Add(this.pnlMaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMaterials);
            this.Name = "MaterialsView";
            this.Size = new System.Drawing.Size(504, 447);
            this.pnlMaterial.ResumeLayout(false);
            this.pnlMaterial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteMaterial;
        private System.Windows.Forms.Panel pnlMaterial;
        private System.Windows.Forms.TextBox txtRedMaterial;
        private System.Windows.Forms.TextBox txtMaterialName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstMaterials;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBlueMaterial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGreenMaterial;
        private System.Windows.Forms.Label label4;
    }
}
