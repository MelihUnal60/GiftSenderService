
using GiftSenderProject.Domain;
using GiftSenderService.MarketingDepartment;




    Console.WriteLine("Lütfen kampanya için ayrılan bütçeyi giriniz : ");
    decimal budget =Convert.ToDecimal( Console.ReadLine());

    SendGiftAsBudget giftSenderService = new SendGiftAsBudget();

    giftSenderService.StartNewCampaign(budget);
    



public delegate bool GiftSenderDelegate(List<CustomerAddress> customerAddresses);

public class SendGiftAsBudget
{
    public bool ComplateCampaign(GiftSenderDelegate giftSenderDelegate)
    {
        bool complated = false;

        GiveAddressListToSender giveAddressListToSender = new GiveAddressListToSender();

        List<CustomerAddress> customerAddresses = giveAddressListToSender.GetAddressList();

        complated = giftSenderDelegate(customerAddresses);

        return complated;
    }

    public bool StartNewCampaign(decimal budget)
    {
        bool sended = false;

        GiveAddressListToSender sender = new GiveAddressListToSender();

        GiftSenderDelegate giftSender;
        
        if (budget > 10000)
        {
            CoffeeCupsSender cupsSender = new CoffeeCupsSender();

            giftSender = cupsSender.SendCoffeeCupsToCustomers;

            Console.WriteLine("Tüm müşterilere kahve bardağı gönderildi");
        }
        else
        {
            BallPensSender pensSender = new BallPensSender();

            giftSender = pensSender.SendBallPensToCustomers;

            Console.WriteLine("Tüm müşterilere tükenmez kalem gönderildi");
        }

        sended = ComplateCampaign(giftSender);

        return sended;
    }
}