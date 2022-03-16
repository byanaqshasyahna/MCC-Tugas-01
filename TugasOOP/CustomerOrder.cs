using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasOOP
{
    public class CustomerOrder
    {
        private List<String> productOrder = new List<String>();
        private List<int> priceOrder = new List<int>();

        public List<string> ProductOrder { get => productOrder; set => productOrder = value; }
        public List<int> PriceOrder { get => priceOrder; set => priceOrder = value; }
    }
}
