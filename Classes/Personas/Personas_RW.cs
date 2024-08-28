using MetroSet_UI.Forms;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.IO;

namespace P5RBattleEditor
{
    public partial class P5RBattleEditor : MetroSetForm
    {
        const int PERSONA_SEGMENT0_ENTRY_SIZE = 68;
        const int PERSONA_SEGMENT1_ENTRY_SIZE = 40;
        const int PERSONA_SEGMENT2_ENTRY_SIZE = 40;
        const int PERSONA_SEGMENT3_ENTRY_SIZE = 24;

        private PersonaTableData ReadP5RPersonaTbl(string path)
        {
            PersonaTableData tblData = new PersonaTableData();

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (EndianBinaryReader br = new EndianBinaryReader(fs, Endianness.BigEndian))
                {
                    // Segment 0: Persona Stats
                    uint segment0Size = br.ReadUInt32();
                    for (int i = 0; i < (segment0Size / PERSONA_SEGMENT0_ENTRY_SIZE); i++)
                    {
                        PersonaStats persona = new PersonaStats();

                        tblData.Stats.Add(persona);
                    }

                    br.BaseStream.Position += Get16ByteAlignmentPadding(br);

                    // Segment 1: Persona Stat Growth & Skill Inheritance
                    uint segment1Size = br.ReadUInt32();
                    for (int i = 0; i < (segment1Size / PERSONA_SEGMENT1_ENTRY_SIZE); i++)
                    {
                        //tblData.Stats[i].WeightedStatGrowthDistribution = 
                    }

                    // Segment 2: Party Member Levelup Thresholds

                    br.BaseStream.Position += Get16ByteAlignmentPadding(br);

                    uint segment2Size = br.ReadUInt32();
                    for (int i = 0; i < (segment2Size / PERSONA_SEGMENT2_ENTRY_SIZE); i++)
                    {
                        var lvlupThreshold = new PtyLvlUp();

                        tblData.PartyLevelUpThresholds[i] = lvlupThreshold;
                    }

                    br.BaseStream.Position += Get16ByteAlignmentPadding(br);

                    // Segment 3: Party Member Personas
                    uint segment3Size = br.ReadUInt32();
                    for (int i = 0; i < (segment3Size / PERSONA_SEGMENT3_ENTRY_SIZE); i++)
                    {
                        var ptyPersona = new PtyMemberPersona();

                        tblData.PartyMemberPersonas[i] = ptyPersona;
                    }

                    br.BaseStream.Position += Get16ByteAlignmentPadding(br);
                }
            }

            return tblData;
        }

        private void WriteP5RPersonaTbl(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                using (EndianBinaryWriter bw = new EndianBinaryWriter(fs, Endianness.BigEndian))
                {
                    // Segment 0: Persona Stats
                    uint segment0Size = Convert.ToUInt32(PERSONA_SEGMENT0_ENTRY_SIZE * PersonaTblData.Stats.Count);
                    bw.Write(segment0Size);
                    foreach (var persona in PersonaTblData.Stats)
                    {

                    }

                    Add16ByteAlignmentPadding(bw);

                    // Segment 1: Persona Stat Growth & Skill Inheritance
                    uint segment1Size = Convert.ToUInt32(PERSONA_SEGMENT1_ENTRY_SIZE * PersonaTblData.Stats.Count);
                    bw.Write(segment1Size);
                    foreach (var persona in PersonaTblData.Stats)
                    {

                    }

                    Add16ByteAlignmentPadding(bw);

                    // Segment 2: Party Member Levelup Thresholds
                    uint segment2Size = Convert.ToUInt32(PERSONA_SEGMENT2_ENTRY_SIZE * PersonaTblData.PartyLevelUpThresholds.Length);
                    bw.Write(segment2Size);
                    foreach (var partyMember in PersonaTblData.PartyLevelUpThresholds)
                    {

                    }

                    Add16ByteAlignmentPadding(bw);

                    // Segment 3: Party Member Personas
                    uint segment3Size = Convert.ToUInt32(PERSONA_SEGMENT3_ENTRY_SIZE * PersonaTblData.PartyMemberPersonas.Count);
                    bw.Write(segment3Size);
                    foreach (var persona in PersonaTblData.PartyMemberPersonas)
                    {

                    }

                    Add16ByteAlignmentPadding(bw);
                }
            }
        }

    }
}
