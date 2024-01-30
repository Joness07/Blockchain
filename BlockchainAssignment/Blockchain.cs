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

        public List<Transaction> transactionPool = new List<Transaction>();
        int transactionPerBlock = 5;

        public Blockchain()
        {
            Blocks.Add(new Block());
            transactionPool = new List<Transaction>();
        }

        public String GetBlockAsString(int index)
        {
            return Blocks[index].ToString();
        }
    }
}
