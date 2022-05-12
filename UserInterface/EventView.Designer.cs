
namespace UserInterface
{
    partial class EventView
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstEvt = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEvt
            // 
            this.lstEvt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.date});
            this.lstEvt.HideSelection = false;
            this.lstEvt.Location = new System.Drawing.Point(3, 40);
            this.lstEvt.Name = "lstEvt";
            this.lstEvt.Size = new System.Drawing.Size(494, 279);
            this.lstEvt.TabIndex = 0;
            this.lstEvt.UseCompatibleStateImageBehavior = false;
            this.lstEvt.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Event";
            this.name.Width = 255;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Events";
            // 
            // btnBuy
            // 
            this.btnBuy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuy.Location = new System.Drawing.Point(199, 355);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(97, 53);
            this.btnBuy.TabIndex = 13;
            this.btnBuy.Text = "Buy Ticket";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // EventView
            // 
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEvt);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "EventView";
            this.Size = new System.Drawing.Size(500, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstEvt;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Button btnBuy;
    }
}
