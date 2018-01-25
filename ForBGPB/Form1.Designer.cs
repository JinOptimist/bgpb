namespace ForBGPB
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rdBtnSort1 = new System.Windows.Forms.RadioButton();
            this.rdBtnSort2 = new System.Windows.Forms.RadioButton();
            this.rdBtnSort3 = new System.Windows.Forms.RadioButton();
            this.rdBtnDirectTop = new System.Windows.Forms.RadioButton();
            this.rdBtnDirectBot = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.AutoSize = true;
            this.lblLastUpdate.Location = new System.Drawing.Point(121, 3);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(19, 13);
            this.lblLastUpdate.TabIndex = 0;
            this.lblLastUpdate.Text = "***";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(3, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Обновить сейчас";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rdBtnSort1
            // 
            this.rdBtnSort1.AutoSize = true;
            this.rdBtnSort1.Location = new System.Drawing.Point(6, 19);
            this.rdBtnSort1.Name = "rdBtnSort1";
            this.rdBtnSort1.Size = new System.Drawing.Size(121, 17);
            this.rdBtnSort1.TabIndex = 2;
            this.rdBtnSort1.Text = "Времени создания";
            this.rdBtnSort1.UseVisualStyleBackColor = true;
            this.rdBtnSort1.Click += new System.EventHandler(this.rdBtnSort1_Click);
            // 
            // rdBtnSort2
            // 
            this.rdBtnSort2.AutoSize = true;
            this.rdBtnSort2.Location = new System.Drawing.Point(133, 19);
            this.rdBtnSort2.Name = "rdBtnSort2";
            this.rdBtnSort2.Size = new System.Drawing.Size(167, 17);
            this.rdBtnSort2.TabIndex = 3;
            this.rdBtnSort2.Text = "Последний раз записывали";
            this.rdBtnSort2.UseVisualStyleBackColor = true;
            this.rdBtnSort2.Click += new System.EventHandler(this.rdBtnSort1_Click);
            // 
            // rdBtnSort3
            // 
            this.rdBtnSort3.AutoSize = true;
            this.rdBtnSort3.Location = new System.Drawing.Point(306, 19);
            this.rdBtnSort3.Name = "rdBtnSort3";
            this.rdBtnSort3.Size = new System.Drawing.Size(160, 17);
            this.rdBtnSort3.TabIndex = 5;
            this.rdBtnSort3.Text = "Последний раз открывали";
            this.rdBtnSort3.UseVisualStyleBackColor = true;
            this.rdBtnSort3.Click += new System.EventHandler(this.rdBtnSort1_Click);
            // 
            // rdBtnDirectTop
            // 
            this.rdBtnDirectTop.AccessibleName = "";
            this.rdBtnDirectTop.AutoSize = true;
            this.rdBtnDirectTop.Checked = true;
            this.rdBtnDirectTop.Location = new System.Drawing.Point(6, 19);
            this.rdBtnDirectTop.Name = "rdBtnDirectTop";
            this.rdBtnDirectTop.Size = new System.Drawing.Size(60, 17);
            this.rdBtnDirectTop.TabIndex = 6;
            this.rdBtnDirectTop.TabStop = true;
            this.rdBtnDirectTop.Text = "Сверху";
            this.rdBtnDirectTop.UseVisualStyleBackColor = true;
            this.rdBtnDirectTop.CheckedChanged += new System.EventHandler(this.rdBtnDirectTop_CheckedChanged);
            this.rdBtnDirectTop.Click += new System.EventHandler(this.rdBtnSort1_Click);
            // 
            // rdBtnDirectBot
            // 
            this.rdBtnDirectBot.AccessibleName = "";
            this.rdBtnDirectBot.AutoSize = true;
            this.rdBtnDirectBot.Location = new System.Drawing.Point(72, 19);
            this.rdBtnDirectBot.Name = "rdBtnDirectBot";
            this.rdBtnDirectBot.Size = new System.Drawing.Size(55, 17);
            this.rdBtnDirectBot.TabIndex = 8;
            this.rdBtnDirectBot.Text = "Снизу";
            this.rdBtnDirectBot.UseVisualStyleBackColor = true;
            this.rdBtnDirectBot.Click += new System.EventHandler(this.rdBtnSort1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnSort1);
            this.groupBox1.Controls.Add(this.rdBtnSort2);
            this.groupBox1.Controls.Add(this.rdBtnSort3);
            this.groupBox1.Location = new System.Drawing.Point(573, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 46);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировать по";
            this.groupBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdBtnDirectTop);
            this.groupBox2.Controls.Add(this.rdBtnDirectBot);
            this.groupBox2.Location = new System.Drawing.Point(430, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 46);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Новые файлы:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblLastUpdate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton rdBtnSort1;
        private System.Windows.Forms.RadioButton rdBtnSort2;
        private System.Windows.Forms.RadioButton rdBtnSort3;
        private System.Windows.Forms.RadioButton rdBtnDirectBot;
        private System.Windows.Forms.RadioButton rdBtnDirectTop;
        private System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.GroupBox groupBox1;
    }
}

