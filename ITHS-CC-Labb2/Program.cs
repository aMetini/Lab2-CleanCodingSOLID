using ITHS_CC_Labb2;
using ITHS_CC_Labb2.Classes;


OrderService orderService1 = new OrderServiceNormal(
    new MessageTool(new ProcessSpeed()
        ));

OrderModel normalOrder = new OrderModel
{
    ID = Guid.NewGuid(),
    Email = "normalEmail@example.com",
    Priority = OrderStatus.Normal,
    TotalPrce = 100,
};

orderService1.ProcessOrder(normalOrder);

Console.WriteLine(normalOrder);

OrderService orderService2 = new OrderServiceQuick(
    new MessageTool(new ProcessSpeed()
        ));

OrderModel quickOrder = new OrderModel
{
    ID = Guid.NewGuid(),
    Email = "quickEmail@example.com",
    Priority = OrderStatus.Quick,
    TotalPrce = 100,
};

orderService2.ProcessOrder(quickOrder);

Console.WriteLine(quickOrder);

OrderService orderService3 = new OrderServiceLightning(
    new MessageTool(new ProcessSpeed()
        ));


OrderModel lightningOrder = new OrderModel
{
    ID = Guid.NewGuid(),
    Email = "lightningEmail@example.com",
    Priority = OrderStatus.LightningSpeed,
    TotalPrce = 100,
};

orderService3.ProcessOrder(lightningOrder);


Console.WriteLine(lightningOrder);
Console.Read();