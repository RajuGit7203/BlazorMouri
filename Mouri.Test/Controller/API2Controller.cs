using Moq;
using Mouri.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mouri.Test.Controller
{
    public class API2Controller
    {
        [Fact]
        public async Task Dog_Speak_ShouldReturnSilence_WhenCalledOnAnimalReference()
        {

            // Arrange
            Animal d = new Dog();

            // Act
            var result = d.speak(0);

            // Assert
            Assert.Equal("silence", result);
        }

        
    [Fact]
    public async Task Failed_Dog_Speak_ReturnBowbow_WhenCalledOnAnimalReference()
    {

        // Arrange
        Animal d = new Dog();

        // Act
        var result = d.speak(0);

        // Assert
        Assert.NotEqual("bow bow", result);
    }

}    
}
