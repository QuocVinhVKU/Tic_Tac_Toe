using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board
    {
        public Cell cell = new Cell();

        public const int BOARD_SIZE = 3;    //kích thước cố định
        public Cell[,] board;               //ma trận 2 chiều
        //Khởi tạo bảng rỗng
        public Board(){
            board = new Cell[BOARD_SIZE,BOARD_SIZE];
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    board[i, j] = new Cell();
                }
            }
        }
        //Hiển thị bảng
        public void printBoard(){
            int fieldNumber = 1;
            Console.WriteLine("-----");
            for (int i = 0; i < BOARD_SIZE; i++){
                for (int j = 0; j < BOARD_SIZE; j++){
                    if (board[i, j].isEmpty())
                        Console.Write(fieldNumber);
                    else
                    {
                        if((char)(board[i, j].getFieldState()) == 'X')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write('X');
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write('O');
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                    }
                    
                    fieldNumber++;

                    if (j<BOARD_SIZE-1)  Console.Write("|");
                }
                Console.Write("\n");
            }
            Console.WriteLine("-----");
        }
        //Xác định tạo độ
        public void putMark(Player player, int fieldNumber){
            int verticalY = (fieldNumber - 1) / BOARD_SIZE;
            int horizontalX = (fieldNumber - 1) % BOARD_SIZE;
            if (board[verticalY, horizontalX].isEmpty())
                board[verticalY, horizontalX].markField(player);
            else  {
                Console.WriteLine("This place is taken. Select the field again: ");
                putMark(player, player.takeTurn());
            }
        }
        //Xóa bảng
        public void clearBoard(){
            Console.Clear();
        }
    
    }
}
