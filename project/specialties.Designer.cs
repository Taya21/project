namespace project
{
    partial class Specialties
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
            this.dGV_Sp = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.Search_Un = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cB_nameUn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cB_form = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chB_comp = new System.Windows.Forms.CheckBox();
            this.chB_contr = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Sp)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_Sp
            // 
            this.dGV_Sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Sp.Location = new System.Drawing.Point(12, 148);
            this.dGV_Sp.Name = "dGV_Sp";
            this.dGV_Sp.Size = new System.Drawing.Size(768, 241);
            this.dGV_Sp.TabIndex = 0;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(502, 395);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(130, 54);
            this.Back.TabIndex = 1;
            this.Back.Text = "Главное меню";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Search_Un
            // 
            this.Search_Un.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_Un.Location = new System.Drawing.Point(177, 395);
            this.Search_Un.Name = "Search_Un";
            this.Search_Un.Size = new System.Drawing.Size(130, 54);
            this.Search_Un.TabIndex = 2;
            this.Search_Un.Text = "Поиск";
            this.Search_Un.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(304, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Специальности";
            // 
            // cB_nameUn
            // 
            this.cB_nameUn.FormattingEnabled = true;
            this.cB_nameUn.Location = new System.Drawing.Point(13, 72);
            this.cB_nameUn.Name = "cB_nameUn";
            this.cB_nameUn.Size = new System.Drawing.Size(121, 21);
            this.cB_nameUn.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Университет";
            // 
            // cB_form
            // 
            this.cB_form.FormattingEnabled = true;
            this.cB_form.Location = new System.Drawing.Point(177, 72);
            this.cB_form.Name = "cB_form";
            this.cB_form.Size = new System.Drawing.Size(121, 21);
            this.cB_form.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(174, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Форма обучения";
            // 
            // chB_comp
            // 
            this.chB_comp.AutoSize = true;
            this.chB_comp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chB_comp.Location = new System.Drawing.Point(358, 70);
            this.chB_comp.Name = "chB_comp";
            this.chB_comp.Size = new System.Drawing.Size(187, 22);
            this.chB_comp.TabIndex = 8;
            this.chB_comp.Text = "Минимальный конкурс";
            this.chB_comp.UseVisualStyleBackColor = true;
            // 
            // chB_contr
            // 
            this.chB_contr.AutoSize = true;
            this.chB_contr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chB_contr.Location = new System.Drawing.Point(586, 70);
            this.chB_contr.Name = "chB_contr";
            this.chB_contr.Size = new System.Drawing.Size(194, 22);
            this.chB_contr.TabIndex = 9;
            this.chB_contr.Text = "Минимальный контракт\r\n";
            this.chB_contr.UseVisualStyleBackColor = true;
            // 
            // Specialties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 461);
            this.Controls.Add(this.chB_contr);
            this.Controls.Add(this.chB_comp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cB_form);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cB_nameUn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search_Un);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.dGV_Sp);
            this.Name = "Specialties";
            this.Text = "Специальности";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Sp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Sp;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Search_Un;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cB_nameUn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cB_form;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chB_comp;
        private System.Windows.Forms.CheckBox chB_contr;
    }
}