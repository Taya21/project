namespace project
{
    partial class Universities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Universities));
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Name = new System.Windows.Forms.ComboBox();
            this.Show_Un = new System.Windows.Forms.Button();
            this.dGV_tableUn = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_tableUn)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(550, 369);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(130, 54);
            this.Back.TabIndex = 0;
            this.Back.Text = "Главное меню";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Университеты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(57, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название";
            // 
            // cb_Name
            // 
            this.cb_Name.FormattingEnabled = true;
            this.cb_Name.Location = new System.Drawing.Point(60, 63);
            this.cb_Name.Name = "cb_Name";
            this.cb_Name.Size = new System.Drawing.Size(364, 21);
            this.cb_Name.TabIndex = 4;
            this.cb_Name.SelectedIndexChanged += new System.EventHandler(this.cb_Name_SelectedIndexChanged);
            // 
            // Show_Un
            // 
            this.Show_Un.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Show_Un.Location = new System.Drawing.Point(171, 369);
            this.Show_Un.Name = "Show_Un";
            this.Show_Un.Size = new System.Drawing.Size(130, 54);
            this.Show_Un.TabIndex = 0;
            this.Show_Un.Text = "Все университеты";
            this.Show_Un.UseVisualStyleBackColor = true;
            this.Show_Un.Click += new System.EventHandler(this.Show_Un_Click);
            // 
            // dGV_tableUn
            // 
            this.dGV_tableUn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_tableUn.Location = new System.Drawing.Point(13, 131);
            this.dGV_tableUn.Name = "dGV_tableUn";
            this.dGV_tableUn.Size = new System.Drawing.Size(818, 232);
            this.dGV_tableUn.TabIndex = 5;
            // 
            // Universities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 435);
            this.Controls.Add(this.dGV_tableUn);
            this.Controls.Add(this.Show_Un);
            this.Controls.Add(this.cb_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Universities";
            this.Text = "Университеты";
            this.Load += new System.EventHandler(this.Universities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_tableUn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Name;
        private System.Windows.Forms.Button Show_Un;
        private System.Windows.Forms.DataGridView dGV_tableUn;
    }
}