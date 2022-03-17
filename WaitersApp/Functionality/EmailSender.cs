using FluentEmail.Core;
using FluentEmail.Smtp;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace WaitersApp
{
    public class EmailSender :Emailing
    {
        public void SendEmail(Receipt receipt)
        {
            var stream = new MemoryStream();
            var streamWriter = new StreamWriter(stream);
            streamWriter.Write($"Table:{receipt.ReceiptId}\nSeats({receipt.Table.NumberOfSeats})\n");
            receipt.foods.ForEach(food => streamWriter.Write($"{food}\n"));
            receipt.drinks.ForEach(drink => streamWriter.WriteLine($"{drink}\n"));
            streamWriter.Write($"Total price: {receipt.TotalPrice}Eur\nPaid: {receipt.AmountPaid}Eur\nChange: {receipt.AmountPaid - receipt.TotalPrice}Eur\n{DateTime.Now}");
            streamWriter.Flush();
            stream.Seek(0, SeekOrigin.Begin);
            var attachment = new FluentEmail.Core.Models.Attachment
            {
                Data = stream,
                ContentType = "text/plain",
                Filename = "Receipt.txt"
            };


            async Task SendEmail()
            {
                var sender = new SmtpSender(() => new SmtpClient("smtp.gmail.com")
                {
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("utakis.arturas@gmail.com", "xxxxxxxxxxxx"),
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Port = 587

                });
                Email.DefaultSender = sender;
                var email = await Email
                    .From("utakis.arturas@gmail.com")
                    .To("utakis.arturas@gmail.com", "Arturas")
                    .Subject("Receipt")
                    .Body($"Thank you for your order!")
                    .Attach(attachment)
                    .SendAsync();

            }
            SendEmail();

        }

        public void SendEmail(string path)
        {
            var fileName = path;
            var sr = new StreamReader(fileName);
            string content = sr.ReadToEnd();
            var stream = new MemoryStream();
            var streamWriter = new StreamWriter(stream);
            streamWriter.Write(content);
            streamWriter.Flush();
            stream.Seek(0, SeekOrigin.Begin);
            var attachment = new FluentEmail.Core.Models.Attachment
            {
                Data = stream,
                ContentType = "text/plain",
                Filename = "Receipt.txt"
            };


            async Task SendEmail()
            {
                var sender = new SmtpSender(() => new SmtpClient("smtp.gmail.com")
                {
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("utakis.arturas@gmail.com", "xxxxxxxxxxx"),
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Port = 587

                });
                Email.DefaultSender = sender;
                var email = await Email
                    .From("utakis.arturas@gmail.com")
                    .To("utakis.arturas@gmail.com", "Arturas")
                    .Subject("Receipt")
                    .Body($"{content}")
                    .Attach(attachment)
                    .SendAsync();
                    
            }
            SendEmail();

        }


    }
}
