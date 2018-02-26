using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using LaymanFinance.Models;
using System.Data.SqlClient;

namespace LaymanFinance.Controllers
{
    public class OutlayController : Controller
    {
        private ConnectionStrings _connectionStrings;
        public OutlayController(IOptions<ConnectionStrings> connectionStrings)
        {
            _connectionStrings = connectionStrings.Value;
        }

        //public IActionResult Index()
        //{
        //    OutlayModel model = new Models.OutlayModel
        //    {
        //        Date = DateTime.Now,
        //        Amount = 20,
        //        Description = "Panda Express",
        //        Category = new Models.CategoryModel { ID = 1, Name = "Food" }
        //    };

        //    return View(model);
        //}

        public IActionResult Index(int id)
        {
            OutlayModel model = new OutlayModel();

            using (var connection = new SqlConnection(_connectionStrings.DefaultConnection))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "sp_GetOutlay";
                command.Parameters.AddWithValue("@id", id);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                using (var reader = command.ExecuteReader())
                {
                    var DateOccurredColumn = reader.GetOrdinal("Date");
                    var AmountColumn = reader.GetOrdinal("Amount");
                    var PayeeColumn = reader.GetOrdinal("Payee");
                    var MemoColumn = reader.GetOrdinal("Memo");
                    var CategoryColumn = reader.GetOrdinal("Name");
                    while (reader.Read())
                    {
                        model.DateOccurred = reader.GetDateTime(DateOccurredColumn);
                        model.Amount = reader.GetDecimal(AmountColumn);
                        model.Payee = reader.GetString(PayeeColumn);
                        model.Memo = reader.GetString(MemoColumn);
                        model.Category = new Models.CategoryModel
                        {
                            Name = reader.GetString(CategoryColumn),
                        };
                    }
                }
                connection.Close();
            }

            // Getting data through hardcoding
            //if(id == 1)
            //{
            //    model.Date = DateTime.Now;
            //    model.Amount = 10;
            //    model.Description = "Panda Express";
            //    model.Category = new Models.CategoryModel { ID = 1, Name = "Eating Out" };
            //}

            //if (id == 2)
            //{
            //    model.Date = DateTime.Now;
            //    model.Amount = 90;
            //    model.Description = "Jewel";
            //    model.Category = new Models.CategoryModel { ID = 1, Name = "Groceries" };
            //}

            return View(model);

        }
    }
}