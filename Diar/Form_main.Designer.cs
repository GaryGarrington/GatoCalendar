namespace GatoCalendar
{
    partial class Form_main
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.list_events = new System.Windows.Forms.ListBox();
            this.btn_newEvent = new System.Windows.Forms.Button();
            this.btn_trash = new System.Windows.Forms.Button();
            this.btn_newEventPlus = new System.Windows.Forms.Button();
            this.btn_newEventPro = new System.Windows.Forms.Button();
            this.txb_event = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.list_days = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // list_events
            // 
            this.list_events.FormattingEnabled = true;
            this.list_events.Location = new System.Drawing.Point(343, 0);
            this.list_events.Name = "list_events";
            this.list_events.Size = new System.Drawing.Size(341, 433);
            this.list_events.TabIndex = 1;
            this.list_events.Click += new System.EventHandler(this.list_events_click);
            this.list_events.DoubleClick += new System.EventHandler(this.list_events_DoubleClick);
            // 
            // btn_newEvent
            // 
            this.btn_newEvent.Location = new System.Drawing.Point(690, 192);
            this.btn_newEvent.Name = "btn_newEvent";
            this.btn_newEvent.Size = new System.Drawing.Size(210, 39);
            this.btn_newEvent.TabIndex = 2;
            this.btn_newEvent.Text = "Nová Událost";
            this.btn_newEvent.UseVisualStyleBackColor = true;
            this.btn_newEvent.Click += new System.EventHandler(this.novaUdalost_click);
            // 
            // btn_trash
            // 
            this.btn_trash.Location = new System.Drawing.Point(690, 372);
            this.btn_trash.Name = "btn_trash";
            this.btn_trash.Size = new System.Drawing.Size(210, 39);
            this.btn_trash.TabIndex = 3;
            this.btn_trash.Text = "Koš";
            this.btn_trash.UseVisualStyleBackColor = true;
            this.btn_trash.Click += new System.EventHandler(this.btn_trash_Click);
            // 
            // btn_newEventPlus
            // 
            this.btn_newEventPlus.Location = new System.Drawing.Point(690, 237);
            this.btn_newEventPlus.Name = "btn_newEventPlus";
            this.btn_newEventPlus.Size = new System.Drawing.Size(210, 39);
            this.btn_newEventPlus.TabIndex = 4;
            this.btn_newEventPlus.Text = "Nová Událost +";
            this.btn_newEventPlus.UseVisualStyleBackColor = true;
            this.btn_newEventPlus.Click += new System.EventHandler(this.btn_newEventPlus_Click);
            // 
            // btn_newEventPro
            // 
            this.btn_newEventPro.Location = new System.Drawing.Point(690, 282);
            this.btn_newEventPro.Name = "btn_newEventPro";
            this.btn_newEventPro.Size = new System.Drawing.Size(210, 39);
            this.btn_newEventPro.TabIndex = 5;
            this.btn_newEventPro.Text = "Nová Událost Pro";
            this.btn_newEventPro.UseVisualStyleBackColor = true;
            this.btn_newEventPro.Click += new System.EventHandler(this.btn_newEventPro_Click);
            // 
            // txb_event
            // 
            this.txb_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txb_event.Location = new System.Drawing.Point(690, 0);
            this.txb_event.Multiline = true;
            this.txb_event.Name = "txb_event";
            this.txb_event.ReadOnly = true;
            this.txb_event.Size = new System.Drawing.Size(210, 186);
            this.txb_event.TabIndex = 6;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(690, 327);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(210, 39);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Odstranit";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // list_days
            // 
            this.list_days.FormattingEnabled = true;
            this.list_days.Location = new System.Drawing.Point(0, 0);
            this.list_days.Name = "list_days";
            this.list_days.Size = new System.Drawing.Size(337, 433);
            this.list_days.TabIndex = 8;
            this.list_days.Click += new System.EventHandler(this.list_days_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 439);
            this.Controls.Add(this.list_days);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txb_event);
            this.Controls.Add(this.btn_newEventPro);
            this.Controls.Add(this.btn_newEventPlus);
            this.Controls.Add(this.btn_trash);
            this.Controls.Add(this.btn_newEvent);
            this.Controls.Add(this.list_events);
            this.Name = "Form_main";
            this.Text = "GatoCalendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_events;
        private System.Windows.Forms.Button btn_newEvent;
        private System.Windows.Forms.Button btn_trash;
        private System.Windows.Forms.Button btn_newEventPlus;
        private System.Windows.Forms.Button btn_newEventPro;
        private System.Windows.Forms.TextBox txb_event;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ListBox list_days;
    }
}

