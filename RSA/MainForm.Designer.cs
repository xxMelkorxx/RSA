
namespace RSA
{
    partial class MainForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label_n;
            this.button_generateKey = new System.Windows.Forms.Button();
            this.textBox_openKey = new System.Windows.Forms.TextBox();
            this.button_decryptionText = new System.Windows.Forms.Button();
            this.button_encryptionText = new System.Windows.Forms.Button();
            this.groupBox_closedText = new System.Windows.Forms.GroupBox();
            this.button_clearClosedText = new System.Windows.Forms.Button();
            this.button_exportClosedText = new System.Windows.Forms.Button();
            this.richTextBox_closedText = new System.Windows.Forms.RichTextBox();
            this.button_importClosedText = new System.Windows.Forms.Button();
            this.groupBox_openText = new System.Windows.Forms.GroupBox();
            this.button_clearOpenText = new System.Windows.Forms.Button();
            this.richTextBox_openText = new System.Windows.Forms.RichTextBox();
            this.button_exportOpenText = new System.Windows.Forms.Button();
            this.button_importOpenText = new System.Windows.Forms.Button();
            this.textBox_closeKey = new System.Windows.Forms.TextBox();
            this.textBox_module = new System.Windows.Forms.TextBox();
            this.button_saveKeys = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label_n = new System.Windows.Forms.Label();
            this.groupBox_closedText.SuspendLayout();
            this.groupBox_openText.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(22, 372);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(16, 13);
            label1.TabIndex = 14;
            label1.Text = "e:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(22, 399);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(16, 13);
            label2.TabIndex = 16;
            label2.Text = "d:";
            // 
            // label_n
            // 
            label_n.AutoSize = true;
            label_n.Location = new System.Drawing.Point(206, 372);
            label_n.Name = "label_n";
            label_n.Size = new System.Drawing.Size(16, 13);
            label_n.TabIndex = 18;
            label_n.Text = "n:";
            // 
            // button_generateKey
            // 
            this.button_generateKey.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_generateKey.Location = new System.Drawing.Point(390, 368);
            this.button_generateKey.Name = "button_generateKey";
            this.button_generateKey.Size = new System.Drawing.Size(125, 20);
            this.button_generateKey.TabIndex = 13;
            this.button_generateKey.Text = "Сгенерировать ключ";
            this.button_generateKey.UseVisualStyleBackColor = true;
            this.button_generateKey.Click += new System.EventHandler(this.OnClickButtonGenerateKey);
            // 
            // textBox_openKey
            // 
            this.textBox_openKey.Location = new System.Drawing.Point(44, 369);
            this.textBox_openKey.Name = "textBox_openKey";
            this.textBox_openKey.Size = new System.Drawing.Size(156, 20);
            this.textBox_openKey.TabIndex = 12;
            this.textBox_openKey.Text = "273631351";
            this.textBox_openKey.TextChanged += new System.EventHandler(this.OnTextChangedTextBoxOpenKey);
            // 
            // button_decryptionText
            // 
            this.button_decryptionText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_decryptionText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_decryptionText.Location = new System.Drawing.Point(662, 395);
            this.button_decryptionText.Name = "button_decryptionText";
            this.button_decryptionText.Size = new System.Drawing.Size(100, 20);
            this.button_decryptionText.TabIndex = 11;
            this.button_decryptionText.Text = "<<";
            this.button_decryptionText.UseVisualStyleBackColor = true;
            this.button_decryptionText.Click += new System.EventHandler(this.OnClickButtonDecrypt);
            // 
            // button_encryptionText
            // 
            this.button_encryptionText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_encryptionText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_encryptionText.Location = new System.Drawing.Point(662, 368);
            this.button_encryptionText.Name = "button_encryptionText";
            this.button_encryptionText.Size = new System.Drawing.Size(100, 20);
            this.button_encryptionText.TabIndex = 10;
            this.button_encryptionText.Text = ">>";
            this.button_encryptionText.UseVisualStyleBackColor = true;
            this.button_encryptionText.Click += new System.EventHandler(this.OnClickButtonEncrypt);
            // 
            // groupBox_closedText
            // 
            this.groupBox_closedText.Controls.Add(this.button_clearClosedText);
            this.groupBox_closedText.Controls.Add(this.button_exportClosedText);
            this.groupBox_closedText.Controls.Add(this.richTextBox_closedText);
            this.groupBox_closedText.Controls.Add(this.button_importClosedText);
            this.groupBox_closedText.Location = new System.Drawing.Point(390, 12);
            this.groupBox_closedText.Name = "groupBox_closedText";
            this.groupBox_closedText.Size = new System.Drawing.Size(372, 350);
            this.groupBox_closedText.TabIndex = 9;
            this.groupBox_closedText.TabStop = false;
            this.groupBox_closedText.Text = "Закрытый текст";
            // 
            // button_clearClosedText
            // 
            this.button_clearClosedText.Location = new System.Drawing.Point(291, 324);
            this.button_clearClosedText.Name = "button_clearClosedText";
            this.button_clearClosedText.Size = new System.Drawing.Size(75, 20);
            this.button_clearClosedText.TabIndex = 3;
            this.button_clearClosedText.Text = "Очистить";
            this.button_clearClosedText.UseVisualStyleBackColor = true;
            this.button_clearClosedText.Click += new System.EventHandler(this.OnClickButtonClearClosedText);
            // 
            // button_exportClosedText
            // 
            this.button_exportClosedText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_exportClosedText.Location = new System.Drawing.Point(112, 324);
            this.button_exportClosedText.Name = "button_exportClosedText";
            this.button_exportClosedText.Size = new System.Drawing.Size(100, 20);
            this.button_exportClosedText.TabIndex = 7;
            this.button_exportClosedText.Text = "Сохранить";
            this.button_exportClosedText.UseVisualStyleBackColor = true;
            this.button_exportClosedText.Click += new System.EventHandler(this.OnClickButtonExportClosedText);
            // 
            // richTextBox_closedText
            // 
            this.richTextBox_closedText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_closedText.Location = new System.Drawing.Point(6, 19);
            this.richTextBox_closedText.Name = "richTextBox_closedText";
            this.richTextBox_closedText.Size = new System.Drawing.Size(360, 300);
            this.richTextBox_closedText.TabIndex = 2;
            this.richTextBox_closedText.Text = "";
            // 
            // button_importClosedText
            // 
            this.button_importClosedText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_importClosedText.Location = new System.Drawing.Point(6, 324);
            this.button_importClosedText.Name = "button_importClosedText";
            this.button_importClosedText.Size = new System.Drawing.Size(100, 20);
            this.button_importClosedText.TabIndex = 2;
            this.button_importClosedText.Text = "Загрузить";
            this.button_importClosedText.UseVisualStyleBackColor = true;
            this.button_importClosedText.Click += new System.EventHandler(this.OnClickButtonImportClosedText);
            // 
            // groupBox_openText
            // 
            this.groupBox_openText.Controls.Add(this.button_clearOpenText);
            this.groupBox_openText.Controls.Add(this.richTextBox_openText);
            this.groupBox_openText.Controls.Add(this.button_exportOpenText);
            this.groupBox_openText.Controls.Add(this.button_importOpenText);
            this.groupBox_openText.Location = new System.Drawing.Point(12, 12);
            this.groupBox_openText.Name = "groupBox_openText";
            this.groupBox_openText.Size = new System.Drawing.Size(372, 350);
            this.groupBox_openText.TabIndex = 8;
            this.groupBox_openText.TabStop = false;
            this.groupBox_openText.Text = "Открытый текст";
            // 
            // button_clearOpenText
            // 
            this.button_clearOpenText.Location = new System.Drawing.Point(291, 324);
            this.button_clearOpenText.Name = "button_clearOpenText";
            this.button_clearOpenText.Size = new System.Drawing.Size(75, 20);
            this.button_clearOpenText.TabIndex = 2;
            this.button_clearOpenText.Text = "Очистить";
            this.button_clearOpenText.UseVisualStyleBackColor = true;
            this.button_clearOpenText.Click += new System.EventHandler(this.OnClickButtonClearOpenText);
            // 
            // richTextBox_openText
            // 
            this.richTextBox_openText.Location = new System.Drawing.Point(6, 19);
            this.richTextBox_openText.Name = "richTextBox_openText";
            this.richTextBox_openText.Size = new System.Drawing.Size(360, 300);
            this.richTextBox_openText.TabIndex = 0;
            this.richTextBox_openText.Text = "Hello world!";
            // 
            // button_exportOpenText
            // 
            this.button_exportOpenText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_exportOpenText.Location = new System.Drawing.Point(112, 324);
            this.button_exportOpenText.Name = "button_exportOpenText";
            this.button_exportOpenText.Size = new System.Drawing.Size(100, 20);
            this.button_exportOpenText.TabIndex = 1;
            this.button_exportOpenText.Text = "Сохранить";
            this.button_exportOpenText.UseVisualStyleBackColor = true;
            this.button_exportOpenText.Click += new System.EventHandler(this.OnClickButtonExportOpenText);
            // 
            // button_importOpenText
            // 
            this.button_importOpenText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_importOpenText.Location = new System.Drawing.Point(6, 324);
            this.button_importOpenText.Name = "button_importOpenText";
            this.button_importOpenText.Size = new System.Drawing.Size(100, 20);
            this.button_importOpenText.TabIndex = 0;
            this.button_importOpenText.Text = "Загрузить";
            this.button_importOpenText.UseVisualStyleBackColor = true;
            this.button_importOpenText.Click += new System.EventHandler(this.OnClickButtonImportOpenText);
            // 
            // textBox_closeKey
            // 
            this.textBox_closeKey.Location = new System.Drawing.Point(44, 395);
            this.textBox_closeKey.Name = "textBox_closeKey";
            this.textBox_closeKey.Size = new System.Drawing.Size(156, 20);
            this.textBox_closeKey.TabIndex = 15;
            this.textBox_closeKey.Text = "52366471";
            this.textBox_closeKey.TextChanged += new System.EventHandler(this.OnTextChangedTextBoxCloseKey);
            // 
            // textBox_module
            // 
            this.textBox_module.Location = new System.Drawing.Point(228, 369);
            this.textBox_module.Name = "textBox_module";
            this.textBox_module.Size = new System.Drawing.Size(156, 20);
            this.textBox_module.TabIndex = 17;
            this.textBox_module.Text = "634733327";
            this.textBox_module.TextChanged += new System.EventHandler(this.OnTextChangedTextBoxModule);
            // 
            // button_saveKeys
            // 
            this.button_saveKeys.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_saveKeys.Location = new System.Drawing.Point(390, 394);
            this.button_saveKeys.Name = "button_saveKeys";
            this.button_saveKeys.Size = new System.Drawing.Size(125, 20);
            this.button_saveKeys.TabIndex = 19;
            this.button_saveKeys.Text = "Сохранить ключи";
            this.button_saveKeys.UseVisualStyleBackColor = true;
            this.button_saveKeys.Click += new System.EventHandler(this.OnClickButtonSaveKeys);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 424);
            this.Controls.Add(this.button_saveKeys);
            this.Controls.Add(label_n);
            this.Controls.Add(this.textBox_module);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBox_closeKey);
            this.Controls.Add(label1);
            this.Controls.Add(this.button_generateKey);
            this.Controls.Add(this.textBox_openKey);
            this.Controls.Add(this.button_decryptionText);
            this.Controls.Add(this.button_encryptionText);
            this.Controls.Add(this.groupBox_closedText);
            this.Controls.Add(this.groupBox_openText);
            this.Name = "MainForm";
            this.Text = "ИТФИ ННГУ | Шифр RSA";
            this.Load += new System.EventHandler(this.OnLoadMainForm);
            this.groupBox_closedText.ResumeLayout(false);
            this.groupBox_openText.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_generateKey;
        private System.Windows.Forms.TextBox textBox_openKey;
        private System.Windows.Forms.Button button_decryptionText;
        private System.Windows.Forms.Button button_encryptionText;
        private System.Windows.Forms.GroupBox groupBox_closedText;
        private System.Windows.Forms.Button button_clearClosedText;
        private System.Windows.Forms.Button button_exportClosedText;
        private System.Windows.Forms.RichTextBox richTextBox_closedText;
        private System.Windows.Forms.Button button_importClosedText;
        private System.Windows.Forms.GroupBox groupBox_openText;
        private System.Windows.Forms.Button button_clearOpenText;
        private System.Windows.Forms.RichTextBox richTextBox_openText;
        private System.Windows.Forms.Button button_exportOpenText;
        private System.Windows.Forms.Button button_importOpenText;
        private System.Windows.Forms.TextBox textBox_closeKey;
        private System.Windows.Forms.TextBox textBox_module;
        private System.Windows.Forms.Button button_saveKeys;
    }
}

