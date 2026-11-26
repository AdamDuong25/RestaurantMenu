using UnityEngine;
using TMPro;

public class ButtonsHeader : MonoBehaviour
{
  public TextMeshProUGUI headerText;

  // Sets the Text Header to the specified string.
  // If the headerText component is not assigned, this will do nothing.
  public void SetHeaderText(string text)
  {
    if (headerText != null) headerText.text = text;
  }
  public void TextKaikki() { SetHeaderText("KAIKKI"); }
  public void TextAlkuruoat() { SetHeaderText("ALKURUOAT"); }
  public void TextPaaruoat() { SetHeaderText("PÄÄRUOAT"); }
  public void TextJalkiruoat() { SetHeaderText("JÄLKIRUOAT"); }
  public void TextJuomat() { SetHeaderText("JUOMAT"); }
}
