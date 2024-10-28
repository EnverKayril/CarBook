namespace CarBook.Application.Features.CQRS.Commands.BannerCommands
{
    public class RemoveBannerCommand
    {
        public RemoveBannerCommand(int bannerId)
        {
            BannerId = bannerId;
        }

        public int BannerId { get; set; }

    }
}