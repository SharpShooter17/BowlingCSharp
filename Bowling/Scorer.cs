using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    class Scorer
    {
        private int ball;
        private int[] throws = new int[21];
        private int currentThrow = 0;

        public void addThrow(int pins)
        {
            throws[currentThrow++] = pins;
        }

        internal int scoreForFrame(int frame)
        {
            ball = 0;
            int score = 0;
            for (int currentFrame = 0; currentFrame < frame; currentFrame++)
            {
                if (strike())
                {
                    score += 10 + nextTwoBallsForStrike();
                    ball++;
                }
                else if (spare())
                {
                    score += 10 + nextBallForSpare();
                    ball += 2;
                } else
                {
                    score += twoBallsInFrame();
                    ball += 2;
                }
            }
            return score;
        }

        private int twoBallsInFrame()
        {
            return throws[ball] + throws[ball + 1];
        }

        private int nextBallForSpare()
        {
            return throws[ball + 2];
        }

        private bool spare()
        {
            return (throws[ball] + throws[ball + 1]) == 10;
        }

        private int nextTwoBallsForStrike()
        {
            return throws[ball + 1] + throws[ball + 2];
        }

        private bool strike()
        {
            return throws[ball] == 10;
        }
    }
}
