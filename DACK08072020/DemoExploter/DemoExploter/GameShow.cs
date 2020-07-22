using DTOProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExploter
{
    public enum GAME_SHOW_STATE
    {

    }
    public class GameShow
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        Dictionary<int, Player> ListPlayers { get; set; }
        Dictionary<int, List<PlayerScore>> ListUserScores { get; set; }
        Dictionary<int, Question> ListQuestions { get; set; }

        void LoadListQuestions()
        {

        }

        public void CheckAnswer(int playerId, int questionId, string answer)
        {
            List<PlayerScore> lstPlayerScores = null;
            var playerScore = new PlayerScore()
            {
                PlayerId = playerId,
                QuestionId = questionId,
                Answer = answer,
                Result = (answer == ListQuestions[questionId].Answer)
            };

            if (ListUserScores.ContainsKey(playerId))
            {
                lstPlayerScores = ListUserScores[playerId];
                lstPlayerScores.Add(playerScore);
            } 
            else
            {
                ListUserScores.Add(playerId, new List<PlayerScore>() { playerScore });
            }

           

        }

    }
}
