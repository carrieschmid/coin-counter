using System.Collections.Generic;

namespace CoinCounterClass.Models
{
  public class CoinCounter
  {
    public int ChangeAmount { get; set; }
    public int OutputQuarters {get; set;}
    public int OutputDimes {get; set;}
    public int OutputNickels {get; set;}
    public int OutputPennies {get; set;}

    public CoinCounter(int changeamount)
    {
      ChangeAmount = changeamount;
      OutputQuarters = 0;
      OutputDimes = 0;
      OutputNickels = 0;
      OutputPennies = 0;
    }

  public void ConvertToCoins()
  {
    if(ChangeAmount <= 99)
    {
      if(ChangeAmount >= 25)
      {
      OutputQuarters = ChangeAmount / 25;
      int quartersRemainder = ChangeAmount % OutputQuarters;
      if(quartersRemainder >= 10)
      {
        OutputDimes = quartersRemainder / 10;
        int dimesRemainder = quartersRemainder % OutputDimes;
      }
      }
      else if(ChangeAmount < 25)
      {
        
      }
    }
    
  }
  }
}