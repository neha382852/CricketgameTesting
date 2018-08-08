using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Cricket
    {
        public int PlayerScore { get;  set; }

        private bool _playerOut;

        public Cricket()
        {
            PlayerScore = 0;
            _playerOut = false;
        }
        public void Score(int runs)
        {
            if (_playerOut == false && (runs >= 1 && runs <= 6))
            {
                this.PlayerScore += runs;
            }
        }
        public void Out()
        {
            _playerOut = true;
        }

      
    }
}
