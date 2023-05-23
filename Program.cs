using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramBuyerBot;

class Program
{
    
    private static string Token = "6048952678:AAHcbgbMFMU0WS3Umma37SoM3TAu--Wt-K8";

    CancellationToken cts = new CancellationToken();
   
    private static ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
  {
    new KeyboardButton[] { "/AcceptHelper", "/Sticker" }
    })
    {
        ResizeKeyboard = true
    };
  



    static void Main(string[] args)
    {
        ReceiverOptions receiverOptions = new()
        {
            AllowedUpdates = Array.Empty<UpdateType>()
        };

        var botClient = new TelegramBotClient(Token);

        botClient.GetUpdatesAsync().Wait();

        var me = botClient.GetMeAsync();

        botClient.StartReceiving(Updater, Erorr);
        Console.ReadLine();
        
    }

    private static Task Erorr(ITelegramBotClient botClient, Exception exception, CancellationToken cts)
    {
        var ErrorMessage = exception switch
        {
            ApiRequestException apiRequestException
                => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
            _ => exception.ToString()
        };

        Console.WriteLine(ErrorMessage);
        return Task.CompletedTask;

    }

    private static async Task Updater(ITelegramBotClient botClient, Update update, CancellationToken cts)
    {

        if (update.Type == UpdateType.Message && update.Message != null)
            
           await HandleMessege(botClient, update.Message);
        return;

    }

 
    
    public static async Task HandleMessege(ITelegramBotClient botClient,Message message)
    {
        var msg= MessageParser(botClient, message);
       
       string comand = CommandParser(msg, botClient);
        if (message.Text == "/start" || message.Text == "/старт")
        {
            await botClient.SendTextMessageAsync(message.Chat.Id, "Choose", replyMarkup: replyKeyboardMarkup);
            return;
        }
        if (message.Text == "/AcceptHelper")
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Список команд :\n введите-поиск название -для посика ФРОВ\n введите -срок дата изготовления дата окончания сг" +
                $"в формате DD MM YYYY -для расчёта остаточного сг");
        if (comand.ToLower().Contains("поиск"))
            Sourse.SearchResult(message, botClient);
        if (comand.ToLower().Contains("срок"))
        {
            CalcParser(ref msg,botClient);
            DateTime dt = CalcParser(ref msg, botClient).Item1;
            DateTime dt2 = CalcParser(ref msg,botClient).Item2;
            await botClient.SendTextMessageAsync(msg.Chat.Id, $"срок годности {CalculatorSG.BestBeforeDate(dt, dt2)}\n остаточный срок годности {CalculatorSG.Remainder(dt, dt2)} ");
        }
        if (message.Text == "/Sticker")
        {
            var rand=new Random();
            int valur=rand.Next(001, 014);
            await botClient.SendStickerAsync(message.Chat.Id, $"https://chpic.su/ru/stickers/spottyperedoz/{valur}/");
        }
            




        else
            await botClient.SendTextMessageAsync(message.Chat.Id, $"You said: \n {message.Text}");
    }
    static string CommandParser(Message message, ITelegramBotClient botClient)
    {
        
            string command;
            char delemiter = ' ';
        if (message.Text.Contains(" ")&& !message.Text.Contains("/"))
        {
            int finder = message.Text.IndexOf(delemiter);
            command = message.Text.Substring(0, finder);
            message.Text = message.Text.Substring(finder + 1);

            return command;

        }
        else
            return message.Text;
    }
    static public Tuple<DateTime,DateTime> CalcParser(ref Message message,ITelegramBotClient botClient)
    {
        DateTime date1;
        DateTime date2;
        char delemiter = ' ';
        string str = message.Text.ToString();
        
        date1= DateTime.Parse(str.Substring(0,str.IndexOf(delemiter)));
        date2=DateTime.Parse(str.Substring(str.IndexOf(delemiter)+1));
        


        return Tuple.Create(date1, date2);
    }
    static Message MessageParser(ITelegramBotClient botClient, Message message)
    {
        Queue<Message> messages = new Queue<Message>();
        var result = message;
        messages.Enqueue(message);
        if (message.Text.Contains("/"))
            messages.TryDequeue(out message);
        if (!message.Text.Contains("/"))
            result = message;

        return result;
    } 

    
    
}



