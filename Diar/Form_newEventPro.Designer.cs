namespace GatoCalendar
{
    partial class Form_newEventPro
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
            this.txb_desc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dttm_start_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dttm_end_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_priority = new System.Windows.Forms.ComboBox();
            this.chck_allday = new System.Windows.Forms.CheckBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.dttm_start_time = new System.Windows.Forms.DateTimePicker();
            this.dttm_end_time = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txb_desc
            // 
            this.txb_desc.Location = new System.Drawing.Point(71, 12);
            this.txb_desc.Name = "txb_desc";
            this.txb_desc.Size = new System.Drawing.Size(235, 20);
            this.txb_desc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Popis:";
            // 
            // dttm_start_date
            // 
            this.dttm_start_date.CustomFormat = "dd/MM/yyyy";
            this.dttm_start_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttm_start_date.Location = new System.Drawing.Point(71, 38);
            this.dttm_start_date.Name = "dttm_start_date";
            this.dttm_start_date.Size = new System.Drawing.Size(235, 20);
            this.dttm_start_date.TabIndex = 5;
            this.dttm_start_date.Value = new System.DateTime(2022, 12, 15, 18, 43, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Začátek:";
            // 
            // dttm_end_date
            // 
            this.dttm_end_date.CustomFormat = "dd/MM/yyyy";
            this.dttm_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttm_end_date.Location = new System.Drawing.Point(71, 90);
            this.dttm_end_date.Name = "dttm_end_date";
            this.dttm_end_date.Size = new System.Drawing.Size(235, 20);
            this.dttm_end_date.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Konec:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Priorita:";
            // 
            // cmb_priority
            // 
            this.cmb_priority.FormattingEnabled = true;
            this.cmb_priority.Items.AddRange(new object[] {
            "Nízká",
            "Střední",
            "Vysoká"});
            this.cmb_priority.Location = new System.Drawing.Point(71, 142);
            this.cmb_priority.Name = "cmb_priority";
            this.cmb_priority.Size = new System.Drawing.Size(121, 21);
            this.cmb_priority.TabIndex = 9;
            // 
            // chck_allday
            // 
            this.chck_allday.AutoSize = true;
            this.chck_allday.Location = new System.Drawing.Point(312, 92);
            this.chck_allday.Name = "chck_allday";
            this.chck_allday.Size = new System.Drawing.Size(75, 17);
            this.chck_allday.TabIndex = 10;
            this.chck_allday.Text = "Celodenní";
            this.chck_allday.UseVisualStyleBackColor = true;
            this.chck_allday.CheckedChanged += new System.EventHandler(this.chck_allday_CheckedChanged);
            // 
            // btn_create
            // 
            this.btn_create.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_create.Location = new System.Drawing.Point(149, 169);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(86, 39);
            this.btn_create.TabIndex = 11;
            this.btn_create.Text = "Vytvořit";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // dttm_start_time
            // 
            this.dttm_start_time.CustomFormat = "HH:mm:ss";
            this.dttm_start_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttm_start_time.Location = new System.Drawing.Point(71, 64);
            this.dttm_start_time.Name = "dttm_start_time";
            this.dttm_start_time.ShowUpDown = true;
            this.dttm_start_time.Size = new System.Drawing.Size(235, 20);
            this.dttm_start_time.TabIndex = 12;
            // 
            // dttm_end_time
            // 
            this.dttm_end_time.CustomFormat = "HH:mm:ss";
            this.dttm_end_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttm_end_time.Location = new System.Drawing.Point(71, 116);
            this.dttm_end_time.Name = "dttm_end_time";
            this.dttm_end_time.ShowUpDown = true;
            this.dttm_end_time.Size = new System.Drawing.Size(235, 20);
            this.dttm_end_time.TabIndex = 13;
            // 
            // Form_newEventPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 217);
            this.Controls.Add(this.dttm_end_time);
            this.Controls.Add(this.dttm_start_time);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.chck_allday);
            this.Controls.Add(this.cmb_priority);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dttm_end_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dttm_start_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_desc);
            this.Controls.Add(this.label1);
            this.Name = "Form_newEventPro";
            this.Text = "Nová Událost Pro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_desc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dttm_start_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dttm_end_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_priority;
        private System.Windows.Forms.CheckBox chck_allday;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.DateTimePicker dttm_start_time;
        private System.Windows.Forms.DateTimePicker dttm_end_time;
    }
}