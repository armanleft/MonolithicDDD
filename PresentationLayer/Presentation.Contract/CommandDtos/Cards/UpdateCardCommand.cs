using System;

namespace Presentation.Contract.CommandDtos.Cards
{
    public class UpdateCardCommand : CreateCardCommand
    {
        public string Id { get; set; }
    }
}