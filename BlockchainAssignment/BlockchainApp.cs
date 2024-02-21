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
                outputRichTextbox.Text = blockChain.getBlock(index);
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
            blockChain.transactionPool.Add(newTransaction);
            outputRichTextbox.Text = newTransaction.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            List<Transaction> transactions = blockChain.GetPendingTransactions();
            Block newBlock = new Block(blockChain.getLastBlock(), transactions, publicKeyTextbox.Text);
            blockChain.Blocks.Add(newBlock);

            outputRichTextbox.Text = blockChain.ToString();
        }

        private void validateChain_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if(blockChain.Blocks.Count == 1)
            {
                valid = true;
                return;
            }
            for(int i=1; i<blockChain.Blocks.Count -1; i++)
            {
                if(blockChain.Blocks[i].prevHash != blockChain.Blocks[i - 1].hash)
                {
                    valid = false;
                    return;
                }
            }
            if (valid)
            {
                outputRichTextbox.Text = "Blockchain is valid";
            }
            else
            {
                outputRichTextbox.Text = "Blockchain is invalid";
            }
        }

        private void checkBalance_Click(object sender, EventArgs e)
        {
            outputRichTextbox.Text = blockChain.GetBalance(publicKeyTextbox.Text).ToString() + " Assignment Coin";
        }
    }
}
