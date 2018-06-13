using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    class Game
    {
        public int score()
        {
            return scoreForFrame(currentFrame);
        }

        public void add(int pins)
        {
            scorer.addThrow(pins);
            adjustCurrentFrame(pins);
        }

        private void adjustCurrentFrame(int pins)
        {
            if (lastBallInFrame(pins))
            {
                advanceFrame();
            } else
            {
                firstThrowInFrame = false;
            }
        }

        private bool lastBallInFrame(int pins)
        {
            return strike(pins) || !firstThrowInFrame;
        }

        private bool strike(int pins)
        {
            return (firstThrowInFrame && pins == 10);
        }

        private void advanceFrame()
        {
            currentFrame = Math.Min(10, currentFrame + 1);
        }

        public int scoreForFrame(int frame)
        {
            return scorer.scoreForFrame(frame);
        }

        public void round(int pins1, int pins2)
        {
            add(pins1);
            add(pins2);
            Console.WriteLine("First throw: " + pins1);
            Console.WriteLine("Second throw: " + pins2);
            Console.WriteLine("Score after round: " + score());
        }

        public void round(int pins1)
        {
            add(pins1);
            Console.WriteLine("First throw: " + pins1);
            Console.WriteLine("Score after round: " + score());
        }

        private int currentFrame = 0;
        private bool firstThrowInFrame = true;
        private Scorer scorer = new Scorer();
    }
}
