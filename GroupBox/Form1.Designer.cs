
namespace GroupBox
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.FreeRadioButton = new System.Windows.Forms.RadioButton();
            this.PaidRadioButton = new System.Windows.Forms.RadioButton();
            this.PaidLabel = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.PaidRadioButton);
            this.groupBox.Controls.Add(this.FreeRadioButton);
            this.groupBox.Location = new System.Drawing.Point(67, 66);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(594, 164);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "groupBox";
            // 
            // FreeRadioButton
            // 
            this.FreeRadioButton.AutoSize = true;
            this.FreeRadioButton.Location = new System.Drawing.Point(44, 78);
            this.FreeRadioButton.Name = "FreeRadioButton";
            this.FreeRadioButton.Size = new System.Drawing.Size(208, 28);
            this.FreeRadioButton.TabIndex = 0;
            this.FreeRadioButton.TabStop = true;
            this.FreeRadioButton.Text = "FreeRadioButton";
            this.FreeRadioButton.UseVisualStyleBackColor = true;
            this.FreeRadioButton.CheckedChanged += new System.EventHandler(this.FreeRadioButton_CheckedChanged);
            // 
            // PaidRadioButton
            // 
            this.PaidRadioButton.AutoSize = true;
            this.PaidRadioButton.Location = new System.Drawing.Point(347, 78);
            this.PaidRadioButton.Name = "PaidRadioButton";
            this.PaidRadioButton.Size = new System.Drawing.Size(206, 28);
            this.PaidRadioButton.TabIndex = 1;
            this.PaidRadioButton.TabStop = true;
            this.PaidRadioButton.Text = "PaidRadioButton";
            this.PaidRadioButton.UseVisualStyleBackColor = true;
            this.PaidRadioButton.CheckedChanged += new System.EventHandler(this.PaidRadioButton_CheckedChanged);
            // 
            // PaidLabel
            // 
            this.PaidLabel.AutoSize = true;
            this.PaidLabel.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PaidLabel.Location = new System.Drawing.Point(93, 314);
            this.PaidLabel.Name = "PaidLabel";
            this.PaidLabel.Size = new System.Drawing.Size(268, 43);
            this.PaidLabel.TabIndex = 1;
            this.PaidLabel.Text = "有料会員です";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 686);
            this.Controls.Add(this.PaidLabel);
            this.Controls.Add(this.groupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton PaidRadioButton;
        private System.Windows.Forms.RadioButton FreeRadioButton;
        private System.Windows.Forms.Label PaidLabel;
    }
}

