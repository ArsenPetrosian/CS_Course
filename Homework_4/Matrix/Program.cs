namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix mat = new Matrix(4, 4);
            mat[0, 0] = 1;
            mat[1, 1] = 2;
            mat[2, 2] = 3;
            mat[3, 3] = 4;
            for (int i = 0; i < 4; i++)
            {
                string output = new string("");
                for (int j = 0; j < 4; j++)
                    output += mat[i, j].ToString() + " ";
                Console.WriteLine(output);
            }
        }
    }
}
