using System.Collections.Generic;

namespace CleanCode.AgilePractices.BadPractices
{
    public class StringConverter
    {
        public List<int> StringToInt(List<string> strings)
        {
            return NewMethod(strings != null ? new List<string>() : strings);
        }

        private static List<int> NewMethod(List<string> strings)
        {
            List<int> result = new List<int>();

            foreach (var s in strings)
            {
                result.Add(int.Parse(s));
            }

            return result;
        }
    }
}
