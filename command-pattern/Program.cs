using System;
namespace command_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var button1 = new Button();
            var customerService = new CustomerService();
            var addCustomerCommand = new AddCustomerCommand(customerService);
            button1.OnClick = addCustomerCommand;
            // button1.Click();

            var compositeCommand = new CompositeCommand();
            compositeCommand.Commands.Add(addCustomerCommand);
            compositeCommand.Commands.Add(new AddOrderCommand(new OrderService()));
            button1.OnClick = compositeCommand;
            button1.Click();
        }
    }
    
}