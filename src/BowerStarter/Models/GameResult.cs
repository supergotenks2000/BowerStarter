using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowerStarter.Models
{
    public class GameResult
    {
        public string Opponent { get; set; }
        public string Result { get; set; }
        public bool IsOnTwitter { get; set; }
        public string TwitterName { get; set; }
    }
}
