using System.Linq;
public class TestBackend
{
    #region GetPalindromos
    public List<string> GetPalindromos(List<string> stringList)
    {
        List<string> palindromoList = stringList.Where(stringItem => stringItem.Reverse().Equals(stringItem)).ToList();
        return palindromoList;
    }
    #endregion

    #region RepeatedStrings
    public List<string> RepeatedStrings(List<string> stringList)
    {
        List<string> repeatedStringList = stringList.GroupBy(c => c)
        .Where(g => g.Count() > 1)
        .Select(g => g.Key).ToList();

        return repeatedStringList;
    }
    #endregion

    #region CountRepeatedStrings
    public int CountRepeatedStrings(List<string> stringList)
    {
        return this.RepeatedStrings(stringList).Count();
    }
    #endregion

    #region OrderedStringList
    public List<string> OrderStringList(List<string> stringList)
    {
        List<string> orderedStringList = stringList.OrderByDescending(stringItem => stringItem).ToList();
        return orderedStringList;
    }
    #endregion


    #region AverageRepetedString
    public double AverageRepetedString(List<string> stringList)
    {
        var average = this.RepeatedStrings(stringList).Select(x => x.Length).Average();
        return average;
    }
    #endregion

    #region OnlyNumberList
    public List<string> OnlyNumberList(List<string> stringList)
    {
        var onlyNumberList = stringList.Where(c => c.All(char.IsDigit)).ToList();
        return onlyNumberList;
    }
    #endregion
}
