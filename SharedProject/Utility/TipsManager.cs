using SmartSaver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace SharedProject.Utility
{
    class TipsManager
    {
        SQLExpensesList sqlExpensesList = new SQLExpensesList();
        List<Expences> ExpencesList = new List<Expences>();

        public Expences GetTips(int UserId)
        {
            //Getting a clean list
            DataTable sTable = sqlExpensesList.GetExpensesSumByType(UserId);

            ExpencesList = (from DataRow dr in sTable.Rows
                            select new Expences()
                            {
                                ExpencesF = Convert.ToDecimal(dr["SumOfExpences"]),
                                ExpencesType = dr["TypeOfExpences"].ToString(),
                            }).ToList();
            /////////////////////////////////////////////////////////////////
            //Sorts the list
            ExpencesList.Sort((emp1, emp2) => emp2.ExpencesF.CompareTo(emp1.ExpencesF));
            /////////////////////////////////////////////////////////////////

            //ExpencesList.Sort(ExpencesF);
            foreach (var a in ExpencesList)
            {
                Console.WriteLine(a.ExpencesF + a.ExpencesType);
            }

            ///Will probably need some more advanced logic, pretty basic now
            return ExpencesList[0];
        }
    }
}
