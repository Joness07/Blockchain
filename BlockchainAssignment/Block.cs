using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace BlockchainAssignment
{
    class Block
    {
        private int numThreads = 4;

        private DateTime timeStamp;
        public int index;
        public int difficulty = 2;
        
        public String hash;
        public String prevHash;
        public String merkleRoot;
        public String minerAddress = String.Empty;

        public List<Transaction> transactionList = new List<Transaction>();

        //proof of work
        public long nonce;

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
            timeStamp = DateTime.Now;
            index = 0;
            transactionList = new List<Transaction>();
            hash = Mine(numThreads);
        }

        public Block(Block lastBlock, List<Transaction> transactions, String minerAddress)
        {
            timeStamp = DateTime.Now;
            index = lastBlock.index + 1;
            prevHash = lastBlock.hash;

            this.minerAddress = minerAddress;

            transactions.Add(CreateRewardTransaction(transactions));
            transactionList = transactions;

            merkleRoot = MerkleRoot(transactionList);

            hash = Mine(numThreads);
        }

        public Transaction CreateRewardTransaction(List<Transaction> transactions)
        {
            //sum fees in the list of transactions in the mined block
            fees = transactions.Aggregate(0.0, (acc, t)=>acc + t.fee);
            //return reward transaction between transfered as "mined rewards" to the miner
            return new Transaction("Mine Rewards", minerAddress, (reward + fees), 0, "");
        }

        public String CreateHash()
        {
            String hash = String.Empty;
            SHA256 hasher = SHA256Managed.Create();
            String input = index.ToString() + timeStamp.ToString() + prevHash + nonce.ToString() + reward.ToString() + merkleRoot;

            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
            foreach (byte x in hashByte)
            {
                hash += String.Format("{0:x2}", x);
            }
            return hash;
        }
        public String MineSingleThread()
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

        public String Mine(int numThreads)
        {

            Stopwatch totalStopwatch = new Stopwatch(); //create new stopwatch for total.
            totalStopwatch.Start(); //start stopwatch

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(); //crteate cancellation

            List<Task<string>> tasks = new List<Task<string>>();

            for (int i=0; i < numThreads; i++) //create tasks equal to numThreads
            {
                Task<string> task = Task.Run(() =>
                {
                    Stopwatch stopwatch = new Stopwatch(); //create and start individual stopwatch 
                    stopwatch.Start();
                    string hash = MineSingleThread(); //mine function
                    stopwatch.Stop(); //stop individual stopwatch
                    Console.Write($"\nThread {Task.CurrentId}: Hash completed in {stopwatch.ElapsedMilliseconds} milliseconds");
                    return hash;
                }, cancellationTokenSource.Token);

                tasks.Add(task); //adds task back to list.
            }

            // Wait for any task to complete
            Task<string> firstCompletedTask = Task.WhenAny(tasks).Result;  

            // Cancel remaining tasks
            cancellationTokenSource.Cancel();

            // Get the valid hash found by the first completed task
            string validHash = firstCompletedTask.Result;

            totalStopwatch.Stop();
            Console.WriteLine($"\nTotal time taken for mining with {numThreads} threads: {totalStopwatch.ElapsedMilliseconds} milliseconds");

            Console.WriteLine("\nValid Hash: " + validHash);
            return validHash;
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

            return "[BLOCK START]"
                + "\nIndex: " + index
                + "\tTimestamp: " + timeStamp
                + "\nPrevious Hash: " + prevHash
                + "\n-- PoW --"
                + "\nDifficulty Level: " + difficulty
                + "\nNonce: " + nonce
                + "\nHash: " + hash
                + "\n-- Rewards --"
                + "\nReward: " + reward
                + "\nMiners Address: " + minerAddress
                + "\n-- " + transactionList.Count + " Transactions --"
                + "\nMerkle Root: " + merkleRoot
                + "\n" + String.Join("\n", transactionList)
                + "\n[BLOCK END]";
        }
    }
}
