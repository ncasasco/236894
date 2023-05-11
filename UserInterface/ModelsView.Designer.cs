
namespace UserInterface
{
    partial class ModelsView
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
            System.Windows.Forms.ComboBox cmbModelMaterial;
            this.btnDeleteModel = new System.Windows.Forms.Button();
            this.pnlMaterial = new System.Windows.Forms.Panel();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateModel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMaterials = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbModelFigure = new System.Windows.Forms.ComboBox();
            this.checkBoxPreview = new System.Windows.Forms.CheckBox();
            cmbModelMaterial = new System.Windows.Forms.ComboBox();
            this.pnlMaterial.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteModel
            // 
            this.btnDeleteModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteModel.Location = new System.Drawing.Point(321, 222);
            this.btnDeleteModel.Name = "btnDeleteModel";
            this.btnDeleteModel.Size = new System.Drawing.Size(146, 35);
            this.btnDeleteModel.TabIndex = 16;
            this.btnDeleteModel.Text = "Delete Model";
            this.btnDeleteModel.UseVisualStyleBackColor = true;
            // 
            // pnlMaterial
            // 
            this.pnlMaterial.Controls.Add(this.checkBoxPreview);
            this.pnlMaterial.Controls.Add(cmbModelMaterial);
            this.pnlMaterial.Controls.Add(this.cmbModelFigure);
            this.pnlMaterial.Controls.Add(this.label7);
            this.pnlMaterial.Controls.Add(this.txtModelName);
            this.pnlMaterial.Controls.Add(this.label3);
            this.pnlMaterial.Controls.Add(this.label2);
            this.pnlMaterial.Location = new System.Drawing.Point(37, 222);
            this.pnlMaterial.Name = "pnlMaterial";
            this.pnlMaterial.Size = new System.Drawing.Size(278, 222);
            this.pnlMaterial.TabIndex = 15;
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(0, 27);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(206, 22);
            this.txtModelName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(0, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Figure";
            // 
            // btnCreateModel
            // 
            this.btnCreateModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateModel.Location = new System.Drawing.Point(321, 400);
            this.btnCreateModel.Name = "btnCreateModel";
            this.btnCreateModel.Size = new System.Drawing.Size(167, 30);
            this.btnCreateModel.TabIndex = 2;
            this.btnCreateModel.Text = "Create Model";
            this.btnCreateModel.UseVisualStyleBackColor = true;
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
            this.label1.Size = new System.Drawing.Size(232, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "List of Models";
            // 
            // lstMaterials
            // 
            this.lstMaterials.HideSelection = false;
            this.lstMaterials.Location = new System.Drawing.Point(37, 70);
            this.lstMaterials.Name = "lstMaterials";
            this.lstMaterials.Size = new System.Drawing.Size(430, 146);
            this.lstMaterials.TabIndex = 13;
            this.lstMaterials.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(0, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Material";
            // 
            // cmbModelFigure
            // 
            this.cmbModelFigure.FormattingEnabled = true;
            this.cmbModelFigure.Location = new System.Drawing.Point(0, 82);
            this.cmbModelFigure.Name = "cmbModelFigure";
            this.cmbModelFigure.Size = new System.Drawing.Size(206, 24);
            this.cmbModelFigure.TabIndex = 13;
            // 
            // cmbModelMaterial
            // 
            cmbModelMaterial.FormattingEnabled = true;
            cmbModelMaterial.Location = new System.Drawing.Point(4, 144);
            cmbModelMaterial.Name = "cmbModelMaterial";
            cmbModelMaterial.Size = new System.Drawing.Size(202, 24);
            cmbModelMaterial.TabIndex = 14;
            // 
            // checkBoxPreview
            // 
            this.checkBoxPreview.AutoSize = true;
            this.checkBoxPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPreview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxPreview.Location = new System.Drawing.Point(10, 178);
            this.checkBoxPreview.Name = "checkBoxPreview";
            this.checkBoxPreview.Size = new System.Drawing.Size(226, 33);
            this.checkBoxPreview.TabIndex = 15;
            this.checkBoxPreview.Text = "Generate preview";
            this.checkBoxPreview.UseVisualStyleBackColor = true;
            // 
            // ModelsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.btnDeleteModel);
            this.Controls.Add(this.pnlMaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMaterials);
            this.Controls.Add(this.btnCreateModel);
            this.Name = "ModelsView";
            this.Size = new System.Drawing.Size(504, 447);
            this.pnlMaterial.ResumeLayout(false);
            this.pnlMaterial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteModel;
        private System.Windows.Forms.Panel pnlMaterial;
        private System.Windows.Forms.ComboBox cmbModelFigure;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstMaterials;
        private System.Windows.Forms.CheckBox checkBoxPreview;
    }
}
