using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Blockchain
    {
        public List<Block> Blocks = new List<Block>();

        public static int GlobalDifficulty = 5;

        int transactionsPerBlock = 5;

        public List<Transaction> transactionPool = new List<Transaction>();

        public Blockchain()
        {
            Blocks = new List<Block>() {
                new Block()
            };
        }

        public String getBlock(int index)
        {
            if (index >= 0 && index < Blocks.Count)
                return Blocks[index].ToString();
            else
                return "Block does not Exist";
        }

        public Block getLastBlock()
        {
            return Blocks[Blocks.Count - 1];
        }

        private void Shuffle<T>(List<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public List<Transaction> GetPendingTransactions(string miningPrefrence)
        {
            switch (miningPrefrence)
            {
                case "Greedy":
                    transactionPool.OrderByDescending(t => t.fee).ToList();
                    Console.WriteLine("Greedy Sorting Applied");
                    break;
                case "Altruistic":
                    transactionPool.OrderBy(t => t.timeStamp).ToList();
                    Console.WriteLine("Alruistic Sorting Applied");
                    break;
                case "Random":
                    Console.WriteLine("Random Sorting Applied");
                    Shuffle(transactionPool);
                    break;
                default:
                    break;
            }

            Console.WriteLine("Mining Preference " + miningPrefrence);

            int n = Math.Min(transactionsPerBlock, transactionPool.Count);
            List<Transaction> transactions = transactionPool.GetRange(0, n);
            transactionPool.RemoveRange(0, n);
            return transactions;
        }

        public override string ToString()
        {
            String output = String.Empty;
            Blocks.ForEach(b => output += (b.ToString() + "\n"));
            return output;
        }
        public bool ValidateMerkleRoot(Block b)
        {
            String reMerkle = Block.MerkleRoot(b.transactionList);
            return reMerkle.Equals(b.merkleRoot);
        }
        public double GetBalance(String address)
        {
            double balance = 0.0;
            foreach(Block b in Blocks)
            {
                foreach(Transaction t in b.transactionList)
                {
                    if (t.recipientAdress.Equals(address))
                    {
                        balance += t.amount;
                    }
                    if (t.senderAdress.Equals(address))
                    {
                        balance -= (t.amount + t.fee);
                    }
                }
            }

            return balance;
        }
    }
}
