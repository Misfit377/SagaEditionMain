using SagaEditionMain_Desktop.Models.Character_Info.Attributes;

namespace SagaEditionMain_Desktop.Models.Character_Info
{
    public class CharacterClasses
    {
        public List<CharacterClassBase> ClassList;
        public CharacterClasses()
        {
            var classList = new List<CharacterClassBase>
            {
            // Heroic Classes
                new CharacterClassBase
                {
                    Name = "Jedi",
                    Level = 0,
                    IsPrestigeClass = false,
                    MartialBaseAttackBonus = true,
                    ReflexBonus = 1,
                    FortitudeBonus = 1,
                    WillBonus = 1,
                },
                new CharacterClassBase
                {
                    Name = "Noble",
                    Level = 0,
                    IsPrestigeClass = false,
                    MartialBaseAttackBonus = false,
                    ReflexBonus = 1,
                    FortitudeBonus = 0,
                    WillBonus = 2,
                },
                new CharacterClassBase
                {
                    Name = "Scoundrel",
                    Level = 0,
                    IsPrestigeClass = false,
                    MartialBaseAttackBonus = false,
                    ReflexBonus = 2,
                    FortitudeBonus = 0,
                    WillBonus = 1,
                },
                new CharacterClassBase
                {
                    Name = "Scout",
                    Level = 0,
                    IsPrestigeClass = false,
                    MartialBaseAttackBonus = false,
                    ReflexBonus = 2,
                    FortitudeBonus = 1,
                    WillBonus = 0,
                },
                new CharacterClassBase
                {
                    Name = "Soldier",
                    Level = 0,
                    IsPrestigeClass = false,
                    MartialBaseAttackBonus = true,
                    ReflexBonus = 1,
                    FortitudeBonus = 2,
                    WillBonus = 0,
                },
                // Prestige CLasses
                new CharacterClassBase
                {
                    Name = "Ace Pilot",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = false,
                    ReflexBonus = 4,
                    FortitudeBonus = 2,
                    WillBonus = 0,
                },
                new CharacterClassBase
                {
                    Name = "Assassin",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = true,
                    ReflexBonus = 4,
                    FortitudeBonus = 2,
                    WillBonus = 0,
                },
                new CharacterClassBase
                {
                    Name = "Bounty Hunter",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = true,
                    ReflexBonus = 4,
                    FortitudeBonus = 2,
                    WillBonus = 0,
                },
                new CharacterClassBase
                {
                    Name = "Charlatan",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = false,
                    ReflexBonus = 2,
                    FortitudeBonus = 0,
                    WillBonus = 4,
                },
                new CharacterClassBase
                {
                    Name = "Corporate Agent",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = false,
                    ReflexBonus = 2,
                    FortitudeBonus = 0,
                    WillBonus = 4,
                },
                new CharacterClassBase
                {
                    Name = "Crime Lord",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = false,
                    ReflexBonus = 2,
                    FortitudeBonus = 0,
                    WillBonus = 4,
                },
                new CharacterClassBase
                {
                    Name = "Droid Commander",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = true,
                    ReflexBonus = 2,
                    FortitudeBonus = 2,
                    WillBonus = 2,
                },
                new CharacterClassBase
                {
                    Name = "Elite Trooper",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = true,
                    ReflexBonus = 2,
                    FortitudeBonus = 4,
                    WillBonus = 0,
                },
                new CharacterClassBase
                {
                    Name = "Enforcer",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = false,
                    ReflexBonus = 4,
                    FortitudeBonus = 0,
                    WillBonus = 2,
                },
                new CharacterClassBase
                {
                    Name = "Force Adept",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = false,
                    ReflexBonus = 2,
                    FortitudeBonus = 2,
                    WillBonus = 4,
                },
                new CharacterClassBase
                {
                    Name = "Force Disciple",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = false,
                    ReflexBonus = 3,
                    FortitudeBonus = 3,
                    WillBonus = 6,
                },
                new CharacterClassBase
                {
                    Name = "Gladiator",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = true,
                    ReflexBonus = 4,
                    FortitudeBonus = 2,
                    WillBonus = 0,
                },
                new CharacterClassBase
                {
                    Name = "Gunslinger",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = true,
                    ReflexBonus = 4,
                    FortitudeBonus = 0,
                    WillBonus = 2,
                },
                new CharacterClassBase
                {
                    Name = "Imperial Knight",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = true,
                    ReflexBonus = 2,
                    FortitudeBonus = 2,
                    WillBonus = 2,
                },
                new CharacterClassBase
                {
                    Name = "Improviser",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = false,
                    ReflexBonus = 2,
                    FortitudeBonus = 0,
                    WillBonus = 4,
                },
                new CharacterClassBase
                {
                    Name = "Independent Droid",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = false,
                    ReflexBonus = 2,
                    FortitudeBonus = 0,
                    WillBonus = 4,
                },
                new CharacterClassBase
                {
                    Name = "Infiltrator",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = true,
                    ReflexBonus = 4,
                    FortitudeBonus = 0,
                    WillBonus = 2,
                },
                new CharacterClassBase
                {
                    Name = "Jedi Knight",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = true,
                    ReflexBonus = 2,
                    FortitudeBonus = 2,
                    WillBonus = 2,
                },
                new CharacterClassBase
                {
                    Name = "Jedi Master",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = true,
                    ReflexBonus = 3,
                    FortitudeBonus = 3,
                    WillBonus = 3,
                },
                new CharacterClassBase
                {
                    Name = "Martial Arts Master",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = true,
                    ReflexBonus = 2,
                    FortitudeBonus = 4,
                    WillBonus = 0,
                },
                new CharacterClassBase
                {
                    Name = "Master Privateer",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = true,
                    ReflexBonus = 2,
                    FortitudeBonus = 0,
                    WillBonus = 4,
                },
                new CharacterClassBase
                {
                    Name = "Medic",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = false,
                    ReflexBonus = 0,
                    FortitudeBonus = 4,
                    WillBonus = 2,
                },
                new CharacterClassBase
                {
                    Name = "Melee Duelist",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = true,
                    ReflexBonus = 4,
                    FortitudeBonus = 2,
                    WillBonus = 0,
                },
                new CharacterClassBase
                {
                    Name = "Military Engineer",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = false,
                    ReflexBonus = 2,
                    FortitudeBonus = 2,
                    WillBonus = 2,
                },
                new CharacterClassBase
                {
                    Name = "Officer",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = true,
                    ReflexBonus = 2,
                    FortitudeBonus = 0,
                    WillBonus = 4,
                },
                new CharacterClassBase
                {
                    Name = "Outlaw",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = false,
                    ReflexBonus = 4,
                    FortitudeBonus = 2,
                    WillBonus = 0,
                },
                new CharacterClassBase
                {
                    Name = "Pathfinder",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = false,
                    ReflexBonus = 2,
                    FortitudeBonus = 4,
                    WillBonus = 0,
                },
                new CharacterClassBase
                {
                    Name = "Sabotuer",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = false,
                    ReflexBonus = 2,
                    FortitudeBonus = 0,
                    WillBonus = 4,
                },
                new CharacterClassBase
                {
                    Name = "Shaper",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = false,
                    ReflexBonus = 0,
                    FortitudeBonus = 2,
                    WillBonus = 4,
                },
                new CharacterClassBase
                {
                    Name = "Sith Apprentice",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = true,
                    ReflexBonus = 2,
                    FortitudeBonus = 2,
                    WillBonus = 2,
                },
                new CharacterClassBase
                {
                    Name = "Sith Lord",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = true,
                    ReflexBonus = 3,
                    FortitudeBonus = 3,
                    WillBonus = 3,
                },
                new CharacterClassBase
                {
                    Name = "Vanguard",
                    Level = 0,
                    IsPrestigeClass = true,
                    MartialBaseAttackBonus = true,
                    ReflexBonus = 2,
                    FortitudeBonus = 4,
                    WillBonus = 0,
                },
            };
            ClassList = classList;
        }

        public class CharacterClassBase
        {
            public string? Name { get; set; }
            public int Level { get; set; }
            public int ReflexBonus { get; set; }
            public int FortitudeBonus { get; set; }
            public int WillBonus { get; set; }
            public bool IsPrestigeClass { get; set; }
            public bool MartialBaseAttackBonus { get; set; }
            public int BaseAttackBonus
            {
                get
                {
                    if (!IsPrestigeClass && MartialBaseAttackBonus)
                        return Level;
                    else if (!IsPrestigeClass && !MartialBaseAttackBonus)
                        return Level > 0 ? Level - 1 : 0;
                    else if (IsPrestigeClass && MartialBaseAttackBonus)
                        return Level;
                    else
                        return Level switch
                        {
                            0 => 0,
                            > 0 and < 5 => Level - 1,
                            >= 5 and < 9 => Level - 2,
                            _ => Level - 3,
                        };
                }
            }
        }
    }
}
