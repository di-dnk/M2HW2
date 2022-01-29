using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service
{
    public class NotificationService
    {
        private static readonly NotificationService instance = new NotificationService();
        private MakeOrder _notification = new MakeOrder();

        static NotificationService()
        {
        }

        private NotificationService()
        {
        }

        public static NotificationService Instance
        {
            get
            {
                return instance;
            }
        }     

        public void MakeOrder()
        {
            _notification.GenereteOrder();
        }
        public void PrintOrder()
        {
            _notification.PrintOrder();
        }
    }
}
