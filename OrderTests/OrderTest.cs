using WaitersApp;
using Xunit;

namespace ReceiptTest
{
    public class OrderTest
    {
        [Fact]
        public void Check_If_Order_Is_Added_To_LisT()
        {
            // ARRANGE
            var table =new Table(2,4,true);
            var receipt = new Receipt(table);
            var receiptRepo = new ReceiptRepo();
            // ACT
            receiptRepo.AddToReceiptList(receipt);
            // ASSERT
            Assert.Contains(receipt,receiptRepo.ReceiptList);

        }
    }
}