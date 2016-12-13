// Connect Four
// https://www.codewars.com/kata/connect-four-1/
// by Equim on 16-12-14

using System.Collections.Generic;
using System.Text;

public class ConnectFour
{
    // 0=Empty, 1=Red, 2=Yellow
    private static int[,] Board = new int[7, 6];
    private static int[] MinAvailableLineForEachColumns = new int[7] { 0, 0, 0, 0, 0, 0, 0 };

    private static bool WinJudge(int Column, int Line)
    {
        int Who = Board[Column, Line];

        // Vertical
        if (Line >= 3)
        {
            if (Board[Column, Line - 1] == Who)
                if (Board[Column, Line - 2] == Who)
                    if (Board[Column, Line - 3] == Who)
                        return true;
        }

        // Horizontal
        int HorizontalCheckStartX = 0;

        if (Board[3, Line] == Who)
        {
            while (HorizontalCheckStartX <= 3)
            {
                while (Board[HorizontalCheckStartX, Line] != Who && HorizontalCheckStartX <= 3)
                    HorizontalCheckStartX++;
                if (Board[HorizontalCheckStartX, Line] == Who)
                    if (Board[HorizontalCheckStartX + 1, Line] == Who)
                        if (Board[HorizontalCheckStartX + 2, Line] == Who)
                            if (Board[HorizontalCheckStartX + 3, Line] == Who)
                                return true;

                HorizontalCheckStartX++;
            }
        }

        // ↙↗Oblique
        int ObliqueCheckStartX = Column - 3;
        int ObliqueCheckStartY = Line - 3;

        if (ObliqueCheckStartX < 0)
        {
            ObliqueCheckStartY -= ObliqueCheckStartX;
            ObliqueCheckStartX = 0;
        }

        if (ObliqueCheckStartY < 0)
        {
            ObliqueCheckStartX -= ObliqueCheckStartY;
            ObliqueCheckStartY = 0;
        }

        while (ObliqueCheckStartY <= 2 && ObliqueCheckStartX <= 3)
        {
            //while (Board[ObliqueCheckStartX, ObliqueCheckStartY] != Who && ObliqueCheckStartY >=0 && ObliqueCheckStartY <= 2 && ObliqueCheckStartX <= 3 && ObliqueCheckStartX >= 0)
            //{
            //    ObliqueCheckStartX++;
            //    ObliqueCheckStartY++;
            //}

            if (Board[ObliqueCheckStartX, ObliqueCheckStartY] == Who)
                if (Board[ObliqueCheckStartX + 1, ObliqueCheckStartY + 1] == Who)
                {
                    if (Board[ObliqueCheckStartX + 2, ObliqueCheckStartY + 2] == Who)
                    {
                        if (Board[ObliqueCheckStartX + 3, ObliqueCheckStartY + 3] == Who)
                            return true;
                    }
                    else
                    {
                    }
                }
                else
                {
                }

            ObliqueCheckStartX++;
            ObliqueCheckStartY++;
        }

        // ↖↘Oblique
        ObliqueCheckStartX = Column + 3;
        ObliqueCheckStartY = Line - 3;

        if (ObliqueCheckStartY < 0)
        {
            ObliqueCheckStartX += ObliqueCheckStartY;
            ObliqueCheckStartY = 0;
        }

        if (ObliqueCheckStartX > 6)
        {
            ObliqueCheckStartY += ObliqueCheckStartX - 6;
            ObliqueCheckStartX = 6;
        }

        while (ObliqueCheckStartY <= 2 && ObliqueCheckStartX >= 3)
        {
            //while (Board[ObliqueCheckStartX, ObliqueCheckStartY] != Who && ObliqueCheckStartY >= 0 && ObliqueCheckStartY <= 2 && ObliqueCheckStartX >= 3  && ObliqueCheckStartX <= 6)
            //{
            //    ObliqueCheckStartX--;
            //    ObliqueCheckStartY++;
            //}

            if (Board[ObliqueCheckStartX, ObliqueCheckStartY] == Who)
                if (Board[ObliqueCheckStartX - 1, ObliqueCheckStartY + 1] == Who)
                {
                    if (Board[ObliqueCheckStartX - 2, ObliqueCheckStartY + 2] == Who)
                    {
                        if (Board[ObliqueCheckStartX - 3, ObliqueCheckStartY + 3] == Who)
                            return true;
                    }
                    else
                    {
                    }
                }
                else
                {
                }

            ObliqueCheckStartX--;
            ObliqueCheckStartY++;
        }

        return false;
    }

    public static string WhoIsWinner(List<string> piecesPositionList)
    {
        Board = new int[7, 6];
        MinAvailableLineForEachColumns = new int[7] { 0, 0, 0, 0, 0, 0, 0 };

        int Step = 0;

        foreach (var item in piecesPositionList)
        {
            string[] CurrentMove = item.Split('_');

            int Column = (int)Encoding.ASCII.GetBytes(CurrentMove[0])[0] - 65;

            int Line = MinAvailableLineForEachColumns[Column]++;

            Board[Column, Line] = CurrentMove[1] == "Red" ? 1 : 2;

            if (++Step >= 7)
                if (WinJudge(Column, Line))
                    return CurrentMove[1];
        }
        return "Draw";
    }

}
