using System;
using Starcounter;

namespace Sample {
    public class Program {
        public static void Main(string[] args) {
            Db.Transact(() => {
				Console.WriteLine("Sample transaction!");
			});
        }
    }
}
