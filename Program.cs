using Telegram.Bot;
using Telegram.Bot.Types;
using System.Linq;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Polling;

class Program
{
    private static TelegramBotClient botClient;
    private static string Token = "6048952678:AAHcbgbMFMU0WS3Umma37SoM3TAu--Wt-K8";

    ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
{
    new KeyboardButton[] { "База Данных", "Калькулятор" },
});

    static void Main(string[] args)
    {
        botClient=new TelegramBotClient(Token);
        var me = botClient.GetMeAsync().Result;
        botClient.GetUpdatesAsync().Wait(1000);
        Console.ReadLine();
        botClient.StartReceiving(Updater, Erorr);
    }

    private static Task Erorr(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
    {
        throw new NotImplementedException();
    }

    private async static Task Updater(ITelegramBotClient botClient, Update update, CancellationToken arg3)
    {
        var messege = update.Message;
    }
}

