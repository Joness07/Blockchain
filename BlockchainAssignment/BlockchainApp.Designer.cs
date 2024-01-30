namespace BlockchainAssignment
{
    partial class BlockchainApp
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
            this.outputRichTextbox = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.printBlockButton = new System.Windows.Forms.Button();
            this.generateKeyButton = new System.Windows.Forms.Button();
            this.publicKeyTextbox = new System.Windows.Forms.TextBox();
            this.privateKeyTextbox = new System.Windows.Forms.TextBox();
            this.publicKeyLabel = new System.Windows.Forms.Label();
            this.privateKeyLabel = new System.Windows.Forms.Label();
            this.validateKeyButton = new System.Windows.Forms.Button();
            this.create_transaction_button = new System.Windows.Forms.Button();
            this.amountTextbox = new System.Windows.Forms.TextBox();
            this.feeTextbox = new System.Windows.Forms.TextBox();
            this.recieverKeyTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.generate_new_block_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputRichTextbox
            // 
            this.outputRichTextbox.BackColor = System.Drawing.SystemColors.InfoText;
            this.outputRichTextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputRichTextbox.Location = new System.Drawing.Point(12, 12);
            this.outputRichTextbox.Name = "outputRichTextbox";
            this.outputRichTextbox.Size = new System.Drawing.Size(657, 314);
            this.outputRichTextbox.TabIndex = 0;
            this.outputRichTextbox.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 338);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 1;
            // 
            // printBlockButton
            // 
            this.printBlockButton.Location = new System.Drawing.Point(12, 332);
            this.printBlockButton.Name = "printBlockButton";
            this.printBlockButton.Size = new System.Drawing.Size(114, 26);
            this.printBlockButton.TabIndex = 2;
            this.printBlockButton.Text = "Print Block";
            this.printBlockButton.UseVisualStyleBackColor = true;
            this.printBlockButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // generateKeyButton
            // 
            this.generateKeyButton.Location = new System.Drawing.Point(596, 349);
            this.generateKeyButton.Name = "generateKeyButton";
            this.generateKeyButton.Size = new System.Drawing.Size(75, 47);
            this.generateKeyButton.TabIndex = 3;
            this.generateKeyButton.Text = "Generate Keys";
            this.generateKeyButton.UseVisualStyleBackColor = true;
            this.generateKeyButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // publicKeyTextbox
            // 
            this.publicKeyTextbox.Location = new System.Drawing.Point(443, 349);
            this.publicKeyTextbox.Name = "publicKeyTextbox";
            this.publicKeyTextbox.Size = new System.Drawing.Size(145, 20);
            this.publicKeyTextbox.TabIndex = 4;
            // 
            // privateKeyTextbox
            // 
            this.privateKeyTextbox.Location = new System.Drawing.Point(443, 376);
            this.privateKeyTextbox.Name = "privateKeyTextbox";
            this.privateKeyTextbox.Size = new System.Drawing.Size(145, 20);
            this.privateKeyTextbox.TabIndex = 5;
            // 
            // publicKeyLabel
            // 
            this.publicKeyLabel.AutoSize = true;
            this.publicKeyLabel.Location = new System.Drawing.Point(380, 353);
            this.publicKeyLabel.Name = "publicKeyLabel";
            this.publicKeyLabel.Size = new System.Drawing.Size(57, 13);
            this.publicKeyLabel.TabIndex = 6;
            this.publicKeyLabel.Text = "Public Key";
            this.publicKeyLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // privateKeyLabel
            // 
            this.privateKeyLabel.AutoSize = true;
            this.privateKeyLabel.Location = new System.Drawing.Point(380, 378);
            this.privateKeyLabel.Name = "privateKeyLabel";
            this.privateKeyLabel.Size = new System.Drawing.Size(61, 13);
            this.privateKeyLabel.TabIndex = 7;
            this.privateKeyLabel.Text = "Private Key";
            // 
            // validateKeyButton
            // 
            this.validateKeyButton.Location = new System.Drawing.Point(596, 403);
            this.validateKeyButton.Name = "validateKeyButton";
            this.validateKeyButton.Size = new System.Drawing.Size(75, 23);
            this.validateKeyButton.TabIndex = 8;
            this.validateKeyButton.Text = "Validate Key";
            this.validateKeyButton.UseVisualStyleBackColor = true;
            this.validateKeyButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // create_transaction_button
            // 
            this.create_transaction_button.Location = new System.Drawing.Point(12, 423);
            this.create_transaction_button.Name = "create_transaction_button";
            this.create_transaction_button.Size = new System.Drawing.Size(95, 45);
            this.create_transaction_button.TabIndex = 9;
            this.create_transaction_button.Text = "Create Transaction";
            this.create_transaction_button.UseVisualStyleBackColor = true;
            this.create_transaction_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // amountTextbox
            // 
            this.amountTextbox.Location = new System.Drawing.Point(162, 405);
            this.amountTextbox.Name = "amountTextbox";
            this.amountTextbox.Size = new System.Drawing.Size(100, 20);
            this.amountTextbox.TabIndex = 10;
            // 
            // feeTextbox
            // 
            this.feeTextbox.Location = new System.Drawing.Point(162, 436);
            this.feeTextbox.Name = "feeTextbox";
            this.feeTextbox.Size = new System.Drawing.Size(100, 20);
            this.feeTextbox.TabIndex = 11;
            // 
            // recieverKeyTextbox
            // 
            this.recieverKeyTextbox.Location = new System.Drawing.Point(346, 437);
            this.recieverKeyTextbox.Name = "recieverKeyTextbox";
            this.recieverKeyTextbox.Size = new System.Drawing.Size(149, 20);
            this.recieverKeyTextbox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Amount";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Reciever Key";
            // 
            // generate_new_block_button
            // 
            this.generate_new_block_button.Location = new System.Drawing.Point(13, 365);
            this.generate_new_block_button.Name = "generate_new_block_button";
            this.generate_new_block_button.Size = new System.Drawing.Size(94, 52);
            this.generate_new_block_button.TabIndex = 16;
            this.generate_new_block_button.Text = "Generate New Block";
            this.generate_new_block_button.UseVisualStyleBackColor = true;
            this.generate_new_block_button.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(683, 469);
            this.Controls.Add(this.generate_new_block_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recieverKeyTextbox);
            this.Controls.Add(this.feeTextbox);
            this.Controls.Add(this.amountTextbox);
            this.Controls.Add(this.create_transaction_button);
            this.Controls.Add(this.validateKeyButton);
            this.Controls.Add(this.privateKeyLabel);
            this.Controls.Add(this.publicKeyLabel);
            this.Controls.Add(this.privateKeyTextbox);
            this.Controls.Add(this.publicKeyTextbox);
            this.Controls.Add(this.generateKeyButton);
            this.Controls.Add(this.printBlockButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.outputRichTextbox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox outputRichTextbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button printBlockButton;
        private System.Windows.Forms.Button generateKeyButton;
        private System.Windows.Forms.TextBox publicKeyTextbox;
        private System.Windows.Forms.TextBox privateKeyTextbox;
        private System.Windows.Forms.Label publicKeyLabel;
        private System.Windows.Forms.Label privateKeyLabel;
        private System.Windows.Forms.Button validateKeyButton;
        private System.Windows.Forms.Button create_transaction_button;
        private System.Windows.Forms.TextBox amountTextbox;
        private System.Windows.Forms.TextBox feeTextbox;
        private System.Windows.Forms.TextBox recieverKeyTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button generate_new_block_button;
    }
}

