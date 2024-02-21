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
        private DateTime timeStamp;
        public int index;
        public int difficulty = 4;
        
        public String hash;
        public String prevHash;
        public String merkleRoot;
        public String minerAdress = String.Empty;

        public List<Transaction> transactionList = new List<Transaction>();

        //proof of work
        public long nonce = 0;
         
        //rewards and fees
        public double reward = 1.0;
        public double fees = 0.0;


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

        public Block(Block lastBlock, List<Transaction> transactions, String address = "")
        {
            this.timeStamp = DateTime.Now;
            this.index = lastBlock.index + 1;
            this.prevHash = lastBlock.hash;

            minerAdress = address;

            transactions.Add(CreateRewardTransaction(transactions));
            transactionList = transactions;
            
            this.hash = Mine();
        }

        public Transaction CreateRewardTransaction(List<Transaction> transactions)
        {
            //sum fees in the list of transactions in the mined block
            fees = transactions.Aggregate(0.0, (acc, t)=>acc + t.fee);
            //return reward transaction between transfered as "mined rewards" to the miner
            return new Transaction("Mine Rewards", minerAdress, (reward + fees), 0, "");
        }

        public String CreateHash()
        {
            String hash = String.Empty;
            SHA256 hasher = SHA256Managed.Create();
            String input = index.ToString() + timeStamp.ToString() + prevHash + nonce.ToString() + reward.ToString();

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

        public static String MerkleRoot(List<Transaction> transactionList)
        {
            List<String> hashes = transactionList.Select(t => t.hash).ToList(); // Get a list of transaction hashes for "combining"

            // Handle Blocks with...
            if (hashes.Count == 0) // No transactions
            {
                return String.Empty;
            }
            if (hashes.Count == 1) // One transaction - hash with "self"
            {
                return HashCode.HashTools.CombineHash(hashes[0], hashes[0]);
            }
            while (hashes.Count != 1) // Multiple transactions - Repeat until tree has been traversed
            {
                List<String> merkleLeaves = new List<String>(); // Keep track of current "level" of the tree

                for (int i = 0; i < hashes.Count; i += 2) // Step over neighbouring pair combining each
                {
                    if (i == hashes.Count - 1)
                    {
                        merkleLeaves.Add(HashCode.HashTools.CombineHash(hashes[i], hashes[i])); // Handle an odd number of leaves
                    }
                    else
                    {
                        merkleLeaves.Add(HashCode.HashTools.CombineHash(hashes[i], hashes[i + 1])); // Hash neighbours leaves
                    }
                }
                hashes = merkleLeaves; // Update the working "layer"
            }
            return hashes[0]; // Return the root node
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
                "\nReward: " + reward.ToString() +
                "\nFees: " + fees.ToString() +
                "\nMiner's Address: " + minerAdress.ToString() +
                "\nTransactions:\n" + output + "\n";
        }
    }
}
