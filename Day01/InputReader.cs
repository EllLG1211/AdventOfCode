using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public class InputReader
    {
        private const string FILENAME = "input.txt";

        public IEnumerable<int> GetInput()
        {
            List<int> values = new();
            int tmp = 0;

            string[] lines = File.ReadAllLines(FILENAME);
            foreach(string line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    values.Add(tmp);
                    tmp = 0;
                }
                else tmp += int.Parse(line);
            }
            return values;
        }
    }
}
