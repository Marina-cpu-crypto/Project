namespace Project
{
    partial class FormTour
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxFreeTours = new System.Windows.Forms.ListBox();
            this.listBoxGetTours = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxFreeTours
            // 
            this.listBoxFreeTours.FormattingEnabled = true;
            this.listBoxFreeTours.Location = new System.Drawing.Point(44, 118);
            this.listBoxFreeTours.Name = "listBoxFreeTours";
            this.listBoxFreeTours.Size = new System.Drawing.Size(120, 199);
            this.listBoxFreeTours.TabIndex = 0;
            this.listBoxFreeTours.SelectedIndexChanged += new System.EventHandler(this.listBoxFreeTours_SelectedIndexChanged);
            // 
            // listBoxGetTours
            // 
            this.listBoxGetTours.FormattingEnabled = true;
            this.listBoxGetTours.Location = new System.Drawing.Point(286, 118);
            this.listBoxGetTours.Name = "listBoxGetTours";
            this.listBoxGetTours.Size = new System.Drawing.Size(120, 199);
            this.listBoxGetTours.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список доступных туров";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Забронированные";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(199, 359);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 6;
            this.buttonCheck.Text = "ПРОВЕРКА";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // FormTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxGetTours);
            this.Controls.Add(this.listBoxFreeTours);
            this.Name = "FormTour";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormTour_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFreeTours;
        private System.Windows.Forms.ListBox listBoxGetTours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCheck;
    }
}

