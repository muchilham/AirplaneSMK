using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneSMK
{
    class session
    {
        public static int primary { get; set; }
        public static string nameprim { get; set; }

        public static int departorigin { get; set; }
        public static string namedepart { get; set; }

        public static int arrivorigin { get; set; }
        public static string namearriv { get; set; }

        public static int idplane { get; set; }
        public static string nameplane { get; set; }
        public static int transit1 { get; set; }
        public static string transit1name { get; set; }

        public static int transit2 { get; set; }
        public static string transit2name { get; set; }

        public static int transit3 { get; set; }
        public static string transit3name { get; set; }

        public static int idCustomer { get; set; }
        public static string customerName { get; set; }

        public static int idConsumption { get; set; }
        public static string consumptionName { get; set; }
        public static float priceConsumption { get; set; }
        public static int quantity { get; set; }
    }
}
