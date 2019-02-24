﻿using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Data.Interface
{
    public interface ICheckout
    {
        void Add(Checkout newCheckout);
        IEnumerable<Checkout> GetAll();
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int id);
        IEnumerable<Hold> GetCurrentHolds(int id);

        Checkout GetById(int checkoutId);
        Checkout GetLatestCheckout(int assetId);
        string GetCurrentCheckoutPatron(int assetId);
        string GetCurrentHoldPatronName(int id);
        DateTime GetCurrentHoldPlaced(int id);

        void CheckOutItem(int assetId, int libraryCardId);
        void CheckInItem(int assetId);    
        void PlaceHold(int assetId, int libraryCardId);        
        void MarkLost(int assetId);
        void MarkFound(int assetId);
        bool IsCheckedOut(int assetId);
    }
}
