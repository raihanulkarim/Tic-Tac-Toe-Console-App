using System;

namespace TicTacToe
{
    public static class MainClass
    {   
        static string [] btn = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
        static string rounds;
        static bool playAgain = true;
        static int clicked = 0;
        static string player = "Player1";
        static int player1Score = 0;
        static int player2Score = 0;
        
        public static void looping(){
            Console.WriteLine("Play Again? Y/N:");
            rounds =Console.ReadLine();
            if(rounds == "Y" || rounds =="y"){
            for(int i = 0; i < btn.Length; i++){
                btn[i] = Convert.ToString(i+1);
            }
            player = "Player1";
            playAgain = true;
            Console.Clear();
            board();
            }
            else if(rounds == "N" || rounds == "n")
            { 
                playAgain = false;
            }else{
                Console.WriteLine("Invalid");
                looping();
            }   
        }
        public static void board(){
            Console.WriteLine("-------------");
            Console.WriteLine("| {0} | {1} | {2} |", btn[0],btn[1], btn[2]);
            Console.WriteLine("-------------");
            Console.WriteLine("| {0} | {1} | {2} |", btn[3],btn[4], btn[5]);
            Console.WriteLine("-------------");
            Console.WriteLine("| {0} | {1} | {2} |", btn[6],btn[7], btn[8]);
            Console.WriteLine("-------------");
        }
        public static void hrzntalWin(){
            if(btn[0] == "X" && btn[1] == "X" && btn[2] == "X"){
                Console.WriteLine("Winner is Player1!");
                Console.WriteLine("Score: Player1: {0} Player2: {1}", ++player1Score, player2Score);
                clicked = 0;
                 looping();
            }
             else if(btn[3] == "X" && btn[4] == "X" && btn[5] == "X"){
                Console.WriteLine("Winner is Player1!");
                Console.WriteLine("Score: Player1: {0} Player2: {1}", ++player1Score, player2Score);
                clicked = 0;
                 looping();
            }
             else if(btn[6] == "X" && btn[7] == "X" && btn[8] == "X"){
                Console.WriteLine("Winner is Player1!");
                Console.WriteLine("Score: Player1: {0} Player2: {1}", ++player1Score, player2Score);
                clicked = 0;
                 looping();

            }else if(btn[0] == "O" && btn[1] == "O" && btn[2] == "O"){
                Console.WriteLine("Winner is Player2!");
                Console.WriteLine("Score: Player1: {0} Player2: {1}", player1Score, ++player2Score);
                clicked = 0;
                 looping();
            }
             else if(btn[3] == "O" && btn[4] == "O" && btn[5] == "O"){
                Console.WriteLine("Winner is Player2!");
                Console.WriteLine("Score: Player1: {0} Player2: {1}", player1Score, ++player2Score);
                clicked = 0;
                 looping();
            }
             else if(btn[6] == "O" && btn[7] == "O" && btn[8] == "O"){
                Console.WriteLine("Winner is Player2!");
                Console.WriteLine("Score: Player1: {0} Player2: {1}", player1Score, ++player2Score);
                clicked = 0;
                 looping();
            }
            
        }
        public static void verticalWin(){
            if(btn[0] == "X" && btn[3] == "X" && btn[6] == "X"){
                Console.WriteLine("Winner is Player1!");
                 Console.WriteLine("Score: Player1: {0} Player2: {1}", ++player1Score, player2Score);
                clicked = 0;
                looping();
            }
             else if(btn[1] == "X" && btn[4] == "X" && btn[7] == "X"){
                Console.WriteLine("Winner is Player1!");
                 Console.WriteLine("Score: Player1: {0} Player2: {1}", ++player1Score, player2Score);
                clicked = 0;
                looping();
            }
             else if(btn[2] == "X" && btn[5] == "X" && btn[8] == "X"){
                Console.WriteLine("Winner is Player1!");
                 Console.WriteLine("Score: Player1: {0} Player2: {1}", ++player1Score, player2Score);
                clicked = 0;
                looping();
            }else if(btn[0] == "O" && btn[3] == "O" && btn[6] == "O"){
                Console.WriteLine("Winner is Player2!");
                Console.WriteLine("Score: Player1: {0} Player2: {1}", player1Score, ++player2Score);
                clicked = 0;
                looping();
            }
             else if(btn[1] == "O" && btn[4] == "O" && btn[7] == "O"){
                Console.WriteLine("Winner is Player2!");
                Console.WriteLine("Score: Player1: {0} Player2: {1}", player1Score, ++player2Score);
                clicked = 0;
                looping();
            }
             else if(btn[2] == "O" && btn[5] == "O" && btn[8] == "O"){
                Console.WriteLine("Winner is Player2!");
                Console.WriteLine("Score: Player1: {0} Player2: {1}", player1Score, ++player2Score);
                clicked = 0;
                looping();
            }
        }
        public static void diagonalWin(){
            if(btn[0] == "X" && btn[4] == "X" && btn[8] == "X"){
                Console.WriteLine("Winner is Player1!");
                 Console.WriteLine("Score: Player1: {0} Player2: {1}", ++player1Score, player2Score);
                clicked = 0;
                looping();
            }
             else if(btn[2] == "X" && btn[4] == "X" && btn[6] == "X"){
                Console.WriteLine("Winner is Player1!");
                 Console.WriteLine("Score: Player1: {0} Player2: {1}", ++player1Score, player2Score);
                clicked = 0;
                looping();
            }
             else if(btn[0] == "O" && btn[4] == "O" && btn[8] == "O"){
                Console.WriteLine("Winner is Player2!");
                Console.WriteLine("Score: Player1: {0} Player2: {1}", player1Score, ++player2Score);
                clicked = 0;
                looping();
            }
             else if(btn[2] == "O" && btn[4] == "O" && btn[6] == "O"){
                Console.WriteLine("Winner is Player2!");
                Console.WriteLine("Score: Player1: {0} Player2: {1}", player1Score, ++player2Score);
                clicked = 0;
                looping();
            }
        }    
        public static void Main(string[] args){
            Console.WriteLine("Welcome to TicTacToe!");
            board();
            while (playAgain ==  true)
            {             
                try{
                    if(clicked < 9){
                        Console.WriteLine("\"{0}\" Enter postion:",player);
                        int pos = Convert.ToInt32(Console.ReadLine()) - 1;
                        if(btn[pos] == "X" || btn[pos] == "O"){
                            Console.WriteLine("Already selected!");
                        }else{
                            if(player == "Player1"){
                                btn[pos] = "X"; 
                                player = "Player2";
                            }else{
                                btn[pos] = "O";
                                player = "Player1";
                            }
                            Console.Clear();              
                            Console.WriteLine("-------------");
                            Console.WriteLine("| {0} | {1} | {2} |", btn[0],btn[1], btn[2]);
                            Console.WriteLine("-------------");
                            Console.WriteLine("| {0} | {1} | {2} |", btn[3],btn[4], btn[5]);
                            Console.WriteLine("-------------");
                            Console.WriteLine("| {0} | {1} | {2} |", btn[6],btn[7], btn[8]);
                            Console.WriteLine("-------------");
                            verticalWin();
                            hrzntalWin();
                            diagonalWin();
                            clicked++;
                            //Console.WriteLine("Clicked {0}",clicked);
                        }  
                    }else{
                        Console.WriteLine("Draw!");
                        Console.WriteLine("Score: Player1: {0} Player2: {1}",player1Score, player2Score);
                        clicked = 0;
                        looping();
                    }  
                }catch(Exception){

                }
            }
        }
    }
}