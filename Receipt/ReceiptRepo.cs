
using System.Collections.Generic;

namespace WaitersApp
{
    public  class ReceiptRepo
    {
        public  List<Receipt> ReceiptList = new List<Receipt>();

        public  void AddToReceiptList(Receipt receipt)
        {
            ReceiptList.Add(receipt);
        }
    }
}
