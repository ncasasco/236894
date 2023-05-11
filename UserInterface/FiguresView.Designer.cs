
namespace UserInterface
{
    partial class FiguresView
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
            this.lstFigures = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateFigure = new System.Windows.Forms.Button();
            this.pnlFigureList = new System.Windows.Forms.Panel();
            this.btnDeleteFigure = new System.Windows.Forms.Button();
            this.pnlFigure = new System.Windows.Forms.Panel();
            this.txtRadiusFigure = new System.Windows.Forms.TextBox();
            this.txtFigureName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlFigureList.SuspendLayout();
            this.pnlFigure.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFigures
            // 
            this.lstFigures.HideSelection = false;
            this.lstFigures.Location = new System.Drawing.Point(36, 68);
            this.lstFigures.Name = "lstFigures";
            this.lstFigures.Size = new System.Drawing.Size(430, 191);
            this.lstFigures.TabIndex = 0;
            this.lstFigures.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(134, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Figures";
            // 
            // btnCreateFigure
            // 
            this.btnCreateFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFigure.Location = new System.Drawing.Point(24, 123);
            this.btnCreateFigure.Name = "btnCreateFigure";
            this.btnCreateFigure.Size = new System.Drawing.Size(167, 30);
            this.btnCreateFigure.TabIndex = 2;
            this.btnCreateFigure.Text = "Create Figure";
            this.btnCreateFigure.UseVisualStyleBackColor = true;
            this.btnCreateFigure.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlFigureList
            // 
            this.pnlFigureList.Controls.Add(this.btnDeleteFigure);
            this.pnlFigureList.Controls.Add(this.pnlFigure);
            this.pnlFigureList.Controls.Add(this.label1);
            this.pnlFigureList.Controls.Add(this.lstFigures);
            this.pnlFigureList.Location = new System.Drawing.Point(0, 0);
            this.pnlFigureList.Name = "pnlFigureList";
            this.pnlFigureList.Size = new System.Drawing.Size(504, 447);
            this.pnlFigureList.TabIndex = 3;
            // 
            // btnDeleteFigure
            // 
            this.btnDeleteFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFigure.Location = new System.Drawing.Point(310, 271);
            this.btnDeleteFigure.Name = "btnDeleteFigure";
            this.btnDeleteFigure.Size = new System.Drawing.Size(146, 35);
            this.btnDeleteFigure.TabIndex = 8;
            this.btnDeleteFigure.Text = "Delete Figure";
            this.btnDeleteFigure.UseVisualStyleBackColor = true;
            this.btnDeleteFigure.Click += new System.EventHandler(this.btnDeleteFigure_Click);
            // 
            // pnlFigure
            // 
            this.pnlFigure.Controls.Add(this.txtRadiusFigure);
            this.pnlFigure.Controls.Add(this.txtFigureName);
            this.pnlFigure.Controls.Add(this.label3);
            this.pnlFigure.Controls.Add(this.btnCreateFigure);
            this.pnlFigure.Controls.Add(this.label2);
            this.pnlFigure.Location = new System.Drawing.Point(36, 271);
            this.pnlFigure.Name = "pnlFigure";
            this.pnlFigure.Size = new System.Drawing.Size(231, 156);
            this.pnlFigure.TabIndex = 7;
            // 
            // txtRadiusFigure
            // 
            this.txtRadiusFigure.Location = new System.Drawing.Point(0, 82);
            this.txtRadiusFigure.Name = "txtRadiusFigure";
            this.txtRadiusFigure.Size = new System.Drawing.Size(82, 22);
            this.txtRadiusFigure.TabIndex = 6;
            // 
            // txtFigureName
            // 
            this.txtFigureName.Location = new System.Drawing.Point(0, 27);
            this.txtFigureName.Name = "txtFigureName";
            this.txtFigureName.Size = new System.Drawing.Size(206, 22);
            this.txtFigureName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(0, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Radius";
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
            // FiguresView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.pnlFigureList);
            this.Name = "FiguresView";
            this.Size = new System.Drawing.Size(507, 447);
            this.pnlFigureList.ResumeLayout(false);
            this.pnlFigureList.PerformLayout();
            this.pnlFigure.ResumeLayout(false);
            this.pnlFigure.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstFigures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateFigure;
        private System.Windows.Forms.Panel pnlFigureList;
        private System.Windows.Forms.TextBox txtRadiusFigure;
        private System.Windows.Forms.TextBox txtFigureName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlFigure;
        private System.Windows.Forms.Button btnDeleteFigure;
    }
}
