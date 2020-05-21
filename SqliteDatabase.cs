using System.Collections.Generic;
using System.Linq;
using AAEmu.Shared.Database.Models.Sqlite;
using Microsoft.EntityFrameworkCore;
using NLog;

namespace AAEmu.Shared.Database
{
    public static class SqliteDatabase
    {
        private static readonly ILogger log = LogManager.GetCurrentClassLogger();

        public static void CheckConnection()
        {
            using (var ctx = new SqliteContext())
            {
                //TODO: Select compact.sqlite3 location and save in config files
                if (ctx.Database.CanConnect())
                {
                    log.Info("Successfully Connected to Sqlite Database.");
                    return;
                }
                else
                {
                    //TODO: Connection error handling
                    log.Fatal("Unable to connect to Sqlite Database, make sure compact.sqlite3 is in the `AAEmu.Game/Data` directory.");
                    return;
                }
            }
        }

        public static ItemTemplate GetItemTemplate(uint templateId)
        {
            using (var ctx = new SqliteContext())
            {
                return ctx.ItemTemplates.FirstOrDefault(a => a.Id == templateId);
            }
        }

        public static Characters GetCharacterTemplate(byte race, byte gender)
        {
            using (var ctx = new SqliteContext())
            {
                return ctx.Characters.First(a => a.CharRaceId == race && a.CharGenderId == gender);
            }
        }

        public static List<CharacterSupplies> GetCharacterSupplies(byte abilityId)
        {
            using (var ctx = new SqliteContext())
            {
                return ctx.CharacterSupplies.Where(cs => cs.AbilityId == abilityId).ToList();
            }
        }

        public static CharacterEquipPacks GetNewCharEquipment(byte abilityId)
        {
            using (var ctx = new SqliteContext())
            {
                return ctx.CharacterEquipPacks
                    .Include(e => e.NewbieClothPack)
                    .Include(e => e.NewbieWeaponPack)
                    .First(e => e.AbilityId == abilityId);
            }
        }

        public static List<ItemBodyParts> GetBodyParts(int modelId)
        {
            using (var ctx = new SqliteContext())
            {
                return ctx.ItemBodyParts.Where(bp => bp.ModelId == modelId).ToList();
            }
        }
    }
}
