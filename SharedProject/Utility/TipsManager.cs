using Saver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace SharedProject.Utility
{
    class TipsManager
    {
        Lazy<SQLExpensesList> sqlExpensesList = new Lazy<SQLExpensesList>();
        List<Expences> ExpencesList = new List<Expences>();

        public Expences GetTips(int UserId)
        {
            //Getting a clean list
            DataTable sTable = sqlExpensesList.Value.GetExpensesSumByType(UserId);
            if(sTable.Rows.Count == 0)
            {
                Expences empty = new Expences();
                return empty;
            }
            else
            {
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


                ///Will probably need some more advanced logic, pretty basic now

                return ExpencesList[0];
            }
            
        }
    }
}
