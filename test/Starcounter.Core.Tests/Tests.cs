 
 using System;
 using Starcounter;
 using Xunit;

 namespace Tests {
	 
     public class StarcounterCoreTests {
		 
         [Fact]
         public void TestTransact() {
             Db.Transact(() => { Console.WriteLine("Transacted"); });
         }
     }
 }