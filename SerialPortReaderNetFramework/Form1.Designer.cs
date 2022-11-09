
namespace SerialPortReaderNetFramework
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.startReadButton = new System.Windows.Forms.Button();
            this.stopReadButton = new System.Windows.Forms.Button();
            this.readTextBox = new System.Windows.Forms.TextBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.labelLog = new System.Windows.Forms.Label();
            this.labelWrite = new System.Windows.Forms.Label();
            this.writeTextBox = new System.Windows.Forms.TextBox();
            this.labelRead = new System.Windows.Forms.Label();
            this.writeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startReadButton
            // 
            this.startReadButton.Location = new System.Drawing.Point(12, 12);
            this.startReadButton.Name = "startReadButton";
            this.startReadButton.Size = new System.Drawing.Size(100, 50);
            this.startReadButton.TabIndex = 0;
            this.startReadButton.Text = "Start Reading";
            this.startReadButton.UseVisualStyleBackColor = true;
            this.startReadButton.Click += new System.EventHandler(this.startReadButton_Click);
            // 
            // stopReadButton
            // 
            this.stopReadButton.Enabled = false;
            this.stopReadButton.Location = new System.Drawing.Point(12, 68);
            this.stopReadButton.Name = "stopReadButton";
            this.stopReadButton.Size = new System.Drawing.Size(100, 50);
            this.stopReadButton.TabIndex = 1;
            this.stopReadButton.Text = "Stop Reading";
            this.stopReadButton.UseVisualStyleBackColor = true;
            this.stopReadButton.Click += new System.EventHandler(this.stopReadButton_Click);
            // 
            // readTextBox
            // 
            this.readTextBox.Location = new System.Drawing.Point(137, 28);
            this.readTextBox.Multiline = true;
            this.readTextBox.Name = "readTextBox";
            this.readTextBox.Size = new System.Drawing.Size(170, 90);
            this.readTextBox.TabIndex = 2;
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(12, 283);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(499, 95);
            this.logTextBox.TabIndex = 3;
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(12, 267);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(28, 13);
            this.labelLog.TabIndex = 4;
            this.labelLog.Text = "Log:";
            // 
            // labelWrite
            // 
            this.labelWrite.AutoSize = true;
            this.labelWrite.Location = new System.Drawing.Point(501, 12);
            this.labelWrite.Name = "labelWrite";
            this.labelWrite.Size = new System.Drawing.Size(91, 13);
            this.labelWrite.TabIndex = 5;
            this.labelWrite.Text = "Write Some Data:";
            // 
            // writeTextBox
            // 
            this.writeTextBox.Location = new System.Drawing.Point(504, 28);
            this.writeTextBox.Multiline = true;
            this.writeTextBox.Name = "writeTextBox";
            this.writeTextBox.Size = new System.Drawing.Size(170, 90);
            this.writeTextBox.TabIndex = 6;
            this.writeTextBox.TextChanged += new System.EventHandler(this.writeTextBox_TextChanged);
            // 
            // labelRead
            // 
            this.labelRead.AutoSize = true;
            this.labelRead.Location = new System.Drawing.Point(134, 12);
            this.labelRead.Name = "labelRead";
            this.labelRead.Size = new System.Drawing.Size(62, 13);
            this.labelRead.TabIndex = 7;
            this.labelRead.Text = "Read Data:";
            // 
            // writeButton
            // 
            this.writeButton.Enabled = false;
            this.writeButton.Location = new System.Drawing.Point(377, 46);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(100, 50);
            this.writeButton.TabIndex = 8;
            this.writeButton.Text = "Write";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.labelRead);
            this.Controls.Add(this.writeTextBox);
            this.Controls.Add(this.labelWrite);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.readTextBox);
            this.Controls.Add(this.stopReadButton);
            this.Controls.Add(this.startReadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startReadButton;
        private System.Windows.Forms.Button stopReadButton;
        private System.Windows.Forms.TextBox readTextBox;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Label labelWrite;
        private System.Windows.Forms.TextBox writeTextBox;
        private System.Windows.Forms.Label labelRead;
        private System.Windows.Forms.Button writeButton;
    }
}

