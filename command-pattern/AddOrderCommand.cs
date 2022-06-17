using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace command_pattern
{
    public class AddOrderCommand : Command
    {
        private readonly OrderService _orderService;
        public AddOrderCommand(OrderService orderService)
        {
            _orderService = orderService;
        }

        public void Execute()
        {
            _orderService.AddOrder();
        }
    }
    
}