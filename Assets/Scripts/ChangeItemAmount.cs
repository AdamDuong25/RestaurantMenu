using UnityEngine;
using TMPro;

public class ChangeItemAmount : MonoBehaviour
{
  public TextMeshProUGUI itemAmount;

  public void IncreaseAmount() 
  {
    if (itemAmount != null)
    {
      int currentAmount = int.Parse(itemAmount.text);
      if (currentAmount < 100) 
      {
        currentAmount++;
        itemAmount.text = currentAmount.ToString();
      }
    }
  }

  public void DecreaseAmount() 
  {
    if (itemAmount != null)
    {
      int currentAmount = int.Parse(itemAmount.text);
      if (currentAmount > 0) 
      {
        currentAmount--;
        itemAmount.text = currentAmount.ToString();
      }
    }
  }
}
