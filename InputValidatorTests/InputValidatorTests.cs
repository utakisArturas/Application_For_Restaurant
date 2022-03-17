using WaitersApp;
using Xunit;

namespace InputValidatorTests
{
    public class InputValidatorTests
    {
        [Fact]
        public void Is_Input_A_Int()
        {
            //ARRANGE
            var userInputValidations = new UserInputValidation();
            int randomNumber = 1;
            //ACT
            var testinNumber = userInputValidations.UserInputForInts();
            //ASSERT
            Assert.Equal(randomNumber, testinNumber);
        }
    }
}