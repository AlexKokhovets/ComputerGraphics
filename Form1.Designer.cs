
namespace Lab1KG
{
    partial class Form1
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
            this.hsvPicture = new System.Windows.Forms.PictureBox();
            this.xyzPicture = new System.Windows.Forms.PictureBox();
            this.labPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hField = new System.Windows.Forms.TextBox();
            this.sField = new System.Windows.Forms.TextBox();
            this.vField = new System.Windows.Forms.TextBox();
            this.hsvButton = new System.Windows.Forms.Button();
            this.xyzButton = new System.Windows.Forms.Button();
            this.xFieldXYZ = new System.Windows.Forms.TextBox();
            this.yFieldXYZ = new System.Windows.Forms.TextBox();
            this.zFieldXYZ = new System.Windows.Forms.TextBox();
            this.lField = new System.Windows.Forms.TextBox();
            this.aField = new System.Windows.Forms.TextBox();
            this.bField = new System.Windows.Forms.TextBox();
            this.ShowLAB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hsvPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xyzPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // hsvPicture
            // 
            this.hsvPicture.Location = new System.Drawing.Point(31, 39);
            this.hsvPicture.Name = "hsvPicture";
            this.hsvPicture.Size = new System.Drawing.Size(260, 34);
            this.hsvPicture.TabIndex = 1;
            this.hsvPicture.TabStop = false;
            // 
            // xyzPicture
            // 
            this.xyzPicture.Location = new System.Drawing.Point(290, 39);
            this.xyzPicture.Name = "xyzPicture";
            this.xyzPicture.Size = new System.Drawing.Size(227, 34);
            this.xyzPicture.TabIndex = 2;
            this.xyzPicture.TabStop = false;
            // 
            // labPicture
            // 
            this.labPicture.Location = new System.Drawing.Point(514, 39);
            this.labPicture.Name = "labPicture";
            this.labPicture.Size = new System.Drawing.Size(229, 34);
            this.labPicture.TabIndex = 3;
            this.labPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "HSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "XYZ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "LAB";
            // 
            // hField
            // 
            this.hField.Location = new System.Drawing.Point(66, 107);
            this.hField.Name = "hField";
            this.hField.Size = new System.Drawing.Size(50, 22);
            this.hField.TabIndex = 7;
            // 
            // sField
            // 
            this.sField.Location = new System.Drawing.Point(122, 107);
            this.sField.Name = "sField";
            this.sField.Size = new System.Drawing.Size(50, 22);
            this.sField.TabIndex = 8;
            // 
            // vField
            // 
            this.vField.Location = new System.Drawing.Point(178, 107);
            this.vField.Name = "vField";
            this.vField.Size = new System.Drawing.Size(50, 22);
            this.vField.TabIndex = 9;
            // 
            // hsvButton
            // 
            this.hsvButton.Location = new System.Drawing.Point(57, 162);
            this.hsvButton.Name = "hsvButton";
            this.hsvButton.Size = new System.Drawing.Size(204, 23);
            this.hsvButton.TabIndex = 10;
            this.hsvButton.Text = "ShowHSV";
            this.hsvButton.UseVisualStyleBackColor = true;
            this.hsvButton.Click += new System.EventHandler(this.hsvButton_Click);
            // 
            // xyzButton
            // 
            this.xyzButton.Location = new System.Drawing.Point(290, 162);
            this.xyzButton.Name = "xyzButton";
            this.xyzButton.Size = new System.Drawing.Size(204, 23);
            this.xyzButton.TabIndex = 11;
            this.xyzButton.Text = "ShowXYZ";
            this.xyzButton.UseVisualStyleBackColor = true;
            this.xyzButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // xFieldXYZ
            // 
            this.xFieldXYZ.Location = new System.Drawing.Point(303, 107);
            this.xFieldXYZ.Name = "xFieldXYZ";
            this.xFieldXYZ.Size = new System.Drawing.Size(50, 22);
            this.xFieldXYZ.TabIndex = 12;
            // 
            // yFieldXYZ
            // 
            this.yFieldXYZ.Location = new System.Drawing.Point(359, 107);
            this.yFieldXYZ.Name = "yFieldXYZ";
            this.yFieldXYZ.Size = new System.Drawing.Size(50, 22);
            this.yFieldXYZ.TabIndex = 13;
            // 
            // zFieldXYZ
            // 
            this.zFieldXYZ.Location = new System.Drawing.Point(415, 107);
            this.zFieldXYZ.Name = "zFieldXYZ";
            this.zFieldXYZ.Size = new System.Drawing.Size(50, 22);
            this.zFieldXYZ.TabIndex = 14;
            // 
            // lField
            // 
            this.lField.Location = new System.Drawing.Point(539, 107);
            this.lField.Name = "lField";
            this.lField.Size = new System.Drawing.Size(50, 22);
            this.lField.TabIndex = 15;
            // 
            // aField
            // 
            this.aField.Location = new System.Drawing.Point(595, 107);
            this.aField.Name = "aField";
            this.aField.Size = new System.Drawing.Size(50, 22);
            this.aField.TabIndex = 16;
            // 
            // bField
            // 
            this.bField.Location = new System.Drawing.Point(651, 107);
            this.bField.Name = "bField";
            this.bField.Size = new System.Drawing.Size(50, 22);
            this.bField.TabIndex = 17;
            // 
            // ShowLAB
            // 
            this.ShowLAB.Location = new System.Drawing.Point(525, 162);
            this.ShowLAB.Name = "ShowLAB";
            this.ShowLAB.Size = new System.Drawing.Size(204, 23);
            this.ShowLAB.TabIndex = 18;
            this.ShowLAB.Text = "ShowLAB";
            this.ShowLAB.UseVisualStyleBackColor = true;
            this.ShowLAB.Click += new System.EventHandler(this.ShowLAB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 233);
            this.Controls.Add(this.ShowLAB);
            this.Controls.Add(this.bField);
            this.Controls.Add(this.aField);
            this.Controls.Add(this.lField);
            this.Controls.Add(this.zFieldXYZ);
            this.Controls.Add(this.yFieldXYZ);
            this.Controls.Add(this.xFieldXYZ);
            this.Controls.Add(this.xyzButton);
            this.Controls.Add(this.hsvButton);
            this.Controls.Add(this.vField);
            this.Controls.Add(this.sField);
            this.Controls.Add(this.hField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labPicture);
            this.Controls.Add(this.xyzPicture);
            this.Controls.Add(this.hsvPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hsvPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xyzPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox hsvPicture;
        private System.Windows.Forms.PictureBox xyzPicture;
        private System.Windows.Forms.PictureBox labPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hField;
        private System.Windows.Forms.TextBox sField;
        private System.Windows.Forms.TextBox vField;
        private System.Windows.Forms.Button hsvButton;
        private System.Windows.Forms.Button xyzButton;
        private System.Windows.Forms.TextBox xFieldXYZ;
        private System.Windows.Forms.TextBox yFieldXYZ;
        private System.Windows.Forms.TextBox zFieldXYZ;
        private System.Windows.Forms.TextBox lField;
        private System.Windows.Forms.TextBox aField;
        private System.Windows.Forms.TextBox bField;
        private System.Windows.Forms.Button ShowLAB;
    }
}

