using BuildingBlocks.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Basket.Domain.Entities.ShoppingCardItems
{
    public class ShoppingCardItem : AggregateRoot<int>
    {
        public string UserID { get; set; }
        public string ProductID { get; set; }
        public decimal Amount { get; set; }
    }
}
