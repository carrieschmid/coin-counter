using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCounterClass.Models;
using System.Collections.Generic;
using System;

namespace CoinCounterClass.Tests
{
    [TestClass]
    public class CoinCounterTest
    {
        [TestMethod]
        public void ChangeToCoins_CreateInstanceOfCoinCounter_CoinCounter ()
        {
          CoinCounter newCoins = new CoinCounter(25);
          Assert.AreEqual(typeof(CoinCounter), newCoins.GetType());
        }
        
        [TestMethod]
        public void ChangeToCoins_TwentyFiveToQuarter_OneQuarter ()
        {
          CoinCounter newCoins = new CoinCounter(78);
          newCoins.ConvertToCoins();
          Assert.AreEqual(newCoins.OutputQuarters , 3);       
        }

        [TestMethod]
        public void ChangeToCoins_TenToDime_OneDime ()
        {
          CoinCounter newCoins = new CoinCounter(10);
          newCoins.ConvertToCoins();
          Assert.AreEqual(newCoins.OutputQuarters , 3);       
        }
    }
}
