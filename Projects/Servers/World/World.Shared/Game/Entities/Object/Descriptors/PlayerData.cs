﻿// Copyright (c) Multi-Emu.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using World.Shared.Constants.Objects;

namespace World.Shared.Game.Entities.Object.Descriptors
{
    public class PlayerData : DescriptorBase
    {
        public PlayerData() : base(UnitData.End) { }

        public DescriptorField DuelArbiter                   => base[0x0, 0x4, MirrorFlags.All];
        public DescriptorField WowAccount                    => base[0x4, 0x4, MirrorFlags.All];
        public DescriptorField LootTargetGUID                => base[0x8, 0x4, MirrorFlags.All];
        public DescriptorField PlayerFlags                   => base[0xC, 0x1, MirrorFlags.All];
        public DescriptorField PlayerFlagsEx                 => base[0xD, 0x1, MirrorFlags.All];
        public DescriptorField GuildRankID                   => base[0xE, 0x1, MirrorFlags.All];
        public DescriptorField GuildDeleteDate               => base[0xF, 0x1, MirrorFlags.All];
        public DescriptorField GuildLevel                    => base[0x10, 0x1, MirrorFlags.All];
        public DescriptorField HairColorID                   => base[0x11, 0x1, MirrorFlags.All];
        public DescriptorField RestState                     => base[0x12, 0x1, MirrorFlags.All];
        public DescriptorField ArenaFaction                  => base[0x13, 0x1, MirrorFlags.All];
        public DescriptorField DuelTeam                      => base[0x14, 0x1, MirrorFlags.All];
        public DescriptorField GuildTimeStamp                => base[0x15, 0x1, MirrorFlags.All];
        public DescriptorField QuestLog                      => base[0x16, 0x2EE, MirrorFlags.Party];
        public DescriptorField VisibleItems                  => base[0x304, 0x26, MirrorFlags.All];
        public DescriptorField PlayerTitle                   => base[0x32A, 0x1, MirrorFlags.All];
        public DescriptorField FakeInebriation               => base[0x32B, 0x1, MirrorFlags.All];
        public DescriptorField VirtualPlayerRealm            => base[0x32C, 0x1, MirrorFlags.All];
        public DescriptorField CurrentSpecID                 => base[0x32D, 0x1, MirrorFlags.All];
        public DescriptorField TaxiMountAnimKitID            => base[0x32E, 0x1, MirrorFlags.All];
        public DescriptorField AvgItemLevel                  => base[0x32F, 0x4, MirrorFlags.All];
        public DescriptorField CurrentBattlePetBreedQuality  => base[0x333, 0x1, MirrorFlags.All];
        public DescriptorField InvSlots                      => base[0x334, 0x2E0, MirrorFlags.Self];
        public DescriptorField FarsightObject                => base[0x614, 0x4, MirrorFlags.Self];
        public DescriptorField KnownTitles                   => base[0x618, 0xC, MirrorFlags.Self];
        public DescriptorField Coinage                       => base[0x624, 0x2, MirrorFlags.Self];
        public DescriptorField XP                            => base[0x626, 0x1, MirrorFlags.Self];
        public DescriptorField NextLevelXP                   => base[0x627, 0x1, MirrorFlags.Self];
        public DescriptorField Skill                         => base[0x628, 0x1C0, MirrorFlags.Self];
        public DescriptorField CharacterPoints               => base[0x7E8, 0x1, MirrorFlags.Self];
        public DescriptorField MaxTalentTiers                => base[0x7E9, 0x1, MirrorFlags.Self];
        public DescriptorField TrackCreatureMask             => base[0x7EA, 0x1, MirrorFlags.Self];
        public DescriptorField TrackResourceMask             => base[0x7EB, 0x1, MirrorFlags.Self];
        public DescriptorField MainhandExpertise             => base[0x7EC, 0x1, MirrorFlags.Self];
        public DescriptorField OffhandExpertise              => base[0x7ED, 0x1, MirrorFlags.Self];
        public DescriptorField RangedExpertise               => base[0x7EE, 0x1, MirrorFlags.Self];
        public DescriptorField CombatRatingExpertise         => base[0x7EF, 0x1, MirrorFlags.Self];
        public DescriptorField BlockPercentage               => base[0x7F0, 0x1, MirrorFlags.Self];
        public DescriptorField DodgePercentage               => base[0x7F1, 0x1, MirrorFlags.Self];
        public DescriptorField ParryPercentage               => base[0x7F2, 0x1, MirrorFlags.Self];
        public DescriptorField CritPercentage                => base[0x7F3, 0x1, MirrorFlags.Self];
        public DescriptorField RangedCritPercentage          => base[0x7F4, 0x1, MirrorFlags.Self];
        public DescriptorField OffhandCritPercentage         => base[0x7F5, 0x1, MirrorFlags.Self];
        public DescriptorField SpellCritPercentage           => base[0x7F6, 0x7, MirrorFlags.Self];
        public DescriptorField ShieldBlock                   => base[0x7FD, 0x1, MirrorFlags.Self];
        public DescriptorField ShieldBlockCritPercentage     => base[0x7FE, 0x1, MirrorFlags.Self];
        public DescriptorField Mastery                       => base[0x7FF, 0x1, MirrorFlags.Self];
        public DescriptorField Amplify                       => base[0x800, 0x1, MirrorFlags.Self];
        public DescriptorField Multistrike                   => base[0x801, 0x1, MirrorFlags.Self];
        public DescriptorField MultistrikeEffect             => base[0x802, 0x1, MirrorFlags.Self];
        public DescriptorField Readiness                     => base[0x803, 0x1, MirrorFlags.Self];
        public DescriptorField Speed                         => base[0x804, 0x1, MirrorFlags.Self];
        public DescriptorField Lifesteal                     => base[0x805, 0x1, MirrorFlags.Self];
        public DescriptorField Avoidance                     => base[0x806, 0x1, MirrorFlags.Self];
        public DescriptorField Sturdiness                    => base[0x807, 0x1, MirrorFlags.Self];
        public DescriptorField Cleave                        => base[0x808, 0x1, MirrorFlags.Self];
        public DescriptorField Versatility                   => base[0x809, 0x1, MirrorFlags.Self];
        public DescriptorField VersatilityBonus              => base[0x80A, 0x1, MirrorFlags.Self];
        public DescriptorField PvpPowerDamage                => base[0x80B, 0x1, MirrorFlags.Self];
        public DescriptorField PvpPowerHealing               => base[0x80C, 0x1, MirrorFlags.Self];
        public DescriptorField ExploredZones                 => base[0x80D, 0x100, MirrorFlags.Self];
        public DescriptorField RestStateBonusPool            => base[0x90D, 0x1, MirrorFlags.Self];
        public DescriptorField ModDamageDonePos              => base[0x90E, 0x7, MirrorFlags.Self];
        public DescriptorField ModDamageDoneNeg              => base[0x915, 0x7, MirrorFlags.Self];
        public DescriptorField ModDamageDonePercent          => base[0x91C, 0x7, MirrorFlags.Self];
        public DescriptorField ModHealingDonePos             => base[0x923, 0x1, MirrorFlags.Self];
        public DescriptorField ModHealingPercent             => base[0x924, 0x1, MirrorFlags.Self];
        public DescriptorField ModHealingDonePercent         => base[0x925, 0x1, MirrorFlags.Self];
        public DescriptorField ModPeriodicHealingDonePercent => base[0x926, 0x1, MirrorFlags.Self];
        public DescriptorField WeaponDmgMultipliers          => base[0x927, 0x3, MirrorFlags.Self];
        public DescriptorField WeaponAtkSpeedMultipliers     => base[0x92A, 0x3, MirrorFlags.Self];
        public DescriptorField ModSpellPowerPercent          => base[0x92D, 0x1, MirrorFlags.Self];
        public DescriptorField ModResiliencePercent          => base[0x92E, 0x1, MirrorFlags.Self];
        public DescriptorField OverrideSpellPowerByAPPercent => base[0x92F, 0x1, MirrorFlags.Self];
        public DescriptorField OverrideAPBySpellPowerPercent => base[0x930, 0x1, MirrorFlags.Self];
        public DescriptorField ModTargetResistance           => base[0x931, 0x1, MirrorFlags.Self];
        public DescriptorField ModTargetPhysicalResistance   => base[0x932, 0x1, MirrorFlags.Self];
        public DescriptorField LocalFlags                    => base[0x933, 0x1, MirrorFlags.Self];
        public DescriptorField LifetimeMaxRank               => base[0x934, 0x1, MirrorFlags.Self];
        public DescriptorField SelfResSpell                  => base[0x935, 0x1, MirrorFlags.Self];
        public DescriptorField PvpMedals                     => base[0x936, 0x1, MirrorFlags.Self];
        public DescriptorField BuybackPrice                  => base[0x937, 0xC, MirrorFlags.Self];
        public DescriptorField BuybackTimestamp              => base[0x943, 0xC, MirrorFlags.Self];
        public DescriptorField YesterdayHonorableKills       => base[0x94F, 0x1, MirrorFlags.Self];
        public DescriptorField LifetimeHonorableKills        => base[0x950, 0x1, MirrorFlags.Self];
        public DescriptorField WatchedFactionIndex           => base[0x951, 0x1, MirrorFlags.Self];
        public DescriptorField CombatRatings                 => base[0x952, 0x20, MirrorFlags.Self];
        public DescriptorField PvpInfo                       => base[0x972, 0x24, MirrorFlags.Self];
        public DescriptorField MaxLevel                      => base[0x996, 0x1, MirrorFlags.Self];
        public DescriptorField RuneRegen                     => base[0x997, 0x4, MirrorFlags.Self];
        public DescriptorField NoReagentCostMask             => base[0x99B, 0x4, MirrorFlags.Self];
        public DescriptorField GlyphSlots                    => base[0x99F, 0x6, MirrorFlags.Self];
        public DescriptorField Glyphs                        => base[0x9A5, 0x6, MirrorFlags.Self];
        public DescriptorField GlyphSlotsEnabled             => base[0x9AB, 0x1, MirrorFlags.Self];
        public DescriptorField PetSpellPower                 => base[0x9AC, 0x1, MirrorFlags.Self];
        public DescriptorField Researching                   => base[0x9AD, 0xA, MirrorFlags.Self];
        public DescriptorField ProfessionSkillLine           => base[0x9B7, 0x2, MirrorFlags.Self];
        public DescriptorField UiHitModifier                 => base[0x9B9, 0x1, MirrorFlags.Self];
        public DescriptorField UiSpellHitModifier            => base[0x9BA, 0x1, MirrorFlags.Self];
        public DescriptorField HomeRealmTimeOffset           => base[0x9BB, 0x1, MirrorFlags.Self];
        public DescriptorField ModPetHaste                   => base[0x9BC, 0x1, MirrorFlags.Self];
        public DescriptorField SummonedBattlePetGUID         => base[0x9BD, 0x4, MirrorFlags.Self];
        public DescriptorField OverrideSpellsID              => base[0x9C1, 0x1, MirrorFlags.Self | MirrorFlags.UrgentSelfOnly];
        public DescriptorField LfgBonusFactionID             => base[0x9C2, 0x1, MirrorFlags.Self];
        public DescriptorField LootSpecID                    => base[0x9C3, 0x1, MirrorFlags.Self];
        public DescriptorField OverrideZonePVPType           => base[0x9C4, 0x1, MirrorFlags.Self | MirrorFlags.UrgentSelfOnly];
        public DescriptorField ItemLevelDelta                => base[0x9C5, 0x1, MirrorFlags.Self];
        public DescriptorField BagSlotFlags                  => base[0x9C6, 0x4, MirrorFlags.Self];
        public DescriptorField BankBagSlotFlags              => base[0x9CA, 0x7, MirrorFlags.Self];
        public DescriptorField InsertItemsLeftToRight        => base[0x9D1, 0x1, MirrorFlags.Self];
        public DescriptorField QuestCompleted                => base[0x9D2, 0x36B, MirrorFlags.Self];

        public static new int End => UnitData.End + 0xD3D;
    }
}
