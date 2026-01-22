using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTrainingCollectionsAAndFurther3.smart_checkout
{
    internal interface ICheckout
    {
        void AddACustomer();

        void RemoveCustomer();

        void FetchItemPrice();
    }
}
