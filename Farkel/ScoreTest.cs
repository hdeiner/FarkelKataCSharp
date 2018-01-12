using System;
using Xunit;

namespace Farkel
{
    public class ScoreTest
    {
        [Fact]
        public void canRecognizeStraight()
        {
            Score score = new Score("246135");
            Assert.Equal(score.calculate(), 1200);
        }

        [Fact]
        public void canRecognizeThreePairs()
        {
            Score score = new Score("432234");
            Assert.Equal(score.calculate(), 800);
        }

        [Fact]
        public void canRecognizeSixOnes()
        {
            Score score = new Score("111111");
            Assert.Equal(score.calculate(), 8000);
        }

        [Fact]
        public void canRecognizeThreeOnes()
        {
            Score score = new Score("213411");
            Assert.Equal(score.calculate(), 1000);
        }

        [Fact]
        public void canRecognizeSixTwos()
        {
            Score score = new Score("222222");
            Assert.Equal(score.calculate(), 1600);
        }

        [Fact]
        public void canRecognizeThreeTwos()
        {
            Score score = new Score("423224");
            Assert.Equal(score.calculate(), 200);
        }

        [Fact]
        public void canRecognizeSixThrees()
        {
            Score score = new Score("333333");
            Assert.Equal(score.calculate(), 2400);
        }

        [Fact]
        public void canRecognizeThreeThrees()
        {
            Score score = new Score("323234");
            Assert.Equal(score.calculate(), 300);
        }

        [Fact]
        public void canRecognizeSixFours()
        {
            Score score = new Score("444444");
            Assert.Equal(score.calculate(), 3200);
        }

        [Fact]
        public void canRecognizeThreeFours()
        {
            Score score = new Score("323444");
            Assert.Equal(score.calculate(), 400);
        }

        [Fact]
        public void canRecognizeSixFives()
        {
            Score score = new Score("555555");
            Assert.Equal(score.calculate(), 4000);
        }

        [Fact]
        public void canRecognizeThreeFives()
        {
            Score score = new Score("325655");
            Assert.Equal(score.calculate(), 500);
        }

        [Fact]
        public void canRecognizeSixSixs()
        {
            Score score = new Score("666666");
            Assert.Equal(score.calculate(), 4800);
        }

        [Fact]
        public void canRecognizeFiveOnes()
        {
            Score score = new Score("111112");
            Assert.Equal(score.calculate(), 4000);
        }

        [Fact]
        public void canRecognizeFiveTwos()
        {
            Score score = new Score("232222");
            Assert.Equal(score.calculate(), 800);
        }

        [Fact]
        public void canRecognizeFiveThrees()
        {
            Score score = new Score("633333");
            Assert.Equal(score.calculate(), 1200);
        }

        [Fact]
        public void canRecognizeFiveFours()
        {
            Score score = new Score("544444");
            Assert.Equal(score.calculate(), 1600);
        }

        [Fact]
        public void canRecognizeFiveFives()
        {
            Score score = new Score("555255");
            Assert.Equal(score.calculate(), 2000);
        }

        [Fact]
        public void canRecognizeFiveSixs()
        {
            Score score = new Score("166666");
            Assert.Equal(score.calculate(), 2400);
        }


        [Fact]
        public void canRecognizeFourOnes()
        {
            Score score = new Score("113112");
            Assert.Equal(score.calculate(), 2000);
        }

        [Fact]
        public void canRecognizeFourTwos()
        {
            Score score = new Score("232224");
            Assert.Equal(score.calculate(), 400);
        }

        [Fact]
        public void canRecognizeFourThrees()
        {
            Score score = new Score("633343");
            Assert.Equal(score.calculate(), 600);
        }

        [Fact]
        public void canRecognizeFourFours()
        {
            Score score = new Score("514444");
            Assert.Equal(score.calculate(), 800);
        }

        [Fact]
        public void canRecognizeFourFives()
        {
            Score score = new Score("655255");
            Assert.Equal(score.calculate(), 1000);
        }

        [Fact]
        public void canRecognizeFourSixs()
        {
            Score score = new Score("166662");
            Assert.Equal(score.calculate(), 1200);
        }

        [Fact]
        public void canRecognizeThreeSixs()
        {
            Score score = new Score("666324");
            Assert.Equal(score.calculate(), 600);
        }

        [Fact]
        public void canRecognizeThreeOnesThreeTwos()
        {
            Score score = new Score("121212");
            Assert.Equal(score.calculate(), 1200);
        }

        [Fact]
        public void canRecognizeThreeOnesOneFive()
        {
            Score score = new Score("121315");
            Assert.Equal(score.calculate(), 1050);
        }

        [Fact]
        public void canRecognizeThreeOnesTwoFives()
        {
            Score score = new Score("121515");
            Assert.Equal(score.calculate(), 1100);
        }

        [Fact]
        public void canRecognizeThreeFivesTwoOnes()
        {
            Score score = new Score("555311");
            Assert.Equal(score.calculate(), 700);
        }

        [Fact]
        public void canRecognizeThreeFivesOneOne()
        {
            Score score = new Score("124555");
            Assert.Equal(score.calculate(), 600);
        }

        [Fact]
        public void canRecognizeTwoOnes()
        {
            Score score = new Score("321143");
            Assert.Equal(score.calculate(), 200);
        }

        [Fact]
        public void canRecognizeOneOne()
        {
            Score score = new Score("322143");
            Assert.Equal(score.calculate(), 100);
        }
        [Fact]
        public void canRecognizeTwoFives()
        {
            Score score = new Score("325543");
            Assert.Equal(score.calculate(), 100);
        }

        [Fact]
        public void canRecognizeOneFive()
        {
            Score score = new Score("322543");
            Assert.Equal(score.calculate(), 50);
        }
    }
}
