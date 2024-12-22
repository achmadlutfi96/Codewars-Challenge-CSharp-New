using System;

namespace Solution
{
  public static class SolutionClass
  {
    public static int ContentWeight(int bottleWeight, string scaleString)
    {
      // Code goes here ...
      string[] scales = scaleString.Split(" ");
      int scale = Convert.ToInt32(scales[0]);
      string compare = scales[2];

      float bottleOnlyWeight = bottleWeight / (scale+1);
      int res = 0;
      if(compare == "larger"){
        res = (int) bottleOnlyWeight * scale;
      }else{
        res = (int) bottleOnlyWeight*1;
      }
      return res;

    //   Alternative
    // var scale = int.Parse(string.Concat(scaleString.Where(char.IsDigit)));
    // return scaleString.Contains("larger") ? bottleWeight * scale / (scale + 1) : bottleWeight / (scale + 1);
    }
  }
}