using GiftSenderProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftSenderService.MarketingDepartment
{
    public class GiveAddressListToSender
    {
        public List<CustomerAddress> GetAddressList()
        {
            List<CustomerAddress> addressesOfCustomers = new List<CustomerAddress>();

            CustomerAddress customerAddress1 = new CustomerAddress("TEST1", "TEST1", "TEST1");
            CustomerAddress customerAddress2 = new CustomerAddress("TEST2", "TEST2", "TEST2");
            CustomerAddress customerAddress3 = new CustomerAddress("TEST3", "TEST3", "TEST3");

            addressesOfCustomers.Add(customerAddress1);
            addressesOfCustomers.Add(customerAddress2);
            addressesOfCustomers.Add(customerAddress3);

            return addressesOfCustomers;
        }

       
    }
}
