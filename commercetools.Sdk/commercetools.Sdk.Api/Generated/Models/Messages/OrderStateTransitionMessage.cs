using commercetools.Api.Models.Common;
using commercetools.Api.Models.States;
using System;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderStateTransitionMessage : IOrderStateTransitionMessage
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public long SequenceNumber { get; set; }

        public IReference Resource { get; set; }

        public long ResourceVersion { get; set; }

        public string Type { get; set; }

        public IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set; }

        public IStateReference State { get; set; }

        public IStateReference OldState { get; set; }

        public bool Force { get; set; }
        public OrderStateTransitionMessage()
        {
            this.Type = "OrderStateTransition";
        }
    }
}
