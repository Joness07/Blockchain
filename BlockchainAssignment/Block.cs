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
            this.hash = CreateHash();
        }

        public Block(Block lastBlock)
        {
            this.timeStamp = DateTime.Now;
            this.index = lastBlock.index + 1;
            this.prevHash = lastBlock.hash;
            this.hash = CreateHash();
        }

        public String CreateHash()
        {
            String hash = String.Empty;
            SHA256 hasher = SHA256Managed.Create();
            String input = index.ToString() + timeStamp.ToString() + prevHash;

            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
            foreach (byte x in hashByte)
            {
                hash += String.Format("{0:x2}", x);
            }
            return hash;
        }

        public override string ToString()
        {
            return "Index: " + index.ToString() +
                "\nTimestamp: " + timeStamp.ToString() +
                "\nPrevious Hash: " + prevHash +
                "\nHash: " + hash;
        }
    }
}
