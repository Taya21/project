namespace project
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Universities = new System.Windows.Forms.Button();
            this.b_Specialties = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(206, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Справочник абитуриента";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(261, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Харьковская область";
            // 
            // Universities
            // 
            this.Universities.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Universities.Location = new System.Drawing.Point(303, 141);
            this.Universities.Name = "Universities";
            this.Universities.Size = new System.Drawing.Size(129, 55);
            this.Universities.TabIndex = 2;
            this.Universities.Text = "Университеты";
            this.Universities.UseVisualStyleBackColor = true;
            this.Universities.Click += new System.EventHandler(this.Universities_Click);
            // 
            // b_Specialties
            // 
            this.b_Specialties.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Specialties.Location = new System.Drawing.Point(289, 202);
            this.b_Specialties.Name = "b_Specialties";
            this.b_Specialties.Size = new System.Drawing.Size(153, 55);
            this.b_Specialties.TabIndex = 3;
            this.b_Specialties.Text = "Специальности";
            this.b_Specialties.UseVisualStyleBackColor = true;
            this.b_Specialties.Click += new System.EventHandler(this.b_Specialties_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(550, 358);
            this.Controls.Add(this.b_Specialties);
            this.Controls.Add(this.Universities);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Universities;
        private System.Windows.Forms.Button b_Specialties;
    }
}

