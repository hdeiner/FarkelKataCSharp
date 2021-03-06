﻿using System;
namespace Farkel
{
    public class Score
    {
        private String diceFaces;

        public Score(String diceFaces)
        {
            this.diceFaces = diceFaces;
        }

        public int calculate()
        {
            int accumulatedScore = 0;
            if (hasStraight() != 0)
            {
                accumulatedScore += hasStraight();
            }
            else if (hasThreePairs() != 0)
            {
                accumulatedScore += hasThreePairs();
            }
            else if (hasSixOfAKind())
            {
                accumulatedScore += hasSixOnes();
                accumulatedScore += hasSixTwos();
                accumulatedScore += hasSixThrees();
                accumulatedScore += hasSixFours();
                accumulatedScore += hasSixFives();
                accumulatedScore += hasSixSixs();
            }
            else if (hasFiveOfAKind())
            {
                accumulatedScore += hasFiveOnes();
                accumulatedScore += hasFiveTwos();
                accumulatedScore += hasFiveThrees();
                accumulatedScore += hasFiveFours();
                accumulatedScore += hasFiveFives();
                accumulatedScore += hasFiveSixs();
            }
            else if (hasFourOfAKind())
            {
                accumulatedScore += hasFourOnes();
                accumulatedScore += hasFourTwos();
                accumulatedScore += hasFourThrees();
                accumulatedScore += hasFourFours();
                accumulatedScore += hasFourFives();
                accumulatedScore += hasFourSixs();
            }
            else if (hasThreeOfAKind())
            {
                accumulatedScore += hasThreeOnes();
                accumulatedScore += hasThreeTwos();
                accumulatedScore += hasThreeThrees();
                accumulatedScore += hasThreeFours();
                accumulatedScore += hasThreeFives();
                accumulatedScore += hasThreeSixs();
                accumulatedScore += hasOneFive();
                accumulatedScore += hasTwoFives();
                accumulatedScore += hasOneOne();
                accumulatedScore += hasTwoOnes();
            }
            else
            {
                accumulatedScore += hasOneFive();
                accumulatedScore += hasTwoFives();
                accumulatedScore += hasOneOne();
                accumulatedScore += hasTwoOnes();
            }
            return accumulatedScore;
        }

        private bool hasSixOfAKind()
        {
            bool hasSixOfKind = false;
            if (hasSix("1") || hasSix("2") ||
                    hasSix("3") || hasSix("4") ||
                    hasSix("5") || hasSix("6"))
            {
                hasSixOfKind = true;
            }
            return hasSixOfKind;
        }

        private bool hasFiveOfAKind()
        {
            bool hasFiveOfKind = false;
            if (hasFive("1") || hasFive("2") ||
                    hasFive("3") || hasFive("4") ||
                    hasFive("5") || hasFive("6"))
            {
                hasFiveOfKind = true;
            }
            return hasFiveOfKind;
        }

        private bool hasFourOfAKind()
        {
            bool hasFourOfKind = false;
            if (hasFour("1") || hasFour("2") ||
                    hasFour("3") || hasFour("4") ||
                    hasFour("5") || hasFour("6"))
            {
                hasFourOfKind = true;
            }
            return hasFourOfKind;
        }

        private bool hasThreeOfAKind()
        {
            bool hasThreeOfKind = false;
            if (hasThree("1") || hasThree("2") ||
                    hasThree("3") || hasThree("4") ||
                    hasThree("5") || hasThree("6"))
            {
                hasThreeOfKind = true;
            }
            return hasThreeOfKind;
        }

        private int hasSixOnes()
        {
            int returnScore = 0;
            if (hasSix("1"))
            {
                returnScore = 8 * hasThreeOnes();
            }
            return returnScore;
        }

        private int hasSixTwos()
        {
            int returnScore = 0;
            if (hasSix("2"))
            {
                returnScore = 8 * hasThreeTwos();
            }
            return returnScore;
        }

        private int hasSixThrees()
        {
            int returnScore = 0;
            if (hasSix("3"))
            {
                returnScore = 8 * hasThreeThrees();
            }
            return returnScore;
        }

        private int hasSixFours()
        {
            int returnScore = 0;
            if (hasSix("4"))
            {
                returnScore = 8 * hasThreeFours();
            }
            return returnScore;
        }

        private int hasSixFives()
        {
            int returnScore = 0;
            if (hasSix("5"))
            {
                returnScore = 8 * hasThreeFives();
            }
            return returnScore;
        }

        private int hasSixSixs()
        {
            int returnScore = 0;
            if (hasSix("6"))
            {
                returnScore = 8 * hasThreeSixs();
            }
            return returnScore;
        }

        private int hasFiveOnes()
        {
            int returnScore = 0;
            if (hasFive("1"))
            {
                returnScore = 4 * hasThreeOnes();
            }
            return returnScore;
        }

        private int hasFiveTwos()
        {
            int returnScore = 0;
            if (hasFive("2"))
            {
                returnScore = 4 * hasThreeTwos();
            }
            return returnScore;
        }

        private int hasFiveThrees()
        {
            int returnScore = 0;
            if (hasFive("3"))
            {
                returnScore = 4 * hasThreeThrees();
            }
            return returnScore;
        }

        private int hasFiveFours()
        {
            int returnScore = 0;
            if (hasFive("4"))
            {
                returnScore = 4 * hasThreeFours();
            }
            return returnScore;
        }

        private int hasFiveFives()
        {
            int returnScore = 0;
            if (hasFive("5"))
            {
                returnScore = 4 * hasThreeFives();
            }
            return returnScore;
        }

        private int hasFiveSixs()
        {
            int returnScore = 0;
            if (hasFive("6"))
            {
                returnScore = 4 * hasThreeSixs();
            }
            return returnScore;
        }
        private int hasFourOnes()
        {
            int returnScore = 0;
            if (hasFour("1"))
            {
                returnScore = 2 * hasThreeOnes();
            }
            return returnScore;
        }

        private int hasFourTwos()
        {
            int returnScore = 0;
            if (hasFour("2"))
            {
                returnScore = 2 * hasThreeTwos();
            }
            return returnScore;
        }

        private int hasFourThrees()
        {
            int returnScore = 0;
            if (hasFour("3"))
            {
                returnScore = 2 * hasThreeThrees();
            }
            return returnScore;
        }

        private int hasFourFours()
        {
            int returnScore = 0;
            if (hasFour("4"))
            {
                returnScore = 2 * hasThreeFours();
            }
            return returnScore;
        }

        private int hasFourFives()
        {
            int returnScore = 0;
            if (hasFour("5"))
            {
                returnScore = 2 * hasThreeFives();
            }
            return returnScore;
        }

        private int hasFourSixs()
        {
            int returnScore = 0;
            if (hasFour("6"))
            {
                returnScore = 2 * hasThreeSixs();
            }
            return returnScore;
        }

        private int hasThreeOnes()
        {
            int returnScore = 0;
            if (hasAtLeastThree("1"))
            {
                returnScore = 1000;
            }
            return returnScore;
        }

        private int hasThreeTwos()
        {
            int returnScore = 0;
            if (hasAtLeastThree("2"))
            {
                returnScore = 200;
            }
            return returnScore;
        }

        private int hasThreeThrees()
        {
            int returnScore = 0;
            if (hasAtLeastThree("3"))
            {
                returnScore = 300;
            }
            return returnScore;
        }

        private int hasThreeFours()
        {
            int returnScore = 0;
            if (hasAtLeastThree("4"))
            {
                returnScore = 400;
            }
            return returnScore;
        }

        private int hasThreeFives()
        {
            int returnScore = 0;
            if (hasAtLeastThree("5"))
            {
                returnScore = 500;
            }
            return returnScore;
        }

        private int hasThreeSixs()
        {
            int returnScore = 0;
            if (hasAtLeastThree("6"))
            {
                returnScore = 600;
            }
            return returnScore;
        }

        private int hasTwoFives()
        {
            int returnScore = 0;
            if (hasTwo("5"))
            {
                returnScore = 100;
            }
            return returnScore;
        }

        private int hasOneFive()
        {
            int returnScore = 0;
            if (hasOne("5"))
            {
                returnScore = 50;
            }
            return returnScore;
        }

        private int hasTwoOnes()
        {
            int returnScore = 0;
            if (hasTwo("1"))
            {
                returnScore = 200;
            }
            return returnScore;
        }

        private int hasOneOne()
        {
            int returnScore = 0;
            if (hasOne("1"))
            {
                returnScore = 100;
            }
            return returnScore;
        }

        private int hasThreePairs()
        {
            int returnScore = 0;
            if (hasAtLeastTwo("2") && hasAtLeastTwo("3") &&
                    hasAtLeastTwo("4"))
            {
                returnScore = 800;
            }
            return returnScore;
        }

        private bool hasAtLeastTwo(String face)
        {
            bool returnValue = false;
            if (getCount(face) >= 2) returnValue = true;
            return returnValue;
        }

        private bool hasAtLeastThree(String face)
        {
            bool returnValue = false;
            if (getCount(face) >= 3) returnValue = true;
            return returnValue;
        }

        private bool hasSix(String face)
        {
            bool returnValue = false;
            if (getCount(face) == 6) returnValue = true;
            return returnValue;
        }

        private bool hasFive(String face)
        {
            bool returnValue = false;
            if (getCount(face) == 5) returnValue = true;
            return returnValue;
        }

        private bool hasFour(String face)
        {
            bool returnValue = false;
            if (getCount(face) == 4) returnValue = true;
            return returnValue;
        }

        private bool hasThree(String face)
        {
            bool returnValue = false;
            if (getCount(face) == 3) returnValue = true;
            return returnValue;
        }

        private bool hasTwo(String face)
        {
            bool returnValue = false;
            if (getCount(face) == 2) returnValue = true;
            return returnValue;
        }

        private bool hasOne(String face)
        {
            bool returnValue = false;
            if (getCount(face) == 1) returnValue = true;
            return returnValue;
        }

        private int getCount(String face)
        {
            int count = 0;
            for (int i = 0; i < diceFaces.Length; i++)
            {
                if(int.Parse(diceFaces[i].ToString()) == int.Parse(face))
                {
                    count++;
                }
            }
            return count;
        }

        private int hasStraight()
        {
            int returnScore = 0;
            if (diceFaces.Contains("1") && diceFaces.Contains("2") &&
                    diceFaces.Contains("3") && diceFaces.Contains("4") &&
                    diceFaces.Contains("5") && diceFaces.Contains("6")
                    ) returnScore = 1200;
            return returnScore;
        }
    }
}
