using System;

namespace Starcounter {

    public partial class Db {
        
        public static void Transact(Action a) {
            Console.WriteLine("Enter transaction");
            a();
            Console.WriteLine("Exit transaction");
        }
    }
}
