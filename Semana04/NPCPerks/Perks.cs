using System;

[Flags]
    public enum Perks
    {
        None = 0,
        Stealth = 1 << 0,
        Combat = 1 << 1,
        Lockpick = 1 << 2,
        Luck = 1 << 3,
        Intelligence = 1 << 4,
        Charisma = 1 << 5,
        Resistance = 1 << 6
    }
