using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{

  public string id = "default";
  public string name = "Default";
  public string[] tags;

  public int manaCost = 0;
  public int attack = 0;
  public int health = 0;

  public string text = "";
  public string cardClass = CardClass.NEUTRAL;
  public string rarity = Rarity.NONE;
  public string race = "";
  public string cardSet = "classic";

  public List<Event> effects;
}

public class Rarity
{
  public const string NONE = "none";
  public const string COMMON = "common";
  public const string RARE = "rare";
  public const string EPIC = "epic";
  public const string LEGENDARY = "legendary";
}

public class CardClass
{
  public const string NEUTRAL = "neutral";
  public const string DRUID = "druid";
  public const string HUNTER = "hunter";
  public const string MAGE = "mage";
  public const string PALADIN = "paladin";
  public const string PRIEST = "priest";
  public const string ROGUE = "rogue";
  public const string SHAMAN = "shaman";
  public const string WARLOCK = "warlock";
  public const string WARRIOR = "warrior";
}
