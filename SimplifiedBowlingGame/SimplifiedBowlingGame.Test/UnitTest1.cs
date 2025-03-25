using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace SimplifiedBowlingGame.Test
{
    public class UnitTest1
    {
        [Fact]
        public void FirstRoll_HitNinePins()
        {
            Frame frame = new Frame();

            

            Assert.Equal(true, frame.roll(9));

            Assert.Equal(false, frame.isComplete());
        }
    }
}