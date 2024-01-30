using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Block
    {
        int index;
        DateTime timeStamp;
        String hash;
        String prevHash;

        List<Transaction> transactionList = new List<Transaction>();

        //proof of work
        public long nonce = 0;
        public int difficulty = 4;

        //rewards and fees
        public double reward = 1.0;
        public double fees = 0.0;

        public String minerAdress = String.Empty;

        public Block(int index, String prevHash)
        {
            this.timeStamp = DateTime.Now;
            this.index = index + 1;
            this.prevHash = hash;
        }

        /*Genesis Block*/
        public Block()
        {
            this.timeStamp = DateTime.Now;
            this.index = 0;
            this.prevHash = String.Empty;
            reward = 0;
            this.hash = Mine();
        }

        public Block(Block lastBlock, List<Transaction> transactions)
        {
            this.timeStamp = DateTime.Now;
            this.index = lastBlock.index + 1;
            this.prevHash = lastBlock.hash;
            this.hash = Mine();

            transactionList = transactions;
        }

        public Transaction CreateRewardTransaction(List<Transaction> transactions)
        {
            fees = transactions.Aggregate(0.0, (acc, t)=>acc + t.fee);
            return new Transaction("Mine Rewards", minerAdress, (reward + fees), 0, "");
        }

        public String CreateHash()
        {
            String hash = String.Empty;
            SHA256 hasher = SHA256Managed.Create();
            String input = index.ToString() + timeStamp.ToString() + prevHash + nonce.ToString();

            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
            foreach (byte x in hashByte)
            {
                hash += String.Format("{0:x2}", x);
            }
            return hash;
        }
        public String Mine()
        {
            String hash = CreateHash();

            //hash must start with 0's equal to the difficulty.0
            String re = new string('0', difficulty);
            while (!hash.StartsWith(re)) //rehash if hashing requirement not met
            {
                nonce++; //increment nonce
                hash = CreateHash();
            }
            return hash;
        } 

        public override string ToString()
        {
            String output = String.Empty;
            transactionList.ForEach(t => output += (t.ToString() + "\n"));

            return "Index: " + index.ToString() +
                "\nTimestamp: " + timeStamp.ToString() +
                "\nPrevious Hash: " + prevHash +
                "\nHash: " + hash.ToString() +
                "\nNonce: " + nonce.ToString() +
                "\nDifficulty: " + difficulty.ToString() +
                "\nTransactions:\n" + output + "\n";
        }
    }
}
