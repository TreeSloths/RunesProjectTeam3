public class Rune{
   public RuneType runeType;
   public Rarity rarity;
   private int amountOwned;
   public event System.Action<int> AmountAdded;
   public int AmountOwned{
      get => this.amountOwned;
      set{
         this.amountOwned = value;
         this.AmountAdded?.Invoke(value);
      }
   }
   public Rune(RuneType runeType, Rarity rarity, int amountOwned){
      this.runeType = runeType;
      this.rarity = rarity;
      this.AmountOwned = amountOwned;
   }
}