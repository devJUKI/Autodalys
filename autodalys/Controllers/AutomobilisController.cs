using autodalys.Models;
using System;

namespace autodalys.Controllers
{
    public class AutomobilisController
    {
        public static string CreateCar(Automobilis car) {
            var sql = $"INSERT INTO automobiliai VALUES (\"{car.Vin}\", {car.Rida}, \"{car.KilmesSalis}\", " +
                $"'{car.PagaminimoData}', {car.VietuSkaicius}, \"{car.Spalva}\", {car.DuruSkaicius}, {car.DegaluTipas}, " +
                $"{car.PavaruDeze}, {car.KebuloTipas}, {car.Bukle}, {car.VarantysRatai}, {car.SutartiesId}, {car.ModelioId})";
            Sql.Insert(sql);
            return car.Vin;
        }
    }
}
