using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperClassLibrary
{
    public class Leaderboard
    {
        public List<PlayerStats> HighScores = new List<PlayerStats>();
        public string FilePath = System.IO.Directory.GetCurrentDirectory() + @"\scores.txt";
        public Leaderboard()
        {
            // Load Scores from File
            LoadFromFile();
        }



        /// <summary>
        /// Method to Generate Generic Scores if File Not Found
        /// </summary>
        private void GenerateGenericScores()
        {
            HighScores.Add(new PlayerStats("Generic", 1, 120));
            HighScores.Add(new PlayerStats("Generic", 1, 110));
            HighScores.Add(new PlayerStats("Generic", 1, 105));
            HighScores.Add(new PlayerStats("Generic", 1, 100));
            HighScores.Add(new PlayerStats("Generic", 1, 95));
            this.SaveToFile();
            this.LoadFromFile();
        }



        /// <summary>
        /// Method to Save Current Scores to File
        /// </summary>
        private void SaveToFile()
        {
            // Sort Scores using LINQ
            var sortedScores = from stat in HighScores
                               orderby stat descending
                               select stat;
            // Format Output
            List<String> output = new List<string>();
            foreach (var score in sortedScores)
            {
                output.Add(String.Format("{0}%{1}%{2}", score.Name, score.Difficulty, Math.Ceiling(score.TotalSeconds)));
            }

            // Save to File
            File.WriteAllLines(FilePath, output);
        }



        /// <summary>
        /// Method to Read Scores from File
        /// </summary>
        private void LoadFromFile()
        {
            // Reset List
            HighScores.Clear();

            // Try Loading
            try
            {
                // Read Scores from File
                string[] lines = File.ReadAllLines(FilePath);
                foreach (string line in lines)
                {
                    if (line != "")
                    {
                        string[] props = line.Split("%");
                        if (props.Length == 3)
                        {
                            string name = props[0].Trim();
                            int diff = Int32.Parse(props[1].Trim());
                            int totalSeconds = Int32.Parse(props[2].Trim());
                            PlayerStats p = new PlayerStats(name, diff, totalSeconds);
                            HighScores.Add(p);
                        }
                    }
                    
                }
            } catch (FileNotFoundException ex)
            {
                // Catch FileNotFound, Create Generic Scores
                GenerateGenericScores();
            } catch (Exception ex)
            {
                // Catch any other Exception, Create Generic Scores anyway
                GenerateGenericScores();
            }
        }



        /// <summary>
        /// Method to Add New High Score and Save/Reload
        /// </summary>
        /// <param name="stats"></param>
        public void AddNewPlayerStats(PlayerStats stats)
        {
            // Add new Score, Save, Reload File
            HighScores.Add(stats);
            this.SaveToFile();
            this.LoadFromFile();
        }
    }
}
