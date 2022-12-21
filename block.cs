using System;
using System.Security.Cryptography;  

namespace Blockchain{
  class Block{
    int id;
    DateTime timestamp;
    string data;
    string hash;
    string prev;

    public Block(int id, Datetime timestamp, string data){
      this.id = id;
      this.timestamp = timestamp;
      this.data = data;
    }

    computeHash(){
      string text = this.id + this.timestamp + this.data + this.prev;
      byte[] bytes = Encoding.UTF8.GetBytes(text);
      string hash = sha256Hash.ComputeHash(bytes);
      return hash
    }
  }

  class BlockChain{
    Block[] chain;

    public BlockChain(){

    }
  }


  class App{
    static void Main(string[] args){
      Console.WriteLine("Hello World!");    
    }
  }
}