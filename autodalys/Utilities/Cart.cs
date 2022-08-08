using autodalys.Controllers;
using autodalys.Models;
using System.Collections.Generic;
using System.Linq;

namespace autodalys.Utilities {
    public static class Cart {
        private static List<int> PartIds = new List<int>();

        public static void Add(int part) {
            PartIds.Add(part);
        }

        public static void AddRange(List<int> parts) {
            parts.ForEach(x => PartIds.Add(x));
        }

        public static void Remove(int part) {
            PartIds.Remove(part);
        }

        public static void RemoveRange(List<int> parts) {
            parts.ForEach(x => PartIds.Remove(x));
        }

        public static void RemoveAll() {
            PartIds.Clear();
        }

        public static Detale Get(int cartIndex) {
            int dbPartId = PartIds[cartIndex];
            return DetaleController.GetPartById(dbPartId);
        }

        public static List<Detale> GetAll() {
            return DetaleController.GetPartsByIds(PartIds);
        }

        public static List<Detale> FilterFromCart(List<Detale> parts) {
            return parts.Where(x => !PartIds.Contains(x.Id)).ToList();
        }

        public static int GetCount() {
            return PartIds.Count;
        }
    }
}
