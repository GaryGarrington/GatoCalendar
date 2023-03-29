
namespace GatoCalendar
{
    partial class Form_bin
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
            this.list_udalosti = new System.Windows.Forms.ListBox();
            this.txb_event = new System.Windows.Forms.TextBox();
            this.btn_restore = new System.Windows.Forms.Button();
            this.btn_removeall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_udalosti
            // 
            this.list_udalosti.Dock = System.Windows.Forms.DockStyle.Left;
            this.list_udalosti.FormattingEnabled = true;
            this.list_udalosti.Location = new System.Drawing.Point(0, 0);
            this.list_udalosti.Name = "list_udalosti";
            this.list_udalosti.Size = new System.Drawing.Size(389, 357);
            this.list_udalosti.TabIndex = 0;
            this.list_udalosti.Click += new System.EventHandler(this.list_udalosti_Click);
            // 
            // txb_event
            // 
            this.txb_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txb_event.Location = new System.Drawing.Point(395, 0);
            this.txb_event.Multiline = true;
            this.txb_event.Name = "txb_event";
            this.txb_event.ReadOnly = true;
            this.txb_event.Size = new System.Drawing.Size(210, 186);
            this.txb_event.TabIndex = 7;
            // 
            // btn_restore
            // 
            this.btn_restore.Location = new System.Drawing.Point(395, 192);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(210, 39);
            this.btn_restore.TabIndex = 8;
            this.btn_restore.Text = "Obnovit";
            this.btn_restore.UseVisualStyleBackColor = true;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // btn_removeall
            // 
            this.btn_removeall.Location = new System.Drawing.Point(395, 237);
            this.btn_removeall.Name = "btn_removeall";
            this.btn_removeall.Size = new System.Drawing.Size(210, 39);
            this.btn_removeall.TabIndex = 9;
            this.btn_removeall.Text = "Vysypat Koš";
            this.btn_removeall.UseVisualStyleBackColor = true;
            this.btn_removeall.Click += new System.EventHandler(this.btn_removeall_Click);
            // 
            // Form_bin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 357);
            this.Controls.Add(this.btn_removeall);
            this.Controls.Add(this.btn_restore);
            this.Controls.Add(this.txb_event);
            this.Controls.Add(this.list_udalosti);
            this.Name = "Form_bin";
            this.Text = "Form_bin";
            this.Load += new System.EventHandler(this.Form_bin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_udalosti;
        private System.Windows.Forms.TextBox txb_event;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.Button btn_removeall;
    }
}