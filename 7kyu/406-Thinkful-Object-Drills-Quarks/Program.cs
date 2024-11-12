using Microsoft.VisualBasic;

public class Quark {
  // Your code here.
  public string Color { get; set; }
  public string Flavor { get; set; }
  public double BaryonNumber { get; set; } = 1/3;

  public Quark(string color, string flavor) {
    this.Color = color;
    this.Flavor = flavor;
  }

  public void Interact(Quark quark){
    string tempColor = Color;
    string tempFlavor = Flavor;
    this.Color = quark.Color;
    this.Flavor = quark.Flavor;
    quark.Color = tempColor;
    quark.Flavor = tempFlavor;
  }
}

// Alternative
// public class Quark
// {
//   public string Color;
//   public string Flavor;

//   public Quark(string color, string flavor)
//   {
//       Color = color;
//       Flavor = flavor;
//   }

//   public double BaryonNumber => 1 / 3d;
//   public void Interact(Quark q) => (Color, q.Color) = (q.Color, Color);
// }