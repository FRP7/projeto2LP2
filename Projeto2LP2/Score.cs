using System;

namespace Projeto2LP2
{
    struct Score
    {
        public string Date { get; }

        public int ScoreValue { get; }

        public Score(string date, int scoreValue) {
            Date = date;
            ScoreValue = scoreValue;
        }
    }
}
