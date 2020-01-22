using System;
using FinAssist.DAL.MemoryBased;
using FinAssist.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FinAssist.MemoryBasedDAL.Tests
{
    [TestClass]
    public class AccountRepositoryTests
    {
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
        // ova funkcija će reinicijalizirati AccountRepository, odnosno, direktno postaviti njegovu singleton instancu na null korištenjem Reflectiona
        [TestInitialize]
        public void ReInitializeAccountRepository()
        {
            System.Reflection.FieldInfo fi = typeof(AccountRepository).GetField("_instance",
                                                                                System.Reflection.BindingFlags.Static |
                                                                                System.Reflection.BindingFlags.NonPublic);

            Assert.IsNotNull(fi);

            fi.SetValue(null, null);
        }

        [TestMethod]
        public void Test_ExpSinkAccountCreated()
        {
            AccountRepository accRep = AccountRepository.getInstance();

            Account acc = accRep.getAccountByName("Potrošnja");

            Assert.IsInstanceOfType(acc, typeof(ExpenditureSinkAccount));
        }

        [TestMethod]
        public void Test_AddAccount()
        {
            AccountRepository accRep = AccountRepository.getInstance();

            CashAccount cashAcc = new CashAccount(accRep.getNewID(), "Gotovina");

            accRep.addAccount(cashAcc);

            Assert.AreEqual(2, accRep.getAccountNum());

            Account acc = accRep.getAccountByName("Gotovina");

            Assert.IsInstanceOfType(acc, typeof(CashAccount));
        }

        [TestMethod]
        public void Test_CreatingTwoAccounts()
        {
            AccountRepository accRep = AccountRepository.getInstance();

            CashAccount cashAcc = new CashAccount(accRep.getNewID(), "Gotovina 2");
            CurrentAccount currentAcc = new CurrentAccount(accRep.getNewID(), "Tekući");

            int cntBefore = accRep.getAccountNum();

            accRep.addAccount(cashAcc);
            accRep.addAccount(currentAcc);

            Assert.AreEqual(3, accRep.getAccountNum());
        }
        [TestMethod]
        [ExpectedException(typeof(AccountAlreadyExists))]
        public void Test_AddingSameAccountReferenceTwice()
        {
            AccountRepository accRep = AccountRepository.getInstance();

            CashAccount cashAcc = new CashAccount(accRep.getNewID(), "Gotovina");

            accRep.addAccount(cashAcc);
            accRep.addAccount(cashAcc);
        }
        [TestMethod]
        [ExpectedException(typeof(AccountAlreadyExists))]
        public void Test_AddingAccountWithSameName()
        {
            AccountRepository accRep = AccountRepository.getInstance();

            CashAccount cashAcc = new CashAccount(accRep.getNewID(), "Gotovina");
            CurrentAccount currAcc = new CurrentAccount(accRep.getNewID(), "Gotovina");

            accRep.addAccount(cashAcc);
            accRep.addAccount(currAcc);
        }

        [TestMethod]
        public void Test_getAccountByName()
        {
            AccountRepository accRep = AccountRepository.getInstance();

            string accName = "Gotovina";

            CashAccount cashAcc = new CashAccount(accRep.getNewID(), accName);

            accRep.addAccount(cashAcc);

            Account acc = accRep.getAccountByName(accName);

            Assert.AreEqual(cashAcc, acc);
        }
        [TestMethod]
        public void Test_getAccountByNameWithManyAccounts()
        {
            AccountRepository accRep = AccountRepository.getInstance();

            string accName = "Gotovina";

            CashAccount cashAcc = new CashAccount(accRep.getNewID(), accName);

            accRep.addAccount(cashAcc);
            accRep.addAccount(new CurrentAccount(accRep.getNewID(), "Tekući"));
            accRep.addAccount(new CreditCardAccount(accRep.getNewID(), "MasterCard"));

            Account acc = accRep.getAccountByName(accName);

            Assert.AreEqual(cashAcc, acc);
        }
        [TestMethod]
        [ExpectedException(typeof(AccountDoesntExist))]
        public void Test_getAccountByName_AccDoesntExist()
        {
            AccountRepository accRep = AccountRepository.getInstance();

            Account acc2 = accRep.getAccountByName("Mene nema, valjda");
        }
    }
}
