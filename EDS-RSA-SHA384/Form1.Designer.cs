namespace EDS_RSA_SHA384
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
            this.TextInput = new System.Windows.Forms.TextBox();
            this.SignInfo = new System.Windows.Forms.TextBox();
            this.SignInput = new System.Windows.Forms.TextBox();
            this.CreateSignButton = new System.Windows.Forms.Button();
            this.VerifySign = new System.Windows.Forms.Button();
            this.TextLabel = new System.Windows.Forms.Label();
            this.SignInfoLabel = new System.Windows.Forms.Label();
            this.SignLabel = new System.Windows.Forms.Label();
            this.SignVerificationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(12, 25);
            this.TextInput.Multiline = true;
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(300, 100);
            this.TextInput.TabIndex = 0;
            // 
            // SignInfo
            // 
            this.SignInfo.Location = new System.Drawing.Point(12, 185);
            this.SignInfo.Multiline = true;
            this.SignInfo.Name = "SignInfo";
            this.SignInfo.Size = new System.Drawing.Size(300, 100);
            this.SignInfo.TabIndex = 1;
            this.SignInfo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SignInput
            // 
            this.SignInput.Location = new System.Drawing.Point(15, 313);
            this.SignInput.Multiline = true;
            this.SignInput.Name = "SignInput";
            this.SignInput.Size = new System.Drawing.Size(300, 100);
            this.SignInput.TabIndex = 2;
            // 
            // CreateSignButton
            // 
            this.CreateSignButton.Location = new System.Drawing.Point(121, 131);
            this.CreateSignButton.Name = "CreateSignButton";
            this.CreateSignButton.Size = new System.Drawing.Size(75, 23);
            this.CreateSignButton.TabIndex = 3;
            this.CreateSignButton.Text = "Create sign";
            this.CreateSignButton.UseVisualStyleBackColor = true;
            this.CreateSignButton.Click += new System.EventHandler(this.CreateSignButton_Click);
            // 
            // VerifySign
            // 
            this.VerifySign.Location = new System.Drawing.Point(121, 419);
            this.VerifySign.Name = "VerifySign";
            this.VerifySign.Size = new System.Drawing.Size(75, 23);
            this.VerifySign.TabIndex = 4;
            this.VerifySign.Text = "VerifySign";
            this.VerifySign.UseVisualStyleBackColor = true;
            this.VerifySign.Click += new System.EventHandler(this.VerifySign_Click);
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(12, 9);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(28, 13);
            this.TextLabel.TabIndex = 5;
            this.TextLabel.Text = "Text";
            // 
            // SignInfoLabel
            // 
            this.SignInfoLabel.AutoSize = true;
            this.SignInfoLabel.Location = new System.Drawing.Point(12, 160);
            this.SignInfoLabel.Name = "SignInfoLabel";
            this.SignInfoLabel.Size = new System.Drawing.Size(49, 13);
            this.SignInfoLabel.TabIndex = 6;
            this.SignInfoLabel.Text = "Sign Info";
            // 
            // SignLabel
            // 
            this.SignLabel.AutoSize = true;
            this.SignLabel.Location = new System.Drawing.Point(12, 288);
            this.SignLabel.Name = "SignLabel";
            this.SignLabel.Size = new System.Drawing.Size(28, 13);
            this.SignLabel.TabIndex = 7;
            this.SignLabel.Text = "Sign";
            // 
            // SignVerificationLabel
            // 
            this.SignVerificationLabel.AutoSize = true;
            this.SignVerificationLabel.Location = new System.Drawing.Point(147, 460);
            this.SignVerificationLabel.Name = "SignVerificationLabel";
            this.SignVerificationLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SignVerificationLabel.Size = new System.Drawing.Size(0, 13);
            this.SignVerificationLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 512);
            this.Controls.Add(this.SignVerificationLabel);
            this.Controls.Add(this.SignLabel);
            this.Controls.Add(this.SignInfoLabel);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.VerifySign);
            this.Controls.Add(this.CreateSignButton);
            this.Controls.Add(this.SignInput);
            this.Controls.Add(this.SignInfo);
            this.Controls.Add(this.TextInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.TextBox SignInfo;
        private System.Windows.Forms.TextBox SignInput;
        private System.Windows.Forms.Button CreateSignButton;
        private System.Windows.Forms.Button VerifySign;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Label SignInfoLabel;
        private System.Windows.Forms.Label SignLabel;
        private System.Windows.Forms.Label SignVerificationLabel;
    }
}

