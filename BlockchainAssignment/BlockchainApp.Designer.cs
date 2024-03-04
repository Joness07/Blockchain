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
            this.createTransactionButton = new System.Windows.Forms.Button();
            this.amountTextbox = new System.Windows.Forms.TextBox();
            this.feeTextbox = new System.Windows.Forms.TextBox();
            this.recieverKeyTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.generateNewBlockButton = new System.Windows.Forms.Button();
            this.validateChainButton = new System.Windows.Forms.Button();
            this.checkBalanceButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DynamicDifficulty = new System.Windows.Forms.CheckBox();
            this.MiningPrefrence = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputRichTextbox
            // 
            this.outputRichTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.outputRichTextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputRichTextbox.Location = new System.Drawing.Point(538, 12);
            this.outputRichTextbox.Name = "outputRichTextbox";
            this.outputRichTextbox.Size = new System.Drawing.Size(657, 685);
            this.outputRichTextbox.TabIndex = 0;
            this.outputRichTextbox.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 1;
            // 
            // printBlockButton
            // 
            this.printBlockButton.BackColor = System.Drawing.Color.White;
            this.printBlockButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBlockButton.ForeColor = System.Drawing.Color.Black;
            this.printBlockButton.Location = new System.Drawing.Point(295, 13);
            this.printBlockButton.Name = "printBlockButton";
            this.printBlockButton.Size = new System.Drawing.Size(132, 31);
            this.printBlockButton.TabIndex = 2;
            this.printBlockButton.Text = "Print Block";
            this.printBlockButton.UseVisualStyleBackColor = false;
            this.printBlockButton.Click += new System.EventHandler(this.printBlockButton_Click);
            // 
            // generateKeyButton
            // 
            this.generateKeyButton.BackColor = System.Drawing.Color.White;
            this.generateKeyButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateKeyButton.ForeColor = System.Drawing.Color.Black;
            this.generateKeyButton.Location = new System.Drawing.Point(349, 29);
            this.generateKeyButton.Name = "generateKeyButton";
            this.generateKeyButton.Size = new System.Drawing.Size(133, 69);
            this.generateKeyButton.TabIndex = 3;
            this.generateKeyButton.Text = "Generate Keys";
            this.generateKeyButton.UseVisualStyleBackColor = false;
            this.generateKeyButton.Click += new System.EventHandler(this.generateKeyButton_Click);
            // 
            // publicKeyTextbox
            // 
            this.publicKeyTextbox.Location = new System.Drawing.Point(145, 34);
            this.publicKeyTextbox.Name = "publicKeyTextbox";
            this.publicKeyTextbox.Size = new System.Drawing.Size(195, 20);
            this.publicKeyTextbox.TabIndex = 4;
            // 
            // privateKeyTextbox
            // 
            this.privateKeyTextbox.Location = new System.Drawing.Point(145, 73);
            this.privateKeyTextbox.Name = "privateKeyTextbox";
            this.privateKeyTextbox.Size = new System.Drawing.Size(195, 20);
            this.privateKeyTextbox.TabIndex = 5;
            // 
            // publicKeyLabel
            // 
            this.publicKeyLabel.AutoSize = true;
            this.publicKeyLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicKeyLabel.Location = new System.Drawing.Point(14, 29);
            this.publicKeyLabel.Name = "publicKeyLabel";
            this.publicKeyLabel.Size = new System.Drawing.Size(116, 24);
            this.publicKeyLabel.TabIndex = 6;
            this.publicKeyLabel.Text = "Public Key";
            // 
            // privateKeyLabel
            // 
            this.privateKeyLabel.AutoSize = true;
            this.privateKeyLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privateKeyLabel.Location = new System.Drawing.Point(14, 69);
            this.privateKeyLabel.Name = "privateKeyLabel";
            this.privateKeyLabel.Size = new System.Drawing.Size(125, 24);
            this.privateKeyLabel.TabIndex = 7;
            this.privateKeyLabel.Text = "Private Key";
            // 
            // validateKeyButton
            // 
            this.validateKeyButton.BackColor = System.Drawing.Color.White;
            this.validateKeyButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateKeyButton.ForeColor = System.Drawing.Color.Black;
            this.validateKeyButton.Location = new System.Drawing.Point(11, 10);
            this.validateKeyButton.Name = "validateKeyButton";
            this.validateKeyButton.Size = new System.Drawing.Size(134, 30);
            this.validateKeyButton.TabIndex = 8;
            this.validateKeyButton.Text = "Validate Key";
            this.validateKeyButton.UseVisualStyleBackColor = false;
            this.validateKeyButton.Click += new System.EventHandler(this.validateKeyButton_Click);
            // 
            // createTransactionButton
            // 
            this.createTransactionButton.BackColor = System.Drawing.Color.White;
            this.createTransactionButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTransactionButton.ForeColor = System.Drawing.Color.Black;
            this.createTransactionButton.Location = new System.Drawing.Point(18, 22);
            this.createTransactionButton.Name = "createTransactionButton";
            this.createTransactionButton.Size = new System.Drawing.Size(132, 69);
            this.createTransactionButton.TabIndex = 9;
            this.createTransactionButton.Text = "Create Transaction";
            this.createTransactionButton.UseVisualStyleBackColor = false;
            this.createTransactionButton.Click += new System.EventHandler(this.createTransactionButton_Click);
            // 
            // amountTextbox
            // 
            this.amountTextbox.Location = new System.Drawing.Point(261, 36);
            this.amountTextbox.Name = "amountTextbox";
            this.amountTextbox.Size = new System.Drawing.Size(68, 20);
            this.amountTextbox.TabIndex = 10;
            // 
            // feeTextbox
            // 
            this.feeTextbox.Location = new System.Drawing.Point(393, 36);
            this.feeTextbox.Name = "feeTextbox";
            this.feeTextbox.Size = new System.Drawing.Size(89, 20);
            this.feeTextbox.TabIndex = 11;
            // 
            // recieverKeyTextbox
            // 
            this.recieverKeyTextbox.Location = new System.Drawing.Point(314, 62);
            this.recieverKeyTextbox.Name = "recieverKeyTextbox";
            this.recieverKeyTextbox.Size = new System.Drawing.Size(168, 20);
            this.recieverKeyTextbox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Reciever Key";
            // 
            // generateNewBlockButton
            // 
            this.generateNewBlockButton.BackColor = System.Drawing.Color.White;
            this.generateNewBlockButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateNewBlockButton.ForeColor = System.Drawing.Color.Black;
            this.generateNewBlockButton.Location = new System.Drawing.Point(17, 24);
            this.generateNewBlockButton.Name = "generateNewBlockButton";
            this.generateNewBlockButton.Size = new System.Drawing.Size(133, 69);
            this.generateNewBlockButton.TabIndex = 16;
            this.generateNewBlockButton.Text = "Generate New Block";
            this.generateNewBlockButton.UseVisualStyleBackColor = false;
            this.generateNewBlockButton.Click += new System.EventHandler(this.generateNewBlockButton_Click);
            // 
            // validateChainButton
            // 
            this.validateChainButton.BackColor = System.Drawing.Color.White;
            this.validateChainButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateChainButton.ForeColor = System.Drawing.Color.Black;
            this.validateChainButton.Location = new System.Drawing.Point(12, 46);
            this.validateChainButton.Name = "validateChainButton";
            this.validateChainButton.Size = new System.Drawing.Size(151, 30);
            this.validateChainButton.TabIndex = 17;
            this.validateChainButton.Text = "Validate Chain";
            this.validateChainButton.UseVisualStyleBackColor = false;
            this.validateChainButton.Click += new System.EventHandler(this.validateChainButton_Click);
            // 
            // checkBalanceButton
            // 
            this.checkBalanceButton.BackColor = System.Drawing.Color.White;
            this.checkBalanceButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBalanceButton.ForeColor = System.Drawing.Color.Black;
            this.checkBalanceButton.Location = new System.Drawing.Point(11, 82);
            this.checkBalanceButton.Name = "checkBalanceButton";
            this.checkBalanceButton.Size = new System.Drawing.Size(153, 30);
            this.checkBalanceButton.TabIndex = 18;
            this.checkBalanceButton.Text = "Check Balance";
            this.checkBalanceButton.UseVisualStyleBackColor = false;
            this.checkBalanceButton.Click += new System.EventHandler(this.checkBalanceButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Consolas", 45.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(12, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(506, 71);
            this.Title.TabIndex = 19;
            this.Title.Text = "Blockchain App";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(20, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "GenerateKeys";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.generateKeyButton);
            this.panel1.Controls.Add(this.publicKeyTextbox);
            this.panel1.Controls.Add(this.privateKeyTextbox);
            this.panel1.Controls.Add(this.publicKeyLabel);
            this.panel1.Controls.Add(this.privateKeyLabel);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(24, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 119);
            this.panel1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(20, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "CreateTransaction";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.createTransactionButton);
            this.panel2.Controls.Add(this.amountTextbox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.feeTextbox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.recieverKeyTextbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(24, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 119);
            this.panel2.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(20, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Block";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.MiningPrefrence);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.printBlockButton);
            this.panel3.Controls.Add(this.generateNewBlockButton);
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(24, 421);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(494, 119);
            this.panel3.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(20, 551);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Other Controls";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.DynamicDifficulty);
            this.panel4.Controls.Add(this.checkBalanceButton);
            this.panel4.Controls.Add(this.validateKeyButton);
            this.panel4.Controls.Add(this.validateChainButton);
            this.panel4.ForeColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(24, 578);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(494, 119);
            this.panel4.TabIndex = 24;
            // 
            // DynamicDifficulty
            // 
            this.DynamicDifficulty.AutoSize = true;
            this.DynamicDifficulty.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DynamicDifficulty.Location = new System.Drawing.Point(191, 12);
            this.DynamicDifficulty.Name = "DynamicDifficulty";
            this.DynamicDifficulty.Size = new System.Drawing.Size(209, 28);
            this.DynamicDifficulty.TabIndex = 19;
            this.DynamicDifficulty.Text = "Dynamic Difficulty";
            this.DynamicDifficulty.UseVisualStyleBackColor = true;
            // 
            // MiningPrefrence
            // 
            this.MiningPrefrence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MiningPrefrence.FormattingEnabled = true;
            this.MiningPrefrence.Items.AddRange(new object[] {
            "Greedy",
            "Altruistic",
            "Random"});
            this.MiningPrefrence.Location = new System.Drawing.Point(156, 49);
            this.MiningPrefrence.Name = "MiningPrefrence";
            this.MiningPrefrence.Size = new System.Drawing.Size(121, 21);
            this.MiningPrefrence.TabIndex = 17;
            this.MiningPrefrence.SelectedIndexChanged += new System.EventHandler(this.MiningPrefrence_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(156, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Mining Preference";
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1207, 715);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.outputRichTextbox);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.Button createTransactionButton;
        private System.Windows.Forms.TextBox amountTextbox;
        private System.Windows.Forms.TextBox feeTextbox;
        private System.Windows.Forms.TextBox recieverKeyTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button generateNewBlockButton;
        private System.Windows.Forms.Button validateChainButton;
        private System.Windows.Forms.Button checkBalanceButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox DynamicDifficulty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox MiningPrefrence;
    }
}

