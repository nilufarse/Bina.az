﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina.az.Interface
{
    public interface IBillofSale
    {
        void SaleWithBill();
        void SaleWithoutBill();
        void RentWithBill();
        void RentWithoutBill();

    }
}
