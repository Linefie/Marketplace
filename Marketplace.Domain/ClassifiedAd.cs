using System;
using System.Collections.Generic;
using System.Text;

namespace Marketplace.Domain
{
   public class ClassifiedAd
    {

        public Guid Id { get; }

        public ClassifiedAd(Guid id, Guid ownerId)
        {
            if (id == default)
                throw new ArgumentException("Identity must be specified", nameof(id));

            if (ownerId == default)
                throw new ArgumentException(
                "Owner id must be specified", nameof(ownerId));

            Id = id;

            _ownerId = ownerId;
        }

        // We have added three straightforward methods, and you might feel a bit disappointed because these are property setters (not even glorified). 
        //But, what we do here is express the idea of using Ubiquitous Language in code,
        //and transfer words from sticky notes (commands in this case) to methods.
        public void SetTitle(string title) => _title = title;
        public void UpdateText(string text) => _text = text;
        public void UpdatePrice(decimal price) => _price = price;


        private Guid _ownerId;

        private string _title;

        private string _text;

        private decimal _price;

        public void CreateClassifiedAd(Guid id, Guid ownerId)
        {
            var classifiedAd = new ClassifiedAd(id, ownerId);
            // store the entity somehow


        }
    }


}
    

