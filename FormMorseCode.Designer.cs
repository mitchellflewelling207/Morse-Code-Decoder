namespace Flewelling_Mitchell_PR_10b___Morse_Code
{
    partial class FormMorseCode
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
            this.buttonFile = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.listBoxOriginalMessage = new System.Windows.Forms.ListBox();
            this.listBoxEncodedMessage = new System.Windows.Forms.ListBox();
            this.listBoxDecodedMessage = new System.Windows.Forms.ListBox();
            this.labelOriginal = new System.Windows.Forms.Label();
            this.labelEncodedMessage = new System.Windows.Forms.Label();
            this.labelDecodedMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(13, 13);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(99, 36);
            this.buttonFile.TabIndex = 0;
            this.buttonFile.Text = "File";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(129, 16);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(554, 29);
            this.textBoxInput.TabIndex = 1;
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(689, 11);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(99, 36);
            this.buttonProcess.TabIndex = 2;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(689, 55);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(99, 36);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // listBoxOriginalMessage
            // 
            this.listBoxOriginalMessage.FormattingEnabled = true;
            this.listBoxOriginalMessage.HorizontalScrollbar = true;
            this.listBoxOriginalMessage.ItemHeight = 24;
            this.listBoxOriginalMessage.Location = new System.Drawing.Point(12, 97);
            this.listBoxOriginalMessage.Name = "listBoxOriginalMessage";
            this.listBoxOriginalMessage.Size = new System.Drawing.Size(776, 172);
            this.listBoxOriginalMessage.TabIndex = 4;
            // 
            // listBoxEncodedMessage
            // 
            this.listBoxEncodedMessage.FormattingEnabled = true;
            this.listBoxEncodedMessage.HorizontalScrollbar = true;
            this.listBoxEncodedMessage.ItemHeight = 24;
            this.listBoxEncodedMessage.Location = new System.Drawing.Point(13, 303);
            this.listBoxEncodedMessage.Name = "listBoxEncodedMessage";
            this.listBoxEncodedMessage.Size = new System.Drawing.Size(776, 172);
            this.listBoxEncodedMessage.TabIndex = 5;
            // 
            // listBoxDecodedMessage
            // 
            this.listBoxDecodedMessage.FormattingEnabled = true;
            this.listBoxDecodedMessage.HorizontalScrollbar = true;
            this.listBoxDecodedMessage.ItemHeight = 24;
            this.listBoxDecodedMessage.Location = new System.Drawing.Point(12, 510);
            this.listBoxDecodedMessage.Name = "listBoxDecodedMessage";
            this.listBoxDecodedMessage.Size = new System.Drawing.Size(776, 172);
            this.listBoxDecodedMessage.TabIndex = 6;
            // 
            // labelOriginal
            // 
            this.labelOriginal.AutoSize = true;
            this.labelOriginal.Location = new System.Drawing.Point(13, 66);
            this.labelOriginal.Name = "labelOriginal";
            this.labelOriginal.Size = new System.Drawing.Size(176, 25);
            this.labelOriginal.TabIndex = 7;
            this.labelOriginal.Text = "Original Message: ";
            // 
            // labelEncodedMessage
            // 
            this.labelEncodedMessage.AutoSize = true;
            this.labelEncodedMessage.Location = new System.Drawing.Point(12, 274);
            this.labelEncodedMessage.Name = "labelEncodedMessage";
            this.labelEncodedMessage.Size = new System.Drawing.Size(187, 25);
            this.labelEncodedMessage.TabIndex = 8;
            this.labelEncodedMessage.Text = "Encoded Message: ";
            // 
            // labelDecodedMessage
            // 
            this.labelDecodedMessage.AutoSize = true;
            this.labelDecodedMessage.Location = new System.Drawing.Point(12, 478);
            this.labelDecodedMessage.Name = "labelDecodedMessage";
            this.labelDecodedMessage.Size = new System.Drawing.Size(188, 25);
            this.labelDecodedMessage.TabIndex = 9;
            this.labelDecodedMessage.Text = "Decoded Message: ";
            // 
            // FormMorseCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 694);
            this.Controls.Add(this.labelDecodedMessage);
            this.Controls.Add(this.labelEncodedMessage);
            this.Controls.Add(this.labelOriginal);
            this.Controls.Add(this.listBoxDecodedMessage);
            this.Controls.Add(this.listBoxEncodedMessage);
            this.Controls.Add(this.listBoxOriginalMessage);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMorseCode";
            this.Text = "Morse Code";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ListBox listBoxOriginalMessage;
        private System.Windows.Forms.ListBox listBoxEncodedMessage;
        private System.Windows.Forms.ListBox listBoxDecodedMessage;
        private System.Windows.Forms.Label labelOriginal;
        private System.Windows.Forms.Label labelEncodedMessage;
        private System.Windows.Forms.Label labelDecodedMessage;
    }
}

