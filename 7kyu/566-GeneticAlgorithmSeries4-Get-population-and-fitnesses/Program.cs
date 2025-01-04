using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kata
{
    public IEnumerable<ChromosomeWrap> MapPopulationFit(IEnumerable<string> population, Func<string, double> fitness)
    {
        var res = new List<ChromosomeWrap>();
        foreach(var c in population)
        {
          double f = fitness(c);
          res.Add(new ChromosomeWrap
          {
            Chromosome = c,
            Fitness = f
          });
        }
        return res;
    }
}

public class ChromosomeWrap
{
    public string Chromosome { get; set; }
    public double Fitness { get; set; }
}