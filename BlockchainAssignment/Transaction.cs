using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Transaction
    {
        public DateTime timeStamp;
        public String senderAdress;
        public String recipientAdress; 
        public String hash;
            
        String signature;
        public Double amount;
        public Double fee;

        public Transaction(String senderAdress, String recipientAdress, Double amount, Double fee, String privateKey)
        {
            this.timeStamp = DateTime.Now;
            this.senderAdress = senderAdress;
            this.recipientAdress = recipientAdress;
            this.amount = amount;
            this.fee = fee;
            this.hash = CreateHash();
            this.signature = Wallet.Wallet.CreateSignature(senderAdress, privateKey, hash);
        }

        public String CreateHash()
        {
            String hash = String.Empty;
            SHA256 hasher = SHA256Managed.Create();
            String input = timeStamp.ToString() + senderAdress + recipientAdress + amount.ToString() + fee.ToString();

            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
            foreach (byte x in hashByte)
            {
                hash += String.Format("{0:x2}", x);
            }
            return hash;
        }

        public override string ToString()
        {
            return "Timestamp: " + timeStamp.ToString() +
            "\nSender Address: " + senderAdress +
            "\nRecipient Address: " + recipientAdress +
            "\nAmount: " + amount.ToString() + " Assignment coin" +
            "\nFee: " +fee.ToString() + " Assignment coin" +
            "\nHash: " + hash +
            "\nSignature: " + signature;
        }
    }
}
