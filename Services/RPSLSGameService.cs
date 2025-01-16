using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Extensions.ObjectPool;

namespace RPSLS_Endpoint.Services
{
    public class RPSLSGameService
    {
        public string CPUResponse()
        {
            string[] arrMoves = { "rock", "paper", "scissors", "lizard", "spock" };
            Random rng = new Random();
            int randomInt = rng.Next(0, 5);
            return arrMoves[randomInt];
           
        }
    }
}