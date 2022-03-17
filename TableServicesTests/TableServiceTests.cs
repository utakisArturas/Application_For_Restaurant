using WaitersApp;
using Xunit;

namespace TableServicesTests
{
    public class TableServiceTests
    {
        [Fact]
        public void Make_Table_Busy()
        {
           // ARRANGE
           var tableServices = new TableServices();
            var tableRepository = new TableRepository();
            var table = new Table(14, 5, true);
            tableRepository.TablesList.Add(table);
            // ACT
            tableServices.SetTableTaken(table);
            // ASSERT
            Assert.False(table.IsFree);
        }
        [Fact]
        public void Make_Table_Free()
        {
            // ARRANGE
            var tableServices = new TableServices();
            var tableRepository = new TableRepository();
            var table = new Table(14, 5, true);
            tableRepository.TablesList.Add(table);
            // ACT
            tableServices.SetTableFree(table);
            // ASSERT
            Assert.True(table.IsFree);
        }
    }
}