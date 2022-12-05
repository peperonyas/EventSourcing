using EventSourcing.API.DTOs;
using MediatR;

namespace EventSourcing.API.Commands
{
    public class ChangeProducNameCommand : IRequest
    {
        public ChangeProductNameDto ChangeProductNameDto { get; set; }
    }
}