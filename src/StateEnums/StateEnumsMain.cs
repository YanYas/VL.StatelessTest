using System;

namespace StateEnums
{
    public class MyStateEnums
    {
        public enum StateEn{ New, Filled, Shipping, Complete, Cancelled }
        public enum TriggerEn { ItemsConfirmed, PurchaseConfirmed, DeliveryConfirmed, DeliveryCancelled, BeginNewPurchase }

        public static string StateString(StateEn e)
        {
            return e.ToString();
        }

        public static string TriggerString(TriggerEn e)
        {
            return e.ToString();
        }
    }
}
