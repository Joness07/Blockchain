using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockchainAssignment
{
    public partial class BlockchainApp : Form
    {
        Blockchain blockChain;

        public BlockchainApp()
        {
            InitializeComponent();
            blockChain = new Blockchain();
            outputRichTextbox.Text = "New Blockchain Initialised!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0;
            if(Int32.TryParse(textBox1.Text, out index))
            {
                outputRichTextbox.Text = blockChain.GetBlockAsString(index);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String privKey;
            Wallet.Wallet myNewWallet = new Wallet.Wallet(out privKey);
            publicKeyTextbox.Text = myNewWallet.publicID;
            privateKeyTextbox.Text = privKey;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Wallet.Wallet.ValidatePrivateKey(privateKeyTextbox.Text, publicKeyTextbox.Text))
            {
                outputRichTextbox.Text = "Keys are valid";
            }
            else
            {
                outputRichTextbox.Text = "Keys are invald";
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Transaction newTransaction = new Transaction(publicKeyTextbox.Text, privateKeyTextbox.Text, Double.Parse(amountTextbox.Text), Double.Parse(feeTextbox.Text), privateKeyTextbox.Text);
            blockChain.transactionPool.Add(transaction);
            outputRichTextbox.Text = newTransaction.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
