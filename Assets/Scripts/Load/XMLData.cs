using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using UnityEngine;

public class XMLData
{

  public const string path = "";

  public List<Card> cards = new List<Card>();

  public XMLData()
  {
    LoadXML();
  }


  public void LoadXML()
  {
    TextAsset textAsset = (TextAsset)Resources.Load("cards");
    Debug.Log(textAsset);
    XDocument doc = XDocument.Parse(textAsset.text);

    var minions = doc.Elements("minion");

    foreach (XElement minion in minions)
    {
      Card card = new Card();

      card.id = minion.Element("id").Value;
      card.name = minion.Element("name").Value;
      card.tags = minion.Element("tags").Value.Split(',');

      if (int.TryParse(minion.Element("manaCost").Value, out card.manaCost) == false)
      {
        Debug.LogError("Failed to parse element manaCost, expected a number, received: " + minion.Element("manaCost").Value);
      }
      if (int.TryParse(minion.Element("attack").Value, out card.attack) == false)
      {
        Debug.LogError("Failed to parse element attack, expected a number, received: " + minion.Element("attack").Value);
      }
      if (int.TryParse(minion.Element("health").Value, out card.health) == false)
      {
        Debug.LogError("Failed to parse element health, expected a number, received: " + minion.Element("health").Value);
      }

      card.text = minion.Element("text").Value;
      card.cardClass = minion.Element("class").Value;
      card.rarity = minion.Element("rarity").Value;
      card.race = minion.Element("race").Value;
      card.cardSet = minion.Element("set").Value;

      //TODO: effects logic
    }


  }




}
