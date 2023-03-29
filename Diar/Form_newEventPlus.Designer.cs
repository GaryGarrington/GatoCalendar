namespace GatoCalendar
{
    partial class Form_newEventPlus
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
            this.label1 = new System.Windows.Forms.Label();
            this.txb_desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.dttm_time = new System.Windows.Forms.DateTimePicker();
            this.dttm_date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Popis:";
            // 
            // txb_desc
            // 
            this.txb_desc.Location = new System.Drawing.Point(68, 13);
            this.txb_desc.Name = "txb_desc";
            this.txb_desc.Size = new System.Drawing.Size(235, 20);
            this.txb_desc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Začátek:";
            // 
            // btn_create
            // 
            this.btn_create.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_create.Location = new System.Drawing.Point(125, 105);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(86, 39);
            this.btn_create.TabIndex = 4;
            this.btn_create.Text = "Vytvořit";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // dttm_time
            // 
            this.dttm_time.CustomFormat = "HH:mm:ss";
            this.dttm_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttm_time.Location = new System.Drawing.Point(68, 79);
            this.dttm_time.Name = "dttm_time";
            this.dttm_time.ShowUpDown = true;
            this.dttm_time.Size = new System.Drawing.Size(235, 20);
            this.dttm_time.TabIndex = 5;
            this.dttm_time.Value = new System.DateTime(2022, 12, 15, 9, 40, 59, 0);
            // 
            // dttm_date
            // 
            this.dttm_date.CustomFormat = "dd/MM/yyyy";
            this.dttm_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttm_date.Location = new System.Drawing.Point(68, 53);
            this.dttm_date.Name = "dttm_date";
            this.dttm_date.Size = new System.Drawing.Size(235, 20);
            this.dttm_date.TabIndex = 3;
            this.dttm_date.Value = new System.DateTime(2022, 12, 15, 9, 40, 53, 0);
            // 
            // Form_newEventPlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 151);
            this.Controls.Add(this.dttm_time);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.dttm_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_desc);
            this.Controls.Add(this.label1);
            this.Name = "Form_newEventPlus";
            this.Text = "Nová Událost +";
            this.Load += new System.EventHandler(this.Form_newEventPlus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.DateTimePicker dttm_time;
        private System.Windows.Forms.DateTimePicker dttm_date;
    }
}