# Labb 2

ITHS LAB2 CLEAN CODE SOLID

1) I first started to refactor this solution by separating the methods that made up ProcessOrder into separate classes:
	SendNotificationEmail, LogMessage, ProcessOrderNormally, ProcessOrderQuickly, ProcessOrderInLightningSpeed.
2) I then added a corresponding interface to SendNotificationEmail and LogMessage.  I made one interface called IProcessSpeed that would be inherited by:
	ProcessOrderNormally, ProcessOrderQuickly, ProcessOrderInLightningSpeed.
3) Since ProcessOrder would need to take in the class Order as a parameter, I decided to make an interface for that as well. 
4) While trying to connect all of the pieces together I realized that it would take extra dependency injections and extra steps to implement SendNotificationEmail and LogMessage.
	The solution was to create a MessageTool class and matching interface that could handle both methods in one.
5) I also started to become concerned whether I was not following the Single Responsibility principal while still thinking that making 3 classes for ProcessSpeeds 
	(Normal, Quick, Lightning) would be too much since in principal they were all doing the same thing but at different speeds.  I decided to remove my 3 Process speeds classes into one
	ProcessSpeed class that would inherit from IProcessSpeed.  I also added a ConsoleWriteLine to each boolean ProcessSpeed method to confirm that the program is reading the correct method.
6) In order to abstractly implement the if else argument found in ProcessOrder (housed in the OrderService class), I created 3 subclasses fo OrderService called:
	OrderServiceNormal, OrderServiceQuick, OrderServiceLightning that would all inherit the base class OrderService.  Objects of OrderService would then take 
	take the parameter of IMessage message to create new objects of OrderServiceNormal, OrderServiceQuick, and OrderServiceLightning.  ProcessOrder would still take 
	the parameters IOrder order but this time take a new boolean message from IMessage depending on ProcessSpeed.
7) Lastly, in order to refrain from repeating myself, I changed the message for sucessfull processing to include the process speed. All messaging steps were
	then combined into one boolean method for each speed in order to KISS.  These three message success methods were added to the IMessageTool/MessageTool classes.
	I did consider whether or not to further separate this messaging sucess method into further separate classes using polymorphism like I did for OrderService but decided
	against it because I started to feel uncomfortable having so many classes that did relatively the same thing.
8) At the end, I believe that I was able to refactor the original solution to adopt the principals of: S O and D (of SOLID).  I also believe that my solution
	implemented the concepts of KISS and DRY.  I probably could have acheived I (in SOLID) had made interfaces for each original method found in OrderService.
