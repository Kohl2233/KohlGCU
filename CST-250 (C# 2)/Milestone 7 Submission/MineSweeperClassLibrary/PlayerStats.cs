using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperClassLibrary
{
    public class PlayerStats : IComparable<PlayerStats>
    {
        public int Difficulty {  get; set; }
        public string Name { get; set; }
        public double TotalSeconds { get; set; }
        public double Score { get; set; }



        // Parameterized Constructor
        public PlayerStats(string name, int difficulty, double totalSeconds) 
        { 
            this.Name = name;
            this.Difficulty = difficulty;
            this.TotalSeconds = totalSeconds;
            this.Score = CalculateScore();
        }



        /// <summary>
        /// Private Method to Calculate Player Score
        /// </summary>
        /// <returns></returns>
        private double CalculateScore()
        {
            // -- Max Scores for 5min (300s) --
            // Easy: (600 / 300) * (1 * 100) = 200
            // Moderate: (600 / 300) * (2 * 100) = 400
            // Hard: (600 / 300) * (3 * 100) = 600
            // Nightmare: (600 / 300) * (4 * 100) = 800 

            // Calc Score
            double score = (600 / this.TotalSeconds) * (this.Difficulty * 100);
            return score;
        }



        /// <summary>
        /// CompareTo Method for Compaing Stats to Other Stats
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(PlayerStats other)
        {
            if (this.Score == other.Score)
            {
                return 0;
            } else if (this.Score > other.Score)
            {
                return 1;
            } else
            {
                return -1;
            }
        }
    }
}
