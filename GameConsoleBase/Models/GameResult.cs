using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Models
{
    internal class GameResult
    {
        //מאפיינים של שם המשחק, הניקוד ותאריך המשחק
        public string GameName { get; set; }
            public int Score { get; set; }
            public DateTime PlayTime { get; set; }

        //פעולה בונה שמקבלת את שם המשחק והניקוד שהושג
        public GameResult(string gameName, int score)
            {
                GameName = gameName;
                Score = score;
                PlayTime = DateTime.Now;
            }
    }
 }

