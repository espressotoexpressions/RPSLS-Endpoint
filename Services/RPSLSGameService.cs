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
        public string PlayGame(string userMove)
        {
            string[] arrMoves = { "rock", "paper", "scissors", "lizzard", "spock" };
            Random rng = new Random();
            int randomInt = rng.Next(0, 5);
            string computerMove = arrMoves[randomInt];
            Console.WriteLine(computerMove);
            string whoWon= "Game not started";

            switch (userMove.ToLower())
            {
                case "rock":
                 switch (computerMove.ToLower())
                 {
                    case "rock": 
                    whoWon= "It's A Tie";
                    break;

                    case "paper":
                    whoWon = "Computer won!";
                    break;

                    case "scissors":
                    whoWon = "User won!";
                    break;

                    case "lizzard":
                    whoWon = "User won!";
                    break;

                    case "spock":
                    whoWon = "Computer Won!";
                    break;

                    default:
                    whoWon =" computer selected an invalid move.";
                    break;
                 }
                break;

                case "paper":
                 switch (computerMove.ToLower())
                 {
                    case "rock": 
                    whoWon= "User won!";
                    break;

                    case "paper":
                    whoWon = "It's a tie!";
                    break;

                    case "scissors":
                    whoWon = "Computer won!";
                    break;

                    case "lizzard":
                    whoWon = "User won!";
                    break;

                    case "spock":
                    whoWon = "User Won";
                    break;

                    default:
                    whoWon =" computer selected an invalid move.";
                    break;
                 }
                break;

                case "scissors":
                 switch (computerMove.ToLower())
                 {
                    case "rock": 
                    whoWon= "Computer won!";
                    break;

                    case "paper":
                    whoWon = "User won!";
                    break;

                    case "scissors":
                    whoWon = "It's a Tie!";
                    break;

                    case "lizzard":
                    whoWon = "User won!";
                    break;

                    case "spock":
                    whoWon = "Computer Won";
                    break;

                    default:
                    whoWon =" computer selected an invalid move.";
                    break;
                 }
                break;

                 case "lizzard":
                 switch (computerMove.ToLower())
                 {
                    case "rock": 
                    whoWon= "User won!";
                    break;

                    case "paper":
                    whoWon = "User won!";
                    break;

                    case "scissors":
                    whoWon = "Computer won!";
                    break;

                    case "lizzard":
                    whoWon = "It's a Tie!";
                    break;

                    case "spock":
                    whoWon = "User Won";
                    break;

                    default:
                    whoWon =" computer selected an invalid move.";
                    break;
                 }
                break;

                 case "spock":
                 switch (computerMove.ToLower())
                 {
                    case "rock": 
                    whoWon= "User won!";
                    break;

                    case "paper":
                    whoWon = "Computer won!";
                    break;

                    case "scissors":
                    whoWon = "User won!";
                    break;

                    case "lizzard":
                    whoWon = "Computer won!";
                    break;

                    case "spock":
                    whoWon = "It's a Tie!";
                    break;

                    default:
                    whoWon =" computer selected an invalid move.";
                    break;
                 }
                break;

                default: 
                whoWon= "User selected an Invalid Move!Please select between rock, paper, scissors, lizzard or spock";
                break;
            }

            whoWon += " COMPUTER MOVE is : " + computerMove ;
            return whoWon;
        }
    }
}