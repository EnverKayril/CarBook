using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.FooterAddressCommands
{
    public class RemoveFooterAddresCommands : IRequest
    {
        public int Id { get; set; }

        public RemoveFooterAddresCommands(int id)
        {
            Id = id;
        }
    }
}