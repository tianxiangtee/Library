﻿using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Data.Interface
{
    public interface ICheckout
    {
        IEnumerable<Checkout> GetAll();
        Checkout GetById(int checkoutId);
        void Add(Checkout newCheckout);
        void CheckOutItem(int assetId, int libraryCardId);
        void CheckInItem(int assetId, int libraryCardId);
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int id);
        Checkout GetLatestCheckout(int assetId);

        void PlaceHold(int assetId, int libraryCardId);
        string GetCurrentHoldPatronName(int id);
        DateTime GetCurrentHoldPlaced(int id);
        IEnumerable<Hold> GetCurrentHolds(int id);

        void MarkLost(int assetId);
        void MarkFound(int assetId);
    }
}
