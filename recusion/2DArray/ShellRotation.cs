using System;
using System.Collections.Generic;
using System.Text;

namespace _2DArray
{
    public static class ShellRotation
    {
        public static List<List<int>> Method(List<List<int>> input, int shell, int rotate)
        {
            List<int> oned = FillOnedFromShell(input, shell);

            Rotate(oned, rotate);

            FillShellFromOned(input, shell, oned);
        }

        public static int[] FillOnedFromShell(List<List<int>>  input,int shell)
        {
            int minRow = shell - 1;
            int minCol = shell - 1;
            int maxRow = input.Count - 1 - minRow;
            int maxCol = input[0].Count - 1 - minCol;
            int length = maxRow * maxCol;
            int[]
            while (true)
            {
                for()
            }
        }

        static void Rotate(List<int> input,int rotate)
        {
            int[] Result = new int[input.Count];
            rotate = rotate % input.Count;
            rotate = rotate < 0 ? rotate + input.Count: rotate;
            for (int i=0; i< input.Count; i++)
            {
                Result[(i + rotate) % input.Count] = input[i];
            }
        }
    }
}
