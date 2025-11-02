using System.Collections.Generic;
using System.Linq;

namespace QodoTestProject.Services
{
    public class CalculatorService
    {
        // 📝 קטע קוד כפול (Duplicate Code)
        public double CalculateDiscount(List<Item> items)
        {
            double totalDiscount = 0;

            foreach (var item in items)
            {
                if (item.IsActive && item.Value > 50)
                {
                    // 💵 Magic Number: 0.20 - מספר קסם נוסף
                    totalDiscount += item.Value * 0.20;
                }
            }

            return totalDiscount;
        }

        // 📝 קטע קוד כפול נוסף שדומה ל-CalculateDiscount
        public double CalculateTaxableAmount(List<Item> items)
        {
            double totalTaxable = 0;

            foreach (var item in items)
            {
                if (item.IsActive && item.Value > 50)
                {
                    // 💵 Magic Number: 0.20 - בדיוק אותו לוגיקה וקבוע קסם
                    totalTaxable += item.Value * 0.20;
                }
            }

            return totalTaxable * 1.0; // שינוי קל באובייקט ההחזרה
        }
    }
}

public class Item
{
    public int Value { get; set; }
    public bool IsActive { get; set; }
}