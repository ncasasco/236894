
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.bnSalir = new System.Windows.Forms.Button();
            this.eventsView1 = new UserInterface.EventView();
            this.btnEvent = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.btnEvent);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.bnSalir);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 447);
            this.panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(0, 18);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(227, 55);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // bnSalir
            // 
            this.bnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnSalir.Location = new System.Drawing.Point(0, 372);
            this.bnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.bnSalir.Name = "bnSalir";
            this.bnSalir.Size = new System.Drawing.Size(227, 55);
            this.bnSalir.TabIndex = 3;
            this.bnSalir.Text = "Salir";
            this.bnSalir.UseVisualStyleBackColor = true;
            this.bnSalir.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // eventsView1
            // 
            this.eventsView1.BackColor = System.Drawing.SystemColors.Desktop;
            this.eventsView1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eventsView1.Location = new System.Drawing.Point(252, 15);
            this.eventsView1.Margin = new System.Windows.Forms.Padding(5);
            this.eventsView1.Name = "eventsView1";
            this.eventsView1.Size = new System.Drawing.Size(500, 450);
            this.eventsView1.TabIndex = 3;
            this.eventsView1.Load += new System.EventHandler(this.eventsView1_Load);
            // 
            // btnEvent
            // 
            this.btnEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvent.Location = new System.Drawing.Point(1, 119);
            this.btnEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(227, 55);
            this.btnEvent.TabIndex = 5;
            this.btnEvent.Text = "Create Event";
            this.btnEvent.UseVisualStyleBackColor = true;
            this.btnEvent.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(768, 476);
            this.Controls.Add(this.eventsView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu | Social Network";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private EventView eventsView1;
        private System.Windows.Forms.Button bnSalir;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnEvent;
    }
}