using MetroSet_UI.Forms;

namespace P5RBattleEditor
{
    public partial class P5RBattleEditor : MetroSetForm
    {
        enum PersonaInheritType
        {
            InheritNone = 0,
            InheritPhysical = 1,
            InheritFire = 2,
            InheritIce = 3,
            InheritElec = 4,
            InheritWind = 5,
            InheritBless = 6,
            InheritCurse = 7,
            InheritHealing = 8,
            InheritAilment = 10,
            InheritAlmighty = 12,
            InheritRESERVE = 13,
            InheritNuke = 14,
            InheritPsy = 15,
        }

        enum PersonaStatFlags
        {
            Unknown,
            Unknown2,
            PartyPersona,
            StoryPersona,
            NotRegisterable,
            Unknown3,
            CannotBeFusedNormally,
            Evolved
        }

        enum ArcanaNames
        {
            Fool = 1,
            Magician = 2,
            HighPriestess = 3,
            Empress = 4,
            Emperor = 5,
            Hierophant = 6,
            Lovers = 7,
            Chariot = 8,
            Justice = 9,
            Hermit = 10,
            Fortune = 11,
            Strength = 12,
            HangedMan = 13,
            Death = 14,
            Temperance = 15,
            Devil = 16,
            Tower = 17,
            Star = 18,
            Moon = 19,
            Sun = 20,
            Judgement = 21,
            Aeon = 22,
            Other = 23,
            World = 24,
            Faith = 29,
            Councillor = 30,
        }

        enum DLCorTreasureDemon
        {
            NeitherDLCNorTreasure = 0,
            TreasureNotDLC = 1,
            DLCNotTreasure = 2,
            DLCTreasureDemon = 3
        }

        enum LearnableFlags
        {
            Nothing = 0, // No skill or trait
            Skill = 1, // Learnable ID is for a skill
            Trait = 3,  // Learnable ID is for a trait
        };
    }
}