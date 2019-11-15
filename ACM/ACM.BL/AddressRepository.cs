using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "17th street";
                address.StreetLine2 = "14th street";
                address.City = "Dublin";
                address.State = "xxx";
                address.Country = "Ireland";
                address.PostalCode = "144";
            }
            return address;
        }
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "17th street",
                StreetLine2 = "14th street",
                City = "Dublin",
                State = "xxx",
                Country = "Ireland",
                PostalCode = "144"
           };
            addressList.Add(address);
            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "37th street",
                StreetLine2 = "54th street",
                City = "Athens",
                State = "xxx",
                Country = "Greece",
                PostalCode = "54689"
            };
            addressList.Add(address);

            return addressList;
        }
        public bool Save(Address address)
        {
            return true;
        }
    }
}
